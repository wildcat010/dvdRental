using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Setpoints.SetpointsCS
{
    public class CSMaterialOverviewDto
    {
        public MeCodeDto MeCode { get; set; } = new();
        public SourceSet<double?> HExit { get; set; } = new();
        public SourceSet<double?> WidthExit { get; set; } = new();
        public SourceSet<double?> TExit { get; set; } = new();
        public SourceSet<double?> LExit { get; set; } = new();
        public SourceSet<float?> CoilTemp { get; set; } = new();
        public SourceSet<int?> CoolingStrategy { get; set; } = new();
        public SourceSet<double?> FtzLoad { get; set; } = new();
        public SourceSet<short?> StartValveNumberTopInd0 { get; set; } = new();
        public SourceSet<short?> StartValveNumberBotInd0 { get; set; } = new();
        public SourceSet<double?> CoolRateTopInd0 { get; set; } = new();
        public SourceSet<double?> CoolRateBotInd0 { get; set; } = new();
        public SourceSet<float?> LengthUncooledHead { get; set; } = new();
        public SourceSet<float?> LengthUncooledTail { get; set; } = new();
        public SourceSet<float?> LengthProfileHead { get; set; } = new();
        public SourceSet<float?> LengthProfileTail { get; set; } = new();
        public SourceSet<float?> CoilTempProfileHead { get; set; } = new();
        public SourceSet<float?> CoilTempProfileTail { get; set; } = new();
        public SourceSet<int?> CsStrategyPlanNo { get; set; } = new();
        public SourceSet<int?> CsProfilePlanNo { get; set; } = new();
        public SourceSet<int?> CscrsPlanNo { get; set; } = new();
        public SourceSet<int?> CsRtCoolingPlanNo { get; set; } = new();
        public SourceSet<int?> CsPerfPlanNo { get; set; } = new();
        public SourceSet<int?> CsEdgeMaskingPlanNo { get; set; } = new();
    }
}
