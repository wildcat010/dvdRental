using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Strategy.StdDtos
{
    public class StdRampSetDto<TRampDto>
    {
        public int PlanNo { get; set; }
        public List<TRampDto> StdRamps{ get; set; }
    }
}
