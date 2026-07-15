using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public class StdTpPassMapper
    {
        public static void MapEntity(StdTppass entity, StdTpPassDto dto)
        {
            entity.PlanNo = dto.PlanNo;
            entity.ActiveFlag = dto.ActiveFlag;
            entity.PassNo = dto.PassNo;
            entity.Description = dto.Description;
            entity.SpecifFoTension = dto.SpeciffoTension;
            entity.LooperStripLen = dto.LooperStripLen;

        }

        public static StdTpPassDto ToDto(StdTppass entity) => new()
        {
            PlanNo = entity.PlanNo,
            ActiveFlag = entity.ActiveFlag,
            PassNo = entity.PassNo,
            Description = entity.Description,
            SpeciffoTension = entity.SpecifFoTension,
            LooperStripLen = entity.LooperStripLen
        };
    }
}
