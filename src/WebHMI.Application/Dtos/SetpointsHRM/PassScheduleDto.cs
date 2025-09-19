using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.SetpointsHRM
{
    public class PassScheduleDto
    {
        public short PassNo { get; set; } = new();
        public SourceSet<int?> LoadingType { get; set; } = new();
        public SourceSet<double?> Red { get; set; } = new();
        public SourceSet<double?> LoadingValue { get; set; } = new();
        public SourceSet<double?> LoadingValueCorrection { get; set; } = new();
        public SourceSet<double?> Fb { get; set; } = new();
        public SourceSet<float?> PositionWRS { get; set; } = new();
        public SourceSet<double?> Model { get; set; } = new();
        public SourceSet<double?> SpecifFoTension { get; set; } = new();
        public SourceSet<double?> Corr { get; set; } = new();
        public SourceSet<double?> ObservedFlat { get; set; } = new();
        public SourceSet<float?> Fr { get; set; } = new();
        public SourceSet<float?> Sd { get; set; } = new();
        public SourceSet<float?> T0 { get; set; } = new();
        public SourceSet<float?> H0 { get; set; } = new();
        public SourceSet<float?> VCircum { get; set; } = new();
        public SourceSet<double?> TRoll { get; set; } = new();
        public SourceSet<double?> DeltaSdPos { get; set; } = new();
        public SourceSet<float?> RelProfile { get; set; } = new();
        public SourceSet<float?> AbsProfile { get; set; } = new();
        public SourceSet<float?> Ms { get; set; } = new();
        public SourceSet<float?> RPower { get; set; } = new();
        public SourceSet<float?> CalcFlat { get; set; } = new();
        
    }
}
