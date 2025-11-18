using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using WebHMI.L2Adapter.Dtos;
using XIDL;

namespace WebHMI.L2Adapter.Services.RollChangeStub
{
    internal class RollChangeStubService : StubServiceBase<IRollChangeStub>, IRollChangeStubService
    {
        public RollChangeStubService(ILogger logger, Func<IRollChangeStub> stubFactory)
        : base(logger, stubFactory)
        {
        }
        public void RollChange(RollChangeDto dto)
        {
            HandleL2Call(() =>
                _stub.doRollChange_async(null, _timeoutMs, dto.PlantType, dto.StandNo,
                dto.ChangeWKR, dto.ChangeIMR, dto.ChangeBURu,
                dto.ChangeBURl,dto.ChangeEWR, dto.ChangeSPT,
                dto.ChangeZR0, dto.ChangeZR1, dto.SendL1)
            );
        }

    }
}
