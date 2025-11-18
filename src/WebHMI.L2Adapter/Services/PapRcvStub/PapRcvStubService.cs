using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using WebHMI.PRDB.Dbo;
using XIDL;

namespace WebHMI.L2Adapter.Services.PapRcvStub
{
    internal class PapRcvStubService : StubServiceBase<IPapRcvStub>, IPapRcvStubService
    {
        public PapRcvStubService(ILogger logger, Func<IPapRcvStub> stubFactory)
        : base(logger, stubFactory)
        {
        }

        public void PrimdCopyHMI(VMatStructEntry matStruct, string newExtId, short isTestMat) 
        {
            ME_CODE meCode = ToL2MeCode(matStruct);

            HandleL2Call(() =>
                _stub.doPrimdCopyHMI_async(null, _timeoutMs, meCode, newExtId, isTestMat)
            );
        }

    }
}
