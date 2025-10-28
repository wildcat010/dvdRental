using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.PrimaryData
{
    public class CSDataDto
    {
        public SourceSet<float?> CoilTemp { get; set; } = new();
        public SourceSet<float?> CoilTempMax { get; set; } = new();
        public SourceSet<float?> CoilTempMin { get; set; } = new();
        public SourceSet<float?> Fraction { get; set; } = new();
        public SourceSet<float?> HeadUncoolHeadLength { get; set; } = new();
        public SourceSet<float?> HeadProfileTemp { get; set; } = new();
        public SourceSet<float?> HeadProfileLength { get; set; } = new();
        public SourceSet<float?> HeadRampUpLength{ get; set; } = new();
        public SourceSet<float?> TailUncoolHeadLength { get; set; } = new();
        public SourceSet<float?> TailProfileTemp { get; set; } = new();
        public SourceSet<float?> TailProfileLength { get; set; } = new();
        public SourceSet<float?> TailRampUpLength { get; set; } = new();
        public SourceSet<int?> CoolMode { get; set; } = new();
        public SourceSet<short?> CoolModeSource { get; set; } = new();
        public SourceSet<float?> FirstValveTop { get; set; } = new();
        public SourceSet<float?> FirstValveBot { get; set; } = new();
        public SourceSet<float?> LeadingPyro { get; set; } = new();
        public SourceSet<float?> StartValveTop { get; set; } = new();
        public SourceSet<float?> StartValveBot { get; set; } = new();
        public SourceSet<float?> DirCoolRateTop { get; set; } = new();
        public SourceSet<float?> DirCoolRateBot { get; set; } = new();
        public SourceSet<int?> ValveSeqIdx { get; set; } = new();
        public SourceSet<float?> CoolLoad { get; set; } = new();
        public SourceSet<float?> DpCoolRateTop { get; set; } = new();
        public SourceSet<float?> DpCoolRateBot { get; set; } = new();
        public SourceSet<float?> HoldTime { get; set; } = new();
        public SourceSet<float?> HoldTemp { get; set; } = new();
        public SourceSet<float?> DpFraction { get; set; } = new();

    }
}
