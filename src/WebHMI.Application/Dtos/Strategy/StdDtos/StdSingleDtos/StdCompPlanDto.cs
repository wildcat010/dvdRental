using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos
{
    public class StdCompPlanDto : StdItemDto
    {
        public float? Temp { get; set; }
        public float? Kawa { get; set; }
    }
}
