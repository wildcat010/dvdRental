using Abp.UI;
using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WebHMI.L2Adapter.ConnectionManagers;
using WebHMI.PRDB.Dbo;
using XIDL;

namespace WebHMI.L2Adapter.Services
{
    public abstract class StubServiceBase<TStub>
    {
        protected readonly ILogger _logger;
        protected readonly int _timeoutMs = 90;

        protected TStub _stub { get; private set;}
        private readonly Func<TStub> _stubFactory;

        protected StubServiceBase(ILogger logger, Func<TStub> stubFactory)
        {
            _logger = logger;

            _stubFactory = stubFactory ?? throw new ArgumentNullException(nameof(stubFactory));

            //_stub = CreateStub();
            //_logger.Info($"[CAPPA] {_stub.GetType().Name} initialized");
        }

        //lazy init
        protected TStub Stub => _stub ??= CreateStub();

        protected TStub CreateStub()
        {
            var stub = _stubFactory();
            _logger.Info($"[CAPPA]{stub.GetType().Name} initialized");
            return stub;
        }

        protected ME_CODE ToL2OrMeCode(VMatStructEntry entryMatStruct)
        {
            ME_STRUCT meStruct = new()
            {
                MeId = entryMatStruct.Enormeid,
                MesId = entryMatStruct.Enormesid ?? -1,
                MeCreator = entryMatStruct.Enorcreator
            };

            ME_CODE meCode = new()
            {
                BasId = entryMatStruct.Enorbasid,
                ExtId = entryMatStruct.Enorextid,
                MeTyp = entryMatStruct.Enormetype,
                Actual = meStruct,
                Original = meStruct
            };

            return meCode;
        }

        protected ME_CODE ToL2PhyMeCode(VMatStructEntry entryMatStruct)
        {
            ME_STRUCT meStruct = new()
            {
                MeId = entryMatStruct.Enphmeid,
                MesId = entryMatStruct.Enphmesid ?? -1,
                MeCreator = entryMatStruct.Enphcreator
            };

            ME_CODE meCode = new()
            {
                BasId = entryMatStruct.Enphbasid,
                ExtId = entryMatStruct.Enphextid,
                MeTyp = entryMatStruct.Enphmetype,
                Actual = meStruct,
                Original = meStruct
            };

            return meCode;
        }

        protected void HandleL2Call(Action action, [CallerMemberName] string method = "")
        {
            if (!ConnectionManager.IsL2CommunicationRunning)
            {
                _logger.Info($"[{method}] L2 call supressed, communication is not running");
                throw new UserFriendlyException("L2 communication is not running, trying to reconnect...");
            }

            _stub ??= CreateStub();

            try
            {
                _logger.Info($"[{method}] Trying to send L2 call...");
                action();
                _logger.Info($"[{method}] L2 call sent");
            }
            catch (System.Exception ex)
            {
                _logger.Error($"[{method}] Error occured while sending L2 message", ex);
                _logger.Info($"[{method}] Error occured while sending L2 message", ex);

                throw new UserFriendlyException("Exception thrown when calling L2 Process");
            }
        }
    }
}
