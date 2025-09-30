using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public class StdCompPlanMapper
    {
        public static void MapEntity(StdCompPlan entity, StdCompPlanDto dto)
        {
            entity.PlanNo = dto.PlanNo;
            entity.ActiveFlag = dto.ActiveFlag;
            //entity.Description = dto.Description;
            //entity.TempInd0 = dto.Temp;
            //entity.KawaInd0 = dto.Kawa;
        }

        public static StdCompPlanDto ToDto(StdCompPlan entity) => new()
        {
            PlanNo = entity.PlanNo,
            ActiveFlag = entity.ActiveFlag,
            //Description = entity.Description
            //Temp = entity.TempInd0;
            //Kawa = entity.KawaInd0;
        };
    }
}
