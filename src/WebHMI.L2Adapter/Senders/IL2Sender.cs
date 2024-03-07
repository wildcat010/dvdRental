using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.L2Adapter.Senders
{
	public interface IL2Sender
	{
		void SendTestMessage(string msg);
	}
}
