using Abp.Dependency;
using Abp.Events.Bus;
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

		public AlarmListener(IEventBus eventBus)
		{
			_eventBus = eventBus;
		}

		public override void onAlarm(AlarmInfo alarmInfo)
		{
			_eventBus.TriggerAsync(new EventWrapper<AlarmInfo>(alarmInfo));
		}
	}
}
