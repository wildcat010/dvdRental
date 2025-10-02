using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Strategy.StdDtos
{
    public class StdRampKeySetDto<TDto, TRampDto>
    {
            public IEnumerable<TDto> Stds { get; set; }
            public List<StdRampSetDto<TRampDto>> StdKeyRampSets { get; set; } = new();
    }
}
