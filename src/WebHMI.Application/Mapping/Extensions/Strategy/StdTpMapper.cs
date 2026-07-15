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
        public static void MapEntity(StdTp entity, StdTpDto dto)
        {
            entity.PlanNo = dto.PlanNo;
            entity.ActiveFlag = dto.ActiveFlag;
            entity.Description = dto.Description;
            entity.CoilerTension = dto.CoilerTension;
            entity.YieldStress = dto.YieldStress;
        }

        public static StdTpDto ToDto(StdTp entity) => new()
        {
            PlanNo = entity.PlanNo,
            ActiveFlag = entity.ActiveFlag,
            Description = entity.Description,
            CoilerTension = entity.CoilerTension,
            YieldStress = entity.YieldStress
        };
    }
}
