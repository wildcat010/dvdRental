using Abp.Dependency;
using Abp.Events.Bus;
using Castle.Core.Logging;
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
		}

		public override void HmiReturn(string eventKey, ME_CODE meCode, HMI_RETURN hmiReturn)
		{
		}

		public override void MsgRefresh(string ReloadMsg)
		{
		}
	}
}
