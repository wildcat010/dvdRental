using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Strategy.StdDtos
{
    public class StdRampDto
    {
        public int PlanNo { get; set; }
        public int ActiveFlag { get; set; }
        public short Nodes { get; set; }
        public int AssignmentsCount { get; set; }
        public DateTime? LastModified { get; set; }
        public int RampNo { get; set; }
        public string Description { get; set; }
        public DateTime? Tom { get; set; }
    }
}
