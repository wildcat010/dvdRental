using System.Collections.Generic;

namespace WebHMI.Core.Widget.Models
{
	public class ProdSequenceThicknessWidthData : BaseWidgetData
	{
		public List<KeyValuePair<string, SingleProdSequenceThicknessWidth>> ProductionDistributionData { get; set; }
	}

	public class SingleProdSequenceThicknessWidth()
	{ 
		public double? EntryThickness {get; set; }
		public double? ExitThickness {get; set; }
		public double? Width {get; set; }

	}
}
