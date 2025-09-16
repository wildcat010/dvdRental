using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.SetpointsHRM
{
    public class HRMMaterialOverviewDto
    {
        public MeCodeDto MeCode { get; set; } = new();
        public SourceSet<float?> WEntry { get; set; } = new();
        public SourceSet<float?> HEntry { get; set; } = new();
        public SourceSet<float?> TEntry { get; set; } = new();
        public SourceSet<float?> LEntry { get; set; } = new();
        public SourceSet<float?> HExitRM { get; set; } = new();
        public SourceSet<float?> WExitRM { get; set; } = new();
        public SourceSet<float?> WExitRMOrd { get; set; } = new();
        public SourceSet<float?> TExitRM { get; set; } = new();
        public SourceSet<float?> ProfileTarget { get; set; } = new();
        public SourceSet<float?> ProfileCalc { get; set; } = new();

    }
}
