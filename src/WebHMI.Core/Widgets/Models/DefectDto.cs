using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Core.Widget.Models
{
	public class DefectDto
	{
		public int No { get; set; }
		public double? DefectStart { get; set; }
		public double? DefectEnd { get; set; }
		public string DefectIntensity { get; set; }
		public string DefectType { get; set; }
		public string DefectSide { get; set; }
		public short? DefectClass { get; set; }
		public int? Action { get; set; }

	}
}
