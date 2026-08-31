using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.PrimaryData
{
    public class CSDataDto
    {
        public SourceSet<double?> CoilTemp { get; set; } = new();
        public SourceSet<double?> CoilTempMax { get; set; } = new();
        public SourceSet<double?> CoilTempMin { get; set; } = new();
        public SourceSet<double?> Fraction { get; set; } = new();
        public SourceSet<double?> HeadUncoolHeadLength { get; set; } = new();
        public SourceSet<double?> HeadProfileTemp { get; set; } = new();
        public SourceSet<double?> HeadProfileLength { get; set; } = new();
        public SourceSet<double?> HeadRampUpLength{ get; set; } = new();
        public SourceSet<double?> TailUncoolHeadLength { get; set; } = new();
        public SourceSet<double?> TailProfileTemp { get; set; } = new();
        public SourceSet<double?> TailProfileLength { get; set; } = new();
        public SourceSet<double?> TailRampUpLength { get; set; } = new();
        public SourceSet<int?> CoolMode { get; set; } = new();
        public SourceSet<short?> CoolModeSource { get; set; } = new();
        public SourceSet<double?> FirstValveTop { get; set; } = new();
        public SourceSet<double?> FirstValveBot { get; set; } = new();
        public SourceSet<double?> LeadingPyro { get; set; } = new();
        public SourceSet<double?> StartValveTop { get; set; } = new();
        public SourceSet<double?> StartValveBot { get; set; } = new();
        public SourceSet<double?> DirCoolRateTop { get; set; } = new();
        public SourceSet<double?> DirCoolRateBot { get; set; } = new();
        public SourceSet<int?> ValveSeqIdx { get; set; } = new();
        public SourceSet<double?> CoolLoad { get; set; } = new();
        public SourceSet<double?> DpCoolRateTop { get; set; } = new();
        public SourceSet<double?> DpCoolRateBot { get; set; } = new();
        public SourceSet<double?> HoldTime { get; set; } = new();
        public SourceSet<double?> HoldTemp { get; set; } = new();
        public SourceSet<double?> DpFraction { get; set; } = new();
        public SourceSet<double?> CsDirectivesCoolingRateTop { get; set; } = new();
        public SourceSet<double?> CsDirectivesCoolingRateBot { get; set; } = new();
        public SourceSet<double?> CsDualPhaseFractionForTrans { get; set; } = new();
    }
}
