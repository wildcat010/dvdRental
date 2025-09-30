using System;

namespace WebHMI.Dtos.Strategies
{
    public class StdPassSetsDto<TDto, TPassDto>
    {
        public TDto Std { get; set; }
        public StdPassSetDto<TPassDto> PassSets { get; set; }
    }
}
