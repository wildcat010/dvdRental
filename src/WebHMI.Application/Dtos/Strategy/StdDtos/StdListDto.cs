using System.Collections.Generic;

namespace WebHMI.Dtos.Strategy
{
    public class StdListDto<TDto>
    {
        public IEnumerable<TDto> Stds { get; set; }
    }
}
