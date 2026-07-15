using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public class StdLpPassMapper
    {
        public static void MapEntity(StdLppass entity, StdLpPassDto dto)
        {
            entity.PlanNo = dto.PlanNo;
            entity.ActiveFlag = dto.ActiveFlag;
            entity.PassNo = dto.PassNo;
            entity.Description = dto.Description;
            entity.LoadingValue = dto.LoadingValue;
            entity.LoadingType = dto.LoadingType;
            entity.CircumSpeedCorrection = dto.CircumSpeedCorrection;

        }

        public static StdLpPassDto ToDto(StdLppass entity) => new()
        {
            PlanNo = entity.PlanNo,
            ActiveFlag = entity.ActiveFlag,
            PassNo = entity.PassNo,
            Description = entity.Description,
            LoadingValue = entity.LoadingValue,
            LoadingType = entity.LoadingType,
            CircumSpeedCorrection = entity.CircumSpeedCorrection
        };
    }
}
