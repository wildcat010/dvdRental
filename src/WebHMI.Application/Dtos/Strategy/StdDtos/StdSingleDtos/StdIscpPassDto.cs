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
        public int? IscState { get; set; }
        public int? DescalerAuto { get; set; }
        public int? DescalerState { get; set; }
        public double? DescalerVolume { get; set; }
        public double? FumeSuppSprayBefor { get; set; }
        public int? FumeSuppSprayBehState { get; set; }
        public double? IntermBeamCool { get; set; }
        public int? IscAuto { get; set; }
        public double? IscMaxVolumeInd0 { get; set; }
        public double? IscMaxVolumeInd1 { get; set; }
        public double? IscMaxVolumeInd2 { get; set; }
        public double? IscMaxVolumeInd3 { get; set; }
        public double? IscMinVolumeInd0 { get; set; }
        public double? IscMinVolumeInd1 { get; set; }
        public double? IscMinVolumeInd2 { get; set; }
        public double? IscMinVolumeInd3 { get; set; }
        public double? LongCrossSpray { get; set; }
        public double? LooperCool { get; set; }
        public int? PrioDescaler { get; set; }
        public int? PrioIsc { get; set; }
        public double? RollGapSpray { get; set; }
        public double? StripSprayBefor { get; set; }
    }
}
