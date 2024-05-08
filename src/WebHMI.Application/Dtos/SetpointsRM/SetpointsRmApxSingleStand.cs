namespace WebHMI.Dtos.SetpointsRM
{
    public class SetpointsRmApxSingleStand
    {
        public int StandId { get; set; }
        public SourceSet<double?> BendingForceUpperLimit { get; set; }
        public SourceSet<double?> BendingForceLowerLimit { get; set; }
        public SourceSet<double?> ShiftingUpperLimit { get; set; }
        public SourceSet<double?> ShiftingLowerLimit { get; set; }
        public SourceSet<double?> WearShiftingUpperLimit { get; set; }
        public SourceSet<double?> WearShiftingLowerLimit { get; set; }
        public SourceSet<double?> ObsFlatness { get; set; }
        public SourceSet<double?> RollForce { get; set; }
        public SourceSet<double?> EffGrinding { get; set; }
        public SourceSet<double?> ThermalCrown { get; set; }
        public SourceSet<double?> WearCrown { get; set; }
        public SourceSet<double?> RollTemp { get; set; }
        public SourceSet<double?> ExitProfileRel { get; set; }
        public SourceSet<double?> ExitProfileAbs { get; set; }
        public SourceSet<double?> Bend { get; set; }
        public SourceSet<double?> Shift { get; set; }
        public SourceSet<double?> ShiftSpeed { get; set; }
    }
}