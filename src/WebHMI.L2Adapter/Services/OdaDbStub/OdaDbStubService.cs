using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.L2Adapter.Dtos;
using XIDL;

namespace WebHMI.L2Adapter.Services.OdaDbStub
{
    internal class OdaDbStubService : StubServiceBase<IOdaDbStub>, IOdaDbStubService
    {
        public OdaDbStubService(ILogger logger, Func<IOdaDbStub> stubFactory)
        : base(logger, stubFactory)
        {
        }

        public void SendProcessParametersUpdated(ParamsDto arguments)
        {
            HandleL2Call(() =>
                _stub.doParamLimitChange_async(null, _timeoutMs, arguments.PlantType, arguments.Name, arguments.OldUValue, arguments.OldLValue, arguments.NewUValue, arguments.NewLValue, arguments.DisplayName, arguments.UserName)
            );
        }
    }
}
