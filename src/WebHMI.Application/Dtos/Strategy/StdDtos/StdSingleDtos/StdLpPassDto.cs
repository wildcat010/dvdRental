using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos
{
    public class StdLpPassDto : StdPassDto
    {
        public int? LoadingType { get; set; }
        public double? LoadingValue { get; set; }
        public double? CircumSpeedCorrection { get; set; }
    }
}
