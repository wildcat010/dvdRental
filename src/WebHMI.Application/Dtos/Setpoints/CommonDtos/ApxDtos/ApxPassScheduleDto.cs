using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Setpoints.CommonDtos.ApxDtos
{
    public class ApxPassScheduleDto
    {
        public int PassNo { get; set; }
        public SourceSet<double?> BendingForce { get; set; } = new();
        public SourceSet<double?> Fbul { get; set; } = new();
        public SourceSet<double?> Fbll { get; set; } = new();
        public SourceSet<double?> Srul { get; set; } = new();
        public SourceSet<double?> Srll { get; set; } = new();
        public SourceSet<double?> CsMaxLimit { get; set; } = new();
        public SourceSet<double?> CsMinLimit { get; set; } = new();
        public SourceSet<double?> ObservedFlat { get; set; } = new();
        public SourceSet<float?> Fr { get; set; } = new();
        public SourceSet<float?> Fb { get; set; } = new();
        public SourceSet<float?> PositionWrs { get; set; } = new();
        public SourceSet<float?> RelProfile { get; set; } = new();
        public SourceSet<float?> Profile { get; set; } = new();
        public SourceSet<float?> WrCrownEff { get; set; } = new();
        public SourceSet<float?> ThermCrown { get; set; } = new();
        public SourceSet<float?> Wear { get; set; } = new();
        public SourceSet<double?> Troll { get; set; } = new();
        public SourceSet<string> SptlFaultFm { get; set; } = new();
        public SourceSet<double?> WmpModel { get; set; } = new();
        public SourceSet<double?> SrpModel { get; set; } = new();
    }
}
