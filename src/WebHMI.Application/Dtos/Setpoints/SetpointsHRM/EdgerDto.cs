namespace WebHMI.Dtos.Setpoints.SetpointsHRM
{
    public class EdgerDto
    {
        public SourceSet<double?> Fr { get; set; } = new();
        public SourceSet<double?> RPower { get; set; } = new();
        public SourceSet<double?> Ms { get; set; } = new();
        public SourceSet<double?> VCircum { get; set; } = new();
        public SourceSet<double?> Sd { get; set; } = new();
        public SourceSet<int?> PlanNo { get; set; } = new();
        public SourceSet<int?> EdgerMode { get; set; } = new();
        public SourceSet<int?> EdgerActive { get; set; } = new();
        public SourceSet<double?> WidthReduction { get; set; } = new();
    }
}
