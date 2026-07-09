using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public class StdRglpPassMapper
    {
        public static void MapEntity(Stdrglppass entity, StdRglpPassDto dto)
        {
            entity.Planno = dto.PlanNo;
            entity.Activeflag = dto.ActiveFlag;
            entity.Passno = dto.PassNo;
            entity.Description = dto.Description;
            entity.Rollgaplubstate = dto.RollGapLubState;
            entity.Rollgaplubramptimestart = dto.RollGapLubRampTimeStart;
            entity.Rollgaplubramptimestop = dto.RollGapLubRampTimeStop;
            entity.Rollgaplubswitchlength = dto.RollGapLubSwitchLength;
            entity.Rollgapluboilflowtop = dto.RollGapLubOilFlowTop;
            entity.Rollgapluboilflowbot = dto.RollGapLubOilFlowBot;

        }

        public static StdRglpPassDto ToDto(Stdrglppass entity) => new()
        {
            PlanNo = entity.Planno,
            ActiveFlag = entity.Activeflag,
            PassNo = entity.Passno,
            Description = entity.Description,
            RollGapLubState = entity.Rollgaplubstate,
            RollGapLubRampTimeStart = entity.Rollgaplubramptimestart,
            RollGapLubRampTimeStop = entity.Rollgaplubramptimestop,
            RollGapLubSwitchLength = entity.Rollgaplubswitchlength,
            RollGapLubOilFlowTop = entity.Rollgapluboilflowtop,
            RollGapLubOilFlowBot = entity.Rollgapluboilflowbot
        };
    }
}
