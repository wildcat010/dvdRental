using System.Collections.Generic;

namespace WebHMI.Dtos.Setpoints.CommonDtos
{
    public class PowerCoolingDto
    {
        public List<PowerCoolingRampDto> PowerCoolingRamps { get; set; } = new();
        public SourceSet<double?> DelayLength { get;  set; } = new();
        public SourceSet<string> Description { get; set; } = new();
        public SourceSet<int?> NoRamps { get; set; } = new();
        public SourceSet<int?> PlanNo { get; set; } = new();
    }
}
