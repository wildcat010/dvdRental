using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebHMI.Core.Widget.Models;
using WebHMI.Dtos.ProductData;
using WebHMI.Dtos.ProductionSchedule;
using WebHMI.Filters;
using WebHMI.Helpers;
using WebHMI.Mapping.Extensions;
using WebHMI.PRDB;

namespace WebHMI.Services
{
    [AbpAuthorize(Permissions.Pages_ProductionSchedule)]
    public class ProductDataService : ApplicationServiceBase
    {
        private readonly IDbContextProvider<PrdbContext> _dbContextProvider;
        private readonly MatStructEntryService _matStructEntryService;
        private readonly CommonAppService _commonAppService;

        public ProductDataService(IDbContextProvider<PrdbContext> dbContextProvider,
            MatStructEntryService matStructEntryService,
            CommonAppService commonAppService)
        {
            _commonAppService = commonAppService;
            _dbContextProvider = dbContextProvider;
            _matStructEntryService = matStructEntryService;
        }

        [AbpAuthorize(Permissions.Pages_ProductHistory)]
        public async Task<PagedResultDto<ProductionHistoryDto>> GetProductsHistory(FilteredRequestDto input, string sequenceId, DateTime? timeFrom, DateTime? timeTo)
        {
            try
            {
                var context = await _dbContextProvider.GetDbContextAsync();
                var query = context.HmiVProductionHistories.AsQueryable();
                if (string.IsNullOrEmpty(sequenceId))
                    query = query.Where(x => x.Sequenceid == sequenceId);

                if (timeFrom != null)
                    query = query.Where(x => x.Prodstart >= timeFrom);

                if (timeTo != null)
                    query = query.Where(x => x.Prodend <= timeTo);

                return await ApplyFilter(
                    query,
                    input,
                    ProductDataMapper.MapToDto);
            }
            catch (Exception ex)
            {
                Logger.Error("Exception occured during processing request", ex);
                throw new UserFriendlyException($"Exception occured during processing request. {ex.Message}");
            }
        }

        [AbpAuthorize(Permissions.Pages_ProductHistory)]
        public async Task<ProductionHistoryDto> GetProductDataAsync(int meId, string matType)
        {
            var context = await _dbContextProvider.GetDbContextAsync();

            var entryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(meId, matType);
            var prodData = await context.HmiVProductionHistories.FirstOrDefaultAsync(x => x.Meid == entryMatStruct.EnOrMeId);

            if (prodData is null)
            {
                // no annoying exception throw new EntityNotFoundException("Product data not found in the database.");
            }

            return prodData
                .MapToDto();
        }

        public async Task<SequenceOverviewDto> GetSequenceOverview(string sequenceId, DateTime? timeFrom, DateTime? timeTo)
        {
            var context = await _dbContextProvider.GetDbContextAsync();
            sequenceId ??= await _commonAppService.GetActualSequenceId();

            var query = context.HmiVProductionHistories.AsQueryable();

            if (string.IsNullOrEmpty(sequenceId))
                query = query.Where(x => x.Sequenceid == sequenceId);

            if (timeFrom != null)
                query = query.Where(x => x.Prodstart >= timeFrom);

            if (timeTo != null)
                query = query.Where(x => x.Prodend <= timeTo);

            var overviewData = await query.ToListAsync();

            if (overviewData.Count == 0)
                return new SequenceOverviewDto();

            return new SequenceOverviewDto
            {
                SequenceId = sequenceId,

                NoOfHeats = overviewData.Select(x => x.HeatId1)
                                    .Distinct()
                                    .Count(),

                NoOfCoils = overviewData.Select(x => x.Meid)
                                    .Distinct()
                                    .Count(),

                TotalRollLength = overviewData.Sum(x => x.CoilLengthX),


                MinThick = overviewData.Min(x => x.HExit),

                WidthFrom = overviewData.Min(x => x.WExit),

                WidthTo = overviewData.Max(x => x.WExit),
            };
        }

        public async Task<List<KeyValuePair<string, SingleProdSequenceThicknessWidth>>> GetProductionHistoryPlot(string sequenceId, DateTime? timeFrom, DateTime? timeTo)
        {
            var context = await _dbContextProvider.GetDbContextAsync();
            if (string.IsNullOrEmpty(sequenceId))
                sequenceId = context.HmiVProductionHistories.OrderByDescending(x => x.Prodend).Distinct().Select(x => x.Sequenceid).Skip(1).FirstOrDefault();
            var query = context.HmiVProductionHistories.AsQueryable();

            if (string.IsNullOrEmpty(sequenceId))
                query = query.Where(x => x.Sequenceid == sequenceId);

            if (timeFrom != null)
                query = query.Where(x => x.Prodstart >= timeFrom);

            if (timeTo != null)
                query = query.Where(x => x.Prodend <= timeTo);
            var overviewData = await query
                .Select(x => new KeyValuePair<string, SingleProdSequenceThicknessWidth>(
                    x.CoilId,
                    new SingleProdSequenceThicknessWidth
                    {
                        EntryThickness = x.TExitCsaver,
                        Width = x.WExitAver,
                        HeatId = x.HeatId1,
                        SeqId = x.SequenceId,
                    }))
                .ToListAsync();
            if (overviewData.Count == 0)
                throw new EntityNotFoundException("Data for given sequence not found");

            return overviewData;
        }
    }
}
