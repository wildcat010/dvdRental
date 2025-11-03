using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Setpoints.SetpointsCS
{
    public class ProfileCoolingTabDto
    {
        public SourceSet<int?> PlanNo { get; set; } = new();
        public SourceSet<float?> LengthUncooledHead { get; set; } = new();
        public SourceSet<float?> CoilTempProfileHead { get; set; } = new();
        public SourceSet<float?> LengthProfileHead { get; set; } = new();
        public SourceSet<float?> LengthProfileHeadWedge { get; set; } = new();
        public SourceSet<float?> LengthProfileTailWedge { get; set; } = new();
        public SourceSet<float?> LengthProfileTail { get; set; } = new();
        public SourceSet<float?> CoilTempProfileTail { get; set; } = new();
        public SourceSet<float?> LengthUncooledTail { get; set; } = new();
    }
}
