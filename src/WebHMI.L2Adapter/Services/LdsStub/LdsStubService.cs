using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIDL;

namespace WebHMI.L2Adapter.Services.LdsStub
{
    public class LdsStubService : StubServiceBase<ILdsStub>, ILdsStubService
    {
        public LdsStubService(ILogger logger, Func<ILdsStub> stubFactory) 
            :base(logger, stubFactory)
        { 
        }
        public void UpdateConfig(string aggregateName)
        {
            HandleL2Call(() =>
                    _stub.updateConfigEsp_async(null, _timeoutMs)
                );
        }


    }
}
