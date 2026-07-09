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
        public static void MapEntity(Stdtppass entity, StdTpPassDto dto)
        {
            entity.Planno = dto.PlanNo;
            entity.Activeflag = dto.ActiveFlag;
            entity.Passno = dto.PassNo;
            entity.Description = dto.Description;
            entity.Speciffotension = dto.SpeciffoTension;
            entity.Looperstriplen = dto.LooperStripLen;

        }

        public static StdTpPassDto ToDto(Stdtppass entity) => new()
        {
            PlanNo = entity.Planno,
            ActiveFlag = entity.Activeflag,
            PassNo = entity.Passno,
            Description = entity.Description,
            SpeciffoTension = entity.Speciffotension,
            LooperStripLen = entity.Looperstriplen
        };
    }
}
