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
        void UpdateSetpointsRm(string extId, int meId, short mesId, string meCreator, string connectionId);
    }
}
