using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Setpoints.SetpointsCS
{
    public class PreCalculationTabDto
    {
        public SourceSet<float?> Vexitlas { get; set; } = new ();
        public SourceSet<double?> Wateramount { get; set; } = new();
    }
}
