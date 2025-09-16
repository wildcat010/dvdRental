using WebHMI.Status;

namespace WebHMI.L2Adapter.Watchdogs.Dto
{
    public class WebHMIProcessStatusDto
    {
        public string ProcessName { get; set; }
        public OveralStateDto ProcessState { get; set; }
        public string Label { get; set; }

        public WebHMIProcessStatusDto(string processName, OveralStateDto processState, string label)
        {
            ProcessName = processName;
            ProcessState = processState;
            Label = label;
        }
    }
}
