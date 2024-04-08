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

        public async Task<PagedResultDto<ScheduledMaterialsDto>> GetScheduledMaterials(FilteredRequestDto input)
        {
            return await ApplyFilter(
                _prdbContext.HmiVProdsequences, 
                input, 
                ProductionScheduleMapper.ToScheduledMaterialsDto);
        }

        public async Task<PagedResultDto<GhostDischargedMaterialsDto>> GetGhostMaterials(FilteredRequestDto input)
        {
            return await ApplyFilter(
                _prdbContext.HmiVMatInfoShorts
                    .Where(x => x.SimMat == 1),
                input,
                ProductionScheduleMapper.ToGhostDischargedMaterialsDto);
        }

        public async Task<PagedResultDto<GhostDischargedMaterialsDto>> GetDischargedSlabs(FilteredRequestDto input)
        {
            return await ApplyFilter(
                _prdbContext.HmiVMatInfoShorts
                    .Where(x => x.SimMat == 1 && x.EnPhStatus >= 1)
                    .OrderByDescending(x => x.ProdStartTime),
                input,
                ProductionScheduleMapper.ToGhostDischargedMaterialsDto);
        }
        
        public async Task<PagedResultDto<RemovedMaterialsDto>> GetRemovedMaterials(FilteredRequestDto input)
        {
            return await ApplyFilter(
                _prdbContext.HmiVRemovedMaterials
                    .Where(x => x.SimMat == 0)
                    .OrderByDescending(x => x.RejectTime),
                input,
                ProductionScheduleMapper.ToRemovedMaterialsDto);
        }
    }
}
