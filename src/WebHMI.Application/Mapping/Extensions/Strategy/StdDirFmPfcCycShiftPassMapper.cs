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
            //entity.Description = dto.Description;
            entity.PassNo = dto.PassNo;
            entity.CSmaxLimit = dto.CsMaxLimit;
            entity.CSminLimit = dto.CsMinLimit;
            entity.CSstartPos = dto.CsStartPos;
            entity.CSshiftDir = dto.CsShiftDir;
            entity.CSshiftStep1 = dto.CsShiftStep1;
            entity.CSshiftStep2 = dto.CsShiftStep2;
            entity.CSshiftStep3 = dto.CsShiftStep3;
        }

        public static StdDirFmPfcCycShiftPassDto ToDto(StdDirFmPfcCycShiftPpass entity) => new()
        {
            PlanNo = entity.PlanNo,
            ActiveFlag = entity.ActiveFlag,
            PassNo = entity.PassNo,
            //Description = entity.Description
            CsMaxLimit = entity.CSmaxLimit,
            CsMinLimit = entity.CSminLimit,
            CsStartPos = entity.CSstartPos,
            CsShiftDir = entity.CSshiftDir,
            CsShiftStep1 = entity.CSshiftStep1,
            CsShiftStep2 = entity.CSshiftStep2,
            CsShiftStep3 = entity.CSshiftStep3,
        };
    }
}
