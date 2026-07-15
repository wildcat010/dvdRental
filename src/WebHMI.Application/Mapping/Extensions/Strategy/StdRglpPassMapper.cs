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
        public static void MapEntity(StdRglppass entity, StdRglpPassDto dto)
        {
            entity.PlanNo = dto.PlanNo;
            entity.ActiveFlag = dto.ActiveFlag;
            entity.PassNo = dto.PassNo;
            entity.Description = dto.Description;
            entity.RollGapLubState = dto.RollGapLubState;
            entity.RollGapLubRampTimeStart = dto.RollGapLubRampTimeStart;
            entity.RollGapLubRampTimeStop = dto.RollGapLubRampTimeStop;
            entity.RollGapLubSwitchLength = dto.RollGapLubSwitchLength;
            entity.RollGapLubOilFlowTop = dto.RollGapLubOilFlowTop;
            entity.RollGapLubOilFlowBot = dto.RollGapLubOilFlowBot;

        }

        public static StdRglpPassDto ToDto(StdRglppass entity) => new()
        {
            PlanNo = entity.PlanNo,
            ActiveFlag = entity.ActiveFlag,
            PassNo = entity.PassNo,
            Description = entity.Description,
            RollGapLubState = entity.RollGapLubState,
            RollGapLubRampTimeStart = entity.RollGapLubRampTimeStart,
            RollGapLubRampTimeStop = entity.RollGapLubRampTimeStop,
            RollGapLubSwitchLength = entity.RollGapLubSwitchLength,
            RollGapLubOilFlowTop = entity.RollGapLubOilFlowTop,
            RollGapLubOilFlowBot = entity.RollGapLubOilFlowBot
        };
    }
}
