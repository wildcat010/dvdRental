namespace WebHMI.Core.Widget.Models
{
	public class ScheduleSummaryWidgetData : BaseWidgetData
	{
		public int AllGood { get; set; }
		public int SetpointsInvalid { get; set; }
		public int PrimaryDataInvalid { get; set; }
	}
}
