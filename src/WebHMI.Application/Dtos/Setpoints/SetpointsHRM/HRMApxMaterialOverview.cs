using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Setpoints.SetpointsHRM
{
    public class HRMApxMaterialOverview
    {
        public MeCodeDto MeCode { get; set; } = new();
        public SourceSet<float?> HExit { get; set; } = new();
        public SourceSet<float?> WidthExit { get; set; } = new();
        public SourceSet<float?> ExitCrownC25 { get; set; } = new();
        public SourceSet<float?> HEntryColdFm { get; set; } = new();
        public SourceSet<double?> ProfileCorr { get; set; } = new();
        public SourceSet<float?> HExitCold { get; set; } = new();
        public SourceSet<float?> WExitCold { get; set; } = new();
        public SourceSet<float?> ClassMinCrownDelta { get; set; } = new();
        public SourceSet<float?> ProfExCalc { get; set; } = new();
        public SourceSet<double?> ClassMaxCrownDelta { get; set; } = new();
        public SourceSet<int?> DirFmPfcParaPlanNo { get; set; } = new();
        public SourceSet<int?> DirFmPfcCycShiftPlanNo { get; set; } = new();
        public SourceSet<int?> InherPfc { get; set; } = new();
        public SourceSet<string> InherPfcId { get; set; } = new();
    }
}
