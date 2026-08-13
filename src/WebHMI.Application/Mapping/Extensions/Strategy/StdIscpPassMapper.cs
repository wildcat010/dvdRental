using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public class StdIscpPassMapper
    {
        public static void MapEntity(StdIscppass entity, StdIscpPassDto dto)
        {
            entity.PlanNo = dto.PlanNo;
            entity.ActiveFlag = dto.ActiveFlag;
            entity.PassNo = dto.PassNo;
            entity.Description = dto.Description;
            entity.IscVolumeInd0 = dto.IscVolumeInd0;
            entity.IscVolumeInd1 = dto.IscVolumeInd1;
            entity.IscVolumeInd2 = dto.IscVolumeInd2;
            entity.StripSprayBefor = dto.StripSprayBefore;
            entity.FumeSuppSprayBehind = dto.FumeSuppSprayBehind;
            entity.StripSprayBehind = dto.StripSprayBehind;

        }

        public static StdIscpPassDto ToDto(StdIscppass entity) => new()
        {
            PlanNo = entity.PlanNo,
            ActiveFlag = entity.ActiveFlag,
            PassNo = entity.PassNo,
            Description = entity.Description,
            IscVolumeInd0 = entity.IscVolumeInd0,
            IscVolumeInd1 = entity.IscVolumeInd1,
            IscVolumeInd2 = entity.IscVolumeInd2,
            StripSprayBefore = entity.StripSprayBefor,
            FumeSuppSprayBehind = entity.FumeSuppSprayBehind,
            StripSprayBehind = entity.StripSprayBehind
        };
    }
}
