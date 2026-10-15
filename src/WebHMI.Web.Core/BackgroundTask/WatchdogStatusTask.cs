using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.Json;
using Abp.Threading.BackgroundWorkers;
using Abp.Threading.Timers;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebHMI.L2Adapter.Watchdogs;
using WebHMI.L2Adapter.Watchdogs.Dto;
using WebHMI.L2Adapter.Watchdogs.Helpers;
using WebHMI.Status;

namespace WebHMI.BackgroundTask
{
    public class WatchDogStatusTask : PeriodicBackgroundWorkerBase, ISingletonDependency
    {
        private readonly StatusManager _statusManager;
        private readonly WatchdogStatusService _watchDogStatusService;

        public WatchDogStatusTask(AbpTimer timer,
            WatchdogStatusService watchdogStatusServic,
            StatusManager statusManager) :
            base(timer)
        {
            _watchDogStatusService = watchdogStatusServic;
            _statusManager = statusManager;
            Timer.Period = 5000;
        }

        protected override void DoWork()
        {
            GetStatus().GetAwaiter().GetResult();
        }

        [UnitOfWork]
        public virtual async Task GetStatus()
        {
            try
            {
                await _watchDogStatusService.UpdateWatchdogStatuses();

                List<WatchdogItemDto> watchdogs = _watchDogStatusService.GetWatchdogList();
                var OverAllL1L2Comm = new List<string>();
                for (int i = 0; i < watchdogs.Count; i++)
                {
                    var wdog = watchdogs[i];
                    var label = GetWatchDogLabel(wdog);
                    var wdog2 = _watchDogStatusService.GetWatchdog(wdog.Name);
                    var foultyElements = "";
                    if (wdog2.Status == ComponentHealthState.RED)
                    {
                        var redWdogElements = WatchdogHelper.GetRedComponentsAndChannels(wdog2);
                        if (redWdogElements.ChannelStates.Count > 0)
                        {
                            OverAllL1L2Comm.AddRange(redWdogElements.ChannelStates);
                        }
                        foultyElements = string.Join(" ", redWdogElements.ComponentStates.Select(x => $"{x.ComponentName} - {x.RunState}"));
                    }
                    _statusManager.AddWdogStatus(GetState(wdog), label, SimpleStatusGroup.WatchdogStatus, i + 1, $"{wdog.Name}", foultyElements);
                }
                _statusManager.AddWdogStatus(OverAllL1L2Comm.Count > 0 ? OveralStateDto.ERROR : OveralStateDto.OK, "L1/L2",
                    SimpleStatusGroup.WatchdogStatus, 0, "L1-L2 Communication", string.Join(" ", OverAllL1L2Comm));
            }
            catch (Exception ex)
            {
                Logger.Error("Error while trying to resolve Watchdog status", ex);
            }
        }

        private static OveralStateDto GetState(WatchdogItemDto wdog)
        {
            if (wdog is null || wdog.Status == ComponentHealthState.UNKNOWN)
                return OveralStateDto.UNKNOWN;

            OveralStateDto result;

            switch (wdog.Status)
            {
                case ComponentHealthState.RED:
                    result = OveralStateDto.ERROR;
                    break;
                case ComponentHealthState.YELLOW:
                    result = OveralStateDto.OK;
                    break;
                case ComponentHealthState.GREEN:
                    result = OveralStateDto.OK;
                    break;
                default:
                    result = OveralStateDto.UNKNOWN;
                    break;
            }

            return result;

        }

        private string GetWatchDogLabel(WatchdogItemDto watchdogItemDto) => watchdogItemDto.Name.Replace("AppWdog", String.Empty);
    }
}
