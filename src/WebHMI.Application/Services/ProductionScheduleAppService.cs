using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.ProductionSchedule;
using WebHMI.Filters;
using WebHMI.Helpers;
using WebHMI.Mapping.Extensions;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;

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

        public async Task<PagedResultDto<ScheduledMaterialsDto>> GetScheduledMaterials(FilteredRequestDto input, string seqID)
        {
            return await ApplyFilter<HmiVProdsequenceComplete, ScheduledMaterialsDto>(
                _prdbContext.HmiVProdsequenceCompletes
                .Where(x => x.SequenceId == seqID)
                .OrderBy(x => x.Majorno)
                .ThenBy(x => x.Minorno)
                .ThenBy(x => x.Position),
                input, ProductionScheduleMapper.ToScheduledMaterialsDto);
        }

        public async Task<PagedResultDto<GhostDischargedMaterialsDto>> GetGhostMaterials(FilteredRequestDto input, string seqID)
        {
            return await ApplyFilter<HmiVProdsequenceComplete, GhostDischargedMaterialsDto>(
                _prdbContext.HmiVProdsequenceCompletes
                    .Where(x => x.SimMat == 1 && x.SequenceId == seqID)
                    .OrderBy(x => x.Majorno)
                    .ThenBy(x => x.Minorno)
                    .ThenBy(x => x.Position),
                input,
                ProductionScheduleMapper.ToGhostDischargedMaterialsDto);
        }

        [AbpAuthorize(Permissions.Pages_ProductionSchedule_Delete)]
        [Audited]
        public async Task DeleteMaterial(string connectionId, int enPhMeId)
        {
            //var context = _prdbContextProvider.GetDbContext();
            //var enPhExtId = await context.HmiVMatInfoShorts.Where(x => x.EnPhMeId == enPhMeId).Select(x => x.EnPhExtId).FirstOrDefaultAsync();

            //HmiReturn hmiReturn = HmiReturnFactory.CreateHmiReturn(connectionId, "deleteMatFromSeq", "psm");
            //var arguments = VariantArgumentFactory.GetProdScheduleArguments(enPhExtId, hmiReturn);

            //try
            //{
            //    Logger.Info("[Production Schedule] Requesting deleting slab from production sequence on module PSM");
            //    _l2CommunicationTask.SendTelegram(L2Process.psm, hmiReturn.functionName, arguments);
            //    Logger.Info("[Production Schedule] Operation executed and passed to L2");
            //}
            //catch (System.Exception ex)
            //{
            //    Logger.Error("Exception thrown when calling L2 Process", ex);
            //    throw new UserFriendlyException("Exception thrown when calling L2 Process");
            //}
        }

        [AbpAuthorize(Permissions.Pages_ProductionSchedule_Edit)]
        [Audited]
        public async Task SyncL1(string connectionId, int enPhMeId)
        {
            //var context = _dbContextProvider.GetDbContext();
            //var enPhExtId = await context.HmiVMatInfoShorts.Where(x => x.EnPhMeId == enPhMeId).Select(x => x.EnPhExtId).FirstOrDefaultAsync();

            //HmiReturn hmiReturn = HmiReturnFactory.CreateHmiReturn(connectionId, "addMatToSeq", "psm");
            //var arguments = VariantArgumentFactory.GetProdScheduleArguments(enPhExtId, hmiReturn);

            //try
            //{
            //    Logger.Info("[Production Schedule] Requesting appending a slab to production sequence on module PSM");
            //    _l2CommunicationTask.SendTelegram(L2Process.psm, hmiReturn.functionName, arguments);
            //    Logger.Info("[Production Schedule] Operation executed and passed to L2");
            //}
            //catch (System.Exception ex)
            //{
            //    Logger.Error("Exception thrown when calling L2 Process", ex);
            //    throw new UserFriendlyException("Exception thrown when calling L2 Process");
            //}
        }

        [Audited]
        public async Task RejectMaterial(int enPhMeId, string connectionId)
        {
            //HmiReturn hmiReturn = HmiReturnFactory.CreateHmiReturn(connectionId, "sendCoilRequest", "crm");
            //var arguments = VariantArgumentFactory.GetProdScheduleArguments(enPhExtId, hmiReturn);

            //try
            //{
            //    Logger.Info($"[Production Schedule] Requesting coil from production sequence on module CRM");
            //    _l2CommunicationTask.SendTelegram(L2Process.crm, hmiReturn.functionName, arguments);
            //    Logger.Info($"[Production Schedule] Operation executed and passed to L2");
            //}
            //catch (System.Exception ex)
            //{
            //    Logger.Error("Exception thrown when calling L2 Process", ex);
            //    throw new UserFriendlyException("Exception thrown when calling L2 Process");
            //}
        }

        [AbpAuthorize(Permissions.Pages_ProductionSchedule_Edit)]
        [Audited]
        public async Task MoveMaterialUp(string connectionId, int enPhMeId)
        {
           // var context = _prdbContextProvider.GetDbContext();
            //var enPhExtId = await context.HmiVMatInfoShorts.Where(x => x.EnPhMeId == enPhMeId).Select(x => x.EnPhExtId).FirstOrDefaultAsync();
            // move up/down functions intentionally swapped
            //HmiReturn hmiReturn = HmiReturnFactory.CreateHmiReturn(connectionId, "moveMatDown", "psm");
            //var arguments = VariantArgumentFactory.GetProdScheduleArguments(enPhExtId, hmiReturn);

            //try
            //{
            //    Logger.Info($"[Production Schedule] Requesting moving material down from production sequence on module PSM");
            //    _l2CommunicationTask.SendTelegram(L2Process.psm, hmiReturn.functionName, arguments);
            //    Logger.Info($"[Production Schedule] Operation executed and passed to L2");
            //}
            //catch (System.Exception ex)
            //{
            //    Logger.Error("Exception thrown when calling L2 Process", ex);
            //    throw new UserFriendlyException("Exception thrown when calling L2 Process");
            //}
        }

        [AbpAuthorize(Permissions.Pages_ProductionSchedule_Edit)]
        [Audited]
        public async Task MoveMaterialDown(string connectionId, int enPhMeId)
        {
            //var context = _prdbContextProvider.GetDbContext();
            //var enPhExtId = await context.HmiVMatInfoShorts.Where(x => x.EnPhMeId == enPhMeId).Select(x => x.EnPhExtId).FirstOrDefaultAsync();
            //// move up/down functions intentionally swapped
            //HmiReturn hmiReturn = HmiReturnFactory.CreateHmiReturn(connectionId, "moveMatUp", "psm");
            //var arguments = VariantArgumentFactory.GetProdScheduleArguments(enPhExtId, hmiReturn);

            //try
            //{
            //    Logger.Info($"[Production Schedule] Requesting moving material up from production sequence on module PSM");
            //    _l2CommunicationTask.SendTelegram(L2Process.psm, hmiReturn.functionName, arguments);
            //    Logger.Info($"[Production Schedule] Operation executed and passed to L2");
            //}
            //catch (System.Exception ex)
            //{
            //    Logger.Error("Exception thrown when calling L2 Process", ex);
            //    throw new UserFriendlyException("Exception thrown when calling L2 Process");
            //}
        }

        [AbpAuthorize(Permissions.Pages_ProductionSchedule_Edit)]
        [Audited]
        public async Task MoveMatInSeq(string connectionId, int enOrMeid1, int enOrMeid2, int location)
        {
            //var context = _prdbContextProvider.GetDbContext();

            //var enPhExtId1 = await context.HmiVMatInfoShorts.Where(x => x.EnPhMeId == enPhMeId1).Select(x => x.EnPhExtId).FirstOrDefaultAsync();
            //var enPhExtId2 = await context.HmiVMatInfoShorts.Where(x => x.EnPhMeId == enPhMeId2).Select(x => x.EnPhExtId).FirstOrDefaultAsync();

            //HmiReturn hmiReturn = HmiReturnFactory.CreateHmiReturn(connectionId, "moveMatInSeq", "psm");
            //var arguments = VariantArgumentFactory.GetProdScheduleArguments(enPhExtId1, enPhExtId2, hmiReturn);

            //try
            //{
            //    Logger.Info($"[Production Schedule] Requesting moving material in sequence from production sequence on module PSM");
            //    _l2CommunicationTask.SendTelegram(L2Process.psm, hmiReturn.functionName, arguments);
            //    Logger.Info($"[Production Schedule] Operation executed and passed to L2");
            //}
            //catch (System.Exception ex)
            //{
            //    Logger.Error("Exception thrown when calling L2 Process", ex);
            //    throw new UserFriendlyException("Exception thrown when calling L2 Process");
            //}
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
