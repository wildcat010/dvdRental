using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos
{
    public class StdTpPassDto : StdPassDto
    {
        public double? SpeciffoTension { get; set; }
        public double? LooperStripLen { get; set; }
        public string Description { get; set; }
    }
}
