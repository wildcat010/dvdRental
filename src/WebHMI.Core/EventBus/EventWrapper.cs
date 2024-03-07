using Abp.Events.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.EventBus
{
	public class EventWrapper<T> : IEventData
	{
		public EventWrapper(T data)
		{
			Data = data;
		}

		public T Data { get; set; }
		public DateTime EventTime { get; set; } = DateTime.UtcNow;
		public object EventSource { get; set; }
	}
}
