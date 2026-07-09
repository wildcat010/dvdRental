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
        public SourceSet<double?> LengthUncooledHead { get; set; } = new();
        public SourceSet<double?> CoilTempProfileHead { get; set; } = new();
        public SourceSet<double?> LengthProfileHead { get; set; } = new();
        public SourceSet<double?> LengthProfileHeadWedge { get; set; } = new();
        public SourceSet<double?> LengthProfileTailWedge { get; set; } = new();
        public SourceSet<double?> LengthProfileTail { get; set; } = new();
        public SourceSet<double?> CoilTempProfileTail { get; set; } = new();
        public SourceSet<double?> LengthUncooledTail { get; set; } = new();
    }
}
