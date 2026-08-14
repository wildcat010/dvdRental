using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos
{
    public class StdIscpPassDto : StdPassDto
    {
        public double? IscVolumeInd0 { get; set; }
        public double? IscVolumeInd1 { get; set; }
        public double? IscVolumeInd2 { get; set; }
        public double? IscVolumeInd3 { get; set; }
        public double? StripSprayBefore { get; set; }
        public double? FumeSuppSprayBehind { get; set; }
        public string Description { get; set; }
        public double? StripSprayBehind { get; set; }
        public int? IscState { get; internal set; }
    }
}
