using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebHMI.DataBlobs;
using WebHMI.Dtos.Setpoints.SetpointsCS;
using WebHMI.Dtos.Setpoints.SetpointsHRM;
using WebHMI.Helpers;
using WebHMI.L2Adapter.Common;
using WebHMI.L2Adapter.Senders;
using WebHMI.Mapping.Extensions;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;
using WebHMI.WebHMI.Migrations;

namespace WebHMI.Services
{
    public class SetpointsCSAppService : ApplicationServiceBase
    {
        private readonly MatStructEntryService _matStructEntryService;
        private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
        private readonly IL2CommunicationHandler _l2Sender;
        private readonly short _standCount = 4;

        public SetpointsCSAppService(
            MatStructEntryService matStructEntryService,
            IDbContextProvider<PrdbContext> prdbContextProvider,
            IL2CommunicationHandler l2Sender)
        {
            _matStructEntryService = matStructEntryService;
            _prdbContextProvider = prdbContextProvider;
            _l2Sender = l2Sender;
        }



        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task<CSMaterialOverviewDto> GetMaterialOverview(int meid, string matType)
        {
            var result = new CSMaterialOverviewDto();
            var hmiVEntryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(meid, matType);

            var dataBlob = await GetDataBlob(hmiVEntryMatStruct);

            result.MeCode = hmiVEntryMatStruct.ToMeCodeDto();
            result.MapOverview(dataBlob);

            return result;
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_Setpoints_CS_Edit)]
        public async Task UpdateMaterialOverview(CSMaterialOverviewDto input)
        {
            var context = _prdbContextProvider.GetDbContext();

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

        }

        [AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        public async Task<SetpointsCSDto> GetSetpointsCS(int meid, string matType)
        {
            var result = new SetpointsCSDto();
            var hmiVEntryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(meid, matType);

            var dataBlob = await GetDataBlob(hmiVEntryMatStruct);

            result.MeCode = hmiVEntryMatStruct.ToMeCodeDto();
            result.MapPreCalculation(dataBlob);
            result.MapCoolingStrategy(dataBlob);
            result.MapProfileCooling(dataBlob);

            return result;
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_Setpoints_CS_Edit)]
        public async Task UpdateSetpointsCS(SetpointsCSDto input)
        {
            var context = _prdbContextProvider.GetDbContext();
            var vMatStructEntry = await _matStructEntryService.GetMaterialEntryStruct(input.MeCode.MeId, "OR");

            var spOrd2pcM = await context.SpOrd2Pcs.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            spOrd2pcM = context.InsertIfNull(spOrd2pcM, vMatStructEntry);
            spOrd2pcM.VExitLas = input.PreCalculationTab.Vexitlas?.M;

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
            csPcResultM.WaterAmount = input.PreCalculationTab.Wateramount?.M;

            var csStrategyM = await context.CsStrategies.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            csStrategyM = context.InsertIfNull(csStrategyM, vMatStructEntry);
            csStrategyM.PlanNo = input.CoolingStrategyTab.PlanNo?.M;
            csStrategyM.StartValveNumberTopInd0 = input.CoolingStrategyTab.StartValveNumberTopInd0?.M;
            csStrategyM.StartValveNumberBotInd0 = input.CoolingStrategyTab.StartValveNumberBotInd0?.M;
            csStrategyM.CoolRateTopInd0 = input.CoolingStrategyTab.CoolRateTopInd0?.M;
            csStrategyM.CoolRateBotInd0 = input.CoolingStrategyTab.CoolRateBotInd0?.M;
            csStrategyM.TempOffsetAInd0 = input.CoolingStrategyTab.TempOffsetAInd0?.M;
            csStrategyM.TempOffsetBInd0 = input.CoolingStrategyTab.TempOffsetBInd0?.M;
            csStrategyM.AdaptationInd0 = input.CoolingStrategyTab.AdaptationInd0?.M;
            csStrategyM.LeadingPyroIndexInd0 = input.CoolingStrategyTab.LeadingPyroIndexInd0?.M;
            csStrategyM.TargetF4tInd0 = input.CoolingStrategyTab.TargetF4TInd0?.M;
            csStrategyM.TargetTempInd0 = input.CoolingStrategyTab.TargetTempInd0?.M;
            csStrategyM.StartValveNumberTopInd1 = input.CoolingStrategyTab.StartValveNumberTopInd1?.M;
            csStrategyM.StartValveNumberBotInd1 = input.CoolingStrategyTab.StartValveNumberBotInd1?.M;
            csStrategyM.CoolRateTopInd1 = input.CoolingStrategyTab.CoolRateTopInd1?.M;
            csStrategyM.CoolRateBotInd1 = input.CoolingStrategyTab.CoolRateBotInd1?.M;
            csStrategyM.TempOffsetAInd1 = input.CoolingStrategyTab.TempOffsetAInd1?.M;
            csStrategyM.TempOffsetBInd1 = input.CoolingStrategyTab.TempOffsetBInd1?.M;
            csStrategyM.AdaptationInd1 = input.CoolingStrategyTab.AdaptationInd1?.M;
            csStrategyM.LeadingPyroIndexInd1 = input.CoolingStrategyTab.LeadingPyroIndexInd1?.M;
            csStrategyM.TargetF4tInd1 = input.CoolingStrategyTab.TargetF4TInd1?.M;
            csStrategyM.TargetTempInd1 = input.CoolingStrategyTab.TargetTempInd1?.M;
            csStrategyM.AutoSplineValueLowTop = input.CoolingStrategyTab.AutoSplineValueLowTop?.M;
            csStrategyM.AutoSplineValueLowBot = input.CoolingStrategyTab.AutoSplineValueLowBot?.M;
            csStrategyM.AutoSplineTempTransition = input.CoolingStrategyTab.AutoSplineTempTransition?.M;
            csStrategyM.TempOffsetFmA = input.CoolingStrategyTab.TempOffsetFma?.M;
            csStrategyM.TempOffsetFmB = input.CoolingStrategyTab.TempOffsetFmb?.M;
            csStrategyM.AdaptationFm = input.CoolingStrategyTab.AdaptationFm?.M;

            var csProfileM = await context.CsProfiles.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            csProfileM = context.InsertIfNull(csProfileM, vMatStructEntry);
            csProfileM.PlanNo = input.ProfileCoolingTab?.PlanNo.M;
            csProfileM.LengthUncooledHead = input.ProfileCoolingTab?.LengthUncooledHead.M;
            csProfileM.CoilTempProfileHead = input.ProfileCoolingTab?.CoilTempProfileHead.M;
            csProfileM.LengthProfileHead = input.ProfileCoolingTab?.LengthProfileHead.M;
            csProfileM.LengthProfileHeadWedge = input.ProfileCoolingTab?.LengthProfileHeadWedge.M;
            csProfileM.LengthProfileTailWedge = input.ProfileCoolingTab?.LengthProfileTailWedge.M;
            csProfileM.LengthProfileTail = input.ProfileCoolingTab?.LengthProfileTail.M;
            csProfileM.CoilTempProfileTail = input.ProfileCoolingTab?.CoilTempProfileTail.M;
            csProfileM.LengthUncooledTail = input.ProfileCoolingTab?.LengthUncooledTail.M;

        }

