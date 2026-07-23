namespace WebHMI.Dtos.Setpoints.CommonDtos
{
    public class PowerCoolingRampDto
    {
        public SourceSet<int?> PlanNo { get; set; } = new();
        public int RampNo { get; set; }
        public SourceSet<string> Description { get; set; } = new();
        public SourceSet<int?> PcRampAuto { get; set; } = new();
        public SourceSet<int?> PcRampState { get; set; } = new();
        public SourceSet<int?> PrioPowerC { get; set; } = new();
        public SourceSet<double?> PcRampVolumeInd0 { get; set; } = new();
        public SourceSet<double?> PcRampVolumeInd1 { get; set; } = new();
    }
}
