using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Setpoints.CommonDtos
{
    public class DescalingDto
    {
        public SourceSet<int?> PlanNo { get; set; } = new();
        public SourceSet<int?> DescrampAuto { get; set; } = new();
        public SourceSet<int?> DescrampState { get; set; } = new();
        public SourceSet<double?> DescrampVolume { get; set; } = new();
        public SourceSet<int?> RampNo { get; set; } = new();
    }
}
