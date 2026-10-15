using WebHMI.L2Adapter.Watchdogs.Dto;
using XIDL;
using ComponentHealthState = WebHMI.L2Adapter.Watchdogs.Dto.ComponentHealthState;
using ComponentRunState = WebHMI.L2Adapter.Watchdogs.Dto.ComponentRunState;

namespace WebHMI.L2Adapter.Watchdogs.Helpers
{
    public static class WatchdogHelper
    {

        private static readonly List<ComponentRunState> _listOfRedHealthStatuses = new List<ComponentRunState>()
        {
            ComponentRunState.STOPPED,
            ComponentRunState.CRASHED,
            ComponentRunState.BLOCKED,
            ComponentRunState.KILLED,
            ComponentRunState.HALTED,
            ComponentRunState.NON_EXISTENT
        };

        public static bool AreWatchdogInfoEqual(WatchdogInfo watchdog1, WatchdogInfo watchdog2)
        {
            if (watchdog1 == null || watchdog2 == null)
                return false;

            if (watchdog1.Name != watchdog2.Name || watchdog1.Status != watchdog2.Status)
                return false;

            if (watchdog1.Applications.Count != watchdog2.Applications.Count)
                return false;

            for (int i = 0; i < watchdog1.Applications.Count; i++)
            {
                var app1 = watchdog1.Applications[i];
                var app2 = watchdog2.Applications[i];

                if (app1.Name != app2.Name || app1.StartupTime != app2.StartupTime || app1.Pid != app2.Pid)
                    return false;

                if (!AreComponentListsEqual(app1.Components, app2.Components) || !AreChannelListsEqual(app1.Channels, app2.Channels))
                    return false;
            }

            return true;
        }

        private static bool AreComponentListsEqual(List<WatchdogComponentInfo> list1, List<WatchdogComponentInfo> list2)
        {
            if (list1.Count != list2.Count)
                return false;

            for (int i = 0; i < list1.Count; i++)
            {
                var comp1 = list1[i];
                var comp2 = list2[i];

                if (comp1.Name != comp2.Name || comp1.RestartPending != comp2.RestartPending || comp1.RunState != comp2.RunState)
                    return false;
            }

            return true;
        }

        private static bool AreChannelListsEqual(List<WatchdogChannelInfo> list1, List<WatchdogChannelInfo> list2)
        {
            if (list1.Count != list2.Count)
                return false;

            for (int i = 0; i < list1.Count; i++)
            {
                var chan1 = list1[i];
                var chan2 = list2[i];

                if (chan1.Name != chan2.Name || chan1.Ok != chan2.Ok || chan1.Comment != chan2.Comment || chan1.ChannelStatus != chan2.ChannelStatus)
                    return false;
            }

            return true;
        }

        public static ComponentHealthState ResolveWatchDogStatus(WatchdogInfo watchdogInfo)
        {
            if (watchdogInfo == null || watchdogInfo.Applications == null || watchdogInfo.Applications.Count() == 0)
                return ComponentHealthState.RED;

            if (CheckIfAnyComponentHasRedHealthState(watchdogInfo))
                return ComponentHealthState.RED;

            if (CheckIfAnyComponentHasYellowHealthState(watchdogInfo))
                return ComponentHealthState.YELLOW;

            return ComponentHealthState.GREEN;
        }

        public static ComponentHealthState ResolveChannelStatus(ChannelHealthState channelHealthState)
        {
            if (channelHealthState.Ok)
                return ComponentHealthState.GREEN;
            if (channelHealthState.Comment.Contains("#"))
                return ComponentHealthState.YELLOW;
            return ComponentHealthState.RED;
        }

        public static bool CheckIfAnyComponentHasRedHealthState(WatchdogInfo watchdogInfo)
            => watchdogInfo.Applications.Any(app => app.Channels.Any(y => y.ChannelStatus == ComponentHealthState.RED) || app.Components.Any(comp => _listOfRedHealthStatuses.Contains(comp.RunState)));


        public static bool CheckIfAnyComponentHasYellowHealthState(WatchdogInfo watchdogInfo)
            => watchdogInfo.Applications.Where(x => !x.Name.Contains("AppWdog")).Any(app => app.Components.Any(comp => comp.RunState == ComponentRunState.BUSY || comp.RunState == ComponentRunState.PAUSED));

        public static (List<(string ComponentName, string RunState)> ComponentStates, List<string> ChannelStates) GetRedComponentsAndChannels(WatchdogInfo wdog2)
        {
            if (wdog2?.Applications == null)
                return (new List<(string ComponentName, string RunState)>(), new List<string>());

            var componentStates = wdog2.Applications
                .SelectMany(app => app.Components)
                .Where(component => component.State == ComponentHealthState.RED 
                    && component.RunState != ComponentRunState.BUSY 
                    && component.RunState != ComponentRunState.IDLE)
                .Select(component => (ComponentName: component.Name, RunState: component.RunState.ToString()))
                .ToList();

            var channelStates = wdog2.Applications
                .SelectMany(app => app.Channels)
                .Where(channel => channel.ChannelStatus == ComponentHealthState.RED)
                .Select(channel => channel.Name)
                .ToList();

            return (componentStates, channelStates);
        }

    }
}

