using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public class StdIhpMapper
    {
        public static void MapEntity(StdIhp entity, StdIhpDto dto)
        {
            entity.PlanNo = dto.PlanNo;
            entity.ActiveFlag = dto.ActiveFlag;
            //entity.Description = dto.Description;
            entity.Temperature = dto.Temperature;
        }

        public static StdIhpDto ToDto(StdIhp entity) => new()
        {
            PlanNo = entity.PlanNo,
            ActiveFlag = entity.ActiveFlag,
            //Description = entity.Description
            Temperature = entity.Temperature
        };
    }
}
