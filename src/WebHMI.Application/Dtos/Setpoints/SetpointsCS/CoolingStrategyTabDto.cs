using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Setpoints.SetpointsCS
{
    public class CoolingStrategyTabDto
    {
        public SourceSet<int?> PlanNo { get; set; } = new();
        public SourceSet<short?> StartValveNumberTopInd0 { get; set; } = new();
        public SourceSet<short?> StartValveNumberBotInd0 { get; set; } = new();
        public SourceSet<double?> CoolRateTopInd0 { get; set; } = new();
        public SourceSet<double?> CoolRateBotInd0 { get; set; } = new();
        public SourceSet<double?> TempOffsetAInd0 { get; set; } = new();
        public SourceSet<double?> TempOffsetBInd0 { get; set; } = new();
        public SourceSet<short?> AdaptationInd0 { get; set; } = new();
        public SourceSet<short?> LeadingPyroIndexInd0 { get; set; } = new();
        public SourceSet<double?> TargetF4TInd0 { get; set; } = new();
        public SourceSet<double?> TargetTempInd0 { get; set; } = new();
        public SourceSet<short?> StartValveNumberTopInd1 { get; set; } = new();
        public SourceSet<short?> StartValveNumberBotInd1 { get; set; } = new();
        public SourceSet<double?> CoolRateTopInd1 { get; set; } = new();
        public SourceSet<double?> CoolRateBotInd1 { get; set; } = new();
        public SourceSet<double?> TempOffsetAInd1 { get; set; } = new();
        public SourceSet<double?> TempOffsetBInd1 { get; set; } = new();
        public SourceSet<short?> AdaptationInd1 { get; set; } = new();
        public SourceSet<short?> LeadingPyroIndexInd1 { get; set; } = new();
        public SourceSet<double?> TargetF4TInd1 { get; set; } = new();
        public SourceSet<double?> TargetTempInd1 { get; set; } = new();
        public SourceSet<double?> AutoSplineValueLowTop { get; set; } = new();
        public SourceSet<double?> AutoSplineValueLowBot { get; set; } = new();
        public SourceSet<double?> AutoSplineTempTransition { get; set; } = new();
        public SourceSet<double?> TempOffsetFma { get; set; } = new();
        public SourceSet<double?> TempOffsetFmb { get; set; } = new();
        public SourceSet<short?> AdaptationFm { get; set; } = new();
    }
}
