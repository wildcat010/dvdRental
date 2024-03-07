using Abp.Dependency;
using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIDL;

namespace WebHMI.L2Adapter
{
	internal class CommunicationTask
	{
	}

	public class HmiPa : IHmiPa, ISingletonDependency
	{
		private readonly ILogger _logger;
		private readonly ISignalRNotifier _signalRNotifier;

		public HmiPa(ILogger logger, ISignalRNotifier signalRNotifier)
		{
			_logger = logger;
			_signalRNotifier = signalRNotifier;
		}

		public override void HmiRefresh(string[] eventKey, ME_CODE meCode, string locationName, int locationId)
		{
			throw new NotImplementedException();
		}

		public override void HmiReturn(string eventKey, ME_CODE meCode, HMI_RETURN hmiReturn)
		{
			throw new NotImplementedException();
		}

		public override void MsgRefresh(string ReloadMsg)
		{
			throw new NotImplementedException();
		}
	}
}
