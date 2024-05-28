namespace WebHMI.Dtos.SetpointsRM
{
    public class SetpointsRmApxSingleStand
    {
        public int StandId { get; set; }
        public SourceSet<double?> BendingForceUpperLimit { get; set; } = new();
        public SourceSet<double?> BendingForceLowerLimit { get; set; } = new();
        public SourceSet<double?> ShiftingUpperLimit { get; set; } = new();
        public SourceSet<double?> ShiftingLowerLimit { get; set; } = new();
        public SourceSet<double?> WearShiftingUpperLimit { get; set; } = new();
        public SourceSet<double?> WearShiftingLowerLimit { get; set; } = new();
        public SourceSet<double?> ObsFlatness { get; set; } = new();
        public SourceSet<double?> RollForce { get; set; } = new();
        public SourceSet<double?> EffGrinding { get; set; } = new();
        public SourceSet<double?> ThermalCrown { get; set; } = new();
        public SourceSet<double?> WearCrown { get; set; } = new();
        public SourceSet<double?> RollTemp { get; set; } = new();
        public SourceSet<double?> ExitProfileRel { get; set; } = new();
        public SourceSet<double?> ExitProfileAbs { get; set; } = new();
        public SourceSet<double?> Bend { get; set; } = new();
        public SourceSet<double?> Shift { get; set; } = new();
        public SourceSet<double?> ShiftSpeed { get; set; } = new();
    }
}