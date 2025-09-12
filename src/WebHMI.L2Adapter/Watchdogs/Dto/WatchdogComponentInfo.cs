namespace WebHMI.L2Adapter.Watchdogs.Dto
{
    public class WatchdogComponentInfo
    {
        public string Name { get; set; }
        public RestartPending RestartPending { get; set; }
        public ComponentRunState RunState { get; set; }
        public ComponentHealthState State { get; set; }
        public DateTime? LoadTime { get; set; }
    }
}
