using System.Collections.Generic;

namespace WebHMI.Dtos.Strategies
{
    public class StdPassSetDto<TPassDto>
    {
        public int PlanNo { get; set; }
        public List<TPassDto> StdPasses { get; set; }
    }
}
