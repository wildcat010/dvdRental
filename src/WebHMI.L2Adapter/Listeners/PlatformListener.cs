using Abp.Dependency;
using Abp.Events.Bus;
using Abp.Json;
using Castle.Core.Logging;
using WebHMI.Dtos;
using WebHMI.Events;
using WebHMI.EventWrapper;
using WebHMI.Notification;
using XIDL;

namespace WebHMI.L2Adapter.Listeners
{
	public class PlatformListener : IHmiPa, ISingletonDependency
	{
		private readonly ILogger _logger;
		private readonly ISignalRNotifier _signalRNotifier;
		private readonly IEventBus _eventBus;

		public PlatformListener(
			ILogger logger, 
			ISignalRNotifier signalRNotifier, 
			IEventBus eventBus)
		{
			_logger = logger;
			_signalRNotifier = signalRNotifier;
			_eventBus = eventBus;
		}

		public override void HmiRefresh(string[] eventKey, ME_CODE meCode, string locationName, int locationId)
		{
            try
            {
                _logger.Info($"{nameof(HmiRefresh)} received data with event keys: [{string.Join(", ", eventKey)}], MECODE: [{meCode.ExtIdField}], [{meCode.ActualField.MeIdField}],[{meCode.MeTypField}]");

                var eventData = new EventWrapper<HmiRefreshDto>()
                {
                    Data = new HmiRefreshDto()
                    {
                        EventKey = eventKey.ToList(),
                        LocationId = locationId,
                        LocationName = locationName,
                        MeCode = meCode != null && meCode.Actual != null ? new MeCodeDto()
                        {
                            MeId = meCode.Actual.MeId,
                            MesId = meCode.Actual.MesId,
                            MeCreator = meCode.Actual.MeCreator,
                            ExtId = meCode.ExtId,
                            MatType = meCode.MeTyp,
                            Status = 0
                        } : null
                    }
                };
                _eventBus.Trigger(eventData);
                _logger.Debug($"Propagated object: {Newtonsoft.Json.JsonConvert.SerializeObject(eventData)}");
                _signalRNotifier.BroadcastToAllClientsAsync(eventData, "HmiRefreshData");
            }
            catch (System.Exception ex)
            {
                _logger.Error($"[HmiPa::HmiRefresh]Fail to handle HmiRefresh. Error:{ex}");
            }
        }

		public override void HmiReturn(string eventKey, ME_CODE meCode, HMI_RETURN hmiReturn)
		{
            try
            {
                _logger.Info($"{nameof(HmiReturn)} received data with event key: '{eventKey}'");
                _logger.Debug($"Processing {string.Concat(eventKey)} L2 HmiReturn call.");
                var eventData = new EventWrapper<HmiReturnEvent>()
                {
                    Data = new HmiReturnEvent()
                    {
                        ReturnDto = new WebHMIReturnDto()
                        {
                            Acknowledge = hmiReturn.Acknowledge,
                            FunctionName = hmiReturn.FunctionName,
                            HmiClientId = hmiReturn.HmiClientId,
                            HmiServerName = hmiReturn.HmiServerName,
                            LfeName = hmiReturn.LfeName,
                            MessageNo = hmiReturn.MessageNo,
                            MessageText = hmiReturn.MessageText,
                            Pipname = hmiReturn.Pipname,
                            ServerName = hmiReturn.ServerName,
                            Status = hmiReturn.Status,
                            TelID = hmiReturn.TelID,
                        },
                        MeCode = meCode,
                    }
                };
                _signalRNotifier.BroadcastToUserClientAsync(eventData, eventData.Data.ReturnDto.HmiClientId, "HmiReturnData");
                _logger.Debug(new { eventKey, meCode, hmiReturn }.ToJsonString());
            }
            catch (System.Exception ex)
            {
                _logger.Error($"[HmiPa::HmiReturn]Fail to handle HmiReturn event. Error:{ex}");
            }
        }

		public override void MsgRefresh(string ReloadMsg)
		{
            try
            {
                _logger.Debug(ReloadMsg);
            }
            catch (System.Exception ex)
            {
                _logger.Error($"[HmiPa::MsgRefresh]Fail to handle MsgRefresh event. Error:{ex}");
            }
        }
	}
}
