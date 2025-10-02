using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public class StdDrampHrmMapper
    {
        public static void MapEntity(StdDprampHrm entity, StdDprampHrmDto dto)
        {
            entity.PlanNo = dto.PlanNo;
            entity.ActiveFlag = dto.ActiveFlag;
            entity.RampNo = dto.RampNo;
            //entity.Description = dto.Description;
            entity.DescRampAuto = dto.DescrampAuto;
            entity.DescRampState = dto.DescrampState;
            entity.DescRampVolume = dto.DescrampVolume;
        }

        public static StdDprampHrmDto ToDto(StdDprampHrm entity) => new()
        {
            PlanNo = entity.PlanNo,
            ActiveFlag = entity.ActiveFlag,
            RampNo = entity.RampNo,
            //Description = entity.Description
            DescrampAuto = entity.DescRampAuto,
            DescrampState = entity.DescRampState,
            DescrampVolume = entity.DescRampVolume
        };
    }
}
