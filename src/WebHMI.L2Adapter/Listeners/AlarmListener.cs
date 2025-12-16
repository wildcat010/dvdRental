using Abp.Dependency;
using Abp.Events.Bus;
using Abp.Json;
using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.EventBus;
using XIDL;

namespace WebHMI.L2Adapter.Listeners
{
	public class AlarmListener : IAlarmListener, ISingletonDependency
	{
		private readonly IEventBus _eventBus;
		private readonly ILogger _logger;

        public AlarmListener(IEventBus eventBus, ILogger logger)
        {
            _eventBus = eventBus;
            _logger = logger;
        }

        public override void onAlarm(AlarmInfo alarmInfo)
		{
            _logger.Info($"Received L2 alarm info: {alarmInfo.ToJsonString()}"); // TODO: check and delete

			_eventBus.Trigger(new EventWrapper<AlarmInfo>(alarmInfo));
		}
	}
}
