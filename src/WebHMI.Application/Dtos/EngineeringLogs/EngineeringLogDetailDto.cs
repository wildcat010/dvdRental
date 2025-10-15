using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.EngineeringLogs
{
    public class EngineeringLogDetailDto
    {
        public string Name { get; set; }
        public string CoilId { get; set; }
        public string PreCalc { get; set; }
        public string CalcType { get; set; }
        public string PreCalcNumber { get; set; }
        public DateTime? CreationTime { get; set; }
    }
}
