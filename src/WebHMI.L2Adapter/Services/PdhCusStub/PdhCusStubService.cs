using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIDL;

namespace WebHMI.L2Adapter.Services.PdhCusStub
{
    internal class PdhCusStubService : StubServiceBase<IPdhCusStub>, IPdhCusStubService
    {
        public PdhCusStubService(ILogger logger, Func<IPdhCusStub> stubFactory)
         : base ( logger, stubFactory) {
        
        }

        public void NewHeatSimulation(string heatId, string sequenceId, short heatStart, float length)
        {
            HandleL2Call(() =>
            _stub.newHeatSimu_async(null, _timeoutMs, heatId, sequenceId, heatStart,length));
        }
        public void NewHeatOperation(string heatId, string sequenceId, short heatStart, float length)
        {
            HandleL2Call(() =>
                _stub.newHeatOper_async(null, _timeoutMs, heatId, sequenceId, heatStart, length));
        }
    }
}
