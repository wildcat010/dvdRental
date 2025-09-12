using System.Collections.Generic;

namespace WebHMI.Core.Widget.Models
{
	public class StandardDistributionWidgetData : BaseWidgetData
	{
		public IList<StadnardDistributionOneItem> ProductionDistributionData { get; set; }
	}

	public class StadnardDistributionOneItem
	{
		public string Key { get; set; }
		public double Value { get; set; }
	}
}
