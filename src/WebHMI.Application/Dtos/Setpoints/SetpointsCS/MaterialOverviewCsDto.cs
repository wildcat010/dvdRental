using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Interface;

namespace WebHMI.Dtos.Setpoints.SetpointsCS
{
    public class MaterialOverviewCsDto : IAuditLogRelatedIdGetter
    {
        public string GetAuditLogRelatedId()
        {
            return MeCode.GetAuditLogRelatedId();
        }

        public MeCodeDto MeCode { get; set; } = new();
        public SourceSet<double?> HExit { get; set; } = new();
        public SourceSet<double?> WidthExit { get; set; } = new();
        public SourceSet<double?> TExit { get; set; } = new();
        public SourceSet<double?> LExit { get; set; } = new();
        public SourceSet<double?> CoilTemp { get; set; } = new();
        public SourceSet<int?> CoolingStrategy { get; set; } = new();
        public SourceSet<double?> FtzLoad { get; set; } = new();
        public SourceSet<short?> StartValveNumberTopInd0 { get; set; } = new();
        public SourceSet<short?> StartValveNumberBotInd0 { get; set; } = new();
        public SourceSet<double?> CoolRateTopInd0 { get; set; } = new();
        public SourceSet<double?> CoolRateBotInd0 { get; set; } = new();
        public SourceSet<double?> LengthUncooledHead { get; set; } = new();
        public SourceSet<double?> LengthUncooledTail { get; set; } = new();
        public SourceSet<double?> LengthProfileHead { get; set; } = new();
        public SourceSet<double?> LengthProfileTail { get; set; } = new();
        public SourceSet<double?> CoilTempProfileHead { get; set; } = new();
        public SourceSet<double?> CoilTempProfileTail { get; set; } = new();
        public SourceSet<int?> CsStrategyPlanNo { get; set; } = new();
        public SourceSet<int?> CsProfilePlanNo { get; set; } = new();
        public SourceSet<int?> CscrsPlanNo { get; set; } = new();
        public SourceSet<int?> CsRtCoolingPlanNo { get; set; } = new();
        public SourceSet<int?> CsPerfPlanNo { get; set; } = new();
        public SourceSet<int?> CsEdgeMaskingPlanNo { get; set; } = new();
    }
}
