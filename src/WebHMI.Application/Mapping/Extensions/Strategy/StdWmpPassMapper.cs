using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public class StdWmpPassMapper
    {
        public static void MapEntity(Stdwmppass entity, StdWmpPassDto dto)
        {
            entity.Planno = dto.PlanNo;
            entity.Activeflag = dto.ActiveFlag;
            entity.Passno = dto.PassNo;
            entity.Description = dto.Description;
            entity.Model = dto.Model;


        }

        public static StdWmpPassDto ToDto(Stdwmppass entity) => new()
        {
            PlanNo = entity.Planno,
            ActiveFlag = entity.Activeflag,
            PassNo = entity.Passno,
            Description = entity.Description,
            Model = entity.Model
        };
    }
}
