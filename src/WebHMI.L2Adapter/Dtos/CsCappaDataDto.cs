using XIDL;

namespace WebHMI.L2Adapter.Dtos
{
    public class CsCappaDataDto
    {
        public HmiCsValves HmiCsValves { get; set; }
        public HmiCsMeters HmiCsMeters { get; set; }
        public HmiTrackingData TrackingData { get; set; }
        public HmiCsStatus[] Statuses { get; set; }
        public HmiCsSliderF4t CsF4T { get; set; }
        public HmiCsCtcData CtcData { get; set; }
        public HmiCsSliderF4t SliderF4T { get; set; }
    }
}
