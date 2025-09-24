using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Setpoints.CommonDtos
{
    public class LoadingDto
    {
        public short PassNo { get; set; } = new();
        public SourceSet<int?> LoadingPlan { get; set; } = new();
        public SourceSet<int?> LoadingType { get; set; } = new();
        public SourceSet<double?> LoadingValue { get; set; } = new();
        public SourceSet<double?> CircumSpeedCorrection { get; set; } = new();
        public SourceSet<double?> BendingForce { get; set; } = new();
    }
}
