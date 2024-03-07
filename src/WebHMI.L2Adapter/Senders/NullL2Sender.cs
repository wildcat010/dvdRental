using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.L2Adapter.Senders
{
	/// <summary>
	/// Null object pattern for L2 communication sender to disable it for example for development.
	/// </summary>
	internal class NullL2Sender : IL2Sender
	{
		public void SendTestMessage(string msg)
		{
		}
	}
}
