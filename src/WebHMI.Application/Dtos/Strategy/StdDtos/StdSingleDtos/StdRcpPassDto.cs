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
    }
}
