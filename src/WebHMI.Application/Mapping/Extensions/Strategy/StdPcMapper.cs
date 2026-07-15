using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.StdDtos;
using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public class StdPcMapper
    {
        public static void MapEntity(StdPc entity, StdPcDto dto)
        {
            entity.ActiveFlag = dto.ActiveFlag;
            entity.PlanNo = dto.PlanNo;
            entity.DelayLength = dto.Delaylength;
            entity.Description = dto.Description;
            entity.NoRamps = dto.Noramps;
        }

        public static StdPcDto ToDto(StdPc entity) => new()
        {
            ActiveFlag = entity.ActiveFlag,
            PlanNo = entity.PlanNo,
            Delaylength = entity.DelayLength,
            Description = entity.Description,
            Noramps = entity.NoRamps,
        };
    }
}
