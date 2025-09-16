using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.SetpointsHRM
{
    public class SingleHFMApxStandData
    {
        public int PassNo { get; set; } = new();
        public SourceSet<double?> BendingForce { get; set; } = new();
        public SourceSet<double?> Fbul { get; set; } = new();
        public SourceSet<double?> Fbll { get; set; } = new();
        public SourceSet<double?> CvcShifting { get; set; } = new();
        public SourceSet<double?> Srul { get; set; } = new();
        public SourceSet<double?> Srll { get; set; } = new();
        public SourceSet<double?> ObservedFlat { get; set; } = new();
        public SourceSet<double?> Fr { get; set; } = new();
        public SourceSet<double?> Fb { get; set; } = new();
        public SourceSet<double?> PositionWrs { get; set; } = new();
        public SourceSet<double?> RelProfile { get; set; } = new();
        public SourceSet<double?> Profile { get; set; } = new();
        public SourceSet<double?> WrCrownEff { get; set; } = new();
        public SourceSet<double?> ThermCrown { get; set; } = new();
        public SourceSet<double?> Wear { get; set; } = new();
        public SourceSet<double?> Troll { get; set; } = new();
        public SourceSet<string> SptlFaultFm { get; set; } = new();
        public SourceSet<double?> WmpModel { get; set; } = new();
        public SourceSet<double?> SrpModel { get; set; } = new();
        public SourceSet<double?> CsMaxLimit { get; set; } = new();
        public SourceSet<double?> CsMinLimit { get; set; } = new();
    }
}
