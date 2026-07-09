using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Setpoints.SetpointsHRM
{
    public class HRMMaterialOverviewDto
    {
        public MeCodeDto MeCode { get; set; } = new();
        public SourceSet<double?> AimsLabThickness { get; set; } = new();
        public SourceSet<double?> SlabWidth { get; set; } = new();
        public SourceSet<double?> ExitCrownC25 { get; set; } = new();
        public SourceSet<double?> TEntry { get; set; } = new();
        public SourceSet<double?> SlabLength { get; set; } = new();
        public SourceSet<double?> HIntermediate { get; set; } = new();
        public SourceSet<double?> HEntryColdFm { get; set; } = new();
        public SourceSet<double?> WEntryColdFm { get; set; } = new();
        public SourceSet<double?> ProfExTargetHrm { get; set; } = new();
        public SourceSet<double?> ProfExCalcHrm { get; set; } = new();
        public SourceSet<double?> ProfileCorr { get; set; } = new();
        public SourceSet<double?> RedDistHrmFm { get; set; } = new();
        public SourceSet<int?> LpPlanNo { get; set; } = new();
        public SourceSet<int?> DpHrmPlanNo { get; set; } = new();
        public SourceSet<int?> RcpPlanNo { get; set; } = new();
        public SourceSet<int?> TpPlanNo { get; set; } = new();
        public SourceSet<int?> RglpPlanNo { get; set; } = new();
        public SourceSet<int?> IscpPlanNo { get; set; } = new();
        public SourceSet<int?> DirFmPfcCycShiftPlanNo { get; set; } = new();
        public SourceSet<int?> AntiLubricationPlanNo { get; set; } = new();
    }
}
