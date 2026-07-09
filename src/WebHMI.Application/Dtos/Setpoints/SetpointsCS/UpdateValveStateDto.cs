using XIDL;

namespace WebHMI.Dtos.Setpoints.SetpointsCS
{
    public class UpdateValveStateDto
    {
        public int ValveId { get; set; }
        public HmiCsValveColors ManualValveState { get; set; }
        /// <summary>
        /// possible values for type 0 = topvalve, 1=bottomValve, 2=crossSpray, 3=drainalveCs, 4=drainValveFm, 5=airblower, 6=rollerTableCooling
        /// </summary>
        public int Type { get; set; }
    }
}
