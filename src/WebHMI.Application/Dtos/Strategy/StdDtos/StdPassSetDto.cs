using System.Collections.Generic;

namespace WebHMI.Dtos.Strategy
{
    public class StdPassSetDto<TPassDto>
    {
        public int PlanNo { get; set; }
        public List<TPassDto> StdPasses { get; set; }
    }
}
