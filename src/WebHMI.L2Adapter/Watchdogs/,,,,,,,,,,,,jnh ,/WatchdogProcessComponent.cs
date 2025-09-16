namespace WebHMI.L2Adapter.Watchdogs.Dto
{
    public class WatchdogProcessComponent
    {
        public string Name { get; set; }
        public RestartPending AutoRestart { get; set; }
        public DateTime? OccurredTime { get; set; }
        public ComponentRunState ActualState { get; set; }
        public ComponentHealthState HealthState { get; set; }
    }
}
