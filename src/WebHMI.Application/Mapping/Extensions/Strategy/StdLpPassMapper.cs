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
        public static void MapEntity(Stdlppass entity, StdLpPassDto dto)
        {
            entity.Planno = dto.PlanNo;
            entity.Activeflag = dto.ActiveFlag;
            entity.Passno = dto.PassNo;
            entity.Description = dto.Description;
            entity.Loadingvalue = dto.LoadingValue;
            entity.Loadingtype = dto.LoadingType;
            entity.Circumspeedcorrection = dto.CircumSpeedCorrection;

        }

        public static StdLpPassDto ToDto(Stdlppass entity) => new()
        {
            PlanNo = entity.Planno,
            ActiveFlag = entity.Activeflag,
            PassNo = entity.Passno,
            Description = entity.Description,
            LoadingValue = entity.Loadingvalue,
            LoadingType = entity.Loadingtype,
            CircumSpeedCorrection = entity.Circumspeedcorrection
        };
    }
}
