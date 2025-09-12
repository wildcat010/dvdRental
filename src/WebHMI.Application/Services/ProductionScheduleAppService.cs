using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
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

    [AbpAuthorize(Permissions.Pages_ProductionSchedule)]
    public class ProductionScheduleAppService : ApplicationServiceBase
	{
		private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
		private readonly CommonAppService _commonAppService;
		private PrdbContext _prdbContext => _prdbContextProvider.GetDbContext();

        public ProductionScheduleAppService(
            IDbContextProvider<PrdbContext> prdbContextProvider, 
            CommonAppService commonAppService)
        {
            _prdbContextProvider = prdbContextProvider;
            _commonAppService = commonAppService;
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

        /// <summary>
        /// Returns aggregated sequence overview data.
        /// </summary>
        /// <param name="sequenceId">Sequence id, if not specified, then current one is taken</param>
        /// <returns>Overview data for specified or current sequence</returns>
        public async Task<SequenceOverviewDto> GetSequenceOverview(string sequenceId)
        {
            sequenceId ??= await _commonAppService.GetActualSequenceId();

            if (sequenceId == "-1")
                throw new UserFriendlyException("No current sequence, please provide sequence");

            var matInfos = await _prdbContext.HmiVMatInfoShorts
                .Where(x => x.SequenceId == sequenceId)
                .ToListAsync();

            if (matInfos.Count == 0)
                throw new EntityNotFoundException("Data for given sequence not found");

            return new SequenceOverviewDto
            {
                SequenceId = sequenceId,

                NoOfHeats = matInfos.Select(x => x.HeatId)
                                    .Distinct()
                                    .Count(),

                NoOfCoils = matInfos.Select(x => x.EnOrExtId)
                                    .Distinct()
                                    .Count(),

                RemNoOfCoils = matInfos.Where(x => x.EnPhStatus < 0)
                                       .Select(x => x.EnOrExtId)
                                       .Distinct()
                                       .Count(),

                TotalCastLength = matInfos.Sum(x => x.LEntry),

                TotalRollLength = matInfos.Sum(x => x.LExit),

                RemRollLength = matInfos.Where(x => x.EnPhStatus < 0)
                                        .Sum(x => x.LExit),

                MinThick = matInfos.Min(x => x.HExit),

                WidthFrom = matInfos.Min(x => x.WExit),

                WidthTo = matInfos.Max(x => x.WExit),
            };
        }
    }
}
