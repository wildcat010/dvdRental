using XIDL;
using Abp.Json;
using System.Text.Json;
using log4net;
using WebHMI.Notification;
using WebHMI.L2Adapter.ConnectionManagers;
using WebHMI.L2Adapter.Watchdogs.Dto;
using WebHMI.L2Adapter.Watchdogs.Helpers;
using ComponentHealthState = WebHMI.L2Adapter.Watchdogs.Dto.ComponentHealthState;

namespace WebHMI.L2Adapter.Watchdogs
{
    public class WatchdogWrapper
    {
        private readonly ILog _logger;
        private IWatchdogStub _stub;

        public string Name { get; set; }
        public WatchdogInfo WatchdogInfo { get; set; } = new();

        private static readonly List<string> _ignoredItems = new();

        public WatchdogWrapper(string watchDogName)
        {
            _logger = LogManager.GetLogger(typeof(WatchdogWrapper));
            Name = watchDogName;
            _stub = CreateStub();
        }

        public void UpdateWatchdogState(ISignalRNotifier signalRNotifier)
        {
            _logger.Debug($"Updating watchdog data for {Name}");
            // Try to recreate if not created properly
            if (_stub is null && ConnectionManager.IsL2CommunicationRunning)
                _stub = CreateStub();

            // Init failed or comm is disabled
            if (_stub is null || !ConnectionManager.IsL2CommunicationRunning)
            {
                WatchdogInfo.Status = ComponentHealthState.UNKNOWN;
                return;
            }

            try
            {
                XIDL.ApplicationInfo[] applicationInfo;

                try
                {
                    applicationInfo = _stub.getApplicationInfo();
                    _logger.Debug($"Raw ApplicationInfo:{applicationInfo.ToJsonString()}");
                }
                catch (System.Exception)
                {
                    _logger.Error($"Getting watchdog {Name} data failed");
                    throw;
                }

                WatchdogInfo watchdogInfoCandidate = WatchdogMapper.ToWatchdogInfo(applicationInfo);
                _logger.Debug($"ApplicationInfo:{applicationInfo.ToJsonString()}");

                foreach (string watchdogAppName in applicationInfo.Select(x => x.Name))
                {
                    var watchdogApp = watchdogInfoCandidate.Applications.Single(x => x.Name == watchdogAppName);
                    string itemKey = $"{Name}-{watchdogAppName}";
                    _logger.Debug($"Processing {itemKey} component");

                    if (WatchdogInfo.Applications.SingleOrDefault(x => x.Name == watchdogAppName)?.StartupTime.Value.Ticks < watchdogApp.StartupTime.Value.Ticks)
                    {
                        _logger.Debug($"Detected restart of {itemKey}. Removing it from Ignore list");
                        _logger.Debug($"IgnoreListBefore:{JsonSerializer.Serialize(_ignoredItems)}");
                        _ignoredItems.Remove(itemKey);
                        _logger.Debug($"After:{JsonSerializer.Serialize(_ignoredItems)}");
                    }

                    if (_ignoredItems.Contains(itemKey))
                    {
                        _logger.Debug($"Skipping {itemKey} because it is in ignore list");
                        continue;
                    }

                    ChannelHealthState[] channelHealthStates = null;

                    try
                    {
                        channelHealthStates = _stub.getChannelHealthState(watchdogAppName);
                        _logger.Debug($"Raw channelHealthState:{channelHealthStates.ToJsonString()}");
                    }
                    catch (System.Exception ex)
                    {
                        string appWatchdogName = applicationInfo[0].Name;
                        _logger.Debug($"Couldn't get channel status for watchdog: {appWatchdogName}, app: {watchdogAppName}");
                        _logger.Debug($"Error:{ex}");
                    }

                    if (channelHealthStates is null || !channelHealthStates.Any())
                    {
                        _ignoredItems.Add(itemKey);
                        _logger.Debug($"Added {itemKey} to ignore list because it is null or empty.");
                        continue;
                    }

                    foreach (var channelHealthState in channelHealthStates)
                    {
                        var channelInfo = new WatchdogChannelInfo()
                        {
                            Name = channelHealthState.Name,
                            Ok = channelHealthState.Ok,
                            Error = channelHealthState.Error,
                            Comment = channelHealthState.Comment,
                            ChannelStatus = WatchdogHelper.ResolveChannelStatus(channelHealthState)
                        };
                        _logger.Debug($"Adding {channelInfo.Name} to {watchdogApp.Name}");
                        watchdogApp.Channels.Add(channelInfo);
                    }
                }
                watchdogInfoCandidate.Status = WatchdogHelper.ResolveWatchDogStatus(watchdogInfoCandidate);
                if (!WatchdogHelper.AreWatchdogInfoEqual(WatchdogInfo, watchdogInfoCandidate))
                {
                    WatchdogInfo = watchdogInfoCandidate;
                    _logger.Debug($"Change in watchdogInfo detected propagating it to UI");
                    signalRNotifier.BroadcastToAllClientsAsync(WatchdogInfo.ToDto(), "SystemStatusUpdate");
                    _logger.Debug($"New watchdogStatus:{WatchdogInfo.Status}");
                }
                else
                    _logger.Debug($"Discarded new object because there were no changes");
                _logger.Debug($"Finished updating data for {Name} watchdog");
            }
            catch (System.Exception ex)
            {
                _logger.Error($"Error while updating L2 {Name} watchdog status", ex);
                WatchdogInfo.Status = ComponentHealthState.RED;
            }
        }

        private IWatchdogStub CreateStub()
        {
            var request = new Request(Name, "watchdog", "Platform", "IWatchdog", "hmiPa");
            var stub = new IWatchdogStub(request);
            _logger.Info($"[CAPPA] {Name} {nameof(IWatchdogStub)} initialized");
            return stub;
        }
    }
}
