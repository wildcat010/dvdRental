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
using System.Linq.Dynamic.Core;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.ProductionSchedule;
using WebHMI.Filters;
using WebHMI.Helpers;
using WebHMI.L2Adapter.Common;
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
        private readonly MatStructEntryService _matStructEntryService;

        private readonly IL2CommunicationHandler _l2Sender;
        private PrdbContext _prdbContext => _prdbContextProvider.GetDbContext();

        public ProductionScheduleAppService(
            IDbContextProvider<PrdbContext> prdbContextProvider,
            CommonAppService commonAppService,
            IL2CommunicationHandler l2Sender,
            MatStructEntryService matStructEntryService)
        {
            _prdbContextProvider = prdbContextProvider;
            _commonAppService = commonAppService;
            _l2Sender = l2Sender;
            _matStructEntryService = matStructEntryService;
        }

        [AbpAuthorize(Permissions.Pages_ProductionSchedule)]
        public async Task<PagedResultDto<ScheduledMaterialsDto>> GetScheduledMaterials(FilteredRequestDto input, string seqID, bool onlyInSchedule = true)
        {
            if (onlyInSchedule == true) //return material existing in production schedule (without already produced and removed)
            {
                return await ApplyFilter<HmiVProdsequence, ScheduledMaterialsDto>(
                   _prdbContext.HmiVProdsequences
                   .Where(x => x.Sequenceid == seqID)
                  .OrderBy(x => x.Majorno)
                  .ThenBy(x => x.Minorno),
                   input, ProductionScheduleMapper.ToScheduledMaterialsDto);

            }
            else //return all materials from sequence
            {
                return await ApplyFilter<HmiVProdsequenceComplete, ScheduledMaterialsDto>(
                  _prdbContext.HmiVProdsequenceCompletes
                  .Where(x => x.Sequenceid == seqID)
                  .OrderBy(x => x.Majorno)
                  .ThenBy(x => x.Minorno),
                  input, ProductionScheduleMapper.ToScheduledMaterialsDto);
            }
        }

        [AbpAuthorize(Permissions.Pages_ProductionSchedule)]
        public async Task<PagedResultDto<ScheduledMaterialsDto>> GetGhostMaterials(FilteredRequestDto input)
        {
            return await ApplyFilter<HmiVProdsequence, ScheduledMaterialsDto>(
                _prdbContext.HmiVProdsequences
                    .Where(x => x.Simmat == 1)
                    .OrderBy(x => x.Position)
                    .ThenBy(x => x.Majorno),
                input,
                ProductionScheduleMapper.ToScheduledMaterialsDto);
        }

        [AbpAuthorize(Permissions.Pages_ProductionSchedule)]
        public async Task<PagedResultDto<ScheduledMaterialsDto>> GetPlannedMaterials(FilteredRequestDto input)
        {
            return await ApplyFilter<HmiVProdsequence, ScheduledMaterialsDto>(
                _prdbContext.HmiVProdsequences
                    .Where(x => x.Simmat == 0)
                    .OrderBy(x => x.Position)
                    .ThenBy(x => x.Majorno),
                input,
                ProductionScheduleMapper.ToScheduledMaterialsDto);
        }

        [AbpAuthorize(Permissions.Pages_ProductionSchedule)]
        [Audited]
        public async Task<List<string>> GetMoveDestinationCoilCandidates(string steelGrade, string sequenceId)
        {
            var context = await _prdbContextProvider.GetDbContextAsync();
            var candidates = await context.HmiVProdsequences
                .Where(h =>
                    h.Sequenceid == sequenceId &&
                    h.Alloycode == steelGrade &&
                    h.Enorextid != null &&
                    !EF.Functions.Like(h.Enorextid, "%@%") &&
                    !EF.Functions.Like(h.Enorextid, "%#%")
                )
                .Select(x => x.Enorextid)
                .OrderBy(x => x)    
                .ToListAsync();
            return candidates;
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
        public async Task SyncL1(string heatId, string sequenceId, string materialId)
        {
            var context = _prdbContextProvider.GetDbContext();

            var length = context.HmiVProdsequenceCompletes.Where(x => x.Heatid == heatId && x.Sequenceid == sequenceId).Sum(x => x.Lexit) ?? 0.0f;
            var prodSeqCom = context.HmiVProdsequenceCompletes.Where(x => x.Heatid == heatId && x.Sequenceid == sequenceId && x.Enphextid == materialId).FirstOrDefault();
            if (prodSeqCom?.Simmat == 0)
                _l2Sender.NewHeatOperation(heatId, sequenceId, 1, (float)length);
            else
                _l2Sender.NewHeatSimulation(heatId, sequenceId, 1, (float)length);
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
        public async Task MoveMatInSeq(string connectionId, int enPhMeId1, int enPhMeId2, short location)
        {
            var vMatStructSrc = await _matStructEntryService.GetMaterialEntryStruct(enPhMeId1, "PH");
            var vMatStructDest = await _matStructEntryService.GetMaterialEntryStruct(enPhMeId2, "PH");

            _l2Sender.MoveMaterialInSequence(vMatStructSrc, vMatStructDest, location, connectionId);

        }

        [AbpAuthorize(Permissions.Pages_ProductionSchedule_Edit)]
        [Audited]
        public async Task SetNextMatInSchedule(string connectionId, int enPhMeId)
        {
            var vMatStruct = await _matStructEntryService.GetMaterialEntryStruct(enPhMeId, "PH");

            _l2Sender.SetNextMaterialInSchedule(vMatStruct, connectionId);

        }

        [AbpAuthorize(Permissions.Pages_ProductionSchedule)]
        public async Task<int> GetEnPhMeid(string extId, string sequenceId)
        {
            var context = await _prdbContextProvider.GetDbContextAsync();

            if (!await context.HmiVMatInfoShorts.AnyAsync(x => x.Enphextid == extId))
                throw new UserFriendlyException($"There is no {extId} extId in database");

            if (!await context.HmiVMatInfoShorts.AnyAsync(x => x.Sequenceid == sequenceId))
                throw new UserFriendlyException($"There is no material with sequenceId == {sequenceId}");

            var enphMeid = await context.HmiVMatInfoShorts.Where(x => x.Enphextid == extId && x.Sequenceid == sequenceId).FirstOrDefaultAsync();

            return enphMeid.Enphmeid;
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
                .Where(x => x.Sequenceid == sequenceId)
                .ToListAsync();

            if (matInfos.Count == 0)
                throw new EntityNotFoundException("Data for given sequence not found");

            return new SequenceOverviewDto
            {
                SequenceId = sequenceId,

                NoOfHeats = matInfos.Select(x => x.Heatid)
                                    .Distinct()
                                    .Count(),

                NoOfCoils = matInfos.Select(x => x.Enorextid)
                                    .Distinct()
                                    .Count(),

                RemNoOfCoils = matInfos.Where(x => x.Enphstatus < 0)
                                       .Select(x => x.Enorextid)
                                       .Distinct()
                                       .Count(),

                TotalCastLength = matInfos.Sum(x => x.Lentry),

                TotalRollLength = matInfos.Sum(x => x.Lexit),

                RemRollLength = matInfos.Where(x => x.Enphstatus < 0)
                                        .Sum(x => x.Lexit),

                MinThick = matInfos.Min(x => x.Hexit),

                WidthFrom = matInfos.Min(x => x.Wexit),

                WidthTo = matInfos.Max(x => x.Wexit),
            };
        }
    }
}
