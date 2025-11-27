using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.StretchCurves
{
    public class StrechCurveData
    {
        public int StandIdx { get; set; }
        public string PlantType { get; set; }
        public int Meastype { get; set; }
        public List<CurveDataPoints> CurveDataPoints { get; set; }
    }
}
