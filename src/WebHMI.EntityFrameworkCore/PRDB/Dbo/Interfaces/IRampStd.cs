using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.PRDB.Dbo.Interfaces
{
    public interface IRampStd
    {
        public int ActiveFlag { get; set; }
        public int PlanNo { get; set; }
        public int RampNo { get; set; }
        public string Description { get; set; }
        public DateTime? Tom { get; set; }
    }
}
