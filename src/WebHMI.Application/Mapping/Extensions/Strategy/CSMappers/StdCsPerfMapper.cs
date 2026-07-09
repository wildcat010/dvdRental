using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.StdDtos.StdCSDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy.CSMappers
{
    public static class StdCsPerfMapper
    {
        public static void MapEntity(Stdcsperf entity, StdCsPerfDto dto)
        {
            entity.Planno = dto.PlanNo;
            entity.Activeflag = dto.ActiveFlag;
            entity.Description = dto.Description;

            entity.Performatorenable = dto.Performatorenable;
            entity.Performatorenableforf4tcooling = dto.Performatorenableforf4tcooling;
            entity.Performatormaxlimit = dto.Performatormaxlimit;
            entity.Performatorminlimit = dto.Performatorminlimit;
        }

        public static StdCsPerfDto ToDto(Stdcsperf entity) => new()
        {
            PlanNo = entity.Planno,
            ActiveFlag = entity.Activeflag,
            Description = entity.Description,

            Performatorenable = entity.Performatorenable,
            Performatorenableforf4tcooling = entity.Performatorenableforf4tcooling,
            Performatormaxlimit = entity.Performatormaxlimit,
            Performatorminlimit = entity.Performatorminlimit,
        };
    }
}
