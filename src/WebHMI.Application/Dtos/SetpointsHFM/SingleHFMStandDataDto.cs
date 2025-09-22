using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.SetpointsHRM
{
    public class SingleHFMStandDataDto
    {
        public short PassNo { get; set; } = new();
        public SourceSet<int?> LoadingType { get; set; } = new();
        public SourceSet<double?> LoadingValue { get; set; } = new();
        public SourceSet<double?> LoadingValueCorrection { get; set; } = new();
        public SourceSet<double?> Red { get; set; } = new();

        public SourceSet<double?> Fb { get; set; } = new();
        public SourceSet<float?> PositionWRS { get; set; } = new();
        public SourceSet<double?> Model { get; set; } = new();

        public SourceSet<double?> SpecifFoTension { get; set; } = new();
        public SourceSet<double?> Corr { get; set; } = new();
        public SourceSet<double?> BendingForce { get; set; } = new();
        public SourceSet<double?> FlowWrLoadedInd0 { get; set; } = new();
        public SourceSet<double?> FlowWrLoadedInd1 { get; set; } = new();
        public SourceSet<double?> FlowWrLoadedInd2 { get; set; } = new();
        public SourceSet<double?> StripSprayBefor { get; set; } = new();
        public SourceSet<int?> IscState { get; set; } = new();
        
        public SourceSet<double?> Fr { get; set; } = new();
        public SourceSet<double?> Ms { get; set; } = new();
        public SourceSet<double?> RPower { get; set; } = new();
        public SourceSet<double?> VCircum { get; set; } = new();
        public SourceSet<float?> Profile { get; set; } = new();
        public SourceSet<double?> CalcFlat { get; set; } = new();
        public SourceSet<double?> H0 { get; set; } = new();
        public SourceSet<double?> T0 { get; set; } = new();
        public SourceSet<double?> Sd { get; set; } = new();
        public SourceSet<string> SpltlFaultFm { get; set; } = new();
    }
}