        //[AbpAuthorize(Permissions.Pages_Setpoints_CS)]
        //public async Task<CsSetpointsPlansDto> GetSetpointsPlansList()
        //{
        //    var dto = new CsSetpointsPlansDto();

        //    dto.Coolings = await _stdCsstrategyRepository.GetAll()
        //        .Where(x => x.Activeflag == 1)
        //        .OrderBy(x => x.Description)
        //        .Select(x => new StdPlanNoElementDto { PlanNo = x.Planno, PlanDesc = $"{x.Planno} - {x.Description}" })
        //        .ToListAsync();

        //    dto.ProfileCoolings = await _stdCsprofileRepository.GetAll()
        //        .Where(x => x.Activeflag == 1)
        //        .OrderBy(x => x.Description)
        //        .Select(x => new StdPlanNoElementDto { PlanNo = x.Planno, PlanDesc = $"{x.Planno} - {x.Description}" })
        //        .ToListAsync();

        //    dto.RollerTableCoolings = await _stdCsRtCoolingRepository.GetAll()
        //        .Where(x => x.Activeflag == 1)
        //        .OrderBy(x => x.Description)
        //        .Select(x => new StdPlanNoElementDto { PlanNo = x.Planno, PlanDesc = $"{x.Planno} - {x.Description}" })
        //        .ToListAsync();

        //    dto.CrossSprayss = await _stdCscrRepository.GetAll()
        //        .Where(x => x.Activeflag == 1)
        //        .OrderBy(x => x.Description)
        //        .Select(x => new StdPlanNoElementDto { PlanNo = x.Planno, PlanDesc = $"{x.Planno} - {x.Description}" })
        //        .ToListAsync();

        //    dto.Perf = await _stdcsperfRepository.GetAll()
        //        .Where(x => x.Activeflag == 1)
        //        .OrderBy(x => x.Description)
        //        .Select(x => new StdPlanNoElementDto { PlanNo = x.Planno, PlanDesc = $"{x.Planno} - {x.Description}" })
        //        .ToListAsync();

        //    dto.EdgeMask = await _stdcsedgemaskingRepository.GetAll()
        //        .Where(x => x.Activeflag == 1)
        //        .OrderBy(x => x.Description)
        //        .Select(x => new StdPlanNoElementDto { PlanNo = x.Planno, PlanDesc = $"{x.Planno} - {x.Description}" })
        //        .ToListAsync();

        //    return dto;
        //}

        private async Task<SetpointsCSDataBlob> GetDataBlob(VMatStructEntry hmiVEntryMatStruct)
        {
            var context = _prdbContextProvider.GetDbContext();
            string[] sources = ["L", "M", "X", "E"];
            var setpointsBlob = new SetpointsCSDataBlob()
            {
                SpOrd2Pcs = await context.SpOrd2Pcs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edordents = await context.EdOrdEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                CsStrategies = await context.CsStrategies.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                CsProfiles = await context.CsProfiles.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                CsCrs = await context.CsCrs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                CsRtCoolings = await context.CsRtCoolings.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                CsPerves = await context.CsPerves.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                CsPcResults = await context.CsPcResults.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId).AsNoTracking().ToListAsync(), // no source
            };

            return setpointsBlob;

        }

    }
}