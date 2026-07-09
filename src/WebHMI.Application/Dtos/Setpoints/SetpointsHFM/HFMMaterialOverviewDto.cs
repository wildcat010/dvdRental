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
        public SourceSet<double?> HExit { get; set; } = new();
        public SourceSet<double?> WidthExit { get; set; } = new();
        public SourceSet<double?> TExit { get; set; } = new();
        public SourceSet<double?> LExit { get; set; } = new();
        public SourceSet<double?> ExitCrownc25 { get; set; } = new();
        public SourceSet<double?> HEntryColdFm { get; set; } = new();
        public SourceSet<double?> TiHx { get; set; } = new();
        public SourceSet<double?> HExitCold { get; set; } = new();
        public SourceSet<double?> WExitCold { get; set; } = new();
        public SourceSet<double?> T0MhHRM { get; set; } = new();
        public SourceSet<double?> TValue { get; set; } = new();
        public SourceSet<double?> ProfExCalc { get; set; } = new();
        public SourceSet<double?> ProfileCorr { get; set; } = new();
        public SourceSet<double?> RedDistHrmFm { get; set; } = new();
        public SourceSet<int?> LpPlanNo { get; set; } = new();
        public SourceSet<int?> DpHfmPlanNo { get; set; } = new();
        public SourceSet<int?> RcpPlanNo { get; set; } = new();
        public SourceSet<int?> TpPlanNo { get; set; } = new();
        public SourceSet<int?> RglpPlanNo { get; set; } = new();
        public SourceSet<int?> IscpPlanNo { get; set; } = new();
        public SourceSet<int?> SrpPlanNo { get; set; } = new();
        public SourceSet<int?> IhpPlanNo { get; set; } = new();
        public SourceSet<double?> Temperature { get; set; } = new();
        public SourceSet<int?> AntiLubricationPlanNo { get; set; } = new();
    }
}
