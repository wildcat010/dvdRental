using Abp.Dependency;
using Castle.Core.Logging;
using WebHMI.L2Adapter.Watchdogs.Dto;
using WebHMI.Notification;
using WebHMI.Status;

namespace WebHMI.L2Adapter.Watchdogs
{
    public class WatchdogStatusService : ISingletonDependency
    {
        private readonly L2CommunicationConfiguration _l2CommunicationConfiguration;
        private readonly List<WatchdogWrapper> _watchdogs = new();
        private readonly ISignalRNotifier _signalRNotifier;
        private readonly ILogger _logger;

        public WatchdogStatusService(ISignalRNotifier signalRNotifier,
            L2CommunicationConfiguration l2CommunicationConfiguration,
            ILogger logger)
        {
            _signalRNotifier = signalRNotifier;
            _l2CommunicationConfiguration = l2CommunicationConfiguration;
            _logger = logger;
        }

        /// <summary>
        /// Initializes watchdogs with stubs, which should be initialized only on L2 communication startup, not on resolve.
        /// </summary>
        public void InitializeWatchdogs()
        {
            _watchdogs.Clear();

            foreach (var watchdogName in _l2CommunicationConfiguration.Watchdogs)
                _watchdogs.Add(new WatchdogWrapper(watchdogName));
        }

        public async Task UpdateWatchdogStatuses()
        {
            foreach (var watchdog in _watchdogs)
                watchdog.UpdateWatchdogState(_signalRNotifier);

            await _signalRNotifier.BroadcastToAllClientsAsync(DateTime.UtcNow, "L2WatchdogStatusRefresh");
        }

        public string GetWatchdogNameElementWithRedHealthState(string wdogName)
        {
            return _watchdogs.SingleOrDefault(x => x.Name == wdogName && x.WatchdogInfo.Status == ComponentHealthState.RED)?.Name;
        }

        public OveralStateDto GetOverallWatchDogState()
        {
            if (_watchdogs.Select(x => x.WatchdogInfo).Any(x => x.Status == ComponentHealthState.RED) || _watchdogs == null || _watchdogs.Count == 0)
                return OveralStateDto.ERROR;

            if (_watchdogs.Select(x => x.WatchdogInfo).Any(x => x.Status == ComponentHealthState.YELLOW || x.Status == ComponentHealthState.UNKNOWN))
                return OveralStateDto.WARNING;

            return OveralStateDto.OK;
        }

        public string GetFaultyComponentsNames()
        {
            return string.Join(", ", _watchdogs.Where(x => x.WatchdogInfo.Status == ComponentHealthState.RED)
                .Select(x => x.Name));
        }

        public List<WatchdogItemDto> GetWatchdogList()
        {
            return _watchdogs.Select(x => new WatchdogItemDto()
            {
                Name = x.Name,
                Status = x.WatchdogInfo.Status
            }).ToList();
        }

        public WatchdogInfo GetWatchdog(string watchdog)
        {
            return _watchdogs.Single(x => x.Name == watchdog).WatchdogInfo;
        }

        public ChannelStatusPreview GetChannelStatusPreview()
        {
            return _watchdogs.SelectMany(x => x.WatchdogInfo.Applications.SelectMany(y => y.Channels))
                .GroupBy(x => x.ChannelStatus)
                .Aggregate(new ChannelStatusPreview(), (preview, group) =>
                {
                    switch (group.Key)
                    {
                        case ComponentHealthState.GREEN:
                            preview.Ok = group.Count();
                            break;
                        case ComponentHealthState.YELLOW:
                            preview.Warning = group.Count();
                            break;
                        case ComponentHealthState.RED:
                            preview.Error = group.Count();
                            break;
                    }
                    return preview;
                });
        }
    }
}
