using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.L2Adapter.Dtos;

namespace WebHMI.L2Adapter.Services.RollChangeStub
{
    public interface IRollChangeStubService
    {
        void RollChange(RollChangeDto rollChangeDto);
    }
}
