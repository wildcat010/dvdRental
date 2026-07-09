using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.PRDB.Dbo;

namespace WebHMI.DataBlobs
{
	public class PrimaryDataDataBlob
	{
		public List<Edphyent> EdPhyEnts { get; internal set; }
		public List<Edordent> EdOrdEnts { get; internal set; }
		public List<Edlogent> EdLogEnts { get; internal set; }
        public StatEdphyent StatEdPhyEnts { get; internal set; }
        public StatEdordent StatEdOrdEnts { get; internal set; }
        public StatEdlogent StatEdLogEnts { get; internal set; }
    }
}
