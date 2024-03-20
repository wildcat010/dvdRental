using Abp.Application.Services.Dto;
using Abp.EntityFrameworkCore;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos;
using WebHMI.Dtos.Common;
using WebHMI.Filters;
using WebHMI.Helpers;
using WebHMI.Mapping.Extensions;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Services
{
	public class CommonAppService : ApplicationServiceBase
	{
		private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
		private PrdbContext _prdbContext => _prdbContextProvider.GetDbContext();

		public CommonAppService(IDbContextProvider<PrdbContext> prdbContextProvider)
		{
			_prdbContextProvider = prdbContextProvider;
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
			throw new NotImplementedException();

			//var result = await ApplyFilter(_inlineMaterialRepository.GetAll()
			//	.OrderByDescending(t => t.Osdatetime),
			//	input, TrackingDataMapper.ToDto);

			//return result;
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

				dto.MapEffectiveData(item);

				result.Add(dto);
			}

			return new PagedResultDto<MaterialHeaderDto>(result.Count, result.ToList());
		}
	}
}
