using Abp.Application.Services.Dto;
using Abp.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.ProductionSchedule;
using WebHMI.Filters;
using WebHMI.Helpers;
using WebHMI.PRDB;

namespace WebHMI.Services
{
	internal class ProductionScheduleAppService : ApplicationServiceBase
	{
		private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
		private PrdbContext _prdbContext => _prdbContextProvider.GetDbContext();

		public ProductionScheduleAppService(IDbContextProvider<PrdbContext> prdbContextProvider)
		{
			_prdbContextProvider = prdbContextProvider;
		}


		public async Task<PagedResultDto<ProductionScheduleDto>> GetAll(ProductionScheduleFilteredRequestDto input)
		{
			// TODO: add HmiVProdSeq, HmiVSlabOverview
			throw new NotImplementedException();


			//switch (input.Mode)
			//{
			//	case ProductionScheduleMode.Scheduled:
			//		return await ApplyFilter(
			//			_hmiVProdSeqRepository.GetAll()
			//				.Where(x => x.Mecreator == "L3" || x.Mecreator == "PC")
			//				.OrderBy(t => t.Rownumber),
			//			input, ProductionScheduleDtoMapper.ToDtoFromDbo);

			//	case ProductionScheduleMode.Planned:
			//		return await ApplyFilter(
			//			_slabOverview.GetAll()
			//				.Where(x => x.Mecreator == "L3")
			//				.Where(x => x.Status.HasValue && x.Status < 0)
			//				.OrderByDescending(x => x.Enormeid),
			//			input, ProductionScheduleDtoMapper.ToDtoFromDbo);

			//	case ProductionScheduleMode.Ghost:
			//		return await ApplyFilter(
			//			_slabOverview.GetAll()
			//				.Where(x => x.Mecreator == "SI")
			//				.OrderBy(x => x.Enorextid),
			//			input, ProductionScheduleDtoMapper.ToDtoFromDbo);

			//	case ProductionScheduleMode.Test:
			//		return await ApplyFilter(
			//			_slabOverview.GetAll()
			//				.Where(x => x.Mecreator == "TC")
			//				.OrderBy(x => x.Enorextid),
			//			input, ProductionScheduleDtoMapper.ToDtoFromDbo);

			//	case ProductionScheduleMode.Produced:
			//		return await ApplyFilter(
			//			_slabOverview.GetAll()
			//				.Where(x => x.Mecreator == "L3")
			//				.Where(x => x.Status.HasValue && x.Status >= 1)
			//				.OrderByDescending(x => x.Lastupdate),
			//			input, ProductionScheduleDtoMapper.ToDtoFromDbo);

			//	default:
			//		throw new NotImplementedException($"Unhandled {nameof(input.Mode)}");
			//}
		}
	}
}
