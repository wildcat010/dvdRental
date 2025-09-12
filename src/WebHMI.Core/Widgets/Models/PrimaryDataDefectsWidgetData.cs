using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Core.Widget.Models
{
	public class PrimaryDataDefectsWidgetData : BaseWidgetData
	{
		public List<DefectDto> Defects { get; set; } = new();
	}

}
