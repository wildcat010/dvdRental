namespace WebHMI.L2Adapter.Watchdogs.Dto
{
    public class WatchdogChannelInfo
    {
        public string Name { get; set; }
        public bool Ok { get; set; }
        public string Comment { get; set; }
        public string Error { get; set; }
        public ComponentHealthState ChannelStatus { get; set; }
    }
}
