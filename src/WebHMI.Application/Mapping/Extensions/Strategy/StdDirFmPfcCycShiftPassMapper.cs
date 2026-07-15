using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public class StdDirFmPfcCycShiftPassMapper
    {
        public static void MapEntity(StdDirFmPfcCycShiftPpass entity, StdDirFmPfcCycShiftPassDto dto)
        {
            entity.PlanNo = dto.PlanNo;
            entity.ActiveFlag = dto.ActiveFlag;
            entity.Description = dto.Description;
            entity.PassNo = dto.PassNo;
            entity.CSmaxLimit = dto.CsMaxLimit;
            entity.CSminLimit = dto.CsMinLimit;
            entity.CSstartPos = dto.CsStartPos;
            entity.CSshiftDir = dto.CsShiftDir;
            entity.CSshiftStep1 = dto.CsShiftStep1;
            entity.CSshiftStep2 = dto.CsShiftStep2;
            entity.CSshiftStep3 = dto.CsShiftStep3;
            entity.CSmode = dto.Csmode;
            entity.ManInt = dto.Manint;
            entity.CSmaxLimitParabolicInd0 = dto.CsmaxlimitparabolicInd0;
            entity.CSmaxLimitParabolicInd1 = dto.CsmaxlimitparabolicInd1;
            entity.CSmaxLimitParabolicInd2 = dto.CsmaxlimitparabolicInd2;
            entity.CSminLimitParabolicInd0 = dto.CsminlimitparabolicInd0;
            entity.CSminLimitParabolicInd1 = dto.CsminlimitparabolicInd1;
            entity.CSminLimitParabolicInd2 = dto.CsminlimitparabolicInd2;
            entity.CSstepParabolicInd0 = dto.CsstepparabolicInd0;
            entity.CSstepParabolicInd1 = dto.CsstepparabolicInd1;
            entity.CSstepParabolicInd2 = dto.CsstepparabolicInd2;
            entity.CSstepSmartCrownInd0 = dto.CsstepsmartcrownInd0;
            entity.CSstepSmartCrownInd1 = dto.CsstepsmartcrownInd1;
            entity.CSstepSmartCrownInd2 = dto.CsstepsmartcrownInd2;
        }

        public static StdDirFmPfcCycShiftPassDto ToDto(StdDirFmPfcCycShiftPpass entity) => new()
        {
            PlanNo = entity.PlanNo,
            ActiveFlag = entity.ActiveFlag,
            PassNo = entity.PassNo,
            Description = entity.Description,
            Csmode = entity.CSmode,
            CsMaxLimit = entity.CSmaxLimit,
            CsMinLimit = entity.CSminLimit,
            CsStartPos = entity.CSstartPos,
            CsShiftDir = entity.CSshiftDir,
            CsShiftStep1 = entity.CSshiftStep1,
            CsShiftStep2 = entity.CSshiftStep2,
            CsShiftStep3 = entity.CSshiftStep3,
            CsmaxlimitparabolicInd0 = entity.CSmaxLimitParabolicInd0,
            CsmaxlimitparabolicInd1 = entity.CSmaxLimitParabolicInd1,
            CsmaxlimitparabolicInd2 = entity.CSmaxLimitParabolicInd2,
            CsminlimitparabolicInd0 = entity.CSminLimitParabolicInd0,
            CsminlimitparabolicInd1 = entity.CSminLimitParabolicInd1,
            CsminlimitparabolicInd2 = entity.CSminLimitParabolicInd2,
            CsstepparabolicInd0 = entity.CSstepParabolicInd0,
            CsstepparabolicInd1 = entity.CSstepParabolicInd1,
            CsstepparabolicInd2 = entity.CSstepParabolicInd2,
            CsstepsmartcrownInd0 = entity.CSstepSmartCrownInd0,
            CsstepsmartcrownInd1 = entity.CSstepSmartCrownInd1,
            CsstepsmartcrownInd2 = entity.CSstepSmartCrownInd2,
        };
    }
}
