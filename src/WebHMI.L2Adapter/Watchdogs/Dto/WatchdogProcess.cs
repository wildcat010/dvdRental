namespace WebHMI.L2Adapter.Watchdogs.Dto
{
    public class WatchdogProcess
    {
        public string AppName { get; set; }
        public DateTime? StartupTime { get; set; }
        public List<WatchdogProcessComponent> Components { get; set; } = new();
    }
}
