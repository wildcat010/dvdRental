using Abp.Auditing;
using Abp.Authorization;
using Abp.EntityFrameworkCore;
using Abp.Events.Bus.Handlers;
using Abp.Runtime.Caching;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebHMI.DataBlobs;
using WebHMI.Dtos;
using WebHMI.Dtos.Common;
using WebHMI.Dtos.Setpoints.SetpointsCS;
using WebHMI.EventWrapper;
using WebHMI.Helpers;
using WebHMI.L2Adapter.Common;
using WebHMI.Mapping.Extensions;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;
using XIDL;

namespace WebHMI.API.Services
{
    public class SetpointsCSService : ApplicationServiceBase, IAsyncEventHandler<EventWrapper<HmiRefreshDto>>
    {
        private readonly IDbContextProvider<PrdbContext> _dbContextProvider;
        private readonly MatStructEntryService _matStructEntryService;
        private readonly IL2CommunicationHandler _l2CommunicationHandler;
        private readonly ITypedCache<MaterialKey, SetpointsCsDto> _setpointsCache;
        private readonly ITypedCache<MaterialKey, MaterialOverviewCsDto> _setpointsOverviewCache;
        private readonly ITypedCache<string, HmiCsConfigData> _csConfigCache;
        private readonly string _csConfigCacheKey = "csConfigCacheKey";

        public SetpointsCSService(
            IDbContextProvider<PrdbContext> dbContextProvider,
            MatStructEntryService matStructEntryService,
            IL2CommunicationHandler l2CommunicationHandler,
            ICacheManager cacheManager)
        {
            _dbContextProvider = dbContextProvider;
            _setpointsCache = cacheManager.GetCache<MaterialKey, SetpointsCsDto>(nameof(SetpointsCsDto));
            _setpointsOverviewCache = cacheManager.GetCache<MaterialKey, MaterialOverviewCsDto>(nameof(MaterialOverviewCsDto));
            _csConfigCache = cacheManager.GetCache<string, HmiCsConfigData>(nameof(HmiCsConfigData));

            _matStructEntryService = matStructEntryService;
            _l2CommunicationHandler = l2CommunicationHandler;
        }

        public async Task HandleEventAsync(EventWrapper<HmiRefreshDto> eventData)
        {
            Logger.Debug($"[HandleEventAsync] HmiRefresh from L2 has beed received.");
            //Check if any data is received from L2
            if (eventData != null && eventData.Data.EventKey.Contains("SETPTCS"))
            {
                Logger.Debug($"[HandleEventAsync] HmiRefresh event key: {eventData.Data.EventKey}");
                if (eventData.Data.MeCode != null)
                {
                    Logger.Debug($"[HandleEventAsync]Ivalidating setpoints cache for material {eventData.Data.MeCode.ExtId}");
                    await InvalidateMaterialCaches(eventData.Data.MeCode.MeId, eventData.Data.MeCode.MatType);
                }
            }
            Logger.Debug($"[HandleEventAsync] Finished Processing HmiRefreshEventData event");
        }

