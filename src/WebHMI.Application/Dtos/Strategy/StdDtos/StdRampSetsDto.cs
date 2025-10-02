using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Strategy.StdDtos
{
    public class StdRampSetsDto<TDto, TRampDto>
    {
        public TDto Std { get; set; }
        public StdRampSetDto<TRampDto> RampSets { get; set; }
    }
}
