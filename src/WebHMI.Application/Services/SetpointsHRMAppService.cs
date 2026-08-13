using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using Abp.Auditing;
using Abp.Authorization;
using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebHMI.DataBlobs;
using WebHMI.Dtos.Setpoints.SetpointsHRM;
using WebHMI.Helpers;
using WebHMI.L2Adapter.Common;
using WebHMI.Mapping.Extensions;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Services
{
    public class SetpointsHRMAppService : ApplicationServiceBase
    {
        private readonly MatStructEntryService _matStructEntryService;
        private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
        private readonly IL2CommunicationHandler _l2Sender;
        private readonly short _standCount = 4;

        private PrdbContext _prdbContext => _prdbContextProvider.GetDbContext();

        public SetpointsHRMAppService(
            MatStructEntryService matStructEntryService,
            IDbContextProvider<PrdbContext> prdbContextProvider,
            IL2CommunicationHandler l2Sender)
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

            var dataBlob = await GetHrmDataBlob(hmiVEntryMatStruct);

            result.MeCode = hmiVEntryMatStruct.ToOrMeCodeDto();
            result.MapOverview(dataBlob);

            return result;
        }

        [Audited]
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
            edOrdEntM.ExitCrownC40 = input.ExitCrownC25?.M;

            var dirFmPfcParapM = await context.DirFmPfcParaPs.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            dirFmPfcParapM = context.InsertIfNull(dirFmPfcParapM, vMatStructEntry);
            dirFmPfcParapM.ProfileCorr = input.ProfileCorr?.M;

            var lpM = await context.Lps.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            lpM = context.InsertIfNull(lpM, vMatStructEntry);
            lpM.RedDistHrmHfm = input.RedDistHrmFm?.M;
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

            var dirFmPfcCycShiftM = await context.DirFmPfcCycShiftPs.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            dirFmPfcCycShiftM = context.InsertIfNull(dirFmPfcCycShiftM, vMatStructEntry);
            dirFmPfcCycShiftM.PlanNo = input.DirFmPfcCycShiftPlanNo?.M;

            var edgerM = await context.Edghrms.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            edgerM = context.InsertIfNull(edgerM, vMatStructEntry);
            edgerM.PlanNo = input.EdgerPlanNo?.M;

            await context.SaveChangesAsync();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_RM)]
        public async Task<SetpointsHRMDto> GetPassScheduleHRM(int meid, string matType)
        {
            var result = new SetpointsHRMDto();
            var hmiVEntryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(meid, matType);

            var dataBlob = await GetHrmDataBlob(hmiVEntryMatStruct);

            result.MeCode = hmiVEntryMatStruct.ToOrMeCodeDto();
            result.MapPassSchedule(dataBlob, _standCount);
            result.MapEdger(dataBlob);
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
            await UpdateDirFmPfcParaPasses(input, vMatStructEntry);

            await UpdateEdger(input, vMatStructEntry);
            await UpdateLoadingTab(input, vMatStructEntry);
            await UpdateDescalingTab(input, vMatStructEntry);
            await UpdateWorkCoolingTab(input, vMatStructEntry);
            await UpdateTensionTab(input, vMatStructEntry);
            await UpdateTaperShiftingTab(input, vMatStructEntry);
            await UpdateAntiPeelingTab(input, vMatStructEntry);
        }

        private async Task UpdateEdger(SetpointsHRMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var edgHrmManuals = await context.Edghrms.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").FirstOrDefaultAsync();
            if (edgHrmManuals == null)
            {
                edgHrmManuals = new Edghrm()
                {
                    MeCreator = vMatStructEntryOr.EnOrCreator,
                    MeId = vMatStructEntryOr.EnOrMeId,
                    MesId = (short)vMatStructEntryOr.EnOrMesId,
                    Source = "M",
                };
                context.Edghrms.Add(edgHrmManuals);
            }

            edgHrmManuals.PlanNo = input.EdgerDto.PlanNo?.M;
            edgHrmManuals.EdgMode = input.EdgerDto.EdgerMode?.M;
            edgHrmManuals.EdgerActive = input.EdgerDto.EdgerActive?.M;
            edgHrmManuals.Dw = input.EdgerDto.WidthReduction?.M;

            await context.SaveChangesAsync();
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

            }
            await context.SaveChangesAsync();
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

            }
            await context.SaveChangesAsync();
        }

        private async Task UpdateSrpPasses(SetpointsHRMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var srpManual = await context.Srps.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "E").FirstOrDefaultAsync();

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

                srpPassM.PlanNo = srpManual?.PlanNo;
                srpPassM.Model = srpPassM?.Model;

            }
            await context.SaveChangesAsync();
        }

        private async Task UpdateDirFmPfcParaPasses(SetpointsHRMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var dirFmPfcParaPassManuals = await context.DirFmPfcParaPpasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();

            foreach (var pass in input.PassScheduleDtos.OrderByDescending(x => x.PassNo))
            {
                var dirFmPfcParaPassM = dirFmPfcParaPassManuals.FirstOrDefault(x => x.PassNo == pass.PassNo);
                if (dirFmPfcParaPassM == null)
                {
                    dirFmPfcParaPassM = new DirFmPfcParaPpass()
                    {
                        MeCreator = vMatStructEntryOr.EnOrCreator,
                        MeId = vMatStructEntryOr.EnOrMeId,
                        MesId = (short)vMatStructEntryOr.EnOrMesId,
                        PassNo = pass.PassNo,
                        Source = "M",
                    };
                    context.DirFmPfcParaPpasses.Add(dirFmPfcParaPassM);
                }

                dirFmPfcParaPassM.ObservedFlat = pass.ObservedFlat?.M;

            }
            await context.SaveChangesAsync();
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

            }
            await context.SaveChangesAsync();
        }

        private async Task UpdateDescalingTab(SetpointsHRMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var dprmM = await context.Dphrms.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").FirstOrDefaultAsync();

            if (dprmM == null)
            {
                dprmM = new Dphrm()
                {
                    MeCreator = vMatStructEntryOr.EnOrCreator,
                    MeId = vMatStructEntryOr.EnOrMeId,
                    MesId = (short)vMatStructEntryOr.EnOrMesId,
                };
                context.Dphrms.Add(dprmM);
            }

            var dpramprmM = await context.DprampHrms.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M" && x.RampNo == 1).FirstOrDefaultAsync();

            if (dpramprmM == null)
            {
                dpramprmM = new DprampHrm()
                {
                    MeCreator = vMatStructEntryOr.EnOrCreator,
                    MeId = vMatStructEntryOr.EnOrMeId,
                    MesId = (short)vMatStructEntryOr.EnOrMesId,
                    Source = "M",
                    RampNo = 1
                };
                context.DprampHrms.Add(dpramprmM);
            }

            dpramprmM.DescRampAuto = input.Descaling?.DescrampAuto.M;
            dpramprmM.DescRampState = input.Descaling?.DescrampState.M;
            dpramprmM.DescRampVolume = input.Descaling?.DescrampVolume.M;

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
            }

            await context.SaveChangesAsync();

        }

        private async Task UpdateTaperShiftingTab(SetpointsHRMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();
            var srpManual = await context.Srps.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "E").FirstOrDefaultAsync();

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
                srpPassM.PlanNo = srpManual?.PlanNo;
                srpPassM.Model = pass.Model?.M;
            }

            await context.SaveChangesAsync();

        }

        [AbpAuthorize(Permissions.Pages_Setpoints_RM)]
        public async Task<HRMApxMaterialOverviewDto> GetApxMaterialOverview(int meid, string matType)
        {
            var result = new HRMApxMaterialOverviewDto();
            var hmiVEntryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(meid, matType);

            var dataBlob = await GetApxPassScheduleHrmDataBlob(hmiVEntryMatStruct);

            result.MeCode = hmiVEntryMatStruct.ToOrMeCodeDto();
            result.MapApxOverview(dataBlob);

            return result;
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_Setpoints_RM)]
        public async Task UpdateApxMaterialOverview(HRMApxMaterialOverviewDto input)
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
            edOrdEntM.ExitCrownC40 = input.ExitCrownC25?.M;

            var dirFmPfcParapM = await context.DirFmPfcParaPs.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            dirFmPfcParapM = context.InsertIfNull(dirFmPfcParapM, vMatStructEntry);
            dirFmPfcParapM.PlanNo = input.DirFmPfcParaPlanNo?.M;
            dirFmPfcParapM.ProfileCorr = input.ProfileCorr?.M;

            var srpM = await context.Srps.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            srpM = context.InsertIfNull(srpM, vMatStructEntry);
            srpM.PlanNo = input.SrpPlanNo?.M;

            var dirFmPfcCycShiftM = await context.DirFmPfcCycShiftPs.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            dirFmPfcCycShiftM = context.InsertIfNull(dirFmPfcCycShiftM, vMatStructEntry);
            dirFmPfcCycShiftM.PlanNo = input.DirFmPfcCycShiftPlanNo?.M;

            //var rcpM = await context.Rcps.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            //rcpM = context.InsertIfNull(rcpM, vMatStructEntry);
            //rcpM.PlanNo = input.RcpPlanNo?.M;

            await context.SaveChangesAsync();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_RM)]
        public async Task<SetpointsHRMApxDto> GetApxPassScheduleHRM(int meid, string matType)
        {
            var result = new SetpointsHRMApxDto();
            var hmiVEntryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(meid, matType);

            var dataBlob = await GetApxPassScheduleHrmDataBlob(hmiVEntryMatStruct);

            result.MeCode = hmiVEntryMatStruct.ToOrMeCodeDto();
            result.MapApxPassSchedule(dataBlob, _standCount);
            result.MapShifting(dataBlob, _standCount);
            result.MapFlatness(dataBlob, _standCount);
            result.MapTaperShifting(dataBlob, _standCount);

            return result;
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_Setpoints_RM_Edit)]
        public async Task UpdateApxPassScheduleHRM(SetpointsHRMApxDto input, string connectionId, bool pdiChanged = false)
        {
            var context = _prdbContextProvider.GetDbContext();
            var vMatStructEntryOr = await _matStructEntryService.GetMaterialEntryStruct(input.MeCode.MeId, "OR");

            var edPhyEntM = await context.EdPhyEnts.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnPhMeId && x.Source == "M");
            edPhyEntM = context.InsertIfNull(edPhyEntM, vMatStructEntryOr);

            var edLogEntM = await context.EdLogEnts.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnLoMeId && x.Source == "M");
            edLogEntM = context.InsertIfNull(edLogEntM, vMatStructEntryOr);

            var edOrdEntM = await context.EdOrdEnts.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            edOrdEntM = context.InsertIfNull(edOrdEntM, vMatStructEntryOr);

            await UpdateLpSrpWmpPass(input, vMatStructEntryOr);
            await UpdateApxDirFmPfcParaPasses(input, vMatStructEntryOr);

            await UpdateShifting(input, vMatStructEntryOr);
            await UpdateFlatness(input, vMatStructEntryOr);
            await UpdateTaperShiftingTab(input, vMatStructEntryOr);

            if (pdiChanged)
                _l2Sender.EntryDataChange(vMatStructEntryOr, connectionId);
            else
                _l2Sender.SetpointsCalculationHMI(vMatStructEntryOr, "HFM", connectionId);

        }

        private async Task UpdateLpSrpWmpPass(SetpointsHRMApxDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var lpPassManuals = await context.Lppasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();
            var srpPassManuals = await context.Srppasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();
            var wmpPassManuals = await context.Wmppasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();

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

                lpPassM.BendingForce = pass.BendingForce?.M;
                lpPassM.CVcshifting = pass.CvcShifting?.M;

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

                srpPassM.Model = pass.TaperShiftSpeedCorr?.M;

                var wmpPassM = wmpPassManuals.FirstOrDefault(x => x.PassNo == pass.PassNo);
                if (wmpPassM == null)
                {
                    wmpPassM = new Wmppass()
                    {
                        MeCreator = vMatStructEntryOr.EnOrCreator,
                        MeId = vMatStructEntryOr.EnOrMeId,
                        MesId = (short)vMatStructEntryOr.EnOrMesId,
                        PassNo = pass.PassNo,
                        Source = "M",
                    };
                    context.Wmppasses.Add(wmpPassM);
                }

                wmpPassM.Model = pass.WearCorr?.M;
            }
            await context.SaveChangesAsync();

        }

        private async Task UpdateApxDirFmPfcParaPasses(SetpointsHRMApxDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var dirFmPfcParaPassManuals = await context.DirFmPfcParaPpasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();

            foreach (var pass in input.PassScheduleDtos.OrderByDescending(x => x.PassNo))
            {
                var dirFmPfcParaPassM = dirFmPfcParaPassManuals.FirstOrDefault(x => x.PassNo == pass.PassNo);
                if (dirFmPfcParaPassM == null)
                {
                    dirFmPfcParaPassM = new DirFmPfcParaPpass()
                    {
                        MeCreator = vMatStructEntryOr.EnOrCreator,
                        MeId = vMatStructEntryOr.EnOrMeId,
                        MesId = (short)vMatStructEntryOr.EnOrMesId,
                        PassNo = pass.PassNo,
                        Source = "M",
                    };
                    context.DirFmPfcParaPpasses.Add(dirFmPfcParaPassM);
                }

                dirFmPfcParaPassM.FbUl = pass.Fbul?.M;
                dirFmPfcParaPassM.FbLl = pass.Fbll?.M;
                dirFmPfcParaPassM.SrUl = pass.Srul?.M;
                dirFmPfcParaPassM.SrLl = pass.Srll?.M;
                dirFmPfcParaPassM.ObservedFlat = pass.ObservedFlat?.M;

            }
            await context.SaveChangesAsync();
        }

        private async Task UpdateShifting(SetpointsHRMApxDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var dirFmPfcCycShiftPassManuals = await context.DirFmPfcCycShiftPpasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();

            foreach (var pass in input.ShiftingDtos.OrderByDescending(x => x.PassNo))
            {
                var dirFmPfcCycShiftPassM = dirFmPfcCycShiftPassManuals.FirstOrDefault(x => x.PassNo == pass.PassNo);
                if (dirFmPfcCycShiftPassM == null)
                {
                    dirFmPfcCycShiftPassM = new DirFmPfcCycShiftPpass()
                    {
                        MeCreator = vMatStructEntryOr.EnOrCreator,
                        MeId = vMatStructEntryOr.EnOrMeId,
                        MesId = (short)vMatStructEntryOr.EnOrMesId,
                        PassNo = pass.PassNo,
                        Source = "M",
                    };
                    context.DirFmPfcCycShiftPpasses.Add(dirFmPfcCycShiftPassM);
                }

                dirFmPfcCycShiftPassM.CSmaxLimit = pass.CsMaxLimit?.M;
                dirFmPfcCycShiftPassM.CSminLimit = pass.CsMinLimit?.M;
                dirFmPfcCycShiftPassM.CSstartPos = pass.CsStartPos?.M;
                dirFmPfcCycShiftPassM.CSshiftDir = pass.CsShiftDir?.M;
                dirFmPfcCycShiftPassM.CSshiftStep1 = pass.CsShiftStep1?.M;
                dirFmPfcCycShiftPassM.CSshiftStep2 = pass.CsShiftStep2?.M;
                dirFmPfcCycShiftPassM.CSshiftStep3 = pass.CsShiftStep3?.M;
                dirFmPfcCycShiftPassM.Description = pass.Description?.M;
                dirFmPfcCycShiftPassM.ManInt = pass.Manint?.M;
                dirFmPfcCycShiftPassM.ToExtId = pass.Toextid?.M;
                dirFmPfcCycShiftPassM.CSmaxLimitParabolicInd0 = pass.CsmaxlimitparabolicInd0?.M;
                dirFmPfcCycShiftPassM.CSmaxLimitParabolicInd1 = pass.CsmaxlimitparabolicInd1?.M;
                dirFmPfcCycShiftPassM.CSmaxLimitParabolicInd2 = pass.CsmaxlimitparabolicInd2?.M;
                dirFmPfcCycShiftPassM.CSminLimitParabolicInd0 = pass.CsminlimitparabolicInd0?.M;
                dirFmPfcCycShiftPassM.CSminLimitParabolicInd1 = pass.CsminlimitparabolicInd1?.M;
                dirFmPfcCycShiftPassM.CSminLimitParabolicInd2 = pass.CsminlimitparabolicInd2?.M;
                dirFmPfcCycShiftPassM.CSstepParabolicInd0 = pass.CsstepparabolicInd0?.M;
                dirFmPfcCycShiftPassM.CSstepParabolicInd1 = pass.CsstepparabolicInd1?.M;
                dirFmPfcCycShiftPassM.CSstepParabolicInd2 = pass.CsstepparabolicInd2?.M;
                dirFmPfcCycShiftPassM.CSstepSmartCrownInd0 = pass.CsstepsmartcrownInd0?.M;
                dirFmPfcCycShiftPassM.CSstepSmartCrownInd1 = pass.CsstepsmartcrownInd1?.M;
                dirFmPfcCycShiftPassM.CSstepSmartCrownInd2 = pass.CsstepsmartcrownInd2?.M;
                dirFmPfcCycShiftPassM.CSmode = pass.CsMode?.M;

            }
            await context.SaveChangesAsync();
        }

        private async Task UpdateFlatness(SetpointsHRMApxDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var dirFmPfcParaPassManuals = await context.DirFmPfcParaPpasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();

            foreach (var pass in input.FlatnessDtos.OrderByDescending(x => x.PassNo))
            {
                var dirFmPfcParaPassM = dirFmPfcParaPassManuals.FirstOrDefault(x => x.PassNo == pass.PassNo);
                if (dirFmPfcParaPassM == null)
                {
                    dirFmPfcParaPassM = new DirFmPfcParaPpass()
                    {
                        MeCreator = vMatStructEntryOr.EnOrCreator,
                        MeId = vMatStructEntryOr.EnOrMeId,
                        MesId = (short)vMatStructEntryOr.EnOrMesId,
                        PassNo = pass.PassNo,
                        Source = "M",
                    };
                    context.DirFmPfcParaPpasses.Add(dirFmPfcParaPassM);
                }

                dirFmPfcParaPassM.FbUl = pass.Fbul?.M;
                dirFmPfcParaPassM.FbLl = pass.Fbll?.M;
                dirFmPfcParaPassM.SrUl = pass.Srul?.M;
                dirFmPfcParaPassM.SrLl = pass.Srll?.M;
                dirFmPfcParaPassM.FacDfbDfr = pass.Facdfbdfr?.M;
                dirFmPfcParaPassM.FacDfbDiu = pass.Facdfbdiu?.M;

            }
            await context.SaveChangesAsync();
        }

        private async Task UpdateTaperShiftingTab(SetpointsHRMApxDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();
            var srpManual = await context.Srps.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "E").FirstOrDefaultAsync();

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
                srpPassM.PlanNo = srpManual?.PlanNo;
                srpPassM.Model = pass.Model?.M;
            }

            await context.SaveChangesAsync();

        }

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
                Lps = await _prdbContext.Lps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Spord2pcs = await _prdbContext.SpOrd2Pcs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edordents = await _prdbContext.EdOrdEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edphyents = await _prdbContext.EdPhyEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnPhMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edlogents = await _prdbContext.EdLogEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnLoMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Mes = await _prdbContext.Mes.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId).AsNoTracking().ToListAsync(),
                DirFmPfcParaPs = await _prdbContext.DirFmPfcParaPs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                DirFmPfcParapPasses = await _prdbContext.DirFmPfcParaPpasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                DpRms = await _prdbContext.Dphrms.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Dpramprms = await _prdbContext.DprampHrms.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source) && x.RampNo == 1).AsNoTracking().ToListAsync(),
                adordPc2 = await _prdbContext.AdOrd2Pcs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "S").FirstOrDefaultAsync(),
                adordPc2Stands = await _prdbContext.AdOrd2PcStands.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "S").ToListAsync(),
                Edghrm = await _prdbContext.Edghrms.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),


                StatSpord2pcstands = await _prdbContext.StatSpOrd2PcStands.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").AsNoTracking().ToListAsync(),
                StatLppasses = await _prdbContext.StatLppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").AsNoTracking().ToListAsync(),
                StatDirfmpfccycshiftps = await _prdbContext.StatDirFmPfcCycShiftPs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").AsNoTracking().FirstOrDefaultAsync(),
                StatDirfmpfccycshiftppasses = await _prdbContext.StatDirFmPfcCycShiftPpasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").AsNoTracking().ToListAsync(),
                StatSpord2pcs = await _prdbContext.StatSpOrd2Pcs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").AsNoTracking().FirstOrDefaultAsync(),
                StatEdordents = await _prdbContext.StatEdOrdEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").AsNoTracking().FirstOrDefaultAsync(),
                StatEdphyents = await _prdbContext.StatEdPhyEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnPhMeId && x.Source == "E").AsNoTracking().FirstOrDefaultAsync(),
                StatEdlogents = await _prdbContext.StatEdLogEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnLoMeId && x.Source == "E").AsNoTracking().FirstOrDefaultAsync(),
                StatDirFmPfcParaPs = await _prdbContext.StatDirFmPfcParaPs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").AsNoTracking().FirstOrDefaultAsync(),
                StatDirFmPfcParapPasses = await _prdbContext.StatDirFmPfcParaPpasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").AsNoTracking().ToListAsync(),
                StatadordPc2 = await _prdbContext.StatAdOrd2Pcs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").FirstOrDefaultAsync(),
                StatadordPc2Stands = await _prdbContext.StatAdOrd2PcStands.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").ToListAsync()
            };

            return setpointsHRMBlob;

        }

        private async Task<SetpointsHRMApxDataBlob> GetApxPassScheduleHrmDataBlob(VMatStructEntry hmiVEntryMatStruct)
        {
            string[] sources = ["L", "M", "S", "E"];

            return new SetpointsHRMApxDataBlob
            {
                Spord2pcs = await _prdbContext.SpOrd2Pcs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edordents = await _prdbContext.EdOrdEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edphyents = await _prdbContext.EdPhyEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnPhMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edlogents = await _prdbContext.EdLogEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnLoMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                DirFmPfcParaPs = await _prdbContext.DirFmPfcParaPs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Srppasses = await _prdbContext.Srppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Srp = await _prdbContext.Srps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Wmppasses = await _prdbContext.Wmppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Spord2pcstands = await _prdbContext.SpOrd2PcStands.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Lppasses = await _prdbContext.Lppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Dirfmpfccycshiftppasses = await _prdbContext.DirFmPfcCycShiftPpasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Dirfmpfccycshiftps = await _prdbContext.DirFmPfcCycShiftPs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Lps = await _prdbContext.Lps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                AdordPc2 = await _prdbContext.AdOrd2Pcs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "S").FirstOrDefaultAsync(),
                AdordPc2Stands = await _prdbContext.AdOrd2PcStands.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "S").ToListAsync(),
                DirFmPfcParaPasses = await _prdbContext.DirFmPfcParaPpasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Rcps = await _prdbContext.Rcps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),


                StatSpord2pcs = await _prdbContext.StatSpOrd2Pcs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").AsNoTracking().FirstOrDefaultAsync(),
                StatEdordents = await _prdbContext.StatEdOrdEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").AsNoTracking().FirstOrDefaultAsync(),
                StatEdphyents = await _prdbContext.StatEdPhyEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnPhMeId && x.Source == "E").AsNoTracking().FirstOrDefaultAsync(),
                StatEdlogents = await _prdbContext.StatEdLogEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnLoMeId && x.Source == "E").AsNoTracking().FirstOrDefaultAsync(),
                StatDirFmPfcParaPs = await _prdbContext.StatDirFmPfcParaPs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").AsNoTracking().FirstOrDefaultAsync(),
                StatDirFmPfcParapPasses = await _prdbContext.StatDirFmPfcParaPpasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").AsNoTracking().ToListAsync(),
                StatSpord2pcstands = await _prdbContext.StatSpOrd2PcStands.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").AsNoTracking().ToListAsync(),
                StatLppasses = await _prdbContext.StatLppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").AsNoTracking().ToListAsync(),
                StatDirfmpfccycshiftppasses = await _prdbContext.StatDirFmPfcCycShiftPpasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").AsNoTracking().ToListAsync(),
                StatDirfmpfccycshiftps = await _prdbContext.StatDirFmPfcCycShiftPs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").AsNoTracking().FirstOrDefaultAsync(),
                StatAdordPc2 = await _prdbContext.StatAdOrd2Pcs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").FirstOrDefaultAsync(),
                StatAdordPc2Stands = await _prdbContext.StatAdOrd2PcStands.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").ToListAsync()
            };
        }
    }
}