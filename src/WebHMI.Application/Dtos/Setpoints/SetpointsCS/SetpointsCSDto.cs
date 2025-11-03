using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Setpoints.SetpointsCS
{
    public class SetpointsCSDto
    {
        public MeCodeDto MeCode { get; set; } = new();
        public PreCalculationTabDto PreCalculationTab{ get; set;} = new();
        public CoolingStrategyTabDto CoolingStrategyTab { get; set;} = new();
        public ProfileCoolingTabDto ProfileCoolingTab  { get; set;} = new();

    }
}
