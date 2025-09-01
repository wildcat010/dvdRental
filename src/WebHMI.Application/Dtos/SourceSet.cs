using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos
{
	public class SourceSet<TSourceType>
	{
		public TSourceType M { get; set; }
		public TSourceType E { get; set; }
		public TSourceType L { get; set; }
		public TSourceType P { get; set; }
		public TSourceType S { get; set; }

		public short? Status { get; set; }
		public string DbSource { get; set; }
    }
}
