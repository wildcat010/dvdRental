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
        public async Task<HFMMaterialOverviewDto> GetMaterialOverviewHFM(int meid, string matType)
        {
            var result = new HFMMaterialOverviewDto();
            var hmiVEntryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(meid, matType);

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

            var edOrdEntM = await context.Edordents.FirstOrDefaultAsync(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M");
            edOrdEntM = context.InsertIfNull(edOrdEntM, vMatStructEntryOr);
            edOrdEntM.Hexit = input.HExit?.M;
            edOrdEntM.Widthexit = input.WidthExit?.M;
            edOrdEntM.Texit = input.TExit?.M;
            edOrdEntM.Exitcrownc25 = input.ExitCrownc25?.M;

            var edLogEntM = await context.Edlogents.FirstOrDefaultAsync(x => x.Meid == vMatStructEntryOr.Enlomeid && x.Source == "M");
            edLogEntM = context.InsertIfNull(edLogEntM, vMatStructEntryOr);

            var edPhyEntM = await context.Edphyents.FirstOrDefaultAsync(x => x.Meid == vMatStructEntryOr.Enphmeid && x.Source == "M");
            edPhyEntM = context.InsertIfNull(edPhyEntM, vMatStructEntryOr);

            var dirFmPfcParapM = await context.Dirfmpfcparaps.FirstOrDefaultAsync(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M");
            dirFmPfcParapM = context.InsertIfNull(dirFmPfcParapM, vMatStructEntryOr);
            dirFmPfcParapM.Profilecorr = input.ProfileCorr?.M;

            var lpM = await context.Lps.FirstOrDefaultAsync(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M");
            lpM = context.InsertIfNull(lpM, vMatStructEntryOr);
            lpM.Reddisthrmhfm = input.RedDistHrmFm?.M;
            lpM.Planno = input.LpPlanNo?.M;

            var dpfmM = await context.Dpfms.FirstOrDefaultAsync(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M");
            dpfmM = context.InsertIfNull(dpfmM, vMatStructEntryOr);
            dpfmM.Planno = input.DpHfmPlanNo?.M;

            var rcpM = await context.Rcps.FirstOrDefaultAsync(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M");
            rcpM = context.InsertIfNull(rcpM, vMatStructEntryOr);
            rcpM.Planno = input.RcpPlanNo?.M;

            var tpM = await context.Tps.FirstOrDefaultAsync(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M");
            tpM = context.InsertIfNull(tpM, vMatStructEntryOr);
            tpM.Planno = input.TpPlanNo?.M;

            var rglpM = await context.Rglps.FirstOrDefaultAsync(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M");
            rglpM = context.InsertIfNull(rglpM, vMatStructEntryOr);
            rglpM.Planno = input.RglpPlanNo?.M;

            var iscpM = await context.Iscps.FirstOrDefaultAsync(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M");
            iscpM = context.InsertIfNull(iscpM, vMatStructEntryOr);
            iscpM.Planno = input.IscpPlanNo?.M;

            var srpM = await context.Srps.FirstOrDefaultAsync(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M");
            srpM = context.InsertIfNull(srpM, vMatStructEntryOr);
            srpM.Planno = input.SrpPlanNo?.M;

            var ihpM = await context.Ihps.FirstOrDefaultAsync(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M");
            ihpM = context.InsertIfNull(ihpM, vMatStructEntryOr);
            ihpM.Temperature = input.Temperature?.M;

            var spord2pcM = await context.Spord2pcs.FirstOrDefaultAsync(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M");
            spord2pcM = context.InsertIfNull(spord2pcM, vMatStructEntryOr);
            spord2pcM.Lexit = input.LExit?.M;
            spord2pcM.Profexcalc = input.ProfExCalc?.M;

            await context.SaveChangesAsync();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_FM)]
        public async Task<SetpointsHFMDto> GetPassScheduleHFM(int meid, string matType)
        {
            var result = new SetpointsHFMDto();
            var hmiVEntryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(meid, matType);

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

            return result;
        }

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
        }

        private async Task UpdateLpPasses(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var lpPassManuals = await context.Lppasses.Where(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M").ToListAsync();

            foreach (var pass in input.PassScheduleDtos.OrderByDescending(x => x.PassNo))
            {
                var lpPassM = lpPassManuals.FirstOrDefault(x => x.Passno == pass.PassNo);
                if (lpPassM == null)
                {
                    lpPassM = new Lppass()
                    {
                        Mecreator = vMatStructEntryOr.Enorcreator,
                        Meid = vMatStructEntryOr.Enormeid,
                        Mesid = (short)vMatStructEntryOr.Enormesid,
                        Passno = pass.PassNo,
                        Source = "M",
                    };
                    context.Lppasses.Add(lpPassM);
                }

                lpPassM.Loadingtype = pass.LoadingType?.M;
                lpPassM.Loadingvalue = pass.LoadingValue?.M;
                lpPassM.Loadingvaluecorrection = pass.LoadingValueCorrection?.M;

            }
            await context.SaveChangesAsync();
        }

        private async Task UpdateTpPasses(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var tpPassManuals = await context.Tppasses.Where(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M").ToListAsync();

            foreach (var pass in input.PassScheduleDtos.OrderByDescending(x => x.PassNo))
            {
                var tpPassM = tpPassManuals.FirstOrDefault(x => x.Passno == pass.PassNo);
                if (tpPassM == null)
                {
                    tpPassM = new Tppass()
                    {
                        Mecreator = vMatStructEntryOr.Enorcreator,
                        Meid = vMatStructEntryOr.Enormeid,
                        Mesid = (short)vMatStructEntryOr.Enormesid,
                        Passno = pass.PassNo,
                        Source = "M",
                    };
                    context.Tppasses.Add(tpPassM);
                }

                tpPassM.Speciffotension = pass.SpecifFoTension?.M;

            }
            await context.SaveChangesAsync();
        }

        private async Task UpdateSrpPasses(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var srpManual = await context.Srps.Where(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "E").FirstOrDefaultAsync();

            var srpPassManuals = await context.Srppasses.Where(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M").ToListAsync();

            foreach (var pass in input.PassScheduleDtos.OrderByDescending(x => x.PassNo))
            {
                var srpPassM = srpPassManuals.FirstOrDefault(x => x.Passno == pass.PassNo);
                if (srpPassM == null)
                {
                    srpPassM = new Srppass()
                    {
                        Mecreator = vMatStructEntryOr.Enorcreator,
                        Meid = vMatStructEntryOr.Enormeid,
                        Mesid = (short)vMatStructEntryOr.Enormesid,
                        Passno = pass.PassNo,
                        Source = "M",
                    };
                    context.Srppasses.Add(srpPassM);
                }
                srpPassM.Planno = srpManual?.Planno;

            }
            await context.SaveChangesAsync();
        }

        private async Task UpdateSpOrdPasses(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var spOrd2PcStandManuals = await context.Spord2pcstands.Where(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M").ToListAsync();

            foreach (var pass in input.PassScheduleDtos.OrderByDescending(x => x.PassNo))
            {
                var spOrd2PcStandM = spOrd2PcStandManuals.FirstOrDefault(x => x.Standid == pass.PassNo);
                if (spOrd2PcStandM == null)
                {
                    spOrd2PcStandM = new Spord2pcstand()
                    {
                        Mecreator = vMatStructEntryOr.Enorcreator,
                        Meid = vMatStructEntryOr.Enormeid,
                        Mesid = (short)vMatStructEntryOr.Enormesid,
                        Standid = pass.PassNo,
                        Source = "M",
                    };
                    context.Spord2pcstands.Add(spOrd2PcStandM);
                }

                spOrd2PcStandM.Positionwrs = pass.PositionWRS?.M;

            }
            await context.SaveChangesAsync();
        }

        private async Task UpdateDirFmPfcParaPasses(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var dirFmPfcParaPassManuals = await context.Dirfmpfcparappasses.Where(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M").ToListAsync();

            foreach (var pass in input.PassScheduleDtos.OrderByDescending(x => x.PassNo))
            {
                var dirFmPfcParaPassM = dirFmPfcParaPassManuals.FirstOrDefault(x => x.Passno == pass.PassNo);
                if (dirFmPfcParaPassM == null)
                {
                    dirFmPfcParaPassM = new Dirfmpfcparappass()
                    {
                        Mecreator = vMatStructEntryOr.Enorcreator,
                        Meid = vMatStructEntryOr.Enormeid,
                        Mesid = (short)vMatStructEntryOr.Enormesid,
                        Passno = pass.PassNo,
                        Source = "M",
                    };
                    context.Dirfmpfcparappasses.Add(dirFmPfcParaPassM);
                }

                dirFmPfcParaPassM.Observedflat = pass.ObservedFlat?.M;

            }
            await context.SaveChangesAsync();
        }

        private async Task UpdateLoadingTab(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var lpPassManuals = await context.Lppasses.Where(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M").ToListAsync();

            foreach (var pass in input.LoadingDtos.OrderByDescending(x => x.PassNo))
            {
                var lpPassM = lpPassManuals.FirstOrDefault(x => x.Passno == pass.PassNo);
                if (lpPassM == null)
                {
                    lpPassM = new Lppass()
                    {
                        Mecreator = vMatStructEntryOr.Enorcreator,
                        Meid = vMatStructEntryOr.Enormeid,
                        Mesid = (short)vMatStructEntryOr.Enormesid,
                        Passno = pass.PassNo,
                        Source = "M",
                    };
                    context.Lppasses.Add(lpPassM);
                }
                lpPassM.Loadingtype = pass.LoadingType?.M;
                lpPassM.Loadingvalue = pass.LoadingValue?.M;
                lpPassM.Circumspeedcorrection = pass.CircumSpeedCorrection?.M;
                lpPassM.Bendingforce = pass.BendingForce?.M;

            }
            await context.SaveChangesAsync();
        }

        private async Task UpdateDescalingTab(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var dprampfmM = await context.Dprampfms.Where(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M").FirstOrDefaultAsync();

            if (dprampfmM == null)
            {
                dprampfmM = new Dprampfm()
                {
                    Mecreator = vMatStructEntryOr.Enorcreator,
                    Meid = vMatStructEntryOr.Enormeid,
                    Mesid = (short)vMatStructEntryOr.Enormesid,
                    Source = "M",
                };
                context.Dprampfms.Add(dprampfmM);
            }

            dprampfmM.Descrampauto = input.Descaling?.DescrampAuto.M;
            dprampfmM.Descrampstate = input.Descaling?.DescrampState.M;
            dprampfmM.Descrampvolume = input.Descaling?.DescrampVolume.M;

            await context.SaveChangesAsync();

        }

        private async Task UpdateWorkCoolingTab(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var rcpPassManuals = await context.Rcppasses.Where(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M").ToListAsync();

            foreach (var pass in input.WorkCoolingDtos.OrderByDescending(x => x.PassNo))
            {
                var rcPassM = rcpPassManuals.FirstOrDefault(x => x.Passno == pass.PassNo);
                if (rcPassM == null)
                {
                    rcPassM = new Rcppass()
                    {
                        Mecreator = vMatStructEntryOr.Enorcreator,
                        Meid = vMatStructEntryOr.Enormeid,
                        Mesid = (short)vMatStructEntryOr.Enormesid,
                        Passno = pass.PassNo,
                        Source = "M",
                    };
                    context.Rcppasses.Add(rcPassM);
                }
                rcPassM.Rollcoolstate = pass.RollCoolState?.M;
                rcPassM.FlowwrloadedInd0 = pass.FlowWrLoadedInd0?.M;
                rcPassM.FlowwrloadedInd1 = pass.FlowWrLoadedInd1?.M;
                rcPassM.FlowwrloadedInd2 = pass.FlowWrLoadedInd2?.M;
            }

            var iscpPassManuals = await context.Iscppasses.Where(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M").ToListAsync();

            foreach (var pass in input.WorkCoolingDtos.OrderByDescending(x => x.PassNo))
            {
                var iscpPassM = iscpPassManuals.FirstOrDefault(x => x.Passno == pass.PassNo);
                if (iscpPassM == null)
                {
                    iscpPassM = new Iscppass()
                    {
                        Mecreator = vMatStructEntryOr.Enorcreator,
                        Meid = vMatStructEntryOr.Enormeid,
                        Mesid = (short)vMatStructEntryOr.Enormesid,
                        Passno = pass.PassNo,
                        Source = "M",
                    };
                    context.Iscppasses.Add(iscpPassM);
                }
                iscpPassM.Stripspraybefor = pass.StripSprayBefor?.M;
                iscpPassM.IscvolumeInd0 = pass.IscVolumeInd0?.M;
                iscpPassM.IscvolumeInd1 = pass.IscVolumeInd1?.M;
                iscpPassM.IscvolumeInd2 = pass.IscVolumeInd2?.M;
                iscpPassM.IscvolumeInd3 = pass.IscVolumeInd3?.M;
                iscpPassM.Fumesuppspraybehind = pass.FumesuppSprayBehind?.M;
                iscpPassM.Loopercool = pass.LooperCooling?.M;
            }

            await context.SaveChangesAsync();

        }

        private async Task UpdateAntiPeelingTab(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var aopPassManuals = await context.Aoppasses.Where(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M").ToListAsync();

            foreach (var pass in input.AntiPeelingDtos.OrderByDescending(x => x.PassNo))
            {
                var aopPassM = aopPassManuals.FirstOrDefault(x => x.Passno == pass.PassNo);
                if (aopPassM == null)
                {
                    aopPassM = new Aoppass()
                    {
                        Mecreator = vMatStructEntryOr.Enorcreator,
                        Meid = vMatStructEntryOr.Enormeid,
                        Mesid = (short)vMatStructEntryOr.Enormesid,
                        Passno = pass.PassNo,
                        Source = "M",
                    };
                    context.Aoppasses.Add(aopPassM);
                }
                aopPassM.Antioxstateentry = pass.AntiOxStateEntry?.M;
                aopPassM.Antioxidationentry = pass.AntiOxidationEntry?.M;
                aopPassM.Antioxstateexit = pass.AntiOxStateExit?.M;
                aopPassM.Antioxidationexit = pass.AntiOxidationExit?.M;

                aopPassM.Antipeelingstate = pass.AntiPeelingState?.M;
                aopPassM.Antipeeling = pass.AntiPeeling?.M;
            }

            await context.SaveChangesAsync();

        }
        private async Task UpdateTensionTab(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var tpPassManuals = await context.Tppasses.Where(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M").ToListAsync();

            foreach (var pass in input.TensionDtos.OrderByDescending(x => x.PassNo))
            {
                var tpPassM = tpPassManuals.FirstOrDefault(x => x.Passno == pass.PassNo);
                if (tpPassM == null)
                {
                    tpPassM = new Tppass()
                    {
                        Mecreator = vMatStructEntryOr.Enorcreator,
                        Meid = vMatStructEntryOr.Enormeid,
                        Mesid = (short)vMatStructEntryOr.Enormesid,
                        Passno = pass.PassNo,
                        Source = "M",
                    };
                    context.Tppasses.Add(tpPassM);
                }
                tpPassM.Speciffotension = pass.SpeciffoTension?.M;
                tpPassM.Looperstriplen = pass.LooperStripLen?.M;
            }

            await context.SaveChangesAsync();

        }

        private async Task UpdateLubricationTab(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var rglpManual = await context.Rglps.Where(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "E").FirstOrDefaultAsync();

            var rglpPassManuals = await context.Rglppasses.Where(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M").ToListAsync();

            foreach (var pass in input.LubricationDtos.OrderByDescending(x => x.PassNo))
            {
                var rglpPassM = rglpPassManuals.FirstOrDefault(x => x.Passno == pass.PassNo);
                if (rglpPassM == null)
                {
                    rglpPassM = new Rglppass()
                    {
                        Mecreator = vMatStructEntryOr.Enorcreator,
                        Meid = vMatStructEntryOr.Enormeid,
                        Mesid = (short)vMatStructEntryOr.Enormesid,
                        Passno = pass.PassNo,
                        Source = "M",
                    };
                    context.Rglppasses.Add(rglpPassM);
                }

                rglpPassM.Planno = rglpManual?.Planno;
                rglpPassM.Rollgaplubstate = pass.RollGapLubState?.M;
                rglpPassM.Rollgaplubramptimestart = pass.RollGapLubRampTimeStart?.M;
                rglpPassM.Rollgaplubramptimestop = pass.RollGapLubRampTimeStop?.M;
                rglpPassM.Rollgaplubswitchlength = pass.RollGapLubSwitchLength?.M;
                rglpPassM.Rollgapluboilflowtop = pass.RollGapLubOilFlowTop?.M;
                rglpPassM.Rollgapluboilflowbot = pass.RollGapLubOilFlowBot?.M;

                await context.SaveChangesAsync();
            }
        }
        private async Task UpdateTaperShiftingTab(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var srpManual = await context.Srps.Where(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "E").FirstOrDefaultAsync();

            var srpPassManuals = await context.Srppasses.Where(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M").ToListAsync();

            foreach (var pass in input.TaperShiftingDtos.OrderByDescending(x => x.PassNo))
            {
                var srpPassM = srpPassManuals.FirstOrDefault(x => x.Passno == pass.PassNo);
                if (srpPassM == null)
                {
                    srpPassM = new Srppass()
                    {
                        Mecreator = vMatStructEntryOr.Enorcreator,
                        Meid = vMatStructEntryOr.Enormeid,
                        Mesid = (short)vMatStructEntryOr.Enormesid,
                        Passno = pass.PassNo,
                        Source = "M",
                    };
                    context.Srppasses.Add(srpPassM);
                }
                srpPassM.Planno = srpManual?.Planno;
                srpPassM.Model = pass.Model?.M;
            }

            await context.SaveChangesAsync();

        }

        [AbpAuthorize(Permissions.Pages_Setpoints_FM)]
        public async Task<HFMApxMaterialOverviewDto> GetApxMaterialOverview(int meid, string matType)
        {
            var result = new HFMApxMaterialOverviewDto();
            var hmiVEntryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(meid, matType);

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

            var edOrdEntM = await context.Edordents.FirstOrDefaultAsync(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M");
            edOrdEntM = context.InsertIfNull(edOrdEntM, vMatStructEntryOr);
            edOrdEntM.Hexit = input.HExit?.M;
            edOrdEntM.Widthexit = input.WidthExit?.M;
            edOrdEntM.Texit = input.TExit?.M;
            edOrdEntM.Exitcrownc25 = input.ExitCrownC25?.M;

            var edLogEntM = await context.Edlogents.FirstOrDefaultAsync(x => x.Meid == vMatStructEntryOr.Enlomeid && x.Source == "M");
            edLogEntM = context.InsertIfNull(edLogEntM, vMatStructEntryOr);

            var edPhyEntM = await context.Edphyents.FirstOrDefaultAsync(x => x.Meid == vMatStructEntryOr.Enphmeid && x.Source == "M");
            edPhyEntM = context.InsertIfNull(edPhyEntM, vMatStructEntryOr);

            var dirFmPfcParapM = await context.Dirfmpfcparaps.FirstOrDefaultAsync(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M");
            dirFmPfcParapM = context.InsertIfNull(dirFmPfcParapM, vMatStructEntryOr);
            dirFmPfcParapM.Planno = input.DirFmPfcParaPlanNo?.M;
            dirFmPfcParapM.Profilecorr = input.ProfileCorr?.M;

            var srpM = await context.Srps.FirstOrDefaultAsync(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M");
            srpM = context.InsertIfNull(srpM, vMatStructEntryOr);
            srpM.Planno = input.SrpPlanNo?.M;

            var lpM = await context.Lps.FirstOrDefaultAsync(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M");
            lpM = context.InsertIfNull(lpM, vMatStructEntryOr);
            lpM.Reddisthrmhfm = input.RedDistHrmHfm?.M;

            var spord2pcM = await context.Spord2pcs.FirstOrDefaultAsync(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M");
            spord2pcM = context.InsertIfNull(spord2pcM, vMatStructEntryOr);

            await context.SaveChangesAsync();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_FM)]
        public async Task<SetpointsHFMApxDto> GetApxPassScheduleHFM(int meid, string matType)
        {
            var result = new SetpointsHFMApxDto();
            var hmiVEntryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(meid, matType);

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

            var edPhyEntM = await context.Edphyents.FirstOrDefaultAsync(x => x.Meid == vMatStructEntryOr.Enphmeid && x.Source == "M");
            edPhyEntM = context.InsertIfNull(edPhyEntM, vMatStructEntryOr);

            var edLogEntM = await context.Edlogents.FirstOrDefaultAsync(x => x.Meid == vMatStructEntryOr.Enlomeid && x.Source == "M");
            edLogEntM = context.InsertIfNull(edLogEntM, vMatStructEntryOr);

            var edOrdEntM = await context.Edordents.FirstOrDefaultAsync(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M");
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

            var lpPassManuals = await context.Lppasses.Where(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M").ToListAsync();
            var srpPassManuals = await context.Srppasses.Where(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M").ToListAsync();
            var wmpPassManuals = await context.Wmppasses.Where(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M").ToListAsync();

            foreach (var pass in input.PassScheduleDtos.OrderByDescending(x => x.PassNo))
            {
                var lpPassM = lpPassManuals.FirstOrDefault(x => x.Passno == pass.PassNo);
                if (lpPassM == null)
                {
                    lpPassM = new Lppass()
                    {
                        Mecreator = vMatStructEntryOr.Enorcreator,
                        Meid = vMatStructEntryOr.Enormeid,
                        Mesid = (short)vMatStructEntryOr.Enormesid,
                        Passno = pass.PassNo,
                        Source = "M",
                    };
                    context.Lppasses.Add(lpPassM);
                }

                lpPassM.Bendingforce = pass.BendingForce?.M;
                lpPassM.Cvcshifting = pass.CvcShifting?.M;
            }

        }

        private async Task UpdateApxSpOrd2PcStands(SetpointsHFMApxDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var spOrd2PcStandManuals = await context.Spord2pcstands.Where(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M").ToListAsync();

            foreach (var pass in input.PassScheduleDtos.OrderByDescending(x => x.PassNo))
            {
                var spord2pcstandM = spOrd2PcStandManuals.FirstOrDefault(x => x.Standid == pass.PassNo);
                if (spord2pcstandM == null)
                {
                    spord2pcstandM = new Spord2pcstand()
                    {
                        Mecreator = vMatStructEntryOr.Enorcreator,
                        Meid = vMatStructEntryOr.Enormeid,
                        Mesid = (short)vMatStructEntryOr.Enormesid,
                        Standid = (short)pass.PassNo,
                        Source = "M",
                    };
                    context.Spord2pcstands.Add(spord2pcstandM);
                }

                spord2pcstandM.Relprofile = pass.RelProfile?.M;
                spord2pcstandM.Profile = pass.Profile?.M;
                spord2pcstandM.Wcrown = pass.Wear?.M;

            }
            await context.SaveChangesAsync();
        }

        private async Task UpdateApxDirFmPfcParaPasses(SetpointsHFMApxDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var dirFmPfcParaPassManuals = await context.Dirfmpfcparappasses.Where(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M").ToListAsync();

            foreach (var pass in input.PassScheduleDtos.OrderByDescending(x => x.PassNo))
            {
                var dirFmPfcParaPassM = dirFmPfcParaPassManuals.FirstOrDefault(x => x.Passno == pass.PassNo);
                if (dirFmPfcParaPassM == null)
                {
                    dirFmPfcParaPassM = new Dirfmpfcparappass()
                    {
                        Mecreator = vMatStructEntryOr.Enorcreator,
                        Meid = vMatStructEntryOr.Enormeid,
                        Mesid = (short)vMatStructEntryOr.Enormesid,
                        Passno = pass.PassNo,
                        Source = "M",
                    };
                    context.Dirfmpfcparappasses.Add(dirFmPfcParaPassM);
                }

                dirFmPfcParaPassM.Fbul = pass.Fbul?.M;
                dirFmPfcParaPassM.Fbll = pass.Fbll?.M;
                dirFmPfcParaPassM.Srul = pass.Srul?.M;
                dirFmPfcParaPassM.Srll = pass.Srll?.M;
                dirFmPfcParaPassM.Observedflat = pass.ObservedFlat?.M;

            }
            await context.SaveChangesAsync();
        }

        private async Task UpdateShifting(SetpointsHFMApxDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var dirFmPfcCycShiftPassManuals = await context.Dirfmpfccycshiftppasses.Where(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M").ToListAsync();

            foreach (var pass in input.ShiftingDtos.OrderByDescending(x => x.PassNo))
            {
                var dirFmPfcCycShiftPassM = dirFmPfcCycShiftPassManuals.FirstOrDefault(x => x.Passno == pass.PassNo);
                if (dirFmPfcCycShiftPassM == null)
                {
                    dirFmPfcCycShiftPassM = new Dirfmpfccycshiftppass()
                    {
                        Mecreator = vMatStructEntryOr.Enorcreator,
                        Meid = vMatStructEntryOr.Enormeid,
                        Mesid = (short)vMatStructEntryOr.Enormesid,
                        Passno = pass.PassNo,
                        Source = "M",
                    };
                    context.Dirfmpfccycshiftppasses.Add(dirFmPfcCycShiftPassM);
                }

                dirFmPfcCycShiftPassM.Csmaxlimit = pass.CsMaxLimit?.M;
                dirFmPfcCycShiftPassM.Csminlimit = pass.CsMinLimit?.M;
                dirFmPfcCycShiftPassM.Csstartpos = pass.CsStartPos?.M;
                dirFmPfcCycShiftPassM.Csshiftdir = pass.CsShiftDir?.M;
                dirFmPfcCycShiftPassM.Csshiftstep1 = pass.CsShiftStep1?.M;
                dirFmPfcCycShiftPassM.Csshiftstep2 = pass.CsShiftStep2?.M;
                dirFmPfcCycShiftPassM.Csshiftstep3 = pass.CsShiftStep3?.M;
                dirFmPfcCycShiftPassM.Description =pass.Description?.M ;
                dirFmPfcCycShiftPassM.Manint =pass.Manint?.M ;
                dirFmPfcCycShiftPassM.Toextid =pass.Toextid?.M ;
                dirFmPfcCycShiftPassM.CsmaxlimitparabolicInd0 =pass.CsmaxlimitparabolicInd0?.M ;
                dirFmPfcCycShiftPassM.CsmaxlimitparabolicInd1 =pass.CsmaxlimitparabolicInd1?.M ;
                dirFmPfcCycShiftPassM.CsmaxlimitparabolicInd2 =pass.CsmaxlimitparabolicInd2?.M ;
                dirFmPfcCycShiftPassM.CsminlimitparabolicInd0 =pass.CsminlimitparabolicInd0?.M ;
                dirFmPfcCycShiftPassM.CsminlimitparabolicInd1 =pass.CsminlimitparabolicInd1?.M ;
                dirFmPfcCycShiftPassM.CsminlimitparabolicInd2 =pass.CsminlimitparabolicInd2?.M ;
                dirFmPfcCycShiftPassM.CsstepparabolicInd0 =pass.CsstepparabolicInd0?.M ;
                dirFmPfcCycShiftPassM.CsstepparabolicInd1 =pass.CsstepparabolicInd1?.M ;
                dirFmPfcCycShiftPassM.CsstepparabolicInd2 =pass.CsstepparabolicInd2?.M ;
                dirFmPfcCycShiftPassM.CsstepsmartcrownInd0 =pass.CsstepsmartcrownInd0?.M ;
                dirFmPfcCycShiftPassM.CsstepsmartcrownInd1 =pass.CsstepsmartcrownInd1?.M ;
                dirFmPfcCycShiftPassM.CsstepsmartcrownInd2 =pass.CsstepsmartcrownInd2?.M ;

            }
            await context.SaveChangesAsync();
        }

        private async Task UpdateFlatness(SetpointsHFMApxDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var dirFmPfcParaPassManuals = await context.Dirfmpfcparappasses.Where(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M").ToListAsync();

            foreach (var pass in input.FlatnessDtos.OrderByDescending(x => x.PassNo))
            {
                var dirFmPfcParaPassM = dirFmPfcParaPassManuals.FirstOrDefault(x => x.Passno == pass.PassNo);
                if (dirFmPfcParaPassM == null)
                {
                    dirFmPfcParaPassM = new Dirfmpfcparappass()
                    {
                        Mecreator = vMatStructEntryOr.Enorcreator,
                        Meid = vMatStructEntryOr.Enormeid,
                        Mesid = (short)vMatStructEntryOr.Enormesid,
                        Passno = pass.PassNo,
                        Source = "M",
                    };
                    context.Dirfmpfcparappasses.Add(dirFmPfcParaPassM);
                }

                dirFmPfcParaPassM.Fbul = pass.Fbul?.M;
                dirFmPfcParaPassM.Fbll = pass.Fbll?.M;
                dirFmPfcParaPassM.Srul = pass.Srul?.M;
                dirFmPfcParaPassM.Srll = pass.Srll?.M;
                dirFmPfcParaPassM.Facdfbdfr = pass.Facdfbdfr?.M;
                dirFmPfcParaPassM.Facdfbdiu = pass.Facdfbdiu?.M;

            }
            await context.SaveChangesAsync();
        }

        private async Task UpdateTaperShiftingTab(SetpointsHFMApxDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var srpManual = await context.Srps.Where(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "E").FirstOrDefaultAsync();

            var srpPassManuals = await context.Srppasses.Where(x => x.Meid == vMatStructEntryOr.Enormeid && x.Source == "M").ToListAsync();

            foreach (var pass in input.TaperShiftingDtos.OrderByDescending(x => x.PassNo))
            {
                var srpPassM = srpPassManuals.FirstOrDefault(x => x.Passno == pass.PassNo);
                if (srpPassM == null)
                {
                    srpPassM = new Srppass()
                    {
                        Mecreator = vMatStructEntryOr.Enorcreator,
                        Meid = vMatStructEntryOr.Enormeid,
                        Mesid = (short)vMatStructEntryOr.Enormesid,
                        Passno = pass.PassNo,
                        Source = "M",
                    };
                    context.Srppasses.Add(srpPassM);
                }
                srpPassM.Planno = srpManual?.Planno;
                srpPassM.Model = pass.Model?.M;
            }

            await context.SaveChangesAsync();

        }

        private async Task<SetpointsHFMDataBlob> GetPassScheduleHfmDataBlob(VMatStructEntry hmiVEntryMatStruct)
        {
            string[] sources = ["L", "M", "S", "E"];
            var setpointsHFMBlob = new SetpointsHFMDataBlob()
            {
                Srps = await _prdbContext.Srps.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Srppasses = await _prdbContext.Srppasses.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Spord2pcstands = await _prdbContext.Spord2pcstands.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Aoppasses = await _prdbContext.Aoppasses.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Iscpasses = await _prdbContext.Iscppasses.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Rcppasses = await _prdbContext.Rcppasses.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Lppasses = await _prdbContext.Lppasses.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Tppasses = await _prdbContext.Tppasses.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Rglppasses = await _prdbContext.Rglppasses.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Dirfmpfccycshiftps = await _prdbContext.Dirfmpfccycshiftps.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Dirfmpfccycshiftppasses = await _prdbContext.Dirfmpfccycshiftppasses.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Iscps = await _prdbContext.Iscps.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Rglps = await _prdbContext.Rglps.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Tps = await _prdbContext.Tps.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Rcps = await _prdbContext.Rcps.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Lps = await _prdbContext.Lps.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Spord2pcs = await _prdbContext.Spord2pcs.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edordents = await _prdbContext.Edordents.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edphyents = await _prdbContext.Edphyents.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edlogents = await _prdbContext.Edlogents.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Mes = await _prdbContext.Mes.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid).AsNoTracking().ToListAsync(),
                DirFmPfcParaPs = await _prdbContext.Dirfmpfcparaps.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                DirFmPfcParapPasses = await _prdbContext.Dirfmpfcparappasses.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                DpFms = await _prdbContext.Dpfms.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Dprampfms = await _prdbContext.Dprampfms.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Adord2PC = await _prdbContext.Adord2pcs.Where(x=>x.Meid == hmiVEntryMatStruct.Enormeid && x.Source == "S").FirstOrDefaultAsync(),
                Adord2PCStands = await _prdbContext.Adord2pcstands.Where(x=>x.Meid == hmiVEntryMatStruct.Enormeid && x.Source == "S").ToListAsync(),
                StatSpord2pcstands = await _prdbContext.StatSpord2pcstands.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && x.Source =="E").AsNoTracking().ToListAsync(),
                StatLppasses = await _prdbContext.StatLppasses.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && x.Source =="E").AsNoTracking().ToListAsync(),
                StatDirfmpfccycshiftps = await _prdbContext.StatDirfmpfccycshiftps.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && x.Source =="E").AsNoTracking().FirstOrDefaultAsync(),
                StatDirfmpfccycshiftppasses = await _prdbContext.StatDirfmpfccycshiftppasses.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && x.Source =="E").AsNoTracking().ToListAsync(),
                StatSpord2pcs = await _prdbContext.StatSpord2pcs.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && x.Source =="E").AsNoTracking().FirstOrDefaultAsync(),
                StatEdordents = await _prdbContext.StatEdordents.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && x.Source =="E").AsNoTracking().FirstOrDefaultAsync(),
                StatEdphyents = await _prdbContext.StatEdphyents.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && x.Source =="E").AsNoTracking().FirstOrDefaultAsync(),
                StatEdlogents = await _prdbContext.StatEdlogents.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && x.Source =="E").AsNoTracking().FirstOrDefaultAsync(),
                StatDirFmPfcParaPs = await _prdbContext.StatDirfmpfcparaps.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && x.Source =="E").AsNoTracking().FirstOrDefaultAsync(),
                StatDirFmPfcParapPasses = await _prdbContext.StatDirfmpfcparappasses.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && x.Source =="E").AsNoTracking().ToListAsync(),
                StatAdord2PC = await _prdbContext.StatAdord2pcs.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && x.Source == "M").FirstOrDefaultAsync(),
                StatAdord2PCStands = await _prdbContext.StatAdord2pcstands.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && x.Source == "M").ToListAsync(),
                Ihps = await _prdbContext.Ihps.Where(x=>x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
            };

            return setpointsHFMBlob;

        }

        private async Task<SetpointsHFMApxDataBlob> GetApxPassScheduleHfmDataBlob(VMatStructEntry hmiVEntryMatStruct)
        {
            string[] sources = ["L", "M", "S", "E"];

            return new SetpointsHFMApxDataBlob
            {
                Srps = await _prdbContext.Srps.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Spord2pcs = await _prdbContext.Spord2pcs.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edordents = await _prdbContext.Edordents.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edphyents = await _prdbContext.Edphyents.Where(x => x.Meid == hmiVEntryMatStruct.Enphmeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edlogents = await _prdbContext.Edlogents.Where(x => x.Meid == hmiVEntryMatStruct.Enlomeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                DirFmPfcParaPs = await _prdbContext.Dirfmpfcparaps.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Srppasses = await _prdbContext.Srppasses.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Wmppasses = await _prdbContext.Wmppasses.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Spord2pcstands = await _prdbContext.Spord2pcstands.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Lppasses = await _prdbContext.Lppasses.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Dirfmpfccycshiftppasses = await _prdbContext.Dirfmpfccycshiftppasses.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Dirfmpfccycshiftps = await _prdbContext.Dirfmpfccycshiftps.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Lps = await _prdbContext.Lps.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Adord2Pc = await _prdbContext.Adord2pcs.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && x.Source == "S").FirstOrDefaultAsync(),
                Adord2PcStands = await _prdbContext.Adord2pcstands.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && x.Source == "S").ToListAsync(),
                Ihps = await _prdbContext.Ihps.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                DirFmPfcParaPasses = await _prdbContext.Dirfmpfcparappasses.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),


                StatSpord2pcs = await _prdbContext.StatSpord2pcs.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && x.Source == "E").AsNoTracking().FirstOrDefaultAsync(),
                StatEdordents = await _prdbContext.StatEdordents.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && x.Source == "E").AsNoTracking().FirstOrDefaultAsync(),
                StatEdphyents = await _prdbContext.StatEdphyents.Where(x => x.Meid == hmiVEntryMatStruct.Enphmeid && x.Source == "E").AsNoTracking().FirstOrDefaultAsync(),
                StatEdlogents = await _prdbContext.StatEdlogents.Where(x => x.Meid == hmiVEntryMatStruct.Enlomeid && x.Source == "E").AsNoTracking().FirstOrDefaultAsync(),
                StatDirFmPfcParaPs = await _prdbContext.StatDirfmpfcparaps.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && x.Source == "E").AsNoTracking().FirstOrDefaultAsync(),
                StatSpord2pcstands = await _prdbContext.StatSpord2pcstands.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && x.Source == "E").AsNoTracking().ToListAsync(),
                StatLppasses = await _prdbContext.StatLppasses.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && x.Source == "E").AsNoTracking().ToListAsync(),
                StatDirfmpfccycshiftppasses = await _prdbContext.StatDirfmpfccycshiftppasses.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && x.Source == "E").AsNoTracking().ToListAsync(),
                StatDirfmpfccycshiftps = await _prdbContext.StatDirfmpfccycshiftps.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && x.Source == "E").AsNoTracking().FirstOrDefaultAsync(),
                StatAdord2Pc = await _prdbContext.StatAdord2pcs.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && x.Source == "E").FirstOrDefaultAsync(),
                StatAdord2PcStands = await _prdbContext.StatAdord2pcstands.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && x.Source == "E").ToListAsync(),
                StatDirFmPfcParaPasses = await _prdbContext.StatDirfmpfcparappasses.Where(x => x.Meid == hmiVEntryMatStruct.Enormeid && x.Source == "E").ToListAsync()
            };
        }
    }
}