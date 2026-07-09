using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.L2Adapter
{
	public class L2CommunicationConfiguration
	{
		public bool IsEnabled { get; set; }
		public int StatusReadCycleMs { get; set; } = 1000;
        public List<string> Watchdogs { get; set; } = new();
	}
}
