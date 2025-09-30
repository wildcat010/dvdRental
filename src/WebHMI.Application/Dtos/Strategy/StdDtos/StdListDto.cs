using System.Collections.Generic;

namespace WebHMI.Dtos.Strategies
{
    public class StdListDto<TDto>
    {
        public IEnumerable<TDto> Stds { get; set; }
    }
}
