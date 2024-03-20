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
		public List<EdPhyEnt> EdPhyEnts { get; internal set; }
		public List<EdOrdEnt> EdOrdEnts { get; internal set; }
		public List<EdLogEnt> EdLogEnts { get; internal set; }
	}
}
