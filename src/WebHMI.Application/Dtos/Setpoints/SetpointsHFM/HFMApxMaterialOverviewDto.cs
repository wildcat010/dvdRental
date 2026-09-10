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
        public SourceSet<double?> HExit { get; set; } = new();
        public SourceSet<double?> WidthExit { get; set; } = new();
        public SourceSet<double?> TExit { get; set; } = new();
        public SourceSet<double?> LExit { get; set; } = new();
        public SourceSet<double?> ExitCrownC25 { get; set; } = new();
        public SourceSet<double?> HExitCold { get; set; } = new();
        public SourceSet<double?> WExitCold { get; set; } = new();
        public SourceSet<double?> HEntryColdFm { get; set; } = new();
        public SourceSet<double?> WEntryColdFm { get; set; } = new();
        public SourceSet<double?> ProfileCorr { get; set; } = new();
        public SourceSet<double?> T0MhHRM { get; set; } = new();
        public SourceSet<double?> RedDistHrmHfm { get; set; } = new();
        public SourceSet<double?> TiHx { get; set; } = new();
        public SourceSet<double?> TValue { get; set; } = new();
        public SourceSet<double?> ProfExCalc { get; set; } = new();
        public SourceSet<int?> DirFmPfcParaPlanNo { get; set; } = new();
        public SourceSet<int?> SrpPlanNo { get; set; } = new();
        public SourceSet<int?> InherPfc { get; set; } = new();
        public SourceSet<string> InherPfcId { get; set; } = new();
        public SourceSet<double?> Temperature { get; set; } = new();
        public SourceSet<int?> ShiftingPlan { get; set; } = new();
        public SourceSet<int?> WmpPlanNo { get; set; } = new();
    }
}
