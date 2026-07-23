using System;
using System.Linq;
using System.Threading.Tasks;
using Abp.Auditing;
using Abp.Authorization;
using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebHMI.DataBlobs;
using WebHMI.Dtos.Setpoints.SetpointsHFM;
using WebHMI.Dtos.Setpoints.SetpointsHRM;
using WebHMI.Helpers;
using WebHMI.L2Adapter.Common;
using WebHMI.Mapping.Extensions;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Services
{
    public class SetpointsHFMAppService : ApplicationServiceBase
    {
        private readonly MatStructEntryService _matStructEntryService;
        private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
        private readonly IL2CommunicationHandler _l2Sender;
        private readonly short _standCount = 9;
        private readonly short _standStartIdx = 4;

        private PrdbContext _prdbContext => _prdbContextProvider.GetDbContext();

        public SetpointsHFMAppService(
            MatStructEntryService matStructEntryService,
            IDbContextProvider<PrdbContext> prdbContextProvider,
            IL2CommunicationHandler l2Sender
            )
        {
            _matStructEntryService = matStructEntryService;
            _prdbContextProvider = prdbContextProvider;
            _l2Sender = l2Sender;
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_FM)]
        public async Task<HFMMaterialOverviewDto> GetMaterialOverviewHFM(int MeId, string matType)
        {
            var result = new HFMMaterialOverviewDto();
            var hmiVEntryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(MeId, matType);

            string[] sources = ["L", "M", "S", "E"];

            var dataBlob = await GetPassScheduleHfmDataBlob(hmiVEntryMatStruct);

            result.MeCode = hmiVEntryMatStruct.ToOrMeCodeDto();
            result.MapOverview(dataBlob);

            return result;
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_Setpoints_FM_Edit)]
        public async Task UpdateMaterialOverviewHFM(HFMMaterialOverviewDto input)
        {
            var context = _prdbContextProvider.GetDbContext();
            var vMatStructEntryOr = await _matStructEntryService.GetMaterialEntryStruct(input.MeCode.MeId, "OR");

            var edOrdEntM = await context.EdOrdEnts.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            edOrdEntM = context.InsertIfNull(edOrdEntM, vMatStructEntryOr);
            edOrdEntM.HExit = input.HExit?.M;
            edOrdEntM.WidthExit = input.WidthExit?.M;
            edOrdEntM.TExit = input.TExit?.M;
            edOrdEntM.ExitCrownC25 = input.ExitCrownc25?.M;

            var edLogEntM = await context.EdLogEnts.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnLoMeId && x.Source == "M");
            edLogEntM = context.InsertIfNull(edLogEntM, vMatStructEntryOr);

            var edPhyEntM = await context.EdPhyEnts.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnPhMeId && x.Source == "M");
            edPhyEntM = context.InsertIfNull(edPhyEntM, vMatStructEntryOr);

            var dirFmPfcParapM = await context.DirFmPfcParaPs.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            dirFmPfcParapM = context.InsertIfNull(dirFmPfcParapM, vMatStructEntryOr);
            dirFmPfcParapM.ProfileCorr = input.ProfileCorr?.M;

            var lpM = await context.Lps.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            lpM = context.InsertIfNull(lpM, vMatStructEntryOr);
            lpM.RedDistHrmHfm = input.RedDistHrmFm?.M;
            lpM.PlanNo = input.LpPlanNo?.M;

            var dpfmM = await context.Dpfms.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            dpfmM = context.InsertIfNull(dpfmM, vMatStructEntryOr);
            dpfmM.PlanNo = input.DpHfmPlanNo?.M;

            var rcpM = await context.Rcps.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            rcpM = context.InsertIfNull(rcpM, vMatStructEntryOr);
            rcpM.PlanNo = input.RcpPlanNo?.M;

            var tpM = await context.Tps.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            tpM = context.InsertIfNull(tpM, vMatStructEntryOr);
            tpM.PlanNo = input.TpPlanNo?.M;

            var rglpM = await context.Rglps.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            rglpM = context.InsertIfNull(rglpM, vMatStructEntryOr);
            rglpM.PlanNo = input.RglpPlanNo?.M;

            var iscpM = await context.Iscps.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            iscpM = context.InsertIfNull(iscpM, vMatStructEntryOr);
            iscpM.PlanNo = input.IscpPlanNo?.M;

            var srpM = await context.Srps.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            srpM = context.InsertIfNull(srpM, vMatStructEntryOr);
            srpM.PlanNo = input.SrpPlanNo?.M;

            var ihpM = await context.Ihps.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            ihpM = context.InsertIfNull(ihpM, vMatStructEntryOr);
            ihpM.Temperature = input.Temperature?.M;

            var spOrd2PcM = await context.SpOrd2Pcs.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            spOrd2PcM = context.InsertIfNull(spOrd2PcM, vMatStructEntryOr);
            spOrd2PcM.LExit = input.LExit?.M;
            spOrd2PcM.Profexcalc = input.ProfExCalc?.M;

            await context.SaveChangesAsync();
        }

        //function to get the pass schedule and other related data for HFM
        [AbpAuthorize(Permissions.Pages_Setpoints_FM)]
        public async Task<SetpointsHFMDto> GetPassScheduleHFM(int MeId, string matType)
        {
            var result = new SetpointsHFMDto();
            var hmiVEntryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(MeId, matType);

            var dataBlob = await GetPassScheduleHfmDataBlob(hmiVEntryMatStruct);

            result.MeCode = hmiVEntryMatStruct.ToOrMeCodeDto();
            result.MapPassSchedule(dataBlob, _standCount, _standStartIdx);
            result.MapLubrication(dataBlob, _standCount, _standStartIdx);
            result.MapDescaling(dataBlob);
            result.MapAntiPeeling(dataBlob, _standCount, _standStartIdx);
            result.MapWorkCooling(dataBlob, _standCount, _standStartIdx);
            result.MapTension(dataBlob, _standCount, _standStartIdx);
            result.MapTaperShifting(dataBlob, _standCount, _standStartIdx);
            result.MapLoading(dataBlob, _standCount, _standStartIdx);
            result.MapPowerCooling(dataBlob);

            return result;
        }

        //function to update the pass schedule and other related data for HFM
        [Audited]
        [AbpAuthorize(Permissions.Pages_Setpoints_FM_Edit)]
        public async Task UpdatePassScheduleHFM(SetpointsHFMDto input)
        {
            var json = JsonConvert.SerializeObject(input);
            Console.WriteLine("Received JSON: " + json);

            var context = _prdbContextProvider.GetDbContext();
            var vMatStructEntry = await _matStructEntryService.GetMaterialEntryStruct(input.MeCode.MeId, "OR");
            //pass schedule
            await UpdateLpPasses(input, vMatStructEntry);
            await UpdateTpPasses(input, vMatStructEntry);
            await UpdateSrpPasses(input, vMatStructEntry);
            await UpdateSpOrdPasses(input, vMatStructEntry);
            await UpdateDirFmPfcParaPasses(input, vMatStructEntry);

            await UpdateLoadingTab(input, vMatStructEntry);
            await UpdateDescalingTab(input, vMatStructEntry);
            await UpdateWorkCoolingTab(input, vMatStructEntry);
            await UpdateTensionTab(input, vMatStructEntry);
            await UpdateLubricationTab(input, vMatStructEntry);
            await UpdateTaperShiftingTab(input, vMatStructEntry);
            await UpdateAntiPeelingTab(input, vMatStructEntry);
            await UpdatePowerCoolingTab(input, vMatStructEntry);
        }

        private async Task UpdateLpPasses(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
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

        private async Task UpdateTpPasses(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
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

        private async Task UpdateSrpPasses(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
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

            }
            await context.SaveChangesAsync();
        }

        private async Task UpdateSpOrdPasses(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
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

                spOrd2PcStandM.PositionWrs = pass.PositionWRS?.M;

            }
            await context.SaveChangesAsync();
        }

        private async Task UpdateDirFmPfcParaPasses(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
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

        private async Task UpdateLoadingTab(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
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

        private async Task UpdateDescalingTab(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

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

        private async Task UpdateWorkCoolingTab(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
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
                iscpPassM.IscVolumeInd0 = pass.IscVolumeInd0?.M;
                iscpPassM.IscVolumeInd1 = pass.IscVolumeInd1?.M;
                iscpPassM.IscVolumeInd2 = pass.IscVolumeInd2?.M;
                iscpPassM.IscVolumeInd3 = pass.IscVolumeInd3?.M;
                iscpPassM.FumeSuppSprayBehind = pass.FumesuppSprayBehind?.M;
                iscpPassM.LooperCool = pass.LooperCooling?.M;
            }

            await context.SaveChangesAsync();

        }

        private async Task UpdateAntiPeelingTab(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
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
                aopPassM.AntiOxStateEntry = pass.AntiOxStateEntry?.M;
                aopPassM.AntiOxidationEntry = pass.AntiOxidationEntry?.M;
                aopPassM.AntiOxStateExit = pass.AntiOxStateExit?.M;
                aopPassM.AntiOxidationExit = pass.AntiOxidationExit?.M;

                aopPassM.AntiPeelingState = pass.AntiPeelingState?.M;
                aopPassM.AntiPeeling = pass.AntiPeeling?.M;
            }

            await context.SaveChangesAsync();

        }
        private async Task UpdateTensionTab(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
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

        private async Task UpdateLubricationTab(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var rglpManual = await context.Rglps.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "E").FirstOrDefaultAsync();

            var rglpPassManuals = await context.Rglppasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();

            foreach (var pass in input.LubricationDtos.OrderByDescending(x => x.PassNo))
            {
                var rglpPassM = rglpPassManuals.FirstOrDefault(x => x.PassNo == pass.PassNo);
                if (rglpPassM == null)
                {
                    rglpPassM = new Rglppass()
                    {
                        MeCreator = vMatStructEntryOr.EnOrCreator,
                        MeId = vMatStructEntryOr.EnOrMeId,
                        MesId = (short)vMatStructEntryOr.EnOrMesId,
                        PassNo = pass.PassNo,
                        Source = "M",
                    };
                    context.Rglppasses.Add(rglpPassM);
                }

                rglpPassM.PlanNo = rglpManual?.PlanNo;
                rglpPassM.RollGapLubState = pass.RollGapLubState?.M;
                rglpPassM.RollGapLubRampTimeStart = pass.RollGapLubRampTimeStart?.M;
                rglpPassM.RollGapLubRampTimeStop = pass.RollGapLubRampTimeStop?.M;
                rglpPassM.RollGapLubSwitchLength = pass.RollGapLubSwitchLength?.M;
                rglpPassM.RollGapLubOilFlowTop = pass.RollGapLubOilFlowTop?.M;
                rglpPassM.RollGapLubOilFlowBot = pass.RollGapLubOilFlowBot?.M;

                await context.SaveChangesAsync();
            }
        }
        private async Task UpdateTaperShiftingTab(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
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

        //function to update the power cooling tab for HFM
        private async Task UpdatePowerCoolingTab(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var pcManual = await context.Pcs.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "E").FirstOrDefaultAsync();

            var pcRampManuals = await context.Pcramps.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();

            foreach (var ramp in input.PowerCooling.PowerCoolingRamps.OrderByDescending(x => x.RampNo))
            {
                var pcRampM = pcRampManuals.FirstOrDefault(x => x.RampNo == ramp.RampNo);
                if (pcRampM == null)
                {
                    pcRampM = new Pcramp()
                    {
                        MeCreator = vMatStructEntryOr.EnOrCreator,
                        MeId = vMatStructEntryOr.EnOrMeId,
                        MesId = (short)vMatStructEntryOr.EnOrMesId,
                        RampNo = ramp.RampNo,
                        Source = "M",
                    };
                    context.Pcramps.Add(pcRampM);
                }
                pcRampM.PlanNo = pcManual?.PlanNo;
                pcRampM.Description = ramp.Description.M;
                pcRampM.PcRampAuto = ramp.PcRampAuto.M ;
                pcRampM.PcRampState = ramp.PcRampState.M ;
                pcRampM.PlanNo = ramp.PlanNo.M ;
                pcRampM.PrioPowerC = ramp.PrioPowerC.M ;
                pcRampM.PcRampVolumeInd0 = ramp.PcRampVolumeInd0.M ;
                pcRampM.PcRampVolumeInd1 = ramp.PcRampVolumeInd1.M ;
            }

            await context.SaveChangesAsync();

        }

        [AbpAuthorize(Permissions.Pages_Setpoints_FM)]
        public async Task<HFMApxMaterialOverviewDto> GetApxMaterialOverview(int MeId, string matType)
        {
            var result = new HFMApxMaterialOverviewDto();
            var hmiVEntryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(MeId, matType);

            var dataBlob = await GetApxPassScheduleHfmDataBlob(hmiVEntryMatStruct);

            result.MeCode = hmiVEntryMatStruct.ToOrMeCodeDto();
            result.MapApxOverview(dataBlob);

            return result;
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_FM_Edit)]
        public async Task UpdateApxMaterialOverview(HFMApxMaterialOverviewDto input)
        {
            var context = _prdbContextProvider.GetDbContext();
            var vMatStructEntryOr = await _matStructEntryService.GetMaterialEntryStruct(input.MeCode.MeId, "OR");

            var edOrdEntM = await context.EdOrdEnts.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            edOrdEntM = context.InsertIfNull(edOrdEntM, vMatStructEntryOr);
            edOrdEntM.HExit = input.HExit?.M;
            edOrdEntM.WidthExit = input.WidthExit?.M;
            edOrdEntM.TExit = input.TExit?.M;
            edOrdEntM.ExitCrownC25 = input.ExitCrownC25?.M;

            var edLogEntM = await context.EdLogEnts.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnLoMeId && x.Source == "M");
            edLogEntM = context.InsertIfNull(edLogEntM, vMatStructEntryOr);

            var edPhyEntM = await context.EdPhyEnts.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnPhMeId && x.Source == "M");
            edPhyEntM = context.InsertIfNull(edPhyEntM, vMatStructEntryOr);

            var dirFmPfcParapM = await context.DirFmPfcParaPs.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            dirFmPfcParapM = context.InsertIfNull(dirFmPfcParapM, vMatStructEntryOr);
            dirFmPfcParapM.PlanNo = input.DirFmPfcParaPlanNo?.M;
            dirFmPfcParapM.ProfileCorr = input.ProfileCorr?.M;

            var srpM = await context.Srps.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            srpM = context.InsertIfNull(srpM, vMatStructEntryOr);
            srpM.PlanNo = input.SrpPlanNo?.M;

            var lpM = await context.Lps.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            lpM = context.InsertIfNull(lpM, vMatStructEntryOr);
            lpM.RedDistHrmHfm = input.RedDistHrmHfm?.M;

            var spOrd2PcM = await context.SpOrd2Pcs.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            spOrd2PcM = context.InsertIfNull(spOrd2PcM, vMatStructEntryOr);

            await context.SaveChangesAsync();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_FM)]
        public async Task<SetpointsHFMApxDto> GetApxPassScheduleHFM(int MeId, string matType)
        {
            var result = new SetpointsHFMApxDto();
            var hmiVEntryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(MeId, matType);

            var dataBlob = await GetApxPassScheduleHfmDataBlob(hmiVEntryMatStruct);

            result.MeCode = hmiVEntryMatStruct.ToOrMeCodeDto();
            result.MapApxPassSchedule(dataBlob, _standCount, _standStartIdx);
            result.MapShifting(dataBlob, _standCount, _standStartIdx);
            result.MapFlatness(dataBlob, _standCount, _standStartIdx);
            result.MapTaperShifting(dataBlob, _standCount, _standStartIdx);

            return result;
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_Setpoints_FM_Edit)]
        public async Task UpdateApxPassScheduleHFM(SetpointsHFMApxDto input, string connectionId, bool pdiChanged = false)
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
            await UpdateApxSpOrd2PcStands(input, vMatStructEntryOr);
            await UpdateApxDirFmPfcParaPasses(input, vMatStructEntryOr);

            await UpdateShifting(input, vMatStructEntryOr);
            await UpdateFlatness(input, vMatStructEntryOr);
            await UpdateTaperShiftingTab(input, vMatStructEntryOr);


            if (pdiChanged)
                _l2Sender.EntryDataChange(vMatStructEntryOr, connectionId);
            else
                _l2Sender.SetpointsCalculationHMI(vMatStructEntryOr, "HFM", connectionId);
        }

        private async Task UpdateLpSrpWmpPass(SetpointsHFMApxDto input, VMatStructEntry vMatStructEntryOr)
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
            }

        }

        private async Task UpdateApxSpOrd2PcStands(SetpointsHFMApxDto input, VMatStructEntry vMatStructEntryOr)
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
                        StandId = (short)pass.PassNo,
                        Source = "M",
                    };
                    context.SpOrd2PcStands.Add(spOrd2PcStandM);
                }

                spOrd2PcStandM.RelProfile = pass.RelProfile?.M;
                spOrd2PcStandM.Profile = pass.Profile?.M;
                spOrd2PcStandM.WCrown = pass.Wear?.M;

            }
            await context.SaveChangesAsync();
        }

        private async Task UpdateApxDirFmPfcParaPasses(SetpointsHFMApxDto input, VMatStructEntry vMatStructEntryOr)
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

        private async Task UpdateShifting(SetpointsHFMApxDto input, VMatStructEntry vMatStructEntryOr)
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
                dirFmPfcCycShiftPassM.Description =pass.Description?.M ;
                dirFmPfcCycShiftPassM.ManInt =pass.Manint?.M ;
                dirFmPfcCycShiftPassM.ToExtId =pass.Toextid?.M ;
                dirFmPfcCycShiftPassM.CSmaxLimitParabolicInd0 =pass.CsmaxlimitparabolicInd0?.M ;
                dirFmPfcCycShiftPassM.CSmaxLimitParabolicInd1 =pass.CsmaxlimitparabolicInd1?.M ;
                dirFmPfcCycShiftPassM.CSmaxLimitParabolicInd2 =pass.CsmaxlimitparabolicInd2?.M ;
                dirFmPfcCycShiftPassM.CSminLimitParabolicInd0 =pass.CsminlimitparabolicInd0?.M ;
                dirFmPfcCycShiftPassM.CSminLimitParabolicInd1 =pass.CsminlimitparabolicInd1?.M ;
                dirFmPfcCycShiftPassM.CSminLimitParabolicInd2 =pass.CsminlimitparabolicInd2?.M ;
                dirFmPfcCycShiftPassM.CSstepParabolicInd0 =pass.CsstepparabolicInd0?.M ;
                dirFmPfcCycShiftPassM.CSstepParabolicInd1 =pass.CsstepparabolicInd1?.M ;
                dirFmPfcCycShiftPassM.CSstepParabolicInd2 =pass.CsstepparabolicInd2?.M ;
                dirFmPfcCycShiftPassM.CSstepSmartCrownInd0 =pass.CsstepsmartcrownInd0?.M ;
                dirFmPfcCycShiftPassM.CSstepSmartCrownInd1 =pass.CsstepsmartcrownInd1?.M ;
                dirFmPfcCycShiftPassM.CSstepSmartCrownInd2 =pass.CsstepsmartcrownInd2?.M ;

            }
            await context.SaveChangesAsync();
        }

        private async Task UpdateFlatness(SetpointsHFMApxDto input, VMatStructEntry vMatStructEntryOr)
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

        private async Task UpdateTaperShiftingTab(SetpointsHFMApxDto input, VMatStructEntry vMatStructEntryOr)
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

        // function to get the pass schedule data blob for HFM
        private async Task<SetpointsHFMDataBlob> GetPassScheduleHfmDataBlob(VMatStructEntry hmiVEntryMatStruct)
        {
            string[] sources = ["L", "M", "S", "E"];
            var setpointsHFMBlob = new SetpointsHFMDataBlob()
            {
                Srps = await _prdbContext.Srps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Srppasses = await _prdbContext.Srppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Spord2pcstands = await _prdbContext.SpOrd2PcStands.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Aoppasses = await _prdbContext.Aoppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Iscpasses = await _prdbContext.Iscppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Rcppasses = await _prdbContext.Rcppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Lppasses = await _prdbContext.Lppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Tppasses = await _prdbContext.Tppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Rglppasses = await _prdbContext.Rglppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Dirfmpfccycshiftps = await _prdbContext.DirFmPfcCycShiftPs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Dirfmpfccycshiftppasses = await _prdbContext.DirFmPfcCycShiftPpasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Iscps = await _prdbContext.Iscps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Rglps = await _prdbContext.Rglps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Tps = await _prdbContext.Tps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Rcps = await _prdbContext.Rcps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Lps = await _prdbContext.Lps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Spord2pcs = await _prdbContext.SpOrd2Pcs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edordents = await _prdbContext.EdOrdEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edphyents = await _prdbContext.EdPhyEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edlogents = await _prdbContext.EdLogEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Mes = await _prdbContext.Mes.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId).AsNoTracking().ToListAsync(),
                DirFmPfcParaPs = await _prdbContext.DirFmPfcParaPs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                DirFmPfcParapPasses = await _prdbContext.DirFmPfcParaPpasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                DpFms = await _prdbContext.Dpfms.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Dprampfms = await _prdbContext.DprampFms.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Adord2PC = await _prdbContext.AdOrd2Pcs.Where(x=>x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "S").FirstOrDefaultAsync(),
                Adord2PCStands = await _prdbContext.AdOrd2PcStands.Where(x=>x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "S").ToListAsync(),
                Pc = await _prdbContext.Pcs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                PcRamp = await _prdbContext.Pcramps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                StatSpord2pcstands = await _prdbContext.StatSpOrd2PcStands.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source =="E").AsNoTracking().ToListAsync(),
                StatLppasses = await _prdbContext.StatLppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source =="E").AsNoTracking().ToListAsync(),
                StatDirfmpfccycshiftps = await _prdbContext.StatDirFmPfcCycShiftPs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source =="E").AsNoTracking().FirstOrDefaultAsync(),
                StatDirfmpfccycshiftppasses = await _prdbContext.StatDirFmPfcCycShiftPpasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source =="E").AsNoTracking().ToListAsync(),
                StatSpord2pcs = await _prdbContext.StatSpOrd2Pcs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source =="E").AsNoTracking().FirstOrDefaultAsync(),
                StatEdordents = await _prdbContext.StatEdOrdEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source =="E").AsNoTracking().FirstOrDefaultAsync(),
                StatEdphyents = await _prdbContext.StatEdPhyEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source =="E").AsNoTracking().FirstOrDefaultAsync(),
                StatEdlogents = await _prdbContext.StatEdLogEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source =="E").AsNoTracking().FirstOrDefaultAsync(),
                StatDirFmPfcParaPs = await _prdbContext.StatDirFmPfcParaPs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source =="E").AsNoTracking().FirstOrDefaultAsync(),
                StatDirFmPfcParapPasses = await _prdbContext.StatDirFmPfcParaPpasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source =="E").AsNoTracking().ToListAsync(),
                StatAdord2PC = await _prdbContext.StatAdOrd2Pcs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "M").FirstOrDefaultAsync(),
                StatAdord2PCStands = await _prdbContext.StatAdOrd2PcStands.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "M").ToListAsync(),
                Ihps = await _prdbContext.Ihps.Where(x=>x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
            };

            return setpointsHFMBlob;

        }

        private async Task<SetpointsHFMApxDataBlob> GetApxPassScheduleHfmDataBlob(VMatStructEntry hmiVEntryMatStruct)
        {
            string[] sources = ["L", "M", "S", "E"];

            return new SetpointsHFMApxDataBlob
            {
                Srps = await _prdbContext.Srps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Spord2pcs = await _prdbContext.SpOrd2Pcs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edordents = await _prdbContext.EdOrdEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edphyents = await _prdbContext.EdPhyEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnPhMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edlogents = await _prdbContext.EdLogEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnLoMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                DirFmPfcParaPs = await _prdbContext.DirFmPfcParaPs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Srppasses = await _prdbContext.Srppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Wmppasses = await _prdbContext.Wmppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Spord2pcstands = await _prdbContext.SpOrd2PcStands.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Lppasses = await _prdbContext.Lppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Dirfmpfccycshiftppasses = await _prdbContext.DirFmPfcCycShiftPpasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Dirfmpfccycshiftps = await _prdbContext.DirFmPfcCycShiftPs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Lps = await _prdbContext.Lps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Adord2Pc = await _prdbContext.AdOrd2Pcs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "S").FirstOrDefaultAsync(),
                Adord2PcStands = await _prdbContext.AdOrd2PcStands.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "S").ToListAsync(),
                Ihps = await _prdbContext.Ihps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                DirFmPfcParaPasses = await _prdbContext.DirFmPfcParaPpasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),

                StatSpord2pcs = await _prdbContext.StatSpOrd2Pcs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").AsNoTracking().FirstOrDefaultAsync(),
                StatEdordents = await _prdbContext.StatEdOrdEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").AsNoTracking().FirstOrDefaultAsync(),
                StatEdphyents = await _prdbContext.StatEdPhyEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnPhMeId && x.Source == "E").AsNoTracking().FirstOrDefaultAsync(),
                StatEdlogents = await _prdbContext.StatEdLogEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnLoMeId && x.Source == "E").AsNoTracking().FirstOrDefaultAsync(),
                StatDirFmPfcParaPs = await _prdbContext.StatDirFmPfcParaPs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").AsNoTracking().FirstOrDefaultAsync(),
                StatSpord2pcstands = await _prdbContext.StatSpOrd2PcStands.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").AsNoTracking().ToListAsync(),
                StatLppasses = await _prdbContext.StatLppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").AsNoTracking().ToListAsync(),
                StatDirfmpfccycshiftppasses = await _prdbContext.StatDirFmPfcCycShiftPpasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").AsNoTracking().ToListAsync(),
                StatDirfmpfccycshiftps = await _prdbContext.StatDirFmPfcCycShiftPs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").AsNoTracking().FirstOrDefaultAsync(),
                StatAdord2Pc = await _prdbContext.StatAdOrd2Pcs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").FirstOrDefaultAsync(),
                StatAdord2PcStands = await _prdbContext.StatAdOrd2PcStands.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").ToListAsync(),
                StatDirFmPfcParaPasses = await _prdbContext.StatDirFmPfcParaPpasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").ToListAsync()
            };
        }
    }
}