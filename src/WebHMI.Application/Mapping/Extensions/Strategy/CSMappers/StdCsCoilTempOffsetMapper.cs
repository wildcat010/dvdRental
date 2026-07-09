using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.StdDtos.StdCSDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy.CSMappers
{
    public static class StdCsCoilTempOffsetMapper
    {
        public static void MapEntity(Stdcscoiltempoffset entity, StdCsCoilTempOffsetDto dto)
        {
            entity.Planno = dto.PlanNo;
            entity.Activeflag = dto.ActiveFlag;
            entity.Description = dto.Description;
            entity.Splineid = dto.Splineid;
        }

        public static StdCsCoilTempOffsetDto ToDto(Stdcscoiltempoffset entity) => new()
        {
            PlanNo = entity.Planno,
            ActiveFlag = entity.Activeflag,
            Description = entity.Description,
            Splineid = entity.Splineid,
        };
    }
}
