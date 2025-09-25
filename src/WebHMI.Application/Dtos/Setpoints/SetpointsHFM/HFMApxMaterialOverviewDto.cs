using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Setpoints.SetpointsHRM
{
    public class HFMApxMaterialOverviewDto
    {
        public MeCodeDto MeCode { get; set; } = new();
        public SourceSet<float?> HExit { get; set; } = new();
        public SourceSet<float?> WidthExit { get; set; } = new();
        public SourceSet<float?> TExit { get; set; } = new();
        public SourceSet<float?> LExit { get; set; } = new();
        public SourceSet<float?> ExitCrownC25 { get; set; } = new();
        public SourceSet<float?> HExitCold { get; set; } = new();
        public SourceSet<float?> WExitCold { get; set; } = new();
        public SourceSet<float?> HEntryColdFm { get; set; } = new();
        public SourceSet<float?> WEntryColdFm { get; set; } = new();
        public SourceSet<double?> ProfileCorr { get; set; } = new();
        public SourceSet<double?> T0MhHRM { get; set; } = new();
        public SourceSet<double?> RedDistHrmHfm { get; set; } = new();
        public SourceSet<float?> TiHx { get; set; } = new();
        public SourceSet<float?> TValue { get; set; } = new();
        public SourceSet<float?> ProfExCalc { get; set; } = new();
        public SourceSet<int?> DirFmPfcParaPlanNo { get; set; } = new();
        public SourceSet<int?> DirFmPfcCycShiftPlanNo { get; set; } = new();
        public SourceSet<int?> InherPfc { get; set; } = new();
        public SourceSet<string> InherPfcId { get; set; } = new();
    }
}
