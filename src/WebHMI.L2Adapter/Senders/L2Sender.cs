using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIDL;

namespace WebHMI.L2Adapter.Senders
{
	internal class L2Sender : IL2Sender
	{
		private readonly ILogger _logger;
		private readonly IHmiPaStub _paStub;

		public L2Sender(ILogger logger)
		{
			_logger = logger;

			// Initialize communication objects here (like stubs)

			try
			{
				_logger.Info($"Initializing {nameof(IHmiPaStub)}...");

				if (_paStub is null)
				{
					//var request = new Request("AppHmilWeb", "hmilWeb", "HsmCommon", "IHmilWeb", "hsmHmi");
					//_paStub = new IHmiPaStub(request);

					_logger.Info($"{nameof(IHmiPaStub)} initialized");
				}
			}
			catch (System.Exception ex)
			{
				_logger.Error($"{nameof(IHmiPaStub)} can't be created", ex);
			}
		}

		public void SendTestMessage(string msg)
		{
			_logger.Info($"Sending message '{msg}' to L2...");
			//_paStub.MsgRefresh(msg);
		}

        public void UpdateSetpointsRm(string extId, int meId, short mesId, string meCreator, string connectionId)
        {
            // TODO: add L2 call
        }
    }
}
