using System;
using XIDL;

namespace WebHMI.Dtos
{
    public class LaminarCoolingActualValue
    {
        public HmiCsSimpleMeter FmTemp { get; set; }
        public HmiCsSimpleMeter CoilTemp { get; set; }
        public DateTime TimeStamp { get; set; }
        public double CsTargetTempWithPerformator { get; set; }
        public double FmTargetTempWithPerformator { get; set; }
    }
}
