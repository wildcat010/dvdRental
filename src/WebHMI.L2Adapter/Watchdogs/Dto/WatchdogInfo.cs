using XIDL;

namespace WebHMI.L2Adapter.Watchdogs.Dto
{
    public class WatchdogInfo
    {
        public string Name { get; set; }
        public List<WatchdogApplicationInfo> Applications { get; set; } = new List<WatchdogApplicationInfo>();
        public ComponentHealthState Status { get; set; } = ComponentHealthState.UNKNOWN;
        public DateTime TimeStamp { get; init; } = DateTime.UtcNow;
    }
}
