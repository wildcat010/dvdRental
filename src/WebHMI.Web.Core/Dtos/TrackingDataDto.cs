using System.Collections.Generic;
using XIDL;

namespace WebHMI.Dtos.Application.Tracking
{
    public class TrackingDataDto
    {
        public List<MeCodeDto> ProducedCoils { get; set; }

        public List<MeCodeDto> NextSlabs { get; set; }

        public HmiTrackingData HmiTrackingData { get; set; }
        public Dictionary<string, MeCodeDto> ActualNext { get; set; }
    }
}
