using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.L2Adapter.CommunicationHandlers
{
	internal class L2CommunicationHandler : IL2CommunicationHandler
	{
		public string InstanceName => GetType().Name;
	}
}
