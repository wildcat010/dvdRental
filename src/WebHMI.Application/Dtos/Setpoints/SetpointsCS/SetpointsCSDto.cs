using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Setpoints.SetpointsCS
{
    public class SetpointsCsDto
    {
        public MeCodeDto MeCode { get; set; } = new();
        public PreCalculationTabDto PreCalculation{ get; set;} = new();
        public CoolingStrategyTabDto CoolingStrategyTab { get; set;} = new();
        public ProfileCoolingTabDto ProfileCoolingTab  { get; set;} = new();

    }
}
