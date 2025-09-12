using Abp.Authorization;
using Abp.UI;
using System.Collections.Generic;
using WebHMI.Helpers;
using WebHMI.L2Adapter.Watchdogs;
using WebHMI.L2Adapter.Watchdogs.Dto;
using WebHMI.L2Adapter.Watchdogs.Helpers;

namespace WebHMI.Services
{
    public  class SystemStatusService: ApplicationServiceBase
    {
        private readonly WatchdogStatusService _watchdogStatusService;

        public SystemStatusService(
            WatchdogStatusService watchdogStatusService)
        {
            _watchdogStatusService = watchdogStatusService;
        }

        /// <summary>
        /// Returns all watchdogs configured in API project settings
        /// </summary>
        /// <returns>Watchdog list</returns>
        [AbpAuthorize(Permissions.Pages_SystemStatus)]
        public IEnumerable<WatchdogItemDto> GetWatchdogList()
        {
            return _watchdogStatusService.GetWatchdogList();
        }

        [AbpAuthorize(Permissions.Pages_SystemStatus)]
        public WatchdogDto GetWatchdogData(string watchdog)
        {
            try
            {
                var watchdogData = _watchdogStatusService.GetWatchdog(watchdog);

                if (watchdogData is not null)
                    return watchdogData.ToDto();

                return null;
            }
            catch (System.Exception ex)
            {
                Logger.Error("Internal server error", ex);
                throw new UserFriendlyException($"Internal server error. {ex.Message}");
            }
        }

        [AbpAuthorize(Permissions.Pages_SystemStatus)]
        public ChannelStatusPreview GetChannelStatus()
        {
            return _watchdogStatusService.GetChannelStatusPreview();
        }
    }
}
