using Abp.Domain.Services;
using Abp.Domain.Uow;
using Abp.Events.Bus.Handlers;
using Abp.Runtime.Caching;
using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebHMI.Dtos;
using WebHMI.EventWrapper;
using WebHMI.L2Adapter.Common;
using WebHMI.L2Adapter.Dtos;
using WebHMI.Notification;
using XIDL;

namespace WebHMI.API.Services
{
    public class CSActualValuesCacheService : DomainService, IAsyncEventHandler<EventWrapper<CsCappaDataDto>>
    {
        public ILogger Logger { get; set; }
        private const string _trackingDataCacheKey = "TrackingDataBackgroundTask";
        private const string _CsActualValuesCacheKey = "CSActualValuesCache";
        private readonly string _csConfigCacheKey = "csConfigCacheKey";
        private readonly ITypedCache<string, HmiCsConfigData> _CsConfigCache;
        private readonly ITypedCache<string, List<LaminarCoolingActualValue>> _cacheCsActualValues;
        private readonly ISignalRNotifier _signalRNotifier;
        private readonly IL2CommunicationHandler _l2Sender;
        private readonly int _cacheSize = 1000;
        private static DateTime _lastTimeMaterialWasInCs;

        public CSActualValuesCacheService(ICacheManager cacheManager,
            ISignalRNotifier signalRNotifier,
            IL2CommunicationHandler l2Sender)
        {
            _cacheCsActualValues = cacheManager.GetCache<string, List<LaminarCoolingActualValue>>("CSActualValuesCache");
            _CsConfigCache = cacheManager.GetCache<string, HmiCsConfigData>(nameof(HmiCsConfigData));
            _signalRNotifier = signalRNotifier;
            Logger = NullLogger.Instance;
            _l2Sender = l2Sender;
        }

        [UnitOfWork]
        public virtual async Task<List<LaminarCoolingActualValue>> GetTemperaturePlotData()
        {
            Logger.Info($"[CSActualValuesCacheService::GetCsActualValues] Returning cached CsCappaDtataDto");
            return await _cacheCsActualValues.GetAsync(_CsActualValuesCacheKey, async () => new List<LaminarCoolingActualValue>());
        }

        public async Task HandleEventAsync(EventWrapper<CsCappaDataDto> eventData)
        {
            try
            {
                Logger.Debug($"[CSActualValuesCacheService::HandleEventAsync] Handling CsCappaDataDto event");
                await AddToCaches(eventData.Data);

                var pushTasks = new List<Task>
                {
                    _signalRNotifier.BroadcastToAllClientsAsync(eventData.Data.HmiCsMeters, "HmiCsMeters"),
                    _signalRNotifier.BroadcastToAllClientsAsync(eventData.Data.HmiCsValves, "CsActualValue"),
                    _signalRNotifier.BroadcastToAllClientsAsync(eventData.Data.TrackingData, "CsHmiTrackingData"),
                    _signalRNotifier.BroadcastToAllClientsAsync(eventData.Data.Statuses, "HmiCsStatus"),
                    _signalRNotifier.BroadcastToAllClientsAsync(eventData.Data.CtcData, "CtcData"),
                    _signalRNotifier.BroadcastToAllClientsAsync(eventData.Data.CsF4T, "CsF4T"),
                };

                await Task.WhenAll(pushTasks);
                Logger.Debug($"[CSActualValuesCacheService::HandleEventAsync] Handling CsCappaDataDto event");
            }
            catch (System.Exception ex)
            {
                Logger.Error($"[CSActualValuesCacheService::GetCsActualValues] Error while trying to handle CsCappaDataDto: {ex}");
            }
        }

        private async Task AddToCaches(CsCappaDataDto input)
        {
            if (!await MaterialInCoolingSection(input.TrackingData))
                if (_lastTimeMaterialWasInCs.AddSeconds(2) < DateTime.UtcNow)
                    return;

            var temperaturePlotEntry = new LaminarCoolingActualValue()
            {
                FmTemp = input.HmiCsMeters.FmTemp,
                CoilTemp = input.HmiCsMeters.CoilTemp,
                CsTargetTempWithPerformator = input.HmiCsMeters.CsTargetTempWithPerformator,
                FmTargetTempWithPerformator = input.HmiCsMeters.FmTargetTempWithPerformator,
                TimeStamp = DateTime.UtcNow
            };
            var cacheData = await _cacheCsActualValues.GetAsync(_CsActualValuesCacheKey, async () => new List<LaminarCoolingActualValue>());
            if (cacheData.Count > _cacheSize)
                cacheData.Remove(cacheData.First());
            cacheData.Add(temperaturePlotEntry);
            await _cacheCsActualValues.SetAsync(_CsActualValuesCacheKey, cacheData);
            await _signalRNotifier.BroadcastToAllClientsAsync(temperaturePlotEntry, "CSActualValuesCache");
        }

        private async Task<bool> MaterialInCoolingSection(HmiTrackingData csTrackingData)
        {
            var csConfig = await _CsConfigCache.GetAsync(_csConfigCacheKey, async () =>
            {
                var result = new HmiCsConfigData();
                _l2Sender.fillCsConfigurationSync(ref result);
                return result;
            });
            if (csConfig == null || csTrackingData == null || csTrackingData.MaterialsInMill == null)
                return false;
            var csSectionStart = csConfig?.FmTempPosition;
            var csSectionEnd = csConfig?.CoilTempPosition;
            if (csSectionStart == null || csSectionEnd == null)
                return false;

            if (csTrackingData.MaterialsInMill.Any(x => x.TailPosition <= csSectionEnd.Value && x.HeadPosition >= csSectionStart.Value))
            {
                _lastTimeMaterialWasInCs = DateTime.UtcNow;
                return true;
            }
            else
                return false;
        }

        [UnitOfWork]
        public virtual async Task FlushCsActualValueCaches()
        {
            Logger.Info($"[CSActualValuesCacheService::FlushCsActualValueCaches] Flushing CsCappaDataDto caches");
            await _cacheCsActualValues.ClearAsync();
        }
    }
}
