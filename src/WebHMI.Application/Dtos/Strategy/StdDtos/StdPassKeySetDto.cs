using System;
using System.Collections.Generic;

namespace WebHMI.Dtos.Strategy
{
    public class StdPassKeySetDto<TDto, TPassDto>
    {
        public IEnumerable<TDto> Stds { get; set; }
        public List<StdPassSetDto<TPassDto>> StdKeyPassSets { get; set; } = new();
    }
}
