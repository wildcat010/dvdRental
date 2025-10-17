using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.L2Adapter.Common;
using WebHMI.PRDB.Dbo;
using XIDL;

namespace WebHMI.L2Adapter.Senders
{
	/// <summary>
	/// Null object pattern for L2 communication sender to disable it for example for development.
	/// </summary>
	internal class NullCommunicationHandler : IL2CommunicationHandler
	{
        public void EntryDataChange(VMatStructEntry matStruct, string connectionId) 
        {

        }
    }
}
