using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.L2Adapter.Services.PdhCusStub
{
    public interface IPdhCusStubService
    {
        void NewHeatSimulation(string heatId, string sequenceId, short heatStart, float length);
        void NewHeatOperation(string heatId, string sequenceId, short heatStart, float length);
    }
}
