using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Roll;

namespace WebHMI.Dtos.SetpointsHRM
{
    public class SetpointsHRMDto
    {
        public MeCodeDto MeCode { get; set; }
        public SourceSet<string> ApsKey { get; set; } = new();
        public SourceSet<string> AlloyCode { get; set; } = new();
        public SourceSet<int?> SetPointsHrmOk { get; set; } = new();
        public SourceSet<int?> OkAll { get; set; } = new();
        public SourceSet<float?> AimsLabThickness { get; set; } = new();
        public SourceSet<float?> SlabWidth { get; set; } = new();
        public SourceSet<float?> TEntry { get; set; } = new();
        public SourceSet<float?> SlabLength { get; set; } = new();
        public SourceSet<float?> HIntermediate { get; set; } = new();
        public SourceSet<double?> HEntryColdFm { get; set; } = new();
        public SourceSet<double?> WEntryColdFm { get; set; } = new();
        public SourceSet<float?> TValue { get; set; } = new();
        public SourceSet<float?> ProfExTargetHrm { get; set; } = new();
        public SourceSet<float?> ProfExCalcHrm { get; set; } = new();
        public SourceSet<double?> ProfileCorr { get; set; } = new();
        public SourceSet<string> RedDistHrmFm { get; set; } = new();
        public SourceSet<int?> LpPlanNo { get; set; } = new();
        public SourceSet<int?> DpHrmPlanNo { get; set; } = new();
        public SourceSet<int?> RcpPlanNo { get; set; } = new();
        public SourceSet<int?> TpPlanNo { get; set; } = new();
        public SourceSet<int?> RglpPlanNo { get; set; } = new();
        public SourceSet<int?> IscpPlanNo { get; set; } = new();
        public SourceSet<int?> DirFmPfcCycShiftPlanNo { get; set; } = new();
        public SourceSet<DateTime?> Tom { get; set; } = new();
        public List<SingleSetpointsHRMStandDataDto> StandDataDtos { get; set; } = new();  
    }
}
