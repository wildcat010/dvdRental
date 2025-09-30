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
    }
}
