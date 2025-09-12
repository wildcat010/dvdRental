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
        public SourceSet<double?> WEntry { get; set; } = new();
        public SourceSet<double?> HEntry { get; set; } = new();
        public SourceSet<double?> TEntry { get; set; } = new();
        public SourceSet<double?> LEntry { get; set; } = new();
        public SourceSet<double?> HExitRM { get; set; } = new();
        public SourceSet<double?> WExitRM { get; set; } = new();
        public SourceSet<double?> WExitRMOrd { get; set; } = new();
        public SourceSet<double?> TExitRM { get; set; } = new();
        public SourceSet<double?> ProfileTarget { get; set; } = new();
        public SourceSet<double?> ProfileCalc { get; set; } = new();

    }
}
