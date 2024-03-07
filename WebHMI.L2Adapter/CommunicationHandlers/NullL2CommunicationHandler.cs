using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.L2Adapter.CommunicationHandlers
{
	/// <summary>
	/// Null object pattern for L2 communication to disable it for example for development.
	/// </summary>
	internal class NullL2CommunicationHandler : IL2CommunicationHandler
	{
		public string InstanceName => GetType().Name;
	}
}
