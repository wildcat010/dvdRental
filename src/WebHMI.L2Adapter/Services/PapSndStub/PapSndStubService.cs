using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIDL;

namespace WebHMI.L2Adapter.Services.PapSndStub
{
    internal class PapSndStubService : StubServiceBase<IPapSndStub>, IPapSndStubService
    {

        public PapSndStubService(ILogger logger, Func<IPapSndStub> stubFactory) 
            : base(logger, stubFactory) {

        }
        public void RequestRollData(string plantType, string rollId, short standNo, string rollType)
        {
            HandleL2Call(() =>
            _stub.requestRollData_async(null, _timeoutMs, plantType,rollId,standNo,rollType));

        }

    }
}
