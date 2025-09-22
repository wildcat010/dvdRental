using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebHMI.DataBlobs;
using WebHMI.Dtos;
using WebHMI.Dtos.SetpointsHRM;
using WebHMI.Dtos.SetpointsRM;
using WebHMI.Helpers;
using WebHMI.L2Adapter.Senders;
using WebHMI.Mapping.Extensions;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;
using WebHMI.WebHMI.Migrations;

namespace WebHMI.Services
{
    public class SetpointsHRMAppService : ApplicationServiceBase
    {
        private readonly MatStructEntryService _matStructEntryService;
        private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
        private readonly IL2Sender _l2Sender;
        private readonly short _standCount = 9;

        private PrdbContext _prdbContext => _prdbContextProvider.GetDbContext();

        public SetpointsHRMAppService(
            MatStructEntryService matStructEntryService, 
            IDbContextProvider<PrdbContext> prdbContextProvider, 
            IL2Sender l2Sender)
        {
            _matStructEntryService = matStructEntryService;
            _prdbContextProvider = prdbContextProvider;
            _l2Sender = l2Sender;
        }

        

        [AbpAuthorize(Permissions.Pages_Setpoints_RM)]
        public async Task<HRMMaterialOverviewDto> GetMaterialOverviewHRM(int meid, string matType)
        {
            var result = new HRMMaterialOverviewDto();
            var hmiVEntryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(meid, matType);

            string[] sources = ["L", "M", "S", "E"];

            var spord2pcs = await _prdbContext.SpOrd2Pcs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync();
            var edordents = await _prdbContext.EdOrdEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync();
            var edphyents = await _prdbContext.EdPhyEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnPhMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync();

            var dataBlob = await GetHrmDataBlob(hmiVEntryMatStruct);

            result.MeCode = hmiVEntryMatStruct.ToMeCodeDto();
            result.MapOverview(dataBlob);

            return result;
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_RM_Edit)]
        public async Task UpdateMaterialOverviewHRM(HRMMaterialOverviewDto input)
        {
            var context = _prdbContextProvider.GetDbContext();
            var vMatStructEntry = await _matStructEntryService.GetMaterialEntryStruct(input.MeCode.MeId, "OR");

            var edPhyEntM = await context.EdPhyEnts.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnPhMeId && x.Source == "M");
            edPhyEntM = context.InsertIfNull(edPhyEntM, vMatStructEntry);
            edPhyEntM.AimSlabThickness = input.AimsLabThickness?.M;
            edPhyEntM.SlabWidth = input.SlabWidth?.M;
            edPhyEntM.TEntry = input.TEntry?.M;
            edPhyEntM.SlabLength = input.SlabLength?.M;

