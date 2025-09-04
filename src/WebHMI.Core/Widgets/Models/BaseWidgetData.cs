using System;

namespace WebHMI.Core.Widget.Models
{
	public abstract class BaseWidgetData
	{
		public int WidgetId { get; set; }
		public WidgetCalculationStatus Status { get; set; }
		public DateTime LastCalculation { get; set; }
	}

	public enum WidgetCalculationStatus
	{
		NotInitialized,
		Initialized,
		Error,
		Ok
	}
}
