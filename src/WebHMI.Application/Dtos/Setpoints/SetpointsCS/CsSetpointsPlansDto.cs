using System.Collections.Generic;
using WebHMI.Dtos.Common;

namespace WebHMI.Dtos.Setpoints.SetpointsCS
{
    public class CsSetpointsPlansDto
    {
        public IEnumerable<StdPlanNoElementDto> Coolings { get; set; }
        public IEnumerable<StdPlanNoElementDto> ProfileCoolings { get; set; }
        public IEnumerable<StdPlanNoElementDto> RollerTableCoolings { get; set; }
        public IEnumerable<StdPlanNoElementDto> CrossSprayss { get; set; }
        public IEnumerable<StdPlanNoElementDto> Perf { get; set; }
    }
}
