using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Strategy.StdDtos
{
    public class StdPowerCoolingDto
    {
        public int PlanNo { get; set; }
        public int ActiveFlag { get; set; }
        public int AssignmentsCount { get; set; }
        public DateTime? LastModified { get; set; }
        public int NoRamps { get; set; }
        public string Description { get; set; }
        public List<StdPowerCoolingRampDto> Ramps { get; set; } = new();
    }

    public class StdPowerCoolingRampDto
    {
        public int rampNo { get; set; }
        public int? Pcrampauto { get; set; }
        public int? Priopowerc { get; set; }
        public int? Pcrampstate { get; set; }
        public double? PcRampVolumeInd0 { get; set; }
        public double? PcRampVolumeInd1 { get; set; }
    }
}
