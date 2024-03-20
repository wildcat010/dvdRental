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
using WebHMI.Mapping.Extensions;
using WebHMI.PRDB;

namespace WebHMI.Services
{
	public class ProductionScheduleAppService : ApplicationServiceBase
	{
		private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
		private PrdbContext _prdbContext => _prdbContextProvider.GetDbContext();

		public ProductionScheduleAppService(IDbContextProvider<PrdbContext> prdbContextProvider)
		{
			_prdbContextProvider = prdbContextProvider;
		}

		public async Task<PagedResultDto<ProductionScheduleDto>> GetAll(ProductionScheduleFilteredRequestDto input)
		{
			return input.Mode switch
			{
				ProductionScheduleMode.Scheduled => await ApplyFilter(_prdbContext.HmiVProdsequences, input, ProductionScheduleDtoMapper.ToDtoFromDbo),
				_ => throw new NotImplementedException($"Unhandled {nameof(input.Mode)}"),
			};
		}
	}
}