        public async Task FlushAllCaches()
        {
            await _setpointsCache.ClearAsync();
            await _setpointsOverviewCache.ClearAsync();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task<MaterialOverviewCsDto> GetMaterialOverviewCS(int meId, string matType)
        {
            var dto = await _setpointsOverviewCache.GetAsync(new MaterialKey(meId, matType), async () =>
            {
                var entryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(meId, matType);

                var dataBlob = await GetSetpointsOverviewDataBlob(entryMatStruct);

                var result = new MaterialOverviewCsDto()
                        .MapOverview(dataBlob);

                result.MeCode = entryMatStruct.ToOrMeCodeDto();



                return result;
            });

            return dto;
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_Setpoints_CS_Edit)]
        public async Task UpdateMaterialOverview(MaterialOverviewCsDto input)
        {
            var context = _dbContextProvider.GetDbContext();

            var vMatStructEntry = await _matStructEntryService.GetMaterialEntryStruct(input.MeCode.MeId, "OR");

            var edOrdEntM = await context.EdOrdEnts.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            edOrdEntM = context.InsertIfNull(edOrdEntM, vMatStructEntry);
            edOrdEntM.CoilTemp = input.CoilTemp?.M;

            var csStartegyM = await context.CsStrategies.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            csStartegyM = context.InsertIfNull(csStartegyM, vMatStructEntry);
            csStartegyM.CoolingStrategy = input.CoolingStrategy?.M;
            csStartegyM.FtzLoad = input.FtzLoad?.M;
            csStartegyM.StartValveNumberTopInd0 = input.StartValveNumberTopInd0?.M;
            csStartegyM.StartValveNumberBotInd0 = input.StartValveNumberBotInd0?.M;
            csStartegyM.CoolRateTopInd0 = input.CoolRateTopInd0?.M;
            csStartegyM.CoolRateBotInd0 = input.CoolRateBotInd0?.M;
            csStartegyM.PlanNo = input.CsStrategyPlanNo?.M;

            var csProfileM = await context.CsProfiles.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            csProfileM = context.InsertIfNull(csProfileM, vMatStructEntry);
            csProfileM.LengthUncooledHead = input.LengthUncooledHead?.M;
            csProfileM.LengthUncooledTail = input.LengthUncooledTail?.M;
            csProfileM.LengthProfileHead = input.LengthProfileHead?.M;
            csProfileM.LengthProfileTail = input.LengthProfileTail?.M;
            csProfileM.CoilTempProfileHead = input.CoilTempProfileHead?.M;
            csProfileM.CoilTempProfileTail = input.CoilTempProfileTail?.M;
            csProfileM.PlanNo = input.CsProfilePlanNo?.M;

            var csCrsM = await context.CsCrs.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            csCrsM = context.InsertIfNull(csCrsM, vMatStructEntry);
            csCrsM.PlanNo = input.CscrsPlanNo?.M;

            var csRtCoolingM = await context.CsRtCoolings.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            csRtCoolingM = context.InsertIfNull(csRtCoolingM, vMatStructEntry);
            csRtCoolingM.PlanNo = input.CsRtCoolingPlanNo?.M;

            var csPerfM = await context.CsPerves.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            csPerfM = context.InsertIfNull(csPerfM, vMatStructEntry);
            csPerfM.PlanNo = input.CsPerfPlanNo?.M;

            await context.SaveChangesAsync();
        }

        //Function to get the CS Setpoints for a given material and type. The result is cached for performance.
        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task<SetpointsCsDto> GetSetpointsCS(int MeId, string matType)
        {
            var dto = await _setpointsCache.GetAsync(new MaterialKey(MeId, matType), async () =>
            {
                var entryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(MeId, matType);

                var dataBlob = await GetSetpointsDataBlob(entryMatStruct);

                var result = new SetpointsCsDto()
                        .MapPreCalculation(dataBlob)
                        .MapCoolingStrategy(dataBlob)
                        .MapProfileCooling(dataBlob);

                result.MeCode = entryMatStruct.ToOrMeCodeDto();

                return result;
            });

            return dto;
        }

        /// <summary>
        /// Updates CS Setpoints. Some properties are doubled and should be read-only.
        /// </summary>
        [Audited]
        [AbpAuthorize(Permissions.Pages_Setpoints_CS_Edit)]
        public async Task UpdateSetpointsCS(SetpointsCsDto input, string connectionId, bool pdiChanged = false)
        {
            var context = _dbContextProvider.GetDbContext();
            var vMatStructEntry = await _matStructEntryService.GetMaterialEntryStruct(input.MeCode.MeId, "OR");

            var spOrd2pcM = await context.SpOrd2Pcs.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            spOrd2pcM = context.InsertIfNull(spOrd2pcM, vMatStructEntry);
            spOrd2pcM.VExitLas = input.PreCalculation.OrderData.Vexit?.M;

            var csPcResultM = await context.CsPcResults.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId);
            if (csPcResultM == null)
            {
                csPcResultM = new CsPcResult()
                {
                    MeId = vMatStructEntry.EnOrMeId,
                    MesId = (short)vMatStructEntry.EnOrMesId,
                    MeCreator = vMatStructEntry.EnOrCreator
                };
            }
            csPcResultM.WaterAmount = input.PreCalculation.OrderData.WaterAmount?.M;

