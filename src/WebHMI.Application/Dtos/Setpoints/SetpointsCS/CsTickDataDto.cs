using System.Collections.Generic;
using XIDL;

namespace WebHMI.Dtos.Setpoints.SetpointsCS
{
    public class CsTickDataDto
    {
        public int Seg { get; set; }
        public double? Ril { get; set; } = new();
        public double? Secdiff { get; set; } = new();
        public double? Speed { get; set; } = new();
        public double? Acc { get; set; } = new();
        public double? Speed5D { get; set; } = new();
        public double? TempFM { get; set; } = new();
        public double? ErrFM { get; set; } = new();
        public double? TempCS { get; set; } = new();
        public double? ErrCS { get; set; } = new();
        public double? TotalFlow { get; set; } = new();
        public double? TOFM0 { get; set; } = new();
        public double? TOFM2 { get; set; } = new();
        public double? TOFM1 { get; set; } = new();
        public object TOFM3 { get; set; } = new();
        public List<HmiCsValveState> UsedValvePatternsTop { get; set; }
        public List<HmiCsValveState> UsedValvePatternsBot { get; set; }
    }
}
