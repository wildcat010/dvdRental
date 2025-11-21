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
        public static void MapEntity(StdCsCoilTempOffset entity, StdCsCoilTempOffsetDto dto)
        {
            entity.PlanNo = dto.PlanNo;
            entity.ActiveFlag = dto.ActiveFlag;
            entity.Description = dto.Description;
            entity.SplineId = dto.Splineid;
        }

        public static StdCsCoilTempOffsetDto ToDto(StdCsCoilTempOffset entity) => new()
        {
            PlanNo = entity.PlanNo,
            ActiveFlag = entity.ActiveFlag,
            Description = entity.Description,
            Splineid = entity.SplineId,
        };
    }
}
