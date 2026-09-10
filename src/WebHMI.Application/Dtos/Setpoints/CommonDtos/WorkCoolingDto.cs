using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Setpoints.CommonDtos
{
    public class WorkCoolingDto
    {
        public short PassNo { get; set; }
        public SourceSet<int?> RcpPlanNo { get; set; } = new();
        public SourceSet<int?> IscpPlanNo { get; set; } = new();
        public SourceSet<int?> RollCoolState { get; set; } = new();
        public SourceSet<double?> FlowWrLoadedInd0 { get; set; } = new();
        public SourceSet<double?> FlowWrLoadedInd1 { get; set; } = new();
        public SourceSet<double?> FlowWrLoadedInd2 { get; set; } = new();
        public SourceSet<double?> StripSprayBefor { get; set; } = new();
        public SourceSet<double?> LooperCooling { get; set; } = new();
        public SourceSet<double?> IscVolumeInd0 { get; set; } = new();
        public SourceSet<double?> IscVolumeInd1 { get; set; } = new();
        public SourceSet<double?> IscVolumeInd2 { get; set; } = new();
        public SourceSet<double?> IscVolumeInd3 { get; set; } = new();
        public SourceSet<double?> FumesuppSprayBehind { get; set; } = new();
        public SourceSet<double?> StripSprayBehind { get; set; } = new();
        public SourceSet<int?> IscState { get; set; } = new();
        public SourceSet<int?> FumeSuppSprayBehState { get; set; } = new();
        public SourceSet<double?> Mzcamplitude { get; set; } = new();
        public SourceSet<int?> MzccascadeInd0 { get; set; } = new();
        public SourceSet<double?> MzcflowRate { get; set; } = new();
        public SourceSet<double?> MzcflowRateEdge { get; set; } = new();
        public SourceSet<int?> MzcnozzelIndex { get; set; } = new();
    }
}
