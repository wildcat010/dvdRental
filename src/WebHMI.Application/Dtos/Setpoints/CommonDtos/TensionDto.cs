using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Setpoints.CommonDtos
{
    public class TensionDto
    {
        public short PassNo { get; set; }
        public SourceSet<int?> PlanNo { get; set; } = new();
        public SourceSet<double?> SpeciffoTension { get; set; } = new();
        public SourceSet<double?> LooperStripLen { get; set; } = new();

    }
}
