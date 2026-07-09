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
        public static void MapEntity(Stddpramphrm entity, StdDprampHrmDto dto)
        {
            entity.Planno = dto.PlanNo;
            entity.Activeflag = dto.ActiveFlag;
            entity.Description = dto.Description;
            entity.Rampno = dto.RampNo;
            entity.Descrampauto = dto.DescrampAuto;
            entity.Descrampstate = dto.DescrampState;
            entity.Descrampvolume = dto.DescrampVolume;
        }

        public static StdDprampHrmDto ToDto(Stddpramphrm entity) => new()
        {
            PlanNo = entity.Planno,
            ActiveFlag = entity.Activeflag,
            Description = entity.Description,
            RampNo = entity.Rampno,
            DescrampAuto = entity.Descrampauto,
            DescrampState = entity.Descrampstate,
            DescrampVolume = entity.Descrampvolume
        };
    }
}
