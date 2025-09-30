using System;
using System.Collections.Generic;
using WebHMI.Dtos.Strategies;

namespace WebHMI.Dtos.Strategy.Dtos
{
    public class StdPassKeySetDto<TDto, TPassDto>
    {
        public IEnumerable<TDto> Stds { get; set; }
        public List<StdPassSetDto<TPassDto>> StdKeyPassSets { get; set; } = new();
    }
}
