using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Setpoints.SetpointsHRM
{
    public class HRMApxMaterialOverviewDto
    {
        public MeCodeDto MeCode { get; set; } = new();
        public SourceSet<float?> AimsLabThickness { get; set; } = new();
        public SourceSet<float?> SlabWidth { get; set; } = new();
        public SourceSet<float?> ExitCrownC25 { get; set; } = new();
        public SourceSet<float?> TEntry { get; set; } = new();
        public SourceSet<float?> SlabLength { get; set; } = new();
        public SourceSet<float?> HIntermediate { get; set; } = new();
        public SourceSet<float?> HEntryColdFm { get; set; } = new();
        public SourceSet<float?> WEntryColdFm { get; set; } = new();
        public SourceSet<float?> ProfExTargetHrm { get; set; } = new();
        public SourceSet<float?> ProfExCalcHrm { get; set; } = new();
        public SourceSet<double?> ProfileCorr { get; set; } = new();
        public SourceSet<string> RedDistHrmFm { get; set; } = new();
        public SourceSet<int?> InherPfc { get; set; } = new();
        public SourceSet<string> InherPfcId { get; set; } = new();
        public SourceSet<int?> DirFmPfcCycShiftPlanNo { get; set; } = new();
        public SourceSet<int?> DirFmPfcParaPlanNo { get; set; } = new();

    }
}
