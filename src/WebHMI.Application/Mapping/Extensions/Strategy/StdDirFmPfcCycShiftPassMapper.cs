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
        public static void MapEntity(Stddirfmpfccycshiftppass entity, StdDirFmPfcCycShiftPassDto dto)
        {
            entity.Planno = dto.PlanNo;
            entity.Activeflag = dto.ActiveFlag;
            entity.Description = dto.Description;
            entity.Passno = dto.PassNo;
            entity.Csmaxlimit = dto.CsMaxLimit;
            entity.Csminlimit = dto.CsMinLimit;
            entity.Csstartpos = dto.CsStartPos;
            entity.Csshiftdir = dto.CsShiftDir;
            entity.Csshiftstep1 = dto.CsShiftStep1;
            entity.Csshiftstep2 = dto.CsShiftStep2;
            entity.Csshiftstep3 = dto.CsShiftStep3;
            entity.Csmode = dto.Csmode;
            entity.Manint = dto.Manint;
            entity.CsmaxlimitparabolicInd0 = dto.CsmaxlimitparabolicInd0;
            entity.CsmaxlimitparabolicInd1 = dto.CsmaxlimitparabolicInd1;
            entity.CsmaxlimitparabolicInd2 = dto.CsmaxlimitparabolicInd2;
            entity.CsminlimitparabolicInd0 = dto.CsminlimitparabolicInd0;
            entity.CsminlimitparabolicInd1 = dto.CsminlimitparabolicInd1;
            entity.CsminlimitparabolicInd2 = dto.CsminlimitparabolicInd2;
            entity.CsstepparabolicInd0 = dto.CsstepparabolicInd0;
            entity.CsstepparabolicInd1 = dto.CsstepparabolicInd1;
            entity.CsstepparabolicInd2 = dto.CsstepparabolicInd2;
            entity.CsstepsmartcrownInd0 = dto.CsstepsmartcrownInd0;
            entity.CsstepsmartcrownInd1 = dto.CsstepsmartcrownInd1;
            entity.CsstepsmartcrownInd2 = dto.CsstepsmartcrownInd2;
        }

        public static StdDirFmPfcCycShiftPassDto ToDto(Stddirfmpfccycshiftppass entity) => new()
        {
            PlanNo = entity.Planno,
            ActiveFlag = entity.Activeflag,
            PassNo = entity.Passno,
            Description = entity.Description,
            Csmode = entity.Csmode,
            CsMaxLimit = entity.Csmaxlimit,
            CsMinLimit = entity.Csminlimit,
            CsStartPos = entity.Csstartpos,
            CsShiftDir = entity.Csshiftdir,
            CsShiftStep1 = entity.Csshiftstep1,
            CsShiftStep2 = entity.Csshiftstep2,
            CsShiftStep3 = entity.Csshiftstep3,
            CsmaxlimitparabolicInd0 = entity.CsmaxlimitparabolicInd0,
            CsmaxlimitparabolicInd1 = entity.CsmaxlimitparabolicInd1,
            CsmaxlimitparabolicInd2 = entity.CsmaxlimitparabolicInd2,
            CsminlimitparabolicInd0 = entity.CsminlimitparabolicInd0,
            CsminlimitparabolicInd1 = entity.CsminlimitparabolicInd1,
            CsminlimitparabolicInd2 = entity.CsminlimitparabolicInd2,
            CsstepparabolicInd0 = entity.CsstepparabolicInd0,
            CsstepparabolicInd1 = entity.CsstepparabolicInd1,
            CsstepparabolicInd2 = entity.CsstepparabolicInd2,
            CsstepsmartcrownInd0 = entity.CsstepsmartcrownInd0,
            CsstepsmartcrownInd1 = entity.CsstepsmartcrownInd1,
            CsstepsmartcrownInd2 = entity.CsstepsmartcrownInd2,
        };
    }
}
