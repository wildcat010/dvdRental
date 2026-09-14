using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos
{
    public class StdRglpPassDto : StdPassDto
    {
        public int? RollGapLubState { get; set; }
        public double? RollGapLubRampTimeStart { get; set; }
        public double? RollGapLubRampTimeStop { get; set; }
        public double? RollGapLubSwitchLength { get; set; }
        public double? RollGapLubOilFlowTop { get; set; }
        public double? RollGapLubOilFlowBot { get; set; }
        public string Description { get; set; }
    }
}
