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
        public static void MapEntity(Stddprampfm entity, StdDprampFmDto dto)
        {
            entity.Planno = dto.PlanNo;
            entity.Activeflag = dto.ActiveFlag;
            entity.Description = dto.Description;
            entity.Rampno = dto.RampNo;
            entity.Descrampauto = dto.DescrampAuto;
            entity.Descrampstate = dto.DescrampState;
            entity.Descrampvolume = dto.DescrampVolume;
        }

        public static StdDprampFmDto ToDto(Stddprampfm entity) => new()
        {
            PlanNo = entity.Planno,
            ActiveFlag = entity.Activeflag,
            RampNo = entity.Rampno,
            Description = entity.Description,
            DescrampAuto = entity.Descrampauto,
            DescrampState = entity.Descrampstate,
            DescrampVolume = entity.Descrampvolume
        };
    }
}
