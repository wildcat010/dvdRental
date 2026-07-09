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
        public async Task<MaterialOverviewCsDto> GetMaterialOverviewCS(int meid, string matType)
        {
            var dto = await _setpointsOverviewCache.GetAsync(new MaterialKey(meid, matType), async () =>
            {
                var entryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(meid, matType);

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

            var edOrdEntM = await context.Edordents.FirstOrDefaultAsync(x => x.Meid == vMatStructEntry.Enormeid && x.Source == "M");
            edOrdEntM = context.InsertIfNull(edOrdEntM, vMatStructEntry);
            edOrdEntM.Coiltemp = input.CoilTemp?.M;

            var csStartegyM = await context.Csstrategies.FirstOrDefaultAsync(x => x.Meid == vMatStructEntry.Enormeid && x.Source == "M");
            csStartegyM = context.InsertIfNull(csStartegyM, vMatStructEntry);
            csStartegyM.Coolingstrategy = input.CoolingStrategy?.M;
            csStartegyM.Ftzload = input.FtzLoad?.M;
            csStartegyM.StartvalvenumbertopInd0 = input.StartValveNumberTopInd0?.M;
            csStartegyM.StartvalvenumberbotInd0 = input.StartValveNumberBotInd0?.M;
            csStartegyM.CoolratetopInd0 = input.CoolRateTopInd0?.M;
            csStartegyM.CoolratebotInd0 = input.CoolRateBotInd0?.M;
            csStartegyM.Planno = input.CsStrategyPlanNo?.M;

            var csProfileM = await context.Csprofiles.FirstOrDefaultAsync(x => x.Meid == vMatStructEntry.Enormeid && x.Source == "M");
            csProfileM = context.InsertIfNull(csProfileM, vMatStructEntry);
            csProfileM.Lengthuncooledhead = input.LengthUncooledHead?.M;
            csProfileM.Lengthuncooledtail = input.LengthUncooledTail?.M;
            csProfileM.Lengthprofilehead = input.LengthProfileHead?.M;
            csProfileM.Lengthprofiletail = input.LengthProfileTail?.M;
            csProfileM.Coiltempprofilehead = input.CoilTempProfileHead?.M;
            csProfileM.Coiltempprofiletail = input.CoilTempProfileTail?.M;
            csProfileM.Planno = input.CsProfilePlanNo?.M;

            var csCrsM = await context.Cscrs.FirstOrDefaultAsync(x => x.Meid == vMatStructEntry.Enormeid && x.Source == "M");
            csCrsM = context.InsertIfNull(csCrsM, vMatStructEntry);
            csCrsM.Planno = input.CscrsPlanNo?.M;

            var csRtCoolingM = await context.Csrtcoolings.FirstOrDefaultAsync(x => x.Meid == vMatStructEntry.Enormeid && x.Source == "M");
            csRtCoolingM = context.InsertIfNull(csRtCoolingM, vMatStructEntry);
            csRtCoolingM.Planno = input.CsRtCoolingPlanNo?.M;

            var csPerfM = await context.Csperves.FirstOrDefaultAsync(x => x.Meid == vMatStructEntry.Enormeid && x.Source == "M");
            csPerfM = context.InsertIfNull(csPerfM, vMatStructEntry);
            csPerfM.Planno = input.CsPerfPlanNo?.M;

            await context.SaveChangesAsync();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task<SetpointsCsDto> GetSetpointsCS(int meid, string matType)
        {
            var dto = await _setpointsCache.GetAsync(new MaterialKey(meid, matType), async () =>
            {
                var entryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(meid, matType);

                var dataBlob = await GetSetpointsDataBlob(entryMatStruct);

                var result = new SetpointsCsDto()
                        .MapPreCalculation(dataBlob)
                        .MapCoolingStrategy(dataBlob);

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
        public async Task UpdateSetpointsCS(SetpointsCsDto input, string connectionId)
        {
            var context = _dbContextProvider.GetDbContext();
            var vMatStructEntry = await _matStructEntryService.GetMaterialEntryStruct(input.MeCode.MeId, "OR");

            var spOrd2pcM = await context.Spord2pcs.FirstOrDefaultAsync(x => x.Meid == vMatStructEntry.Enormeid && x.Source == "M");
            spOrd2pcM = context.InsertIfNull(spOrd2pcM, vMatStructEntry);
            spOrd2pcM.Vexitlas = input.PreCalculation.OrderData.Vexit?.M;

            var csPcResultM = await context.Cspcresults.FirstOrDefaultAsync(x => x.Meid == vMatStructEntry.Enormeid);
            if (csPcResultM == null)
            {
                csPcResultM = new Cspcresult()
                {
                    Meid = vMatStructEntry.Enormeid,
                    Mesid = (short)vMatStructEntry.Enormesid,
                    Mecreator = vMatStructEntry.Enorcreator
                };
            }
            csPcResultM.Wateramount = input.PreCalculation.OrderData.WaterAmount?.M;

            var csStrategyM = await context.Csstrategies.FirstOrDefaultAsync(x => x.Meid == vMatStructEntry.Enormeid && x.Source == "M");
            csStrategyM = context.InsertIfNull(csStrategyM, vMatStructEntry);
            csStrategyM.Planno = input.CoolingStrategyTab.PlanNo?.M;
            csStrategyM.StartvalvenumbertopInd0 = input.CoolingStrategyTab.StartValveNumberTopInd0?.M;
            csStrategyM.StartvalvenumberbotInd0 = input.CoolingStrategyTab.StartValveNumberBotInd0?.M;
            csStrategyM.CoolratetopInd0 = input.CoolingStrategyTab.CoolRateTopInd0?.M;
            csStrategyM.CoolratebotInd0 = input.CoolingStrategyTab.CoolRateBotInd0?.M;
            csStrategyM.TempoffsetaInd0 = input.CoolingStrategyTab.TempOffsetAInd0?.M;
            csStrategyM.TempoffsetbInd0 = input.CoolingStrategyTab.TempOffsetBInd0?.M;
            csStrategyM.AdaptationInd0 = input.CoolingStrategyTab.AdaptationInd0?.M;
            csStrategyM.LeadingpyroindexInd0 = input.CoolingStrategyTab.LeadingPyroIndexInd0?.M;
            csStrategyM.Targetf4tInd0 = input.CoolingStrategyTab.TargetF4TInd0?.M;
            csStrategyM.TargettempInd0 = input.CoolingStrategyTab.TargetTempInd0?.M;
            csStrategyM.Tempoffsetfma = input.CoolingStrategyTab.TempOffsetFma?.M;
            csStrategyM.Tempoffsetfma = input.CoolingStrategyTab.TempOffsetFmb?.M;
            csStrategyM.Adaptationfm = input.CoolingStrategyTab.AdaptationFm?.M;

            var csProfileM = await context.Csprofiles.FirstOrDefaultAsync(x => x.Meid == vMatStructEntry.Enormeid && x.Source == "M");
            csProfileM = context.InsertIfNull(csProfileM, vMatStructEntry);
            csProfileM.Planno = input.ProfileCoolingTab?.PlanNo.M;
            csProfileM.Lengthuncooledhead = input.ProfileCoolingTab?.LengthUncooledHead.M;
            csProfileM.Coiltempprofilehead = input.ProfileCoolingTab?.CoilTempProfileHead.M;
            csProfileM.Lengthprofilehead = input.ProfileCoolingTab?.LengthProfileHead.M;
            csProfileM.Lengthprofileheadwedge = input.ProfileCoolingTab?.LengthProfileHeadWedge.M;
            csProfileM.Lengthprofiletailwedge = input.ProfileCoolingTab?.LengthProfileTailWedge.M;
            csProfileM.Lengthprofiletail = input.ProfileCoolingTab?.LengthProfileTail.M;
            csProfileM.Coiltempprofiletail = input.ProfileCoolingTab?.CoilTempProfileTail.M;
            csProfileM.Lengthuncooledtail = input.ProfileCoolingTab?.LengthUncooledTail.M;

            await context.SaveChangesAsync();

            _l2CommunicationHandler.SetpointsCalculationHMI(vMatStructEntry, "HFM", connectionId);
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task<CsSetpointsPlansDto> GetSetpointsPlansList()
        {
            var context = await _dbContextProvider.GetDbContextAsync();
            var dto = new CsSetpointsPlansDto();
            
            dto.Coolings = await context.Stdcsstrategies
                .Where(x => x.Activeflag == 1)
                .OrderBy(x => x.Description)
                .Select(x => new StdPlanNoElementDto { PlanNo = x.Planno, PlanDesc = $"{x.Planno} - {x.Description}" })
                .ToListAsync();
            
            dto.ProfileCoolings = await context.Stdcsprofiles
                .Where(x => x.Activeflag == 1)
                .OrderBy(x => x.Description)
                .Select(x => new StdPlanNoElementDto { PlanNo = x.Planno, PlanDesc = $"{x.Planno} - {x.Description}" })
                .ToListAsync();

            dto.RollerTableCoolings = await context.Stdcsrtcoolings
                .Where(x => x.Activeflag == 1) 
                .OrderBy(x => x.Description)
                .Select(x => new StdPlanNoElementDto { PlanNo = x.Planno, PlanDesc = $"{x.Planno} - {x.Description}" })
                .ToListAsync();

            dto.CrossSprayss = await context.Stdcscrs
                .Where(x => x.Activeflag == 1) 
                .OrderBy(x => x.Description)
                .Select(x => new StdPlanNoElementDto { PlanNo = x.Planno, PlanDesc = $"{x.Planno} - {x.Description}" })
                .ToListAsync();

            dto.Perf = await context.Stdcsperves
                .Where(x => x.Activeflag == 1) 
                .OrderBy(x => x.Description)
                .Select(x => new StdPlanNoElementDto { PlanNo = x.Planno, PlanDesc = $"{x.Planno} - {x.Description}" })
                .ToListAsync();

            return dto;
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task<ProcessProtocolDto> GetProcessProtocolData(int meid)
        {
            var context = await _dbContextProvider.GetDbContextAsync();

            var csProtData = await context.Csprotdata.FirstOrDefaultAsync(x => x.Meid == meid);
            if (csProtData == null) 
                return null;
            var csTickData = await context.Csprotticks.Where(x => x.Meid == meid).ToListAsync();
            var csSimilarData = await context.Csprotsimilars.Where(x => x.Meid == meid && x.Seg == 0).ToListAsync();
            var vMatStructs = await context.Proddatacores.Where(x => csSimilarData.Select(x => x.Meidsim).Contains(x.Meid)).ToListAsync();
            var csSimilarDtos = csSimilarData.Join(vMatStructs, a => a.Meidsim, b => b.Meid, (a, b) => new CsSimilarStripsDto()
            {
                Produced = b.Prodend,
                ExtId = b.Coilid
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

        private async Task InvalidateMaterialCaches(long meId, string matType)
        {
            await _setpointsCache.RemoveAsync(new MaterialKey(meId, matType));
            await _setpointsOverviewCache.RemoveAsync(new MaterialKey(meId, matType));
        }

        private async Task InvalidateMaterialCache(long meId, string matType)
        {
            await _setpointsCache.RemoveAsync(new MaterialKey(meId, matType));
        }

        private async Task<SetpointsCsDataBlob> GetSetpointsDataBlob(VMatStructEntry entryMatStruct)
        {
            var context = await _dbContextProvider.GetDbContextAsync();
            string[] sources = { "L", "X", "M", "S", "P", "E" };

            return new()
            {
                SpOrd2Pcs = await context.Spord2pcs.Where(x => x.Meid == entryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Cspcresults = await context.Cspcresults.Where(x => x.Meid == entryMatStruct.Enormeid).AsNoTracking().ToListAsync(),
                CsStrategies = await context.Csstrategies.Where(x => x.Meid == entryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                CsProfiles = await context.Csprofiles.Where(x => x.Meid == entryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                CsPcCurves = await context.Cspccurves.Where(x => x.Meid == entryMatStruct.Enormeid).OrderBy(x => x.Distpoint).AsNoTracking().ToListAsync(),
                CsPcResult = await context.Cspcresults.AsNoTracking().FirstOrDefaultAsync(x => x.Meid == entryMatStruct.Enormeid),
                CsPcSpeedDiags = await context.Cspcspeeddiags.Where(x => x.Meid == entryMatStruct.Enormeid).OrderBy(x => x.Phaseindex).AsNoTracking().ToListAsync()
            };
        }

        private async Task<SetpointsCsOverviewDataBlob> GetSetpointsOverviewDataBlob(VMatStructEntry entryMatStruct)
        {
            var context = await _dbContextProvider.GetDbContextAsync();
            string[] sources = { "L", "X", "M", "S", "P", "E" };

            return new()
            {
                Edordents =await context.Edordents.Where(x=>x.Meid == entryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                SpOrd2Pcs = await context.Spord2pcs.Where(x => x.Meid == entryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                CsStrategies = await context.Csstrategies.Where(x => x.Meid == entryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                CsProfiles = await context.Csprofiles.Where(x => x.Meid == entryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                CsCrs = await context.Cscrs.Where(x => x.Meid == entryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                CsRtCoolings = await context.Csrtcoolings.Where(x => x.Meid == entryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                CsPerves = await context.Csperves.Where(x => x.Meid == entryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
            };
        }
    }
}
