using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.PRDB.Dbo.Ext.Interfaces
{
    public interface IRampStd
    {
        public int Activeflag { get; set; }
        public int Planno { get; set; }
        public int Rampno { get; set; }
        public string Description { get; set; }
        public DateTime? Tom { get; set; }
    }
}
