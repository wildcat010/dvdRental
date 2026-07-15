using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public class StdLpMapper
    {
        public static void MapEntity(StdLp entity, StdLpDto dto)
        {
            entity.PlanNo = dto.PlanNo;
            entity.ActiveFlag = dto.ActiveFlag;
            entity.Description = dto.Description;
            entity.RedDistHrmHfm = dto.Reddisthrmhfm;


        }

        public static StdLpDto ToDto(StdLp entity) => new()
        {
            PlanNo = entity.PlanNo,
            ActiveFlag = entity.ActiveFlag,
            Description = entity.Description,
            Reddisthrmhfm = entity.RedDistHrmHfm
        };
    }
}
