using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos
{
    public class StdDirFmPfcCycShiftPassDto : StdPassDto
    {
        public double? CsMaxLimit { get; set; }
        public double? CsMinLimit { get; set; }
        public double? CsStartPos { get; set; }
        public int? CsShiftDir { get; set; }
        public double? CsShiftStep1 { get; set; }
        public double? CsShiftStep2 { get; set; }
        public double? CsShiftStep3 { get; set; }
        public string Description { get; set; }
        public double? CsmaxlimitparabolicInd0 { get; set; }

        public double? CsmaxlimitparabolicInd1 { get; set; }

        public double? CsmaxlimitparabolicInd2 { get; set; }

        public double? CsminlimitparabolicInd0 { get; set; }

        public double? CsminlimitparabolicInd1 { get; set; }

        public double? CsminlimitparabolicInd2 { get; set; }

        public double? CsstepparabolicInd0 { get; set; }

        public double? CsstepparabolicInd1 { get; set; }

        public double? CsstepparabolicInd2 { get; set; }

        public double? CsstepsmartcrownInd0 { get; set; }

        public double? CsstepsmartcrownInd1 { get; set; }

        public double? CsstepsmartcrownInd2 { get; set; }
        public int? Csmode { get; set; }
        public short? Manint { get; set; }
    }
}
