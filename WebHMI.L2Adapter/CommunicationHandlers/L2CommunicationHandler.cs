using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIDL;

namespace WebHMI.L2Adapter.CommunicationHandlers
{
	internal class L2CommunicationHandler : IL2CommunicationHandler
	{
		private readonly ILogger _logger;
		private readonly IHmiPaStub _paStub;

		public L2CommunicationHandler(ILogger logger, IHmiPaStub paStub)
		{
			// Initialize communication objects here (like stubs)

			try
			{
				_logger.Debug($"Initializing {nameof(IHmiPaStub)}...");

				if (_paStub is null)
				{
					//var request = new Request("AppHmilWeb", "hmilWeb", "HsmCommon", "IHmilWeb", "hsmHmi");
					//_paStub = new IHmiPaStub(request);

					_logger.Debug($"{nameof(IHmiPaStub)} initialized");
				}
			}
			catch (System.Exception ex)
			{
				_logger.Error($"{nameof(IHmiPaStub)} can't be created", ex);
			}

			_logger = logger;
			_paStub = paStub;
		}

		public void SendTestMessage(string msg)
		{
			_logger.Debug($"Sending message '{msg}' to L2...");
			//_paStub.MsgRefresh(msg);
		}
	}
}
