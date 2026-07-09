using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public class StdTpMapper
    {
        public static void MapEntity(Stdtp entity, StdTpDto dto)
        {
            entity.Planno = dto.PlanNo;
            entity.Activeflag = dto.ActiveFlag;
            entity.Description = dto.Description;
            entity.Coilertension = dto.CoilerTension;
            entity.Yieldstress = dto.YieldStress;
        }

        public static StdTpDto ToDto(Stdtp entity) => new()
        {
            PlanNo = entity.Planno,
            ActiveFlag = entity.Activeflag,
            Description = entity.Description,
            CoilerTension = entity.Coilertension,
            YieldStress = entity.Yieldstress
        };
    }
}
