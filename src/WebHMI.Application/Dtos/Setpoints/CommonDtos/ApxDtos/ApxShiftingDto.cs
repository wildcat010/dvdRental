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
        public SourceSet<string> Description { get; set; } = new();
        public SourceSet<short?> Manint { get; set; } = new();
        public SourceSet<string> Toextid { get; set; } = new();
        public SourceSet<double?> CsmaxlimitparabolicInd0 { get; set; } = new();
        public SourceSet<double?> CsmaxlimitparabolicInd1 { get; set; } = new();
        public SourceSet<double?> CsmaxlimitparabolicInd2 { get; set; } = new();
        public SourceSet<double?> CsminlimitparabolicInd0 { get; set; } = new();
        public SourceSet<double?> CsminlimitparabolicInd1 { get; set; } = new();
        public SourceSet<double?> CsminlimitparabolicInd2 { get; set; } = new();
        public SourceSet<double?> CsstepparabolicInd0 { get; set; } = new();
        public SourceSet<double?> CsstepparabolicInd1 { get; set; } = new();
        public SourceSet<double?> CsstepparabolicInd2 { get; set; } = new();
        public SourceSet<double?> CsstepsmartcrownInd0 { get; set; } = new();
        public SourceSet<double?> CsstepsmartcrownInd1 { get; set; } = new();
        public SourceSet<double?> CsstepsmartcrownInd2 { get; set; } = new();
        public SourceSet<int?> CsMode { get; set; } = new();
    }
}
