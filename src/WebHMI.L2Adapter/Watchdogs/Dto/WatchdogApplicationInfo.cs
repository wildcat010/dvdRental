namespace WebHMI.L2Adapter.Watchdogs.Dto
{
    public class WatchdogApplicationInfo
    {
        public string Name { get; set; }
        public DateTime? StartupTime { get; set; }
        public int Pid { get; set; }
        public List<WatchdogComponentInfo> Components { get; set; } = new();
        public List<WatchdogChannelInfo> Channels { get; set; } = new();
    }
}
