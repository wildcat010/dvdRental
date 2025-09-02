using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Limit
{
    public class LimitDto
    {
        public string LimitName { get; set; }
        public string PlantType { get; set; }
        public string CType { get; set; }
        public string Description { get; set; }
        public float? LowerLimit { get; set; }
        public string Moddescr { get; set; }
        public string SortOrder { get; set; }
        public string Unit { get; set; }
        public float? UpperLimit { get; set; }
        public DateTime? Toc { get; set; }
        public DateTime? Tom { get; set; }
    }
}
