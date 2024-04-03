using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Filters;

namespace WebHMI.Dtos.ProductionSchedule
{
	public class ProductionScheduleFilteredRequestDto : FilteredRequestDto
	{
		public ProductionScheduleMode Mode { get; set; }
    }

	public enum ProductionScheduleMode
	{
		Scheduled,
		Rolled,
        Rejected,
        Test
	}
}
