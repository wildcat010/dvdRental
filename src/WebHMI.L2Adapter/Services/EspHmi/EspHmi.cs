using Abp.Dependency;
using Abp.Json;
using Castle.Core.Logging;
using Abp.Events.Bus;
using XIDL;
using WebHMI.EventWrapper;

namespace WebHMI.L2Adapter.Services.EspHmi
{
    public class EspHmi : IEspHmi, ISingletonDependency
    {
        private readonly ILogger _logger;

        public EspHmi(
            ILogger logger)
        {
            _logger = logger;
        }

        public override void takeOverTrackingData(HmiTrackingData trackingData)
        {
            try
            {
                _logger.Info($"{nameof(takeOverTrackingData)} received data");
                _logger.Debug($"[HsmHmi::takeOverTrackingData]HmiTrackingData:{trackingData.ToJsonString()}");
                _ = EventBus.Default.TriggerAsync(new EventWrapper<HmiTrackingData>() { Data = trackingData });
            }
            catch (System.Exception ex)
            {
                _logger.Error($"[HsmHmi::takeOverTrackingData]Failer do take over Tracking data. Error:{ex}");
            }
        }

        public override void takeOverTWMData(HmiTwmData data)
        {
            _logger.Info($"{nameof(takeOverTWMData)} received data");

        }
    }
}
