using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.ProductionSchedule
{
    public class SequenceOverviewDto
    {
        public int NoOfHeats { get; set; }
        public int NoOfCoils { get; set; }
        public int RemNoOfCoils { get; set; }
        public float? TotalCastLength { get; set; }
        public float? TotalRollLength { get; set; }
        public float? RemRollLength { get; set; }
        public float? MinThick { get; set; }
        public float? WidthFrom { get; set; }
        public float? WidthTo { get; set; }
        public TimeSpan? TotalRollTime { get; set; }
        public TimeSpan? RemainingRollTime { get; set; }
    }
}