            var edLogEntM = await context.EdLogEnts.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnLoMeId && x.Source == "M");
            edLogEntM = context.InsertIfNull(edLogEntM, vMatStructEntry);

            var edOrdEntM = await context.EdOrdEnts.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            edOrdEntM = context.InsertIfNull(edOrdEntM, vMatStructEntry);
            edOrdEntM.HIntermediate = input.HIntermediate?.M;

            var dirFmPfcParapM = await context.DirFmPfcParaPs.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            dirFmPfcParapM = context.InsertIfNull(dirFmPfcParapM, vMatStructEntry);
            dirFmPfcParapM.ProfileCorr = input.ProfileCorr?.M;

            var lpM = await context.Lps.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            lpM = context.InsertIfNull(lpM, vMatStructEntry);
            //lpM.REDDISTHRMHFM = input.RedDistHrmFm?.M;
            lpM.PlanNo = input.LpPlanNo?.M;

            var dphrmM = await context.Dphrms.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            dphrmM = context.InsertIfNull(dphrmM, vMatStructEntry);
            dphrmM.PlanNo = input.DpHrmPlanNo?.M;

            var rcpM = await context.Rcps.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            rcpM = context.InsertIfNull(rcpM, vMatStructEntry);
            rcpM.PlanNo = input.RcpPlanNo?.M;

            var tpM = await context.Tps.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            tpM = context.InsertIfNull(tpM, vMatStructEntry);
            tpM.PlanNo = input.TpPlanNo?.M;

            var rglpM = await context.Rglps.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            rglpM = context.InsertIfNull(rglpM, vMatStructEntry);
            rglpM.PlanNo = input.RglpPlanNo?.M;

            var iscpM = await context.Iscps.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            iscpM = context.InsertIfNull(iscpM, vMatStructEntry);
            iscpM.PlanNo = input.IscpPlanNo?.M;

            await context.SaveChangesAsync();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_RM)]
        public async Task<SetpointsHRMDto> GetPassScheduleHRM(int meid, string matType)
        {
            var result = new SetpointsHRMDto();
            var hmiVEntryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(meid, matType);

            var dataBlob = await GetHrmDataBlob(hmiVEntryMatStruct);
            
            result.MeCode = hmiVEntryMatStruct.ToMeCodeDto();
            result.MapPassSchedule(dataBlob, _standCount);
            result.MapLubrication(dataBlob);
            result.MapDescaling(dataBlob);
            result.MapAntiPeeling(dataBlob, _standCount);
            result.MapWorkCooling(dataBlob, _standCount);
            result.MapTension(dataBlob, _standCount);
            result.MapTaperShifting(dataBlob, _standCount);
            result.MapLoading(dataBlob, _standCount);

            return result;
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_Setpoints_RM_Edit)]
        public async Task UpdatePassScheduleHRM(SetpointsHRMDto input)
        {
            var context = _prdbContextProvider.GetDbContext();
            var vMatStructEntry = await _matStructEntryService.GetMaterialEntryStruct(input.MeCode.MeId, "OR");
            //pass schedule
            await UpdateLpPasses(input, vMatStructEntry);
            await UpdateTpPasses(input, vMatStructEntry);
            await UpdateSrpPasses(input, vMatStructEntry);
            await UpdateSpOrdPasses(input, vMatStructEntry);

            await UpdateLoadingTab(input, vMatStructEntry);
            await UpdateDescalingTab(input, vMatStructEntry);
            await UpdateWorkCoolingTab(input, vMatStructEntry);
            await UpdateTensionTab(input, vMatStructEntry);
            await UpdateTaperShiftingTab(input, vMatStructEntry);
            await UpdateAntiPeelingTab(input, vMatStructEntry);

        }

        private async Task UpdateLpPasses(SetpointsHRMDto input, VMatStructEntry vMatStructEntryOr) 
        {
            var context = _prdbContextProvider.GetDbContext();

            var lpPassManuals = await context.Lppasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();

            foreach (var pass in input.PassScheduleDtos.OrderByDescending(x => x.PassNo))
            {
                var lpPassM = lpPassManuals.FirstOrDefault(x => x.PassNo == pass.PassNo);
                if (lpPassM == null)
                {
                    lpPassM = new Lppass()
                    {
                        MeCreator = vMatStructEntryOr.EnOrCreator,
                        MeId = vMatStructEntryOr.EnOrMeId,
                        MesId = (short)vMatStructEntryOr.EnOrMesId,
                        PassNo = pass.PassNo,
                        Source = "M",
                    };
                    context.Lppasses.Add(lpPassM);
                }

                lpPassM.LoadingType = pass.LoadingType?.M;
                lpPassM.LoadingValue = pass.LoadingValue?.M;
                lpPassM.LoadingValueCorrection = pass.LoadingValueCorrection?.M;

                await context.SaveChangesAsync();
            }
        }

        private async Task UpdateTpPasses(SetpointsHRMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var tpPassManuals = await context.Tppasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();

            foreach (var pass in input.PassScheduleDtos.OrderByDescending(x => x.PassNo))
            {
                var tpPassM = tpPassManuals.FirstOrDefault(x => x.PassNo == pass.PassNo);
                if (tpPassM == null)
                {
                    tpPassM = new Tppass()
                    {
                        MeCreator = vMatStructEntryOr.EnOrCreator,
                        MeId = vMatStructEntryOr.EnOrMeId,
                        MesId = (short)vMatStructEntryOr.EnOrMesId,
                        PassNo = pass.PassNo,
                        Source = "M",
                    };
                    context.Tppasses.Add(tpPassM);
                }

                tpPassM.SpecifFoTension = pass.SpecifFoTension?.M;

                await context.SaveChangesAsync();
            }
        }

        private async Task UpdateSrpPasses(SetpointsHRMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var srpPassManuals = await context.Srppasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();

            foreach (var pass in input.PassScheduleDtos.OrderByDescending(x => x.PassNo))
            {
                var srpPassM = srpPassManuals.FirstOrDefault(x => x.PassNo == pass.PassNo);
                if (srpPassM == null)
                {
                    srpPassM = new Srppass()
                    {
                        MeCreator = vMatStructEntryOr.EnOrCreator,
                        MeId = vMatStructEntryOr.EnOrMeId,
                        MesId = (short)vMatStructEntryOr.EnOrMesId,
                        PassNo = pass.PassNo,
                        Source = "M",
                    };
                    context.Srppasses.Add(srpPassM);
                }
                srpPassM.PassNo = pass.PassNo;
                srpPassM.Model = pass.Model?.M;

                await context.SaveChangesAsync();
            }
        }

        private async Task UpdateSpOrdPasses(SetpointsHRMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var spOrd2PcStandManuals = await context.SpOrd2PcStands.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();

            foreach (var pass in input.PassScheduleDtos.OrderByDescending(x => x.PassNo))
            {
                var spOrd2PcStandM = spOrd2PcStandManuals.FirstOrDefault(x => x.StandId == pass.PassNo);
                if (spOrd2PcStandM == null)
                {
                    spOrd2PcStandM = new SpOrd2PcStand()
                    {
                        MeCreator = vMatStructEntryOr.EnOrCreator,
                        MeId = vMatStructEntryOr.EnOrMeId,
                        MesId = (short)vMatStructEntryOr.EnOrMesId,
                        StandId = pass.PassNo,
                        Source = "M",
                    };
                    context.SpOrd2PcStands.Add(spOrd2PcStandM);
                }

                spOrd2PcStandM.Fr = pass.Fr?.M;
                spOrd2PcStandM.Sd = pass.Sd?.M;
                spOrd2PcStandM.T0 = pass.T0?.M;
                spOrd2PcStandM.H0 = pass.H0?.M;
                spOrd2PcStandM.VCircum = pass.VCircum?.M;
                spOrd2PcStandM.TRoll = pass.TRoll?.M;
                spOrd2PcStandM.RelProfile = pass.RelProfile?.M;
                spOrd2PcStandM.Profile = pass.AbsProfile?.M;
                spOrd2PcStandM.Ms = pass.Ms?.M;
                spOrd2PcStandM.RPower = pass.RPower?.M;
                spOrd2PcStandM.CalcFlat = pass.CalcFlat?.M;

                await context.SaveChangesAsync();
            }
        }

        private async Task UpdateLoadingTab(SetpointsHRMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var lpPassManuals = await context.Lppasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();

            foreach (var pass in input.LoadingDtos.OrderByDescending(x => x.PassNo))
            {
                var lpPassM = lpPassManuals.FirstOrDefault(x => x.PassNo == pass.PassNo);
                if (lpPassM == null)
                {
                    lpPassM = new Lppass()
                    {
                        MeCreator = vMatStructEntryOr.EnOrCreator,
                        MeId = vMatStructEntryOr.EnOrMeId,
                        MesId = (short)vMatStructEntryOr.EnOrMesId,
                        PassNo = pass.PassNo,
                        Source = "M",
                    };
                    context.Lppasses.Add(lpPassM);
                }
                lpPassM.LoadingType = pass.LoadingType?.M;
                lpPassM.LoadingValue = pass.LoadingValue?.M;
                lpPassM.CircumSpeedCorrection = pass.CircumSpeedCorrection?.M;
                lpPassM.BendingForce = pass.BendingForce?.M;

                await context.SaveChangesAsync();
            }
        }

        private async Task UpdateDescalingTab(SetpointsHRMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var dpfmM = await context.Dpfms.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").FirstOrDefaultAsync();

            if (dpfmM == null)
            {
                dpfmM = new Dpfm()
                {
                    MeCreator = vMatStructEntryOr.EnOrCreator,
                    MeId = vMatStructEntryOr.EnOrMeId,
                    MesId = (short)vMatStructEntryOr.EnOrMesId,
                    Source = "M",
                };
                context.Dpfms.Add(dpfmM);
            }

            dpfmM.PlanNo = input.Descaling?.PlanNo.M;

            var dprampfmM = await context.DprampFms.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").FirstOrDefaultAsync();

            if (dprampfmM == null)
            {
                dprampfmM = new DprampFm()
                {
                    MeCreator = vMatStructEntryOr.EnOrCreator,
                    MeId = vMatStructEntryOr.EnOrMeId,
                    MesId = (short)vMatStructEntryOr.EnOrMesId,
                    Source = "M",
                };
                context.DprampFms.Add(dprampfmM);
            }

            dprampfmM.DescRampAuto = input.Descaling?.DescrampAuto.M;
            dprampfmM.DescRampState = input.Descaling?.DescrampState.M;
            dprampfmM.DescRampVolume = input.Descaling?.DescrampVolume.M;

            await context.SaveChangesAsync();

        }

        private async Task UpdateWorkCoolingTab(SetpointsHRMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var rcpPassManuals = await context.Rcppasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();

            foreach (var pass in input.WorkCoolingDtos.OrderByDescending(x => x.PassNo))
            {
                var rcPassM = rcpPassManuals.FirstOrDefault(x => x.PassNo == pass.PassNo);
                if (rcPassM == null)
                {
                    rcPassM = new Rcppass()
                    {
                        MeCreator = vMatStructEntryOr.EnOrCreator,
                        MeId = vMatStructEntryOr.EnOrMeId,
                        MesId = (short)vMatStructEntryOr.EnOrMesId,
                        PassNo = pass.PassNo,
                        Source = "M",
                    };
                    context.Rcppasses.Add(rcPassM);
                }
                rcPassM.RollCoolState = pass.RollCoolState?.M;
                rcPassM.FlowWrLoadedInd0 = pass.FlowWrLoadedInd0?.M;
                rcPassM.FlowWrLoadedInd1 = pass.FlowWrLoadedInd1?.M;
                rcPassM.FlowWrLoadedInd2 = pass.FlowWrLoadedInd2?.M;

                await context.SaveChangesAsync();
            }

            var iscpPassManuals = await context.Iscppasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();

            foreach (var pass in input.WorkCoolingDtos.OrderByDescending(x => x.PassNo))
            {
                var iscpPassM = iscpPassManuals.FirstOrDefault(x => x.PassNo == pass.PassNo);
                if (iscpPassM == null)
                {
                    iscpPassM = new Iscppass()
                    {
                        MeCreator = vMatStructEntryOr.EnOrCreator,
                        MeId = vMatStructEntryOr.EnOrMeId,
                        MesId = (short)vMatStructEntryOr.EnOrMesId,
                        PassNo = pass.PassNo,
                        Source = "M",
                    };
                    context.Iscppasses.Add(iscpPassM);
                }
                iscpPassM.StripSprayBefor = pass.StripSprayBefor?.M;
                iscpPassM.LooperCool = pass.LooperCooling?.M;

                await context.SaveChangesAsync();
            }

            await context.SaveChangesAsync();

        }

        private async Task UpdateAntiPeelingTab(SetpointsHRMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var aopPassManuals = await context.Aoppasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();

            foreach (var pass in input.AntiPeelingDtos.OrderByDescending(x => x.PassNo))
            {
                var aopPassM = aopPassManuals.FirstOrDefault(x => x.PassNo == pass.PassNo);
                if (aopPassM == null)
                {
                    aopPassM = new Aoppass()
                    {
                        MeCreator = vMatStructEntryOr.EnOrCreator,
                        MeId = vMatStructEntryOr.EnOrMeId,
                        MesId = (short)vMatStructEntryOr.EnOrMesId,
                        PassNo = pass.PassNo,
                        Source = "M",
                    };
                    context.Aoppasses.Add(aopPassM);
                }
                aopPassM.AntiPeelingState = pass.AntiPeelingState?.M;
                aopPassM.AntiPeeling = pass.AntiPeeling?.M;

                await context.SaveChangesAsync();
            }

            await context.SaveChangesAsync();

        }
        private async Task UpdateTensionTab(SetpointsHRMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var tpPassManuals = await context.Tppasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();

            foreach (var pass in input.TensionDtos.OrderByDescending(x => x.PassNo))
            {
                var tpPassM = tpPassManuals.FirstOrDefault(x => x.PassNo == pass.PassNo);
                if (tpPassM == null)
                {
                    tpPassM = new Tppass()
                    {
                        MeCreator = vMatStructEntryOr.EnOrCreator,
                        MeId = vMatStructEntryOr.EnOrMeId,
                        MesId = (short)vMatStructEntryOr.EnOrMesId,
                        PassNo = pass.PassNo,
                        Source = "M",
                    };
                    context.Tppasses.Add(tpPassM);
                }
                tpPassM.SpecifFoTension = pass.SpeciffoTension?.M;
                tpPassM.LooperStripLen = pass.LooperStripLen?.M;

                await context.SaveChangesAsync();
            }

            await context.SaveChangesAsync();

        }
        private async Task UpdateTaperShiftingTab(SetpointsHRMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var srpPassManuals = await context.Srppasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();

            foreach (var pass in input.TaperShiftingDtos.OrderByDescending(x => x.PassNo))
            {
                var srpPassM = srpPassManuals.FirstOrDefault(x => x.PassNo == pass.PassNo);
                if (srpPassM == null)
                {
                    srpPassM = new Srppass()
                    {
                        MeCreator = vMatStructEntryOr.EnOrCreator,
                        MeId = vMatStructEntryOr.EnOrMeId,
                        MesId = (short)vMatStructEntryOr.EnOrMesId,
                        PassNo = pass.PassNo,
                        Source = "M",
                    };
                    context.Srppasses.Add(srpPassM);
                }
                srpPassM.Model = pass.Model?.M;

                await context.SaveChangesAsync();
            }

            await context.SaveChangesAsync();

        }

        //[AbpAuthorize(Permissions.Pages_Setpoints_RM)]
        //public async Task<SetpointsHRMApxDto> GetApxPassScheduleHRM(int meid, string matType)
        //{
        //    var result = new SetpointsHRMApxDto();
        //    var hmiVEntryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(meid, matType);

        //    var dataBlob = await GetApxPassScheduleHrmDataBlob(hmiVEntryMatStruct);

        //    result.MeCode = hmiVEntryMatStruct.ToMeCodeDto();
        //    result.MapData(dataBlob);
        //    result.MapStandData(dataBlob, _standCount);

        //    return result;
        //}

        //[Audited]
        //[AbpAuthorize(Permissions.Pages_Setpoints_RM_Edit)]
        //public async Task UpdateApxPassScheduleHRM(SetpointsHRMApxDto input)
        //{
        //    var context = _prdbContextProvider.GetDbContext();
        //    var vMatStructEntryOr = await _matStructEntryService.GetMaterialEntryStruct(input.MeCode.MeId, "OR");
        //    var vMatStructEntryLog = await _matStructEntryService.GetMaterialEntryStruct(vMatStructEntryOr.EnLoMeId, "LO");
        //    var vMatStructEntryPh = await _matStructEntryService.GetMaterialEntryStruct(vMatStructEntryOr.EnPhMeId, "PH");

        //    var edOrdEntM = await context.EdOrdEnts.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
        //    edOrdEntM = context.InsertIfNull(edOrdEntM, vMatStructEntryOr);
        //    edOrdEntM.HExit = input.HExit?.M;
        //    edOrdEntM.WidthExit = input.WidthExit?.M;
        //    edOrdEntM.ExitCrownC25 = input.ExitCrownC25?.M;

        //    var dirFmPfcParapM = await context.DirFmPfcParaPs.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
        //    dirFmPfcParapM = context.InsertIfNull(dirFmPfcParapM, vMatStructEntryOr);
        //    dirFmPfcParapM.ProfileCorr = input.ProfileCorr?.M;
        //    dirFmPfcParapM.PlanNo = input.DirFmPfcParaPlanNo?.M;

        //    var dirFmPfcCycShiftPM = await context.DirFmPfcCycShiftPs.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
        //    dirFmPfcCycShiftPM = context.InsertIfNull(dirFmPfcCycShiftPM, vMatStructEntryOr);
        //    dirFmPfcCycShiftPM.PlanNo = input.DirFmPfcCycShiftPlanNo?.M;

        //    await context.SaveChangesAsync();

        //    await UpdateApxLpPasses(input, vMatStructEntryOr);
        //    await UpdateApxDirFmOfcParaPasses(input, vMatStructEntryOr);
        //}

        //private async Task UpdateApxLpPasses(SetpointsHRMApxDto input, VMatStructEntry vMatStructEntryOr)
        //{
        //    var context = _prdbContextProvider.GetDbContext();

        //    var lpPassManuals = await context.Lppasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();

        //    foreach (var pass in input.StandDataDtos.OrderByDescending(x => x.PassNo))
        //    {
        //        var lpPassM = lpPassManuals.FirstOrDefault(x => x.PassNo == pass.PassNo);
        //        if (lpPassM == null)
        //        {
        //            lpPassM = new Lppass()
        //            {
        //                MeCreator = vMatStructEntryOr.EnOrCreator,
        //                MeId = vMatStructEntryOr.EnOrMeId,
        //                MesId = (short)vMatStructEntryOr.EnOrMesId,
        //                PassNo = pass.PassNo,
        //                Source = "M",
        //            };
        //            context.Lppasses.Add(lpPassM);
        //        }

        //        lpPassM.CVcshifting = pass.CvcShifting?.M;
        //        lpPassM.BendingForce = pass.BendingForce?.M;

        //        await context.SaveChangesAsync();
        //    }
        //}

        //private async Task UpdateApxDirFmOfcParaPasses(SetpointsHRMApxDto input, VMatStructEntry vMatStructEntryOr)
        //{
        //    var context = _prdbContextProvider.GetDbContext();

        //    var dirFmPfcParaPassManuals = await context.DirFmPfcParaPpasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();

        //    foreach (var pass in input.StandDataDtos.OrderByDescending(x => x.PassNo))
        //    {
        //        var dirFmPfcParaPassM = dirFmPfcParaPassManuals.FirstOrDefault(x => x.PassNo == pass.PassNo);
        //        if (dirFmPfcParaPassM == null)
        //        {
        //            dirFmPfcParaPassM = new DirFmPfcParaPpass()
        //            {
        //                MeCreator = vMatStructEntryOr.EnOrCreator,
        //                MeId = vMatStructEntryOr.EnOrMeId,
        //                MesId = (short)vMatStructEntryOr.EnOrMesId,
        //                PassNo = pass.PassNo,
        //                Source = "M",
        //            };
        //            context.DirFmPfcParaPpasses.Add(dirFmPfcParaPassM);
        //        }

        //        dirFmPfcParaPassM.FbUl = pass.Fbul?.M;
        //        dirFmPfcParaPassM.FbLl = pass.Fbll?.M;
        //        dirFmPfcParaPassM.SrUl = pass.Srul?.M;
        //        dirFmPfcParaPassM.SrLl = pass.Srll?.M;
        //        dirFmPfcParaPassM.ObservedFlat = pass.ObservedFlat?.M;

        //        await context.SaveChangesAsync();
        //    }
        //}

        private async Task<SetpointsHRMDataBlob> GetHrmDataBlob(VMatStructEntry hmiVEntryMatStruct)
        {
            string[] sources = ["L", "M", "S", "E"];
            var setpointsHRMBlob = new SetpointsHRMDataBlob() 
            {
                Srppasses = await _prdbContext.Srppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Spord2pcstands = await _prdbContext.SpOrd2PcStands.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Aoppasses = await _prdbContext.Aoppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Iscpasses = await _prdbContext.Iscppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Rcppasses = await _prdbContext.Rcppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Lppasses = await _prdbContext.Lppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Tppasses = await _prdbContext.Tppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Dirfmpfccycshiftps = await _prdbContext.DirFmPfcCycShiftPs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Dirfmpfccycshiftppasses = await _prdbContext.DirFmPfcCycShiftPpasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Iscps = await _prdbContext.Iscps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Rglps = await _prdbContext.Rglps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Tps = await _prdbContext.Tps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Rcps = await _prdbContext.Rcps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Dphrms = await _prdbContext.Dphrms.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Lps = await _prdbContext.Lps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Spord2pcs = await _prdbContext.SpOrd2Pcs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edordents = await _prdbContext.EdOrdEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edphyents = await _prdbContext.EdPhyEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnPhMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edlogents = await _prdbContext.EdLogEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnLoMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Mes = await _prdbContext.Mes.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId).AsNoTracking().ToListAsync(),
                DirFmPfcParaPs = await _prdbContext.DirFmPfcParaPs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                DirFmPfcParapPasses = await _prdbContext.DirFmPfcParaPpasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                DpFms = await _prdbContext.Dpfms.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Dprampfms = await _prdbContext.DprampFms.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync()
            };

            return setpointsHRMBlob;

        }

        //private async Task<SetpointsHRMApxDataBlob> GetApxPassScheduleHrmDataBlob(VMatStructEntry hmiVEntryMatStruct)
        //{
        //    string[] sources = ["L", "M", "S", "E"];

        //    return new SetpointsHRMApxDataBlob
        //    {
        //        Spord2pcs = await _prdbContext.SpOrd2Pcs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
        //        Edordents = await _prdbContext.EdOrdEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
        //        Edphyents = await _prdbContext.EdPhyEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnPhMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
        //        Edlogents = await _prdbContext.EdLogEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnLoMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
        //        DirFmPfcParaPs = await _prdbContext.DirFmPfcParaPs.Where(x => x.MeId == hmiVEntryMatStruct.EnLoMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
        //        Srppasses = await _prdbContext.Srppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnLoMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
        //        Wmppasses = await _prdbContext.Wmppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnLoMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
        //        Spord2pcstands = await _prdbContext.SpOrd2PcStands.Where(x => x.MeId == hmiVEntryMatStruct.EnLoMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
        //        Lppasses = await _prdbContext.Lppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnLoMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
        //        Dirfmpfccycshiftppasses = await _prdbContext.DirFmPfcCycShiftPpasses.Where(x => x.MeId == hmiVEntryMatStruct.EnLoMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
        //        Dirfmpfccycshiftps = await _prdbContext.DirFmPfcCycShiftPs.Where(x => x.MeId == hmiVEntryMatStruct.EnLoMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync()

        //    };
        //}
    }
}