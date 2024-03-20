using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Filters;

namespace WebHMI.Dtos.ProductionSchedule
{
	internal class ProductionScheduleFilteredRequestDto : FilteredRequestDto
	{
		public ProductionScheduleMode Mode { get; set; }
	}

	public enum ProductionScheduleMode
	{
		Scheduled,
		Planned,
		Ghost,
		Test,
		Produced
	}
}
