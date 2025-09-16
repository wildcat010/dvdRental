namespace WebHMI.L2Adapter.Watchdogs.Dto
{
    public class WatchdogProxyItem
    {
        public string Channel { get; set; }
        public string Description { get; set; }
        public bool Ok { get; set; }
        public ComponentHealthState ChannelStatus { get; set; }
    }
}
