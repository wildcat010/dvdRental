using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Setpoints.CommonDtos.ApxDtos
{
    public class ApxShiftingDto
    {
        public int PassNo { get; set; }
        public SourceSet<int?> PlanNo { get; set; } = new();
        public SourceSet<double?> CsMaxLimit { get; set; } = new();
        public SourceSet<double?> CsMinLimit { get; set; } = new();
        public SourceSet<double?> CsStartPos { get; set; } = new();
        public SourceSet<int?> CsShiftDir { get; set; } = new();
        public SourceSet<double?> CsShiftStep1 { get; set; } = new();
        public SourceSet<double?> CsShiftStep2 { get; set; } = new();
        public SourceSet<double?> CsShiftStep3 { get; set; } = new();
    }
}
