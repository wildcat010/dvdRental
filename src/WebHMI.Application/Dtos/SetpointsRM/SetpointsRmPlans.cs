namespace WebHMI.Dtos.SetpointsRM
{
    public class SetpointsRmPlans
    {
        public SourceSet<int?> Loading { get; set; } = new();
        public SourceSet<int?> Descaling { get; set; } = new();
        public SourceSet<int?> RollCooling { get; set; } = new();
        public SourceSet<int?> Tension { get; set; } = new();
        public SourceSet<int?> RollGap { get; set; } = new();
        public SourceSet<int?> Isc { get; set; } = new();
    }
}