using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Setpoints.CommonDtos
{
    public class TaperShiftingDto
    {
        public short PassNo { get; set; }
        public SourceSet<int?> PlanNo { get; set; } = new();
        public SourceSet<double?> Model { get; set; } = new();

    }
}
