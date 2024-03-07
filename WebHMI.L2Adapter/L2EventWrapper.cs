using Abp.Events.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.L2Adapter
{
	public class L2EventWrapper<T> : IEventData
	{
		public L2EventWrapper(T data)
		{
			Data = data;
		}

		public T Data { get; set; }
		public DateTime EventTime { get; set; } = DateTime.UtcNow;
		public object EventSource { get; set; }
	}
}
