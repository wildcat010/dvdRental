namespace WebHMI.L2Adapter.Watchdogs.Dto
{
    public class WatchdogDto
    {
        public string Name { get; set; }
        public List<WatchdogProcess> Processes { get; set; } = new();
        public List<WatchdogProxy> Proxies { get; set; } = new();
        public DateTime TimeStamp { get; set; }
    }
}
