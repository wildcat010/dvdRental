using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public class StdDrampFmMapper
    {
        public static void MapEntity(StdDprampFm entity, StdDprampFmDto dto)
        {
            entity.PlanNo = dto.PlanNo;
            entity.ActiveFlag = dto.ActiveFlag;
            entity.Description = dto.Description;
            entity.RampNo = dto.RampNo;
            entity.DescRampAuto = dto.DescrampAuto;
            entity.DescRampState = dto.DescrampState;
            entity.DescRampVolume = dto.DescrampVolume;
        }

        public static StdDprampFmDto ToDto(StdDprampFm entity) => new()
        {
            PlanNo = entity.PlanNo,
            ActiveFlag = entity.ActiveFlag,
            RampNo = entity.RampNo,
            Description = entity.Description,
            DescrampAuto = entity.DescRampAuto,
            DescrampState = entity.DescRampState,
            DescrampVolume = entity.DescRampVolume
        };
    }
}
