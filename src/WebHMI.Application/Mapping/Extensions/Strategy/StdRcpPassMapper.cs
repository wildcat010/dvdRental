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
        public static void MapEntity(StdRcppass entity, StdRcpPassDto dto)
        {
            entity.PlanNo = dto.PlanNo;
            entity.ActiveFlag = dto.ActiveFlag;
            entity.PassNo = dto.PassNo;
            //entity.Description = dto.Description;
            entity.RollCoolState = dto.RollCoolState;
            entity.FlowBrLoadedInd0 = dto.FlowWrLoadedInd0;
            entity.FlowBrLoadedInd1 = dto.FlowWrLoadedInd1;
            entity.FlowBrLoadedInd2 = dto.FlowWrLoadedInd2;

        }

        public static StdRcpPassDto ToDto(StdRcppass entity) => new()
        {
            PlanNo = entity.PlanNo,
            ActiveFlag = entity.ActiveFlag,
            PassNo = entity.PassNo,
            //Description = entity.Description
            RollCoolState = entity.RollCoolState,
            FlowWrLoadedInd0 = entity.FlowBrLoadedInd0,
            FlowWrLoadedInd1 = entity.FlowBrLoadedInd1,
            FlowWrLoadedInd2 = entity.FlowBrLoadedInd2
        };
    }
}
