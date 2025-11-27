using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.StretchCurves
{
    public class CurveDataPoints
    {
        public double? Force { get; set; }
        public double? Dsframeds { get; set; }
        public double? Dsframeos { get; set; }
        public double? Dsframepade { get; set; }
        public double? DsDsDown { get; set; }
        public double? DsDsUp { get; set; }
        public double? DsOsDown { get; set; }
        public double? DsOsUp { get; set; }
    }
}