            var csStrategyM = await context.CsStrategies.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            csStrategyM = context.InsertIfNull(csStrategyM, vMatStructEntry);
            //csStrategyM.PlanNo = input.CoolingStrategyTab.PlanNo?.M; //plan number set in method UpdateMaterialOverview
            csStrategyM.StartValveNumberTopInd0 = input.CoolingStrategyTab.StartValveNumberTopInd0?.M;
            csStrategyM.StartValveNumberBotInd0 = input.CoolingStrategyTab.StartValveNumberBotInd0?.M;
            csStrategyM.StartValveNumberTopInd1 = input.CoolingStrategyTab.StartValveNumberTopInd1?.M;
            csStrategyM.StartValveNumberBotInd1 = input.CoolingStrategyTab.StartValveNumberBotInd1?.M;
            csStrategyM.CoolRateTopInd0 = input.CoolingStrategyTab.CoolRateTopInd0?.M;
            csStrategyM.CoolRateBotInd0 = input.CoolingStrategyTab.CoolRateBotInd0?.M;
            csStrategyM.CoolRateTopInd1 = input.CoolingStrategyTab.CoolRateTopInd1?.M;
            csStrategyM.CoolRateBotInd1 = input.CoolingStrategyTab.CoolRateBotInd1?.M;
            csStrategyM.TempOffsetAInd0 = input.CoolingStrategyTab.TempOffsetAInd0?.M;
            csStrategyM.TempOffsetBInd0 = input.CoolingStrategyTab.TempOffsetBInd0?.M;
            csStrategyM.TempOffsetAInd1 = input.CoolingStrategyTab.TempOffsetAInd1?.M;
            csStrategyM.TempOffsetBInd1 = input.CoolingStrategyTab.TempOffsetBInd1?.M;
            csStrategyM.AdaptationInd0 = input.CoolingStrategyTab.AdaptationInd0?.M;
            csStrategyM.AdaptationInd1 = input.CoolingStrategyTab.AdaptationInd1?.M;
            csStrategyM.LeadingPyroIndexInd0 = input.CoolingStrategyTab.LeadingPyroIndexInd0?.M;
            csStrategyM.LeadingPyroIndexInd1 = input.CoolingStrategyTab.LeadingPyroIndexInd1?.M;
            csStrategyM.TargetF4tInd0 = input.CoolingStrategyTab.TargetF4TInd0?.M;
            csStrategyM.TargetF4tInd1 = input.CoolingStrategyTab.TargetF4TInd1?.M;
            csStrategyM.TargetTempInd0 = input.CoolingStrategyTab.TargetTempInd0?.M;
            csStrategyM.TargetTempInd1 = input.CoolingStrategyTab.TargetTempInd1?.M;
            csStrategyM.TempOffsetFmA = input.CoolingStrategyTab.TempOffsetFma?.M;
            csStrategyM.TempOffsetFmB = input.CoolingStrategyTab.TempOffsetFmb?.M;
            csStrategyM.AdaptationFm = input.CoolingStrategyTab.AdaptationFm?.M;
            csStrategyM.AutoSplineTempTransition = input.CoolingStrategyTab.AutoSplineTempTransition?.M;
            csStrategyM.AutoSplineValueLowTop = input.CoolingStrategyTab.AutoSplineValueLowTop?.M;
            csStrategyM.AutoSplineValueLowBot = input.CoolingStrategyTab.AutoSplineValueLowBot?.M;

