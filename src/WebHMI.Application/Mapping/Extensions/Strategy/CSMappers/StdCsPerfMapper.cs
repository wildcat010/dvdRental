using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.StdDtos.StdCSDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy.CSMappers
{
    public static class StdCsPerfMapper
    {
        public static void MapEntity(StdCsPerf entity, StdCsPerfDto dto)
        {
            entity.PlanNo = dto.PlanNo;
            entity.ActiveFlag = dto.ActiveFlag;
            entity.Description = dto.Description;

            entity.PerformatorEnable = dto.Performatorenable;
            entity.PerformatorEnableForF4tCooling = dto.Performatorenableforf4tcooling;
            entity.PerformatorMaxLimit = dto.Performatormaxlimit;
            entity.PerformatorMinLimit = dto.Performatorminlimit;
            entity.PerformatorManualNo = dto.Performatormanualno;
            entity.PerformatorControlRatio = dto.Performatorcontrolratio;
        }

        public static StdCsPerfDto ToDto(StdCsPerf entity) => new()
        {
            PlanNo = entity.PlanNo,
            ActiveFlag = entity.ActiveFlag,
            Description = entity.Description,

            Performatorenable = entity.PerformatorEnable,
            Performatorenableforf4tcooling = entity.PerformatorEnableForF4tCooling,
            Performatormaxlimit = entity.PerformatorMaxLimit,
            Performatorminlimit = entity.PerformatorMinLimit,
            Performatormanualno = entity.PerformatorManualNo,
            Performatorcontrolratio = entity.PerformatorControlRatio,
        };
    }
}
