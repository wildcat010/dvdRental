using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public class StdRcpPassMapper
    {
        public static void MapEntity(StdRcppass entity, StdRcpPassDto dto)
        {
            entity.Mzcamplitude = dto.Mzcamplitude;
            entity.MzccascadeInd0 = dto.MzccascadeInd0;
            entity.MzccascadeInd1 = dto.MzccascadeInd1;
            entity.MzccascadeInd2 = dto.MzccascadeInd2;
            entity.MzcflowRate = dto.MzcflowRate;
            entity.MzcflowRateEdge = dto.MzcflowRateEdge;
            entity.MzcnozzelIndex = dto.MzcnozzelIndex;
            entity.DelayTime = dto.DelayTime;
            entity.Description = dto.Description;
            entity.FlowBrIdleInd0 = dto.FlowBrIdleInd0;
            entity.FlowBrIdleInd1 = dto.FlowBrIdleInd1;
            entity.FlowBrIdleInd2 = dto.FlowBrIdleInd2;
            entity.FlowBrLoadedInd0 = dto.FlowBrLoadedInd0;
            entity.FlowBrLoadedInd1 = dto.FlowBrLoadedInd1;
            entity.FlowBrLoadedInd2 = dto.FlowBrLoadedInd2;
            entity.FlowWrIdleInd0 = dto.FlowWrIdleInd0;
            entity.FlowWrIdleInd1 = dto.FlowWrIdleInd1;
            entity.FlowWrIdleInd2 = dto.FlowWrIdleInd2;
            entity.FlowWrIdleInd3 = dto.FlowWrIdleInd3;
            entity.FlowWrIdleInd4 = dto.FlowWrIdleInd4;
            entity.FlowWrIdleInd5 = dto.FlowWrIdleInd5;
            entity.FlowWrLoadedInd0 = dto.FlowWrLoadedInd0;
            entity.FlowWrLoadedInd1 = dto.FlowWrLoadedInd1;
            entity.FlowWrLoadedInd2 = dto.FlowWrLoadedInd2;
            entity.FlowWrLoadedInd3 = dto.FlowWrLoadedInd3;
            entity.FlowWrLoadedInd4 = dto.FlowWrLoadedInd4;
            entity.FlowWrLoadedInd5 = dto.FlowWrLoadedInd5;
            entity.RollCoolCurve = dto.RollCoolCurve;
            entity.RollCoolState = dto.RollCoolState;
            entity.WrcAngle = dto.WrcAngle;
        }

        public static StdRcpPassDto ToDto(StdRcppass entity) => new()
        {
            Mzcamplitude = entity.Mzcamplitude,
            MzccascadeInd0 = entity.MzccascadeInd0,
            MzccascadeInd1 = entity.MzccascadeInd1,
            MzccascadeInd2 = entity.MzccascadeInd2,
            MzcflowRate = entity.MzcflowRate,
            MzcflowRateEdge = entity.MzcflowRateEdge,
            MzcnozzelIndex = entity.MzcnozzelIndex,
            DelayTime = entity.DelayTime,
            Description = entity.Description,
            FlowBrIdleInd0 = entity.FlowBrIdleInd0,
            FlowBrIdleInd1 = entity.FlowBrIdleInd1,
            FlowBrIdleInd2 = entity.FlowBrIdleInd2,
            FlowBrLoadedInd0 = entity.FlowBrLoadedInd0,
            FlowBrLoadedInd1 = entity.FlowBrLoadedInd1,
            FlowBrLoadedInd2 = entity.FlowBrLoadedInd2,
            FlowWrIdleInd0 = entity.FlowWrIdleInd0,
            FlowWrIdleInd1 = entity.FlowWrIdleInd1,
            FlowWrIdleInd2 = entity.FlowWrIdleInd2,
            FlowWrIdleInd3 = entity.FlowWrIdleInd3,
            FlowWrIdleInd4 = entity.FlowWrIdleInd4,
            FlowWrIdleInd5 = entity.FlowWrIdleInd5,
            FlowWrLoadedInd0 = entity.FlowWrLoadedInd0,
            FlowWrLoadedInd1 = entity.FlowWrLoadedInd1,
            FlowWrLoadedInd2 = entity.FlowWrLoadedInd2,
            FlowWrLoadedInd3 = entity.FlowWrLoadedInd3,
            FlowWrLoadedInd4 = entity.FlowWrLoadedInd4,
            FlowWrLoadedInd5 = entity.FlowWrLoadedInd5,
            RollCoolCurve = entity.RollCoolCurve,
            RollCoolState = entity.RollCoolState,
            WrcAngle = entity.WrcAngle,
        };
    }
}
