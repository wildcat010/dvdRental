using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.StdDtos.StdCSDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy.CSMappers
{
    public static class StdRtCoolingCsMapper
    {
        public static void MapEntity(StdCsRtCooling entity, StdRtCoolingCsDto dto)
        {

            entity.ActiveFlag = dto.ActiveFlag;
            entity.PlanNo = dto.PlanNo;
            entity.Description = dto.Description;
            entity.RtcCoolDownTime = dto.Rtccooldowntime;
            entity.RtcStrategyInd10 = dto.RtcstrategyInd10;
            entity.RtcStrategyInd11 = dto.RtcstrategyInd11;
            entity.RtcStrategyInd12 = dto.RtcstrategyInd12;
            entity.RtcStrategyInd13 = dto.RtcstrategyInd13;
            entity.RtcStrategyInd14 = dto.RtcstrategyInd14;
            entity.RtcStrategyInd15 = dto.RtcstrategyInd15;
            entity.RtcStrategyInd00 = dto.RtcstrategyInd00;
            entity.RtcStrategyInd01 = dto.RtcstrategyInd01;
            entity.RtcStrategyInd02 = dto.RtcstrategyInd02;
            entity.RtcStrategyInd03 = dto.RtcstrategyInd03;
            entity.RtcStrategyInd04 = dto.RtcstrategyInd04;
            entity.RtcStrategyInd05 = dto.RtcstrategyInd05;
            entity.RtcStrategyInd06 = dto.RtcstrategyInd06;
            entity.RtcStrategyInd07 = dto.RtcstrategyInd07;
            entity.RtcStrategyInd08 = dto.RtcstrategyInd08;
            entity.RtcStrategyInd09 = dto.RtcstrategyInd09;

        }

        public static StdRtCoolingCsDto ToDto(StdCsRtCooling entity) => new()
        {
            ActiveFlag = entity.ActiveFlag,
            PlanNo = entity.PlanNo,
            Description = entity.Description,
            Rtccooldowntime = entity.RtcCoolDownTime,
            RtcstrategyInd10 = entity.RtcStrategyInd10,
            RtcstrategyInd11 = entity.RtcStrategyInd11,
            RtcstrategyInd12 = entity.RtcStrategyInd12,
            RtcstrategyInd13 = entity.RtcStrategyInd13,
            RtcstrategyInd14 = entity.RtcStrategyInd14,
            RtcstrategyInd15 = entity.RtcStrategyInd15,
            RtcstrategyInd00 = entity.RtcStrategyInd00,
            RtcstrategyInd01 = entity.RtcStrategyInd01,
            RtcstrategyInd02 = entity.RtcStrategyInd02,
            RtcstrategyInd03 = entity.RtcStrategyInd03,
            RtcstrategyInd04 = entity.RtcStrategyInd04,
            RtcstrategyInd05 = entity.RtcStrategyInd05,
            RtcstrategyInd06 = entity.RtcStrategyInd06,
            RtcstrategyInd07 = entity.RtcStrategyInd07,
            RtcstrategyInd08 = entity.RtcStrategyInd08,
            RtcstrategyInd09 = entity.RtcStrategyInd09,
        };
    }
}
