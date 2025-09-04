using System.Collections.Generic;

namespace WebHMI.Core.Widget.Models
{
	public class ShiftAggregatedResultWidgetData : BaseWidgetData
	{
		public List<SingleShiftAggregatedResultWidgetData> LastShiftsSummary { get; set; } = new();
	}
}
