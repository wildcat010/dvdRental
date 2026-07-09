namespace WebHMI.Dtos.Setpoints.SetpointsCS
{
    public class OrderData
    {
        public SourceSet<double?> Vexit { get; set; } = new();
        public SourceSet<double?> VthrCoiler { get; set; } = new();
        public SourceSet<double?> Vtail { get; set; } = new();
        public SourceSet<double?> TempSpeedup { get; set; } = new();
        public SourceSet<short?> TempSpeedupFlag { get; set; } = new();
        public SourceSet<double?> VMax { get; set; } = new();
        public SourceSet<double?> WaterAmount { get; set; } = new();
    }
}
