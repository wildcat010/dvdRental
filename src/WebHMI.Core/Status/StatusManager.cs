using Abp.Dependency;
using Castle.Core.Logging;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;
using WebHMI.Notification;

namespace WebHMI.Status
{
    public class StatusManager : ISingletonDependency
    {
        public ILogger Logger { get; set; }

        private System.Timers.Timer _timerStatusManager;
        private readonly ISignalRNotifier _notifier;
        private readonly ConcurrentDictionary<StatusKey, SimpleStatusDto> _simpleStatusDtos = new();

        public StatusManager(ISignalRNotifier notifier)
        {
            _notifier = notifier;
            Logger = NullLogger.Instance;
        }

        #region init
        public async Task Initialize()
        {
            Logger.Debug("[StatusManager] StatusManager initializing");
            _timerStatusManager = new System.Timers.Timer(2000);
            _timerStatusManager.Elapsed += TimerElapsed;
            _timerStatusManager.Start();
            Logger.Debug("[StatusManager] StatusManager initialized");
        }
        #endregion

        void TimerElapsed(object sender, System.Timers.ElapsedEventArgs args)
        {
            _notifier.BroadcastToAllClientsAsync(
                _simpleStatusDtos.Values
                    .GroupBy(z => z.Group)
                    .OrderBy(x => x.Key)
                    .ToDictionary(x => x.Key, v => v.OrderBy(x => x.GroupOrder).ToList()),
                "ProcessShortStatusData");
        }

        public void AddStatus(OveralStateDto state, string label, SimpleStatusGroup group, int groupOrder, string additionalInfo = "")
        {
            var key = new StatusKey(label, group);
            var lastStatusChangeTs = DateTime.UtcNow;

            _simpleStatusDtos.AddOrUpdate(key,
                new SimpleStatusDto(state, label, lastStatusChangeTs, group, groupOrder, additionalInfo),
                (key, val) =>
                {
                    val.State = state;
                    val.Label = label;
                    val.AddInfo = additionalInfo;
                    val.LastStatusChangeTs = lastStatusChangeTs;
                    val.Group = group;
                    val.GroupOrder = groupOrder;
                    return val;
                });
        }
        public void AddWdogStatus(OveralStateDto state, string label, SimpleStatusGroup group, int groupOrder, string additionalInfo = "", string wdog = "")
        {
            var key = new StatusKey(label, group);
            var lastStatusChangeTs = DateTime.UtcNow;

            _simpleStatusDtos.AddOrUpdate(key,
                new SimpleStatusDto(state, label, lastStatusChangeTs, group, groupOrder, additionalInfo),
                (key, val) =>
                {
                    val.State = state;
                    val.Label = label;
                    val.AddInfo = additionalInfo;
                    val.LastStatusChangeTs = lastStatusChangeTs;
                    val.Group = group;
                    val.GroupOrder = groupOrder;
                    val.FaultyElements = wdog;
                    return val;
                });
        }
    }

    public record StatusKey(string Label, SimpleStatusGroup Group);
}
