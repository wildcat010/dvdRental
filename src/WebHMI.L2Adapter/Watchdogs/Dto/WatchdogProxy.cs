namespace WebHMI.L2Adapter.Watchdogs.Dto
{
    public class WatchdogProxy
    {
        public string Name { get; set; }
        public ComponentHealthState Status { get; set; }

        public List<WatchdogProxyItem> Items { get; set; } = new();
    }
}
