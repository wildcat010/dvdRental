using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Interface;

namespace WebHMI.Dtos.Setpoints.SetpointsHRM
{
    public class HRMApxMaterialOverviewDto : IAuditLogRelatedIdGetter
    {
        public string GetAuditLogRelatedId()
        {
            return MeCode.GetAuditLogRelatedId();
        }
        public MeCodeDto MeCode { get; set; } = new();
        public SourceSet<double?> AimsLabThickness { get; set; } = new();
        public SourceSet<double?> SlabWidth { get; set; } = new();
        public SourceSet<double?> PMPM_EXIT_PROFILE_CASTER { get; set; } = new();
        public SourceSet<double?> TEntry { get; set; } = new();
        public SourceSet<double?> SlabLength { get; set; } = new();
        public SourceSet<double?> HIntermediate { get; set; } = new();
        public SourceSet<double?> HEntryColdFm { get; set; } = new();
        public SourceSet<double?> WEntryColdFm { get; set; } = new();
        public SourceSet<double?> ProfExTargetHrm { get; set; } = new();
        public SourceSet<double?> ProfileCorr { get; set; } = new();
        public SourceSet<double?> RedDistHrmFm { get; set; } = new();
        public SourceSet<int?> InherPfc { get; set; } = new();
        public SourceSet<string> InherPfcId { get; set; } = new();
        public SourceSet<int?> SrpPlanNo { get; set; } = new();
        public SourceSet<int?> DirFmPfcParaPlanNo { get; set; } = new();
        public SourceSet<int?> DirFmPfcCycShiftPlanNo { get; set; } = new();
        public SourceSet<int?> RcpPlanNo { get; set; } = new();
        public SourceSet<int?> WmpPlanNo { get; set; } = new();
    }
}
