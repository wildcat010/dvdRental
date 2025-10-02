using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.PRDB.Dbo.Ext.Interfaces
{
    public interface IRampStd
    {
        public int ActiveFlag { get; set; }
        public int PlanNo { get; set; }
        public int RampNo { get; set; }
    }
}
