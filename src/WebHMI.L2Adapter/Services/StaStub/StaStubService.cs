using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.PRDB.Dbo;
using XIDL;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WebHMI.L2Adapter.Services.StaStub
{
    internal class StaStubService : StubServiceBase<IStaStub>, IStaStubService
    {
        public StaStubService(ILogger logger, Func<IStaStub> stubFactory)
        : base(logger, stubFactory)
        {
        }
       
        public void SetpointsCalculationHMI(VMatStructEntry matStruct, string aggregate, string connectionId)
        {
            ME_CODE meCode = ToL2OrMeCode(matStruct);

            HMI_RETURN hmiReturn = new HMI_RETURN();
            hmiReturn.HmiClientId = connectionId ?? "NoId";
            hmiReturn.FunctionName = "doSetpCalcHMI";
            hmiReturn.LfeName = "sta";
                
            HandleL2Call(() =>
                _stub.doSetpCalcHMI_async(null, _timeoutMs, meCode, aggregate, hmiReturn)
            );
        }

    }
}
