using Abp.Domain.Services;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Abp.Events.Bus.Handlers;
using Abp.Runtime.Caching;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebHMI.API.Helpers;
using WebHMI.Dtos;
using WebHMI.Dtos.Application.Tracking;
using WebHMI.Dtos.Core.Communication;
using WebHMI.EventWrapper;
using WebHMI.Notification;
using WebHMI.PRDB;
using WebHMI.Services;
using XIDL;

namespace WebHMI.API.Services
{
    public class TrackingDataCacheService :
        DomainService,
        IAsyncEventHandler<EventWrapper<HmiTrackingData>>,
        IAsyncEventHandler<EventWrapper<HmiRefreshDto>>
    {
        private const string _trackingDataCacheKey = "TrackingDataBackgroundTask";

        private readonly ITypedCache<string, HmiTrackingData> _cacheTrackingData;
        private readonly ITypedCache<MeIdMatTypeKey, MeasurementCache> _cacheMeasuredValues;
        private readonly ITypedCache<string, Dictionary<string, MeCodeDto>> _cacheActualNext;
        private readonly ITypedCache<string, List<MeCodeDto>> _cacheNextSlabs;
        //private readonly ITypedCache<string, List<MeCodeDto>> _cacheProducedCoils;

        private readonly CommonAppService _commonService;
        private readonly IDbContextProvider<PrdbContext> _dbContextProvider;
        private readonly ISignalRNotifier _signalRNotifier;
        private readonly IUnitOfWorkManager _unitOfWorkManager;

        public TrackingDataCacheService(ICacheManager cacheManager,
            ISignalRNotifier signalRNotifier,
            IUnitOfWorkManager unitOfWorkManager,
            CommonAppService commonService,
            IDbContextProvider<PrdbContext> dbContextProvider)
        {
            _cacheTrackingData = cacheManager.GetCache<string, HmiTrackingData>("HmiTrackingData");
            _cacheMeasuredValues = cacheManager.GetCache<MeIdMatTypeKey, MeasurementCache>("Measurements");
            _cacheActualNext = cacheManager.GetCache<string, Dictionary<string, MeCodeDto>>("ActualNext");

            _cacheNextSlabs = cacheManager.GetCache<string, List<MeCodeDto>>("NextSlabs");
            //_cacheProducedCoils = cacheManager.GetCache<string, List<MeCodeDto>>("ProducedCoils");
            _signalRNotifier = signalRNotifier;
            _unitOfWorkManager = unitOfWorkManager;
            _dbContextProvider = dbContextProvider;
            _commonService = commonService;
        }

        [UnitOfWork]
        public async Task HandleEventAsync(EventWrapper<HmiRefreshDto> eventData)
        {
            bool isCoilEvent = eventData.Data?.EventKey?.Contains("COILS") ?? false;
            if (!isCoilEvent)
                return;

            //await _cacheNextSlabs.SetAsync(_trackingDataCacheKey, await GetNextSlabsCachesAsync());
        }

        [UnitOfWork]
        public virtual async Task<TrackingDataDto> GetTrackingStructCaches()
        {
            var context = await _dbContextProvider.GetDbContextAsync();
            return new TrackingDataDto()
            {
                HmiTrackingData = await _cacheTrackingData.GetOrDefaultAsync(_trackingDataCacheKey),
                ActualNext = await _cacheActualNext.GetOrDefaultAsync(_trackingDataCacheKey),
                NextSlabs = await _cacheNextSlabs.GetAsync(_trackingDataCacheKey, async key => await GetNextSlabsCachesAsync()),
                ActualSequenceId = await context.HmiVActualsequences.Select(x => x.Getcurrentsequence).FirstOrDefaultAsync(),
                ActualHeatId = await context.HmiVActualheats.Select(x => x.GetCurrentHeat).FirstOrDefaultAsync(),
                //ProducedCoils = await _cacheProducedCoils.GetOrDefaultAsync(_trackingDataCacheKey),
            };
        }

        [UnitOfWork]
        public virtual async Task<MaterialMVDataDto> GetMeasurements(int meid, string matType, string measurementName, short passNo)
        {
            var context = _dbContextProvider.GetDbContext();
            try
            {
                var measurementsCache = await _cacheMeasuredValues.GetAsync(new MeIdMatTypeKey(meid, matType), async () => new MeasurementCache());
                var cache = measurementsCache.GetMeasuredValuesByNamePassNo(measurementName, passNo);
                var result = new MaterialMVDataDto()
                {
                    MVName = measurementName,
                    MeCode = (await context.VMatStructEntries.FirstOrDefaultAsync(x => x.EnOrMeId == meid))?.ToMeCodeDto(),
                    MVSeries = cache.Select(x => new MVPoint(1, new float?[] { (float)x.Value })).ToList()
                };
                return result;
            }
            catch (System.Exception ex)
            {
                Logger.Error($"[PassSchedule] Cannot get PC2 pass schedule data:", ex);
                return null;
            }
        }

        public async Task HandleEventAsync(EventWrapper<HmiTrackingData> eventData)
        {
            _cacheTrackingData.Set(_trackingDataCacheKey, eventData.Data);
            await _signalRNotifier.BroadcastToAllClientsAsync(eventData.Data, "TrackingData");
            await AddMeasurementsToCaches(eventData.Data);
        }

        private async Task AddMeasurementsToCaches(HmiTrackingData data)
        {
            foreach (var measurementPack in data.Measurements)
            {
                MeasurementCache measurementsCaches = await _cacheMeasuredValues.GetAsync(new MeIdMatTypeKey(measurementPack.MeCode.Actual.MeId, measurementPack.MeCode.MeTyp), async () => new MeasurementCache());
                if (measurementsCaches.NameMeasurementsPairs.Any(x => x.Name == measurementPack.Name && x.PassNo == measurementPack.PassNo))
                    measurementsCaches.NameMeasurementsPairs.Single(x => x.Name == measurementPack.Name && x.PassNo == measurementPack.PassNo).MeasuredValues.AddRange(measurementPack.Measurements);
                else
                    measurementsCaches.NameMeasurementsPairs.Add(new NamePassNoMeasurements()
                    {
                        Name = measurementPack.Name,
                        PassNo = measurementPack.PassNo,
                        MeasuredValues = measurementPack.Measurements.ToList()
                    });
                await _cacheMeasuredValues.SetAsync(new MeIdMatTypeKey(measurementPack.MeCode.Actual.MeId, measurementPack.MeCode.MeTyp), measurementsCaches);
                await _signalRNotifier.BroadcastToAllClientsAsync(measurementPack.Measurements, $"MV:{measurementPack.Name}");
            }
        }

        //[UnitOfWork]
        //public virtual async Task HandleEventAsync(EventWrapper<HmiTrackingData> eventData)
        //{
        //}

        [UnitOfWork]
        public virtual async Task FlushTrackingDataCaches()
        {
            await _cacheTrackingData.ClearAsync();
            await _cacheMeasuredValues.ClearAsync();
            await _cacheActualNext.ClearAsync();
            await _cacheNextSlabs.ClearAsync();
            //await _cacheProducedCoils.ClearAsync();
        }

        //[UnitOfWork]
        private async Task<List<MeCodeDto>> GetNextSlabsCachesAsync()
        {
            var context = _dbContextProvider.GetDbContext();
            using var uow = _unitOfWorkManager.Begin();

            var result = new List<MeCodeDto>();

            var curSeqId = await _commonService.GetActualSequenceId();
            var nextSlabId = await context.HmiVProdsequences
                .Where(x => x.SequenceId == curSeqId)
                .OrderBy(x => x.Majorno)
                .ThenBy(x => x.Minorno)
                .Select(x => new { x.Majorno, x.Minorno })
                .FirstOrDefaultAsync();
            if (nextSlabId != null)
            {
                var tmp = context.HmiVProdsequences
                    .Where(x => x.Majorno >= nextSlabId.Majorno && x.Minorno >= nextSlabId.Minorno && x.SequenceId == curSeqId)
                    .OrderBy(x => x.Majorno)
                    .ThenBy(x => x.Minorno)
                    .Take(3);

                result = await tmp.Select(x => new MeCodeDto
                {
                    MeId = x.EnOrMeId,
                    MatType = "OR",
                    MesId = x.EnOrMesId ?? -1,
                    MeCreator = x.EnOrCreator,
                    ExtId = x.EnOrExtId,
                    Status = x.EnOrStatus
                })
                .ToListAsync();
            }
            uow.Complete();

            await _signalRNotifier.BroadcastToAllClientsAsync(result, "NextSlabs");
            return result;
        }
    }
}
