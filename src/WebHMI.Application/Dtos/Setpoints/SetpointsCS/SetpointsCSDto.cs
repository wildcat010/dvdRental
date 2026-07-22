using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Interface;

namespace WebHMI.Dtos.Setpoints.SetpointsCS
{
    public class SetpointsCsDto : IAuditLogRelatedIdGetter
    {
        public string GetAuditLogRelatedId()
        {
            return MeCode.GetAuditLogRelatedId();
        }

        public MeCodeDto MeCode { get; set; } = new();
        public PreCalculationTabDto PreCalculation{ get; set;} = new();
        public CoolingStrategyTabDto CoolingStrategyTab { get; set;} = new();
        public ProfileCoolingTabDto ProfileCoolingTab  { get; set;} = new();

    }
}
