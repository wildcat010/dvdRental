using Abp.Events.Bus.Handlers;
using Abp.Runtime.Caching;
using Castle.Core.Logging;
using System.Threading.Tasks;
using WebHMI.Events;
using WebHMI.EventWrapper;
using WebHMI.Helpers;
using WebHMI.L2Adapter.Watchdogs.Dto;
using WebHMI.Notification;

namespace WebHMI.API.Services
{
    public class RollCrownTempService : ApplicationServiceBase, IAsyncEventHandler<EventWrapper<HmiTwmDataDto>>
    {
        private readonly ISignalRNotifier _signalRNotifier;
        private readonly ITypedCache<string, HmiTwmDataDto> _cacheTWMData;
        private readonly string _cacheTwmDataKey = "HmiTwmData";
        private readonly ILogger _logger;

        public RollCrownTempService(ICacheManager cacheManager,
            ISignalRNotifier signalRNotifier,
            ILogger logger)
        {
            _cacheTWMData = cacheManager.GetCache<string, HmiTwmDataDto>(_cacheTwmDataKey);
            _signalRNotifier = signalRNotifier;
            _logger = logger;
        }

        public async Task HandleEventAsync(EventWrapper<HmiTwmDataDto> eventData)
        {
            await _cacheTWMData.SetAsync(eventData.Data.PlantType, eventData.Data);
            await _signalRNotifier.BroadcastTwmToAllClientsAsync(eventData.Data);
        }

        public async Task<HmiTwmDataDto> GetRollCrownTempData(string plantType)
        {
            var result = await _cacheTWMData.GetAsync(plantType, () => Task.FromResult(new HmiTwmDataDto()));
            return result;
        }
    }
}
