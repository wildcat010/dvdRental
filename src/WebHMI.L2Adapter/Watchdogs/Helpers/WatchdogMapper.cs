using WebHMI.L2Adapter.Watchdogs.Dto;
using XIDL;
using ComponentHealthState = WebHMI.L2Adapter.Watchdogs.Dto.ComponentHealthState;
using ComponentRunState = WebHMI.L2Adapter.Watchdogs.Dto.ComponentRunState;

namespace WebHMI.L2Adapter.Watchdogs.Helpers
{
    public static class WatchdogMapper
    {
        public static WatchdogInfo ToWatchdogInfo(ApplicationInfo[] applicationInfos)
        {
            var returnMessage = new WatchdogInfo();

            if (applicationInfos.Length > 0)
            {
                returnMessage.Name = applicationInfos[0].Name;
                returnMessage.Applications = MapApplications(applicationInfos);
            }

            return returnMessage;
        }

        public static WatchdogChannelInfo ToChannelInfo(this ChannelHealthState channelHealthState)
        {
            return new WatchdogChannelInfo()
            {
                Name = channelHealthState.Name,
                Ok = channelHealthState.Ok,
                Error = channelHealthState.Error,
                Comment = channelHealthState.Comment
            };
        }

        private static List<WatchdogApplicationInfo> MapApplications(ApplicationInfo[] applicationInfos)
        {
            var returnList = new List<WatchdogApplicationInfo>();

            foreach (ApplicationInfo element in applicationInfos)
            {
                var webHMIApplicationInfo = new WatchdogApplicationInfo
                {
                    Name = element.Name,
                    Pid = element.Pid,
                    StartupTime = element.StartupTime,
                    Components = MapComponents(element)
                };

                returnList.Add(webHMIApplicationInfo);
            }

            return returnList;
        }

        private static List<WatchdogComponentInfo> MapComponents(ApplicationInfo applicationInfo)
        {
            var returnList = new List<WatchdogComponentInfo>();

            foreach (ComponentInfo element in applicationInfo.ComponentInfos.Where(x => !x.IsNullComponent))
            {

                var webHMIComponentInfo = new WatchdogComponentInfo
                {
                    Name = element.Name,
                    RestartPending = (RestartPending)element.RestartPending,
                    RunState = (ComponentRunState)element.RunState,
                    State = (ComponentHealthState)element.State,
                    LoadTime = element.LoadTime,
                };

                returnList.Add(webHMIComponentInfo);
            }

            return returnList;
        }

        public static WatchdogDto ToDto(this WatchdogInfo input)
        {
            var dto = new WatchdogDto();

            dto.Name = input.Name;
            dto.TimeStamp = input.TimeStamp;

            foreach (var app in input.Applications)
            {
                var watchdogProcess = new WatchdogProcess();

                watchdogProcess.AppName = app.Name;
                watchdogProcess.StartupTime = app.StartupTime;

                foreach (var component in app.Components)
                {
                    var watchdogProcessComponent = new WatchdogProcessComponent
                    {
                        Name = component.Name,
                        AutoRestart = component.RestartPending,
                        OccurredTime = component.LoadTime,
                        ActualState = component.RunState,
                        HealthState = component.State
                    };

                    watchdogProcess.Components.Add(watchdogProcessComponent);
                }

                dto.Processes.Add(watchdogProcess);

                if (!app.Channels.Any())
                    continue;

                var watchdogProxy = new WatchdogProxy();
                watchdogProxy.Name = app.Name;

                foreach (var channel in app.Channels)
                {
                    var watchdogProxyItem = new WatchdogProxyItem();
                    watchdogProxyItem.Channel = channel.Name;
                    watchdogProxyItem.Description = channel.Comment;
                    watchdogProxyItem.Ok = channel.Ok;
                    watchdogProxyItem.ChannelStatus = channel.ChannelStatus;

                    watchdogProxy.Items.Add(watchdogProxyItem);
                }
                watchdogProxy.Status = ResolveProxyStatus(app.Channels);
                dto.Proxies.Add(watchdogProxy);
            }

            return dto;
        }

        private static ComponentHealthState ResolveProxyStatus(List<WatchdogChannelInfo> channels)
        {
            if (channels.Any(x => x.ChannelStatus == ComponentHealthState.RED))
                return ComponentHealthState.RED;
            if (channels.Any(x => x.ChannelStatus == ComponentHealthState.YELLOW))
                return ComponentHealthState.YELLOW;
            return ComponentHealthState.GREEN;
        }
    }
}
