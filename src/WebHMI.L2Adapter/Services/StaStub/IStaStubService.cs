using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.PRDB.Dbo;

namespace WebHMI.L2Adapter.Services.StaStub
{
    public interface IStaStubService
    {
        void SetpointsCalculationHMI(VMatStructEntry vMatStruct, string aggregate, string connectionId);
    }
}
