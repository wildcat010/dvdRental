using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.StretchCurves
{
    public class StretchCurveHistoryDto
    {
        public int No { get; set; }
        public DateTime? RecordingDate { get; set; }
        public double? CoeffA0 { get; set; }
        public double? CoeffA1 { get; set; }
        public double? CoeffA2 { get; set; }
        public double? CoeffB1 { get; set; }
        public int MeasType { get; set; }
        public bool IsEffective { get; set; }
        public bool IsReference { get; set; }
    }
}
