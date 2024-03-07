using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.L2Adapter.CommunicationHandlers
{
	public interface IL2CommunicationHandler
	{
		void SendTestMessage(string msg);
	}
}
