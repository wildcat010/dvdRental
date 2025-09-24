using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Setpoints.CommonDtos
{
    public class LubricationDto
    {
        public short PassNo { get; set; }
        public SourceSet<int?> PlanNo { get; set; } = new();
        public SourceSet<int?> RollGapLubState { get; set; } = new();
        public SourceSet<double?> RollGapLubRampTimeStart { get; set; } = new();
        public SourceSet<double?> RollGapLubRampTimeStop { get; set; } = new();
        public SourceSet<double?> RollGapLubSwitchLength { get; set; } = new();
        public SourceSet<double?> RollGapLubOilFlowTop { get; set; } = new();
        public SourceSet<double?> RollGapLubOilFlowBot { get; set; } = new();
    }
}
