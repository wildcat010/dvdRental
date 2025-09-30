using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos
{
    public class StdTpDto : StdItemDto
    {
        public double? CoilerTension { get; set; }
        public double? YieldStress { get; set; }

    }
}
