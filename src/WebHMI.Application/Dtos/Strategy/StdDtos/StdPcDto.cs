using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Strategy.StdDtos
{
    public class StdPcDto : StdItemDto
    {
        public double? Delaylength { get; set; }
        public int? Noramps { get; set; }
    }
}
