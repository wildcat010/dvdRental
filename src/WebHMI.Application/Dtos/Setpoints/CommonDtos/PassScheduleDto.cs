namespace WebHMI.Dtos.Setpoints.CommonDtos
{
    public class PassScheduleDto
    {
        public short PassNo { get; set; } = new();
        public SourceSet<int?> LoadingType { get; set; } = new();
        public SourceSet<double?> Red { get; set; } = new();
        public SourceSet<double?> LoadingValue { get; set; } = new();
        public SourceSet<double?> LoadingValueCorrection { get; set; } = new();
        public SourceSet<double?> Fb { get; set; } = new();
        public SourceSet<double?> PositionWRS { get; set; } = new();
        public SourceSet<double?> Model { get; set; } = new();
        public SourceSet<double?> SpecifFoTension { get; set; } = new();
        public SourceSet<double?> Corr { get; set; } = new();
        public SourceSet<double?> ObservedFlat { get; set; } = new();
        public SourceSet<double?> Fr { get; set; } = new();
        public SourceSet<double?> Sd { get; set; } = new();
        public SourceSet<double?> T0 { get; set; } = new();
        public SourceSet<double?> H0 { get; set; } = new();
        public SourceSet<double?> VCircum { get; set; } = new();
        public SourceSet<double?> TRoll { get; set; } = new();
        public SourceSet<double?> DeltaSdPos { get; set; } = new();
        public SourceSet<double?> RelProfile { get; set; } = new();
        public SourceSet<double?> Profile { get; set; } = new();
        public SourceSet<double?> Ms { get; set; } = new();
        public SourceSet<double?> RPower { get; set; } = new();
        public SourceSet<double?> CalcFlat { get; set; } = new();
    }
}
