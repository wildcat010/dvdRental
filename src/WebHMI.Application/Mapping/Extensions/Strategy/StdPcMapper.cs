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
        public static void MapEntity(Stdpc entity, StdPcDto dto)
        {
            entity.Activeflag = dto.ActiveFlag;
            entity.Planno = dto.PlanNo;
            entity.Delaylength = dto.Delaylength;
            entity.Description = dto.Description;
            entity.Noramps = dto.Noramps;
        }

        public static StdPcDto ToDto(Stdpc entity) => new()
        {
            ActiveFlag = entity.Activeflag,
            PlanNo = entity.Planno,
            Delaylength = entity.Delaylength,
            Description = entity.Description,
            Noramps = entity.Noramps,
        };
    }
}
