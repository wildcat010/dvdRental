using Abp.Application.Services.Dto;
using Abp.EntityFrameworkCore;
using Abp.Events.Bus;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos;
using WebHMI.Dtos.Common;
using WebHMI.Dtos.Events;
using WebHMI.EventBus;
using WebHMI.Filters;
using WebHMI.Helpers;
using WebHMI.Mapping.Extensions;
using WebHMI.Notification;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Services
{
	public class CommonAppService : ApplicationServiceBase
	{
		private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
		private PrdbContext _prdbContext => _prdbContextProvider.GetDbContext();
        private readonly IEventBus _eventBus;
        private readonly ISignalRNotifier _signalRNotifier;

        public CommonAppService(
            IDbContextProvider<PrdbContext> prdbContextProvider,
            IEventBus eventBus,
            ISignalRNotifier signalRNotifier)
        {
            _prdbContextProvider = prdbContextProvider;
            _eventBus = eventBus;
            _signalRNotifier = signalRNotifier;
        }

        public async Task<MaterialHeaderDto> GetMaterialHeaderDataById(int meid, string matType)
		{
			var result = new MaterialHeaderDto();
			List<HmiVMatInfoShort> hmiVMatInfoShortList = null;

			switch (matType)
			{
				case "OR":
					hmiVMatInfoShortList = await _prdbContext.HmiVMatInfoShorts.Where(x => x.EnOrMeId == meid).ToListAsync();
					break;
				case "PH":
					hmiVMatInfoShortList = await _prdbContext.HmiVMatInfoShorts.Where(x => x.EnPhMeId == meid).ToListAsync();
					break;
				case "LO":
					hmiVMatInfoShortList = await _prdbContext.HmiVMatInfoShorts.Where(x => x.EnLoMeId == meid).ToListAsync();
					break;
			}

			var rec = hmiVMatInfoShortList.FirstOrDefault();

			if (rec is null)
				throw new UserFriendlyException($"Material info not found for material with meid: '{meid}' and matType: '{matType}'");

			result.MeCode = new MeCodeDto
			{
				ExtId = rec.EnOrExtId,
				MatType = "OR",
				MeCreator = rec.EnOrCreator,
				MeId = rec.EnOrMeId,
				MesId = 1,
				Status = rec.EnPhStatus ?? -1
			};

			result.MapData(hmiVMatInfoShortList);

			return result;
		}

		public async Task<PagedResultDto<InLineMaterialDto>> GetInLineMaterials(FilteredRequestDto input)
		{
			return await ApplyFilter(_prdbContext.HmiVInlineMaterials.AsQueryable(), input, TrackingDataMapper.ToDto);
		}

		public async Task<PagedResultDto<MaterialHeaderDto>> GetMaterialHeaderList(FilteredRequestDto input)
		{
			var query = await ApplyFilterWithoutMapping(_prdbContext.HmiVMatInfoShorts.Where(x => x.EdOrSrc == "E" && x.EdLoSrc == "E" && x.EdPhySrc == "E"), input);
			var result = new List<MaterialHeaderDto>();

			foreach (var item in query.Items.DistinctBy(x => x.EnOrMeId))
			{
				var dto = new MaterialHeaderDto()
				{
					MeCode = new MeCodeDto()
					{
						Status = item.EnPhStatus,
						MeId = item.EnOrMeId,
						MatType = "OR",
						ExtId = item.EnOrExtId
					},
				};

				dto.MapData([item]);

				result.Add(dto);
			}

			return new PagedResultDto<MaterialHeaderDto>(result.Count, result.ToList());
		}

        public async Task SendTestRefresh(string refreshKey, int? meId, string matType)
        {
            MeCodeDto meCodeDto = null;
            if (meId != null && matType != null)
            {
                //create MeCode parameter
                Me me = await _prdbContext.Mes.FirstOrDefaultAsync(x => x.MeId == meId && x.MeTyp == matType);
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
