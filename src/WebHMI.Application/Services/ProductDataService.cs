using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using WebHMI.PRDB.Dbo;

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
        public async Task<PagedResultDto<ProductionHistoryDto>> GetProductsHistory(FilteredRequestDto input, string sequenceId)
        {
            try
            {
                var context = await _dbContextProvider.GetDbContextAsync();
                var query = context.HmiVProductionHistories.AsQueryable();
                if (!string.IsNullOrEmpty(sequenceId))
                    query = query.Where(x => x.Sequenceid == sequenceId);

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
            var prodData = await context.HmiVProductionHistories.FirstOrDefaultAsync(x => x.Meid == entryMatStruct.Enormeid);

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

            var prodHist = context.HmiVProductionHistories.AsQueryable();

            if (sequenceId != "-1")
                prodHist = prodHist.Where(x => x.Sequenceid == sequenceId);

            if (timeFrom != null)
                prodHist = prodHist.Where(x => x.Prodstart >= timeFrom);

            if (timeTo != null)
                prodHist = prodHist.Where(x => x.Prodend <= timeTo);

            var overviewData = await prodHist.ToListAsync();

            if (overviewData.Count == 0)
                throw new EntityNotFoundException("Data for given sequence not found");

            return new SequenceOverviewDto
            {
                SequenceId = sequenceId,

                NoOfHeats = overviewData.Select(x => x.Heatid1)
                                    .Distinct()
                                    .Count(),

                NoOfCoils = overviewData.Select(x => x.Meid)
                                    .Distinct()
                                    .Count(),

                TotalRollLength = overviewData.Sum(x => x.Coillengthx),


                MinThick = overviewData.Min(x => x.Hexit),

                WidthFrom = overviewData.Min(x => x.Wexit),

                WidthTo = overviewData.Max(x => x.Wexit),
            };
        }

        public async Task<List<KeyValuePair<string, SingleProdSequenceThicknessWidth>>> GetProductionHistoryPlot(string sequenceId)
        {
            var context = await _dbContextProvider.GetDbContextAsync();
            if (string.IsNullOrEmpty(sequenceId))
                sequenceId = context.HmiVProductionHistories.OrderByDescending(x => x.Prodend).Distinct().Select(x => x.Sequenceid).Skip(1).FirstOrDefault();
            var prodHist = context.HmiVProductionHistories.AsQueryable();
            if (sequenceId != "-1")
                prodHist = prodHist.Where(x => x.Sequenceid == sequenceId);
            var overviewData = await prodHist
                .Select(x => new KeyValuePair<string, SingleProdSequenceThicknessWidth>(
                    x.Coilid,
                    new SingleProdSequenceThicknessWidth
                    {
                        EntryThickness = x.Texitcsaver,
                        Width = x.Wexitaver,
                        HeatId = x.Heatid1,
                        SeqId = x.Sequenceid,
                    }))
                .ToListAsync();
            if (overviewData.Count == 0)
                throw new EntityNotFoundException("Data for given sequence not found");

            return overviewData;
        }
    }
}
