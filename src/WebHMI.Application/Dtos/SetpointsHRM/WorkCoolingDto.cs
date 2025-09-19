using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.SetpointsHRM
{
    public class WorkCoolingDto
    {
        public short PassNo { get; set; }
        public SourceSet<int?> RcpPlanNo { get; set; } = new();
        public SourceSet<int?> IscpPlanNo { get; set; } = new();
        public SourceSet<int?> AopPlanNo { get; set; } = new();
        public SourceSet<int?> RollCoolState { get; set; } = new();
        public SourceSet<double?> FlowWrLoadedInd0 { get; set; } = new();
        public SourceSet<double?> FlowWrLoadedInd1 { get; set; } = new();
        public SourceSet<double?> FlowWrLoadedInd2 { get; set; } = new();
        public SourceSet<double?> StripSprayBefor { get; set; } = new();
        public SourceSet<double?> LooperCooling { get; set; } = new();
    }
}