            var csProfileM = await context.CsProfiles.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            csProfileM = context.InsertIfNull(csProfileM, vMatStructEntry);
            //csProfileM.PlanNo = input.ProfileCoolingTab?.PlanNo.M; //plan number set in method UpdateMaterialOverview
            csProfileM.LengthUncooledHead = input.ProfileCoolingTab?.LengthUncooledHead.M;
            csProfileM.CoilTempProfileHead = input.ProfileCoolingTab?.CoilTempProfileHead.M;
            csProfileM.LengthProfileHead = input.ProfileCoolingTab?.LengthProfileHead.M;
            csProfileM.LengthProfileHeadWedge = input.ProfileCoolingTab?.LengthProfileHeadWedge.M;
            csProfileM.LengthProfileTailWedge = input.ProfileCoolingTab?.LengthProfileTailWedge.M;
            csProfileM.LengthProfileTail = input.ProfileCoolingTab?.LengthProfileTail.M;
            csProfileM.CoilTempProfileTail = input.ProfileCoolingTab?.CoilTempProfileTail.M;
            csProfileM.LengthUncooledTail = input.ProfileCoolingTab?.LengthUncooledTail.M;

            await context.SaveChangesAsync();

            if (pdiChanged)
                _l2CommunicationHandler.EntryDataChange(vMatStructEntry, connectionId);
            else
                _l2CommunicationHandler.SetpointsCalculationHMI(vMatStructEntry, "HFM", connectionId);
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task<CsSetpointsPlansDto> GetSetpointsPlansList()
        {
            var context = await _dbContextProvider.GetDbContextAsync();
            var dto = new CsSetpointsPlansDto();
            
            dto.Coolings = await context.StdCsStrategies
                .Where(x => x.ActiveFlag == 1)
                .OrderBy(x => x.Description)
                .Select(x => new StdPlanNoElementDto { PlanNo = x.PlanNo, PlanDesc = $"{x.PlanNo} - {x.Description}" })
                .ToListAsync();
            
            dto.ProfileCoolings = await context.StdCsProfiles
                .Where(x => x.ActiveFlag == 1)
                .OrderBy(x => x.Description)
                .Select(x => new StdPlanNoElementDto { PlanNo = x.PlanNo, PlanDesc = $"{x.PlanNo} - {x.Description}" })
                .ToListAsync();

            dto.RollerTableCoolings = await context.StdCsRtCoolings
                .Where(x => x.ActiveFlag == 1) 
                .OrderBy(x => x.Description)
                .Select(x => new StdPlanNoElementDto { PlanNo = x.PlanNo, PlanDesc = $"{x.PlanNo} - {x.Description}" })
                .ToListAsync();

            dto.CrossSprayss = await context.StdCsCrs
                .Where(x => x.ActiveFlag == 1) 
                .OrderBy(x => x.Description)
                .Select(x => new StdPlanNoElementDto { PlanNo = x.PlanNo, PlanDesc = $"{x.PlanNo} - {x.Description}" })
                .ToListAsync();

            dto.Perf = await context.StdCsPerves
                .Where(x => x.ActiveFlag == 1) 
                .OrderBy(x => x.Description)
                .Select(x => new StdPlanNoElementDto { PlanNo = x.PlanNo, PlanDesc = $"{x.PlanNo} - {x.Description}" })
                .ToListAsync();

            return dto;
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task<ProcessProtocolDto> GetProcessProtocolData(int MeId)
        {
            var context = await _dbContextProvider.GetDbContextAsync();

            var csProtData = await context.CsProtData.FirstOrDefaultAsync(x => x.MeId == MeId);
            if (csProtData == null) 
                return null;
            var csTickData = await context.CsProtTicks.Where(x => x.MeId == MeId).ToListAsync();
            var csSimilarData = await context.CsProtSimilars.Where(x => x.MeId == MeId && x.Seg == 0).ToListAsync();
            var vMatStructs = await context.ProdDataCores.Where(x => csSimilarData.Select(x => x.MeIdSim).Contains(x.MeId)).ToListAsync();
            var csSimilarDtos = csSimilarData.Join(vMatStructs, a => a.MeIdSim, b => b.MeId, (a, b) => new CsSimilarStripsDto()
            {
                Produced = b.ProdEnd,
                ExtId = b.CoilId
            }).ToList();
            return new ProcessProtocolDto().Map(csProtData, csTickData, csSimilarDtos);
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task<HmiCsConfigData> GetCsVisualisationConfig()
        {
            return await _csConfigCache.GetAsync(_csConfigCacheKey, async () =>
            {
                var result = new HmiCsConfigData();
                _l2CommunicationHandler.fillCsConfigurationSync(ref result);
                return result;
            });
        }

        /// <summary>
        /// possible values for type 0 = topvalve, 1=bottomValve, 2=crossSpray, 3=drainalveCs, 4=drainValveFm, 5=airblower, 6=rollerTableCooling
        /// </summary>
        public void TakeOverManualValveState(int idx, [FromQuery] HmiCsValveColors manualValveState, int type)
        {
            _l2CommunicationHandler.takeOverManualValveState(idx, manualValveState, type);
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS_Edit)]
        public void UpdateValveState(UpdateValveStateDto updateValveStateDto)
        {
            _l2CommunicationHandler.takeOverManualValveState(updateValveStateDto.ValveId, updateValveStateDto.ManualValveState, updateValveStateDto.Type);
        }

        /// <summary>
        /// possible values for type 0 = topvalve, 1=bottomValve, 2=crossSpray, 3=drainalveCs, 4=drainValveFm, 5=airblower, 6=rollerTableCooling
        /// </summary>
        [AbpAuthorize(Permissions.Pages_Setpoints_CS_Edit)]
        public void BulkUpdateValveState(List<UpdateValveStateDto> bulkDto)
        {
            foreach (var valve in bulkDto)
                _l2CommunicationHandler.takeOverManualValveState(valve.ValveId, valve.ManualValveState, valve.Type);
        }

        private async Task InvalidateMaterialCaches(long MeId, string matType)
        {
            await _setpointsCache.RemoveAsync(new MaterialKey(MeId, matType));
            await _setpointsOverviewCache.RemoveAsync(new MaterialKey(MeId, matType));
        }

        private async Task InvalidateMaterialCache(long MeId, string matType)
        {
            await _setpointsCache.RemoveAsync(new MaterialKey(MeId, matType));
        }

        private async Task<SetpointsCsDataBlob> GetSetpointsDataBlob(VMatStructEntry entryMatStruct)
        {
            var context = await _dbContextProvider.GetDbContextAsync();
            string[] sources = { "L", "X", "M", "S", "P", "E" };

            return new()
            {
                SpOrd2Pcs = await context.SpOrd2Pcs.Where(x => x.MeId == entryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Cspcresults = await context.CsPcResults.Where(x => x.MeId == entryMatStruct.EnOrMeId).AsNoTracking().ToListAsync(),
                CsStrategies = await context.CsStrategies.Where(x => x.MeId == entryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                CsProfiles = await context.CsProfiles.Where(x => x.MeId == entryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                CsPcCurves = await context.CspcCurves.Where(x => x.MeId == entryMatStruct.EnOrMeId).OrderBy(x => x.DistPoint).AsNoTracking().ToListAsync(),
                CsPcResult = await context.CsPcResults.AsNoTracking().FirstOrDefaultAsync(x => x.MeId == entryMatStruct.EnOrMeId),
                CsPcSpeedDiags = await context.CsPcSpeedDiags.Where(x => x.MeId == entryMatStruct.EnOrMeId).OrderBy(x => x.PhaseIndex).AsNoTracking().ToListAsync()
            };
        }

        private async Task<SetpointsCsOverviewDataBlob> GetSetpointsOverviewDataBlob(VMatStructEntry entryMatStruct)
        {
            var context = await _dbContextProvider.GetDbContextAsync();
            string[] sources = { "L", "X", "M", "S", "P", "E" };

            return new()
            {
                Edordents =await context.EdOrdEnts.Where(x=>x.MeId == entryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                SpOrd2Pcs = await context.SpOrd2Pcs.Where(x => x.MeId == entryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                CsStrategies = await context.CsStrategies.Where(x => x.MeId == entryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                CsProfiles = await context.CsProfiles.Where(x => x.MeId == entryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                CsCrs = await context.CsCrs.Where(x => x.MeId == entryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                CsRtCoolings = await context.CsRtCoolings.Where(x => x.MeId == entryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                CsPerves = await context.CsPerves.Where(x => x.MeId == entryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
            };
        }
    }
}
