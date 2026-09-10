using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos
{
    public class StdRcpPassDto : StdPassDto
    {
        public int? RollCoolState { get; set; }
        public double? FlowWrLoadedInd0 { get; set; }
        public double? FlowWrLoadedInd1 { get; set; }
        public double? FlowWrLoadedInd2 { get; set; }
        public string Description { get; set; }
        public double? Mzcamplitude { get; internal set; }
        public int? MzccascadeInd0 { get; internal set; }
        public int? MzccascadeInd1 { get; internal set; }
        public int? MzccascadeInd2 { get; internal set; }
        public double? MzcflowRate { get; internal set; }
        public double? MzcflowRateEdge { get; internal set; }
        public int? MzcnozzelIndex { get; internal set; }
        public double? DelayTime { get; internal set; }
        public double? FlowBrIdleInd0 { get; internal set; }
        public double? FlowBrIdleInd1 { get; internal set; }
        public double? FlowBrIdleInd2 { get; internal set; }
        public double? FlowBrLoadedInd0 { get; internal set; }
        public double? FlowBrLoadedInd1 { get; internal set; }
        public double? FlowBrLoadedInd2 { get; internal set; }
        public double? FlowWrIdleInd0 { get; internal set; }
        public double? FlowWrIdleInd1 { get; internal set; }
        public double? FlowWrIdleInd2 { get; internal set; }
        public double? FlowWrIdleInd3 { get; internal set; }
        public double? FlowWrIdleInd4 { get; internal set; }
        public double? FlowWrIdleInd5 { get; internal set; }
        public double? FlowWrLoadedInd3 { get; internal set; }
        public double? FlowWrLoadedInd4 { get; internal set; }
        public double? FlowWrLoadedInd5 { get; internal set; }
        public int? RollCoolCurve { get; internal set; }
        public int? WrcAngle { get; internal set; }
    }
}
