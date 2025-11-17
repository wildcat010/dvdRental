using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.L2Adapter.Dtos;
using XIDL;

namespace WebHMI.L2Adapter.Services.MosRcStub
{
    internal class MosRcStubService : StubServiceBase<IMosRcStub>, IMosRcStubService
    {
        public MosRcStubService(ILogger logger, Func<IMosRcStub> stubFactory)
        : base(logger, stubFactory)
        {
        }
        public void TakeoverActual4RevCurve(short standNo)
        {
            HandleL2Call(() =>
                _stub.takeAct4RevCurv_async(null, _timeoutMs, standNo)
            );
        }
    }
}
