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
        public static void MapEntity(Stdcsrtcooling entity, StdRtCoolingCsDto dto)
        {

            entity.Activeflag = dto.ActiveFlag;
            entity.Planno = dto.PlanNo;
            entity.Description = dto.Description;
            entity.Rtccooldowntime = dto.Rtccooldowntime;
            entity.RtcstrategyInd10 = dto.RtcstrategyInd10;
            entity.RtcstrategyInd11 = dto.RtcstrategyInd11;
            entity.RtcstrategyInd12 = dto.RtcstrategyInd12;
            entity.RtcstrategyInd13 = dto.RtcstrategyInd13;
            entity.RtcstrategyInd14 = dto.RtcstrategyInd14;
            entity.RtcstrategyInd15 = dto.RtcstrategyInd15;
            entity.RtcstrategyInd00 = dto.RtcstrategyInd00;
            entity.RtcstrategyInd01 = dto.RtcstrategyInd01;
            entity.RtcstrategyInd02 = dto.RtcstrategyInd02;
            entity.RtcstrategyInd03 = dto.RtcstrategyInd03;
            entity.RtcstrategyInd04 = dto.RtcstrategyInd04;
            entity.RtcstrategyInd05 = dto.RtcstrategyInd05;
            entity.RtcstrategyInd06 = dto.RtcstrategyInd06;
            entity.RtcstrategyInd07 = dto.RtcstrategyInd07;
            entity.RtcstrategyInd08 = dto.RtcstrategyInd08;
            entity.RtcstrategyInd09 = dto.RtcstrategyInd09;

        }

        public static StdRtCoolingCsDto ToDto(Stdcsrtcooling entity) => new()
        {
            ActiveFlag = entity.Activeflag,
            PlanNo = entity.Planno,
            Description = entity.Description,
            Rtccooldowntime = entity.Rtccooldowntime,
            RtcstrategyInd10 = entity.RtcstrategyInd10,
            RtcstrategyInd11 = entity.RtcstrategyInd11,
            RtcstrategyInd12 = entity.RtcstrategyInd12,
            RtcstrategyInd13 = entity.RtcstrategyInd13,
            RtcstrategyInd14 = entity.RtcstrategyInd14,
            RtcstrategyInd15 = entity.RtcstrategyInd15,
            RtcstrategyInd00 = entity.RtcstrategyInd00,
            RtcstrategyInd01 = entity.RtcstrategyInd01,
            RtcstrategyInd02 = entity.RtcstrategyInd02,
            RtcstrategyInd03 = entity.RtcstrategyInd03,
            RtcstrategyInd04 = entity.RtcstrategyInd04,
            RtcstrategyInd05 = entity.RtcstrategyInd05,
            RtcstrategyInd06 = entity.RtcstrategyInd06,
            RtcstrategyInd07 = entity.RtcstrategyInd07,
            RtcstrategyInd08 = entity.RtcstrategyInd08,
            RtcstrategyInd09 = entity.RtcstrategyInd09,
        };
    }
}
