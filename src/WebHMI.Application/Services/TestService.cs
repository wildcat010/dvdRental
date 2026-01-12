using Abp.EntityFrameworkCore;
using Abp.Events.Bus;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebHMI.Dtos;
using WebHMI.EventBus;
using WebHMI.Helpers;
using WebHMI.Notification;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Services
{
    public class TestService : ApplicationServiceBase
    {
        private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
        private readonly IEventBus _eventBus;
        private readonly ISignalRNotifier _signalRNotifier;

        public TestService(
            IDbContextProvider<PrdbContext> prdbContextProvider,
            IEventBus eventBus,
            ISignalRNotifier signalRNotifier)
        {
            _prdbContextProvider = prdbContextProvider;
            _eventBus = eventBus;
            _signalRNotifier = signalRNotifier;
        }

        public void GenerateHmiRefreshSignalR(HmiRefreshDto hmiRefresh)
        {
            _eventBus.Trigger(new EventWrapper<HmiRefreshDto>(hmiRefresh));

        }

        public async Task SendTestRefresh(string refreshKey, int? meId, string matType)
        {
            var context = _prdbContextProvider.GetDbContext();
            MeCodeDto meCodeDto = null;
            if (meId != null && matType != null)
            {
                //create MeCode parameter
                Me me = await context.Mes.FirstOrDefaultAsync(x => x.MeId == meId && x.MeTyp == matType);
                if (me != null)
                {
                    meCodeDto = new MeCodeDto();
                    meCodeDto.ExtId = me.ExtId;
                    meCodeDto.MeId = me.MeId;
                    meCodeDto.MesId = me.CurMesId ?? 1;
                    meCodeDto.MatType = me.MeTyp;
                    meCodeDto.Status = me.Status;
                    meCodeDto.MeCreator = me.MeCreator;

                }
                else
                {
                    throw new Abp.UI.UserFriendlyException("Unknown material");
                }
            }

            Logger.Info($"Sending Test HMI refresh with key '{refreshKey}'");

            var dto = new HmiRefreshDto();
            dto.MeCode = meCodeDto;
            dto.LocationId = 0;
            dto.LocationName = "";
            dto.EventKey = new List<string> { refreshKey };

            var eventData = new EventWrapper<HmiRefreshDto>(dto);
            _eventBus.Trigger(eventData);
            await _signalRNotifier.BroadcastToAllClientsAsync(eventData, "HmiRefreshData");
        }

    }
}
