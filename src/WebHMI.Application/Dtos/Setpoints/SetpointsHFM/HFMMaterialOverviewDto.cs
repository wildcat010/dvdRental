using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Setpoints.SetpointsHFM
{
    public class HFMMaterialOverviewDto
    {
        public MeCodeDto MeCode { get; set; }
        public SourceSet<float?> HExit { get; set; } = new();
        public SourceSet<float?> WidthExit { get; set; } = new();
        public SourceSet<float?> TExit { get; set; } = new();
        public SourceSet<float?> LExit { get; set; } = new();
        public SourceSet<float?> ExitCrownc25 { get; set; } = new();
        public SourceSet<float?> HEntryColdFm { get; set; } = new();
        public SourceSet<float?> TiHx { get; set; } = new();
        public SourceSet<float?> HExitCold { get; set; } = new();
        public SourceSet<float?> WExitCold { get; set; } = new();
        public SourceSet<float?> T0MhHRM { get; set; } = new();
        public SourceSet<float?> TValue { get; set; } = new();
        public SourceSet<float?> ProfExCalc { get; set; } = new();
        public SourceSet<double?> ProfileCorr { get; set; } = new();
        public SourceSet<string> RedDistHrmFm { get; set; } = new();
        public SourceSet<int?> LpPlanNo { get; set; } = new();
        public SourceSet<int?> DpHfmPlanNo { get; set; } = new();
        public SourceSet<int?> RcpPlanNo { get; set; } = new();
        public SourceSet<int?> TpPlanNo { get; set; } = new();
        public SourceSet<int?> RglpPlanNo { get; set; } = new();
        public SourceSet<int?> IscpPlanNo { get; set; } = new();
        public SourceSet<int?> SrpPlanNo { get; set; } = new();
        public SourceSet<int?> IhpPlanNo { get; set; } = new();
        public SourceSet<float?> Temperature { get; set; } = new();
    }
}
