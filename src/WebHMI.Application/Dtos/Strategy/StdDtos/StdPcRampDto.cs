using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Strategy.StdDtos
{
    public class StdPcRampDto : StdRampDto
    {
        public int? Pcrampauto { get; set; }
        public int? Priopowerc { get; set; }
        public int? Pcrampstate { get; set; }
        public double? PcRampVolumeInd0 { get; set; }
        public double? PcRampVolumeInd1 { get; set; }
    }
}
