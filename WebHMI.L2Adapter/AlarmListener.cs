using Abp.Dependency;
using Abp.Events.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIDL;

namespace WebHMI.L2Adapter
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
			_eventBus.TriggerAsync(new L2EventWrapper<AlarmInfo>(alarmInfo));
		}
	}
}
