using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.SetpointsHRM
{
    public class LubricationDto
    {
        public SourceSet<int?> PlanNo { get; set; } = new();
    }
}
