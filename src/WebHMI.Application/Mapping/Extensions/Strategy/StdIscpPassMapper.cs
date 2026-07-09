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
        public static void MapEntity(Stdiscppass entity, StdIscpPassDto dto)
        {
            entity.Planno = dto.PlanNo;
            entity.Activeflag = dto.ActiveFlag;
            entity.Passno = dto.PassNo;
            entity.Description = dto.Description;
            entity.IscvolumeInd0 = dto.IscVolumeInd0;
            entity.IscvolumeInd1 = dto.IscVolumeInd1;
            entity.IscvolumeInd2 = dto.IscVolumeInd2;
            entity.Stripspraybefor = dto.StripSprayBefore;
            entity.Fumesuppspraybehind = dto.FumeSuppSprayBehind;

        }

        public static StdIscpPassDto ToDto(Stdiscppass entity) => new()
        {
            PlanNo = entity.Planno,
            ActiveFlag = entity.Activeflag,
            PassNo = entity.Passno,
            Description = entity.Description,
            IscVolumeInd0 = entity.IscvolumeInd0,
            IscVolumeInd1 = entity.IscvolumeInd1,
            IscVolumeInd2 = entity.IscvolumeInd2,
            StripSprayBefore = entity.Stripspraybefor,
            FumeSuppSprayBehind = entity.Fumesuppspraybehind

        };
    }
}
