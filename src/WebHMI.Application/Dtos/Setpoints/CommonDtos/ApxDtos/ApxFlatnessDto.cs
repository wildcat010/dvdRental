using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Setpoints.CommonDtos.ApxDtos
{
    public class ApxFlatnessDto
    {
        public int PassNo { get; set; }
        public SourceSet<int?> PlanNo { get; set; } = new(); 
        public SourceSet<double?> Fbul { get; set; } = new();
        public SourceSet<double?> Fbll { get; set; } = new();
        public SourceSet<double?> Srul { get; set; } = new();
        public SourceSet<double?> Srll { get; set; } = new();
        public SourceSet<double?> Facdfbdfr { get; set; } = new();
        public SourceSet<double?> Facdfbdiu { get; set; } = new();
    }
}
