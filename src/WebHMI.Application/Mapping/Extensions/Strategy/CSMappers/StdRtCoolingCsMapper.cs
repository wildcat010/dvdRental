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
            entity.RtcStrategyInd0 = dto.RtcstrategyInd00;
            entity.RtcStrategyInd1 = dto.RtcstrategyInd01;
            entity.RtcStrategyInd2 = dto.RtcstrategyInd02;
            entity.RtcStrategyInd3 = dto.RtcstrategyInd03;
            entity.RtcStrategyInd4 = dto.RtcstrategyInd04;
            entity.RtcStrategyInd5 = dto.RtcstrategyInd05;
            entity.RtcStrategyInd6 = dto.RtcstrategyInd06;
            entity.RtcStrategyInd7 = dto.RtcstrategyInd07;
            entity.RtcStrategyInd8 = dto.RtcstrategyInd08;
            entity.RtcStrategyInd9 = dto.RtcstrategyInd09;

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
            RtcstrategyInd00 = entity.RtcStrategyInd0,
            RtcstrategyInd01 = entity.RtcStrategyInd1,
            RtcstrategyInd02 = entity.RtcStrategyInd2,
            RtcstrategyInd03 = entity.RtcStrategyInd3,
            RtcstrategyInd04 = entity.RtcStrategyInd4,
            RtcstrategyInd05 = entity.RtcStrategyInd5,
            RtcstrategyInd06 = entity.RtcStrategyInd6,
            RtcstrategyInd07 = entity.RtcStrategyInd7,
            RtcstrategyInd08 = entity.RtcStrategyInd8,
            RtcstrategyInd09 = entity.RtcStrategyInd9,
        };
    }
}
