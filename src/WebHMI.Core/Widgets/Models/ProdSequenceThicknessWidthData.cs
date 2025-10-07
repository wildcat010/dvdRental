using System.Collections.Generic;

namespace WebHMI.Core.Widget.Models
{
	public class ProdSequenceThicknessWidthData : BaseWidgetData
	{
		public List<KeyValuePair<string, SingleProdSequenceThicknessWidth>> ProductionDistributionData { get; set; }

        public ProdSequenceThicknessWidthData() { }
    }

	public class SingleProdSequenceThicknessWidth()
	{ 
		public double? EntryThickness {get; set; }
		public double? ExitThickness {get; set; }
		public double? Width {get; set; }
		public string HeatId {get; set; }
		public string SeqId {get; set; }
		public short? FlagNext {get; set; }
		public int? Status {get; set; }

    }
}
