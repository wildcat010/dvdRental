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
        //public int CalcId { get; set; }
        public DateTime? CreationTime { get; set; }
        //public int LogId { get; set; }
    }
}
