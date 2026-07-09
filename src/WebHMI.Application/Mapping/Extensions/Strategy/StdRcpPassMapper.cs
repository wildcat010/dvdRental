using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public class StdRcpPassMapper
    {
        public static void MapEntity(Stdrcppass entity, StdRcpPassDto dto)
        {
            entity.Planno = dto.PlanNo;
            entity.Activeflag = dto.ActiveFlag;
            entity.Passno = dto.PassNo;
            entity.Description = dto.Description;
            entity.Rollcoolstate = dto.RollCoolState;
            entity.FlowwrloadedInd0 = dto.FlowWrLoadedInd0;
            entity.FlowwrloadedInd1 = dto.FlowWrLoadedInd1;
            entity.FlowwrloadedInd2 = dto.FlowWrLoadedInd2;

        }

        public static StdRcpPassDto ToDto(Stdrcppass entity) => new()
        {
            PlanNo = entity.Planno,
            ActiveFlag = entity.Activeflag,
            PassNo = entity.Passno,
            Description = entity.Description,
            RollCoolState = entity.Rollcoolstate,
            FlowWrLoadedInd0 = entity.FlowwrloadedInd0,
            FlowWrLoadedInd1 = entity.FlowwrloadedInd1,
            FlowWrLoadedInd2 = entity.FlowwrloadedInd2
        };
    }
}
