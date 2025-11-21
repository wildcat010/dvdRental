using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Strategy.StdDtos.StdCSDtos
{
    public class StdProfileCsDto : StdItemDto
    {
        public double? Coiltempprofilehead { get; set; }
        public double? Coiltempprofiletail { get; set; }
        public double? Lengthprofilehead { get; set; }
        public double? Lengthprofileheadwedge { get; set; }
        public double? Lengthprofiletail { get; set; }
        public double? Lengthprofiletailwedge { get; set; }
        public double? Lengthuncooledhead { get; set; }
        public double? Lengthuncooledtail { get; set; }
        public string Description2 { get; set; }
    }
}
