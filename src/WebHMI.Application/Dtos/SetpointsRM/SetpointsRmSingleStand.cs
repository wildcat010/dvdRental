namespace WebHMI.Dtos.SetpointsRM
{
    public class SetpointsRmSingleStand
    {
        public int StandId { get; set; } = new();
        public SourceSet<int?> LType { get; set; } = new();
        public SourceSet<double?> Red { get; set; } = new();
        public SourceSet<double?> Lv { get; set; } = new();
        public SourceSet<double?> LvCorr { get; set; } = new();
        public SourceSet<double?> Force { get; set; } = new();
        public SourceSet<double?> Sd { get; set; } = new();
        public SourceSet<double?> Temperature { get; set; } = new();
        public SourceSet<double?> CircSpeed { get; set; } = new();
        public SourceSet<double?> EntryThickness { get; set; } = new();
        public SourceSet<double?> RollTemp { get; set; } = new();
        public SourceSet<double?> SdPosition { get; set; } = new();
        public SourceSet<double?> ExitProfileRel { get; set; } = new();
        public SourceSet<double?> ExitProfileAbs { get; set; } = new();
        public SourceSet<double?> Bend { get; set; } = new(); 
        public SourceSet<double?> Shift { get; set; } = new();
        public SourceSet<double?> ShiftSpeed { get; set; } = new();
        public SourceSet<double?> SpecTens { get; set; } = new();
        public SourceSet<double?> ObsFlatness { get; set; } = new();
    }
}