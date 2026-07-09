using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.ProductionSchedule
{
    public class SequenceOverviewDto
    {
        public string SequenceId { get; set; }
        public int NoOfHeats { get; set; }
        public int NoOfCoils { get; set; }
        public int RemNoOfCoils { get; set; }
        public double? TotalCastLength { get; set; }
        public double? TotalRollLength { get; set; }
        public double? RemRollLength { get; set; }
        public double? MinThick { get; set; }
        public double? WidthFrom { get; set; }
        public double? WidthTo { get; set; }
        public TimeSpan? TotalRollTime { get; set; }
        public TimeSpan? RemainingRollTime { get; set; }
    }
}
