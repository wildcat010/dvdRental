using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Strategy.StdDtos.StdCSDtos
{
    public class StdCsPerfDto : StdItemDto
    {
        public double? Performatorcontrolratio { get; set; }
        public double? Performatordistancetoapply { get; set; }
        public short? Performatorenable { get; set; }
        public short? Performatorenableforf4tcooling { get; set; }
        public short? Performatormanualno { get; set; }
        public double? Performatormaxlimit { get; set; }
        public double? Performatorminlimit { get; set; }
    }
}
