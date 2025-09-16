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

namespace WebHMI.Services
{
    public class SetpointsFMAppService : ApplicationServiceBase
    {
        private readonly MatStructEntryService _matStructEntryService;
        private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
        private readonly IL2Sender _l2Sender;
        private readonly short _standCount = 9;

        private PrdbContext _prdbContext => _prdbContextProvider.GetDbContext();

        public SetpointsFMAppService(
            MatStructEntryService matStructEntryService, 
            IDbContextProvider<PrdbContext> prdbContextProvider, 
            IL2Sender l2Sender)
        {
            _matStructEntryService = matStructEntryService;
            _prdbContextProvider = prdbContextProvider;
            _l2Sender = l2Sender;
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_FM)]
        public async Task<SetpointsHFMDto> GetPassScheduleHFM(int meid, string matType)
        {
            var result = new SetpointsHFMDto();
            var hmiVEntryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(meid, matType);

            var dataBlob = await GetPassScheduleHfmDataBlob(hmiVEntryMatStruct);
            
            result.MeCode = hmiVEntryMatStruct.ToMeCodeDto();
            result.MapData(dataBlob);
            result.MapStandData(dataBlob, _standCount);

            return result;
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_Setpoints_FM_Edit)]
        public async Task UpdatePassScheduleHFM(SetpointsHFMDto input)
        {
            var context = _prdbContextProvider.GetDbContext();
            var vMatStructEntryOr = await _matStructEntryService.GetMaterialEntryStruct(input.MeCode.MeId, "OR");

            var edOrdEntM = await context.EdOrdEnts.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            edOrdEntM = context.InsertIfNull(edOrdEntM, vMatStructEntryOr);
            edOrdEntM.HExit = input.HExit?.M;
            edOrdEntM.WidthExit = input.WidthExit?.M;
            edOrdEntM.TExit = input.TExit?.M;
            edOrdEntM.ExitCrownC25 = input.ExitCrownc25?.M;

            var dirFmPfcParapM = await context.DirFmPfcParaPs.FirstOrDefaultAsync(x =>x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            dirFmPfcParapM = context.InsertIfNull(dirFmPfcParapM, vMatStructEntryOr);
            dirFmPfcParapM.ProfileCorr = input.ProfileCorr?.M;

            var lpM = await context.Lps.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            lpM = context.InsertIfNull(lpM, vMatStructEntryOr);
            //lpM.REDDISTHRMHFM = input.RedDistHrmFm?.M;
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
            srpM.PlanNo = input.IscpPlanNo?.M;

            var ihpM = await context.Ihps.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            ihpM = context.InsertIfNull(ihpM, vMatStructEntryOr);
            ihpM.Temperature = input.Temperature?.M;

            await context.SaveChangesAsync();

            await UpdateLpPasses(input, vMatStructEntryOr);
            await UpdateTpPasses(input, vMatStructEntryOr);
            await UpdateRcpPasses(input, vMatStructEntryOr);
            await UpdateIscpPasses(input, vMatStructEntryOr);
            await UpdateSrpPasses(input, vMatStructEntryOr);
        }

        private async Task UpdateLpPasses(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr) 
        {
            var context = _prdbContextProvider.GetDbContext();

            var lpPassManuals = await context.Lppasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();

            foreach (var pass in input.StandDataDtos.OrderByDescending(x => x.PassNo))
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
                lpPassM.BendingForce = pass.BendingForce?.M;

                await context.SaveChangesAsync();
            }
        }

        private async Task UpdateTpPasses(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var tpPassManuals = await context.Tppasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();

            foreach (var pass in input.StandDataDtos.OrderByDescending(x => x.PassNo))
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

                tpPassM.PassNo = pass.PassNo;
                tpPassM.SpecifFoTension = pass.SpecifFoTension?.M;

                await context.SaveChangesAsync();
            }
        }
        private async Task UpdateRcpPasses(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var rcpPassManuals = await context.Rcppasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();

            foreach (var pass in input.StandDataDtos.OrderByDescending(x => x.PassNo))
            {
                var rcpPassM = rcpPassManuals.FirstOrDefault(x => x.PassNo == pass.PassNo);
                if (rcpPassM == null)
                {
                    rcpPassM = new Rcppass()
                    {
                        MeCreator = vMatStructEntryOr.EnOrCreator,
                        MeId = vMatStructEntryOr.EnOrMeId,
                        MesId = (short)vMatStructEntryOr.EnOrMesId,
                        PassNo = pass.PassNo,
                        Source = "M",
                    };
                    context.Rcppasses.Add(rcpPassM);
                }
                rcpPassM.PassNo = pass.PassNo;
                rcpPassM.FlowBrIdleInd0 = pass.FlowWrLoadedInd0?.M;
                rcpPassM.FlowBrIdleInd1 = pass.FlowWrLoadedInd1?.M;
                rcpPassM.FlowBrIdleInd2 = pass.FlowWrLoadedInd2?.M;

                await context.SaveChangesAsync();
            }
        }

        private async Task UpdateIscpPasses(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var iscpPassManuals = await context.Iscppasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();

            foreach (var pass in input.StandDataDtos.OrderByDescending(x => x.PassNo))
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
                iscpPassM.PassNo = pass.PassNo;
                iscpPassM.IscState = pass.IscState?.M;
                iscpPassM.StripSprayBefor = pass.StripSprayBefor?.M;

                await context.SaveChangesAsync();
            }
        }

        private async Task UpdateSrpPasses(SetpointsHFMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var srpPassManuals = await context.Srppasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();

            foreach (var pass in input.StandDataDtos.OrderByDescending(x => x.PassNo))
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

        [AbpAuthorize(Permissions.Pages_Setpoints_FM)]

        public async Task<SetpointsHFMApxDto> GetApxPassScheduleHFM(int meid, string matType)
        {
            var result = new SetpointsHFMApxDto();
            var hmiVEntryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(meid, matType);

            var dataBlob = await GetApxPassScheduleHfmDataBlob(hmiVEntryMatStruct);

            result.MeCode = hmiVEntryMatStruct.ToMeCodeDto();
            result.MapData(dataBlob);
            result.MapStandData(dataBlob, _standCount);

            return result;
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_Setpoints_FM_Edit)]
        public async Task UpdateApxPassScheduleHFM(SetpointsHFMApxDto input)
        {
            var context = _prdbContextProvider.GetDbContext();
            var vMatStructEntryOr = await _matStructEntryService.GetMaterialEntryStruct(input.MeCode.MeId, "OR");
            var vMatStructEntryLog = await _matStructEntryService.GetMaterialEntryStruct(vMatStructEntryOr.EnLoMeId, "LO");
            var vMatStructEntryPh = await _matStructEntryService.GetMaterialEntryStruct(vMatStructEntryOr.EnPhMeId, "PH");

            var edOrdEntM = await context.EdOrdEnts.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            edOrdEntM = context.InsertIfNull(edOrdEntM, vMatStructEntryOr);
            edOrdEntM.HExit = input.HExit?.M;
            edOrdEntM.WidthExit = input.WidthExit?.M;
            edOrdEntM.ExitCrownC25 = input.ExitCrownC25?.M;

            var dirFmPfcParapM = await context.DirFmPfcParaPs.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            dirFmPfcParapM = context.InsertIfNull(dirFmPfcParapM, vMatStructEntryOr);
            dirFmPfcParapM.ProfileCorr = input.ProfileCorr?.M;
            dirFmPfcParapM.PlanNo = input.DirFmPfcParaPlanNo?.M;

            var dirFmPfcCycShiftPM = await context.DirFmPfcCycShiftPs.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            dirFmPfcCycShiftPM = context.InsertIfNull(dirFmPfcCycShiftPM, vMatStructEntryOr);
            dirFmPfcCycShiftPM.PlanNo = input.DirFmPfcCycShiftPlanNo?.M;

            await context.SaveChangesAsync();

            await UpdateApxLpPasses(input, vMatStructEntryOr);
            await UpdateApxDirFmOfcParaPasses(input, vMatStructEntryOr);
        }

        private async Task UpdateApxLpPasses(SetpointsHFMApxDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var lpPassManuals = await context.Lppasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();

            foreach (var pass in input.StandDataDtos.OrderByDescending(x => x.PassNo))
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

                lpPassM.CVcshifting = pass.CvcShifting?.M;
                lpPassM.BendingForce = pass.BendingForce?.M;

                await context.SaveChangesAsync();
            }
        }

        private async Task UpdateApxDirFmOfcParaPasses(SetpointsHFMApxDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var dirFmPfcParaPassManuals = await context.DirFmPfcParaPpasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();

            foreach (var pass in input.StandDataDtos.OrderByDescending(x => x.PassNo))
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

                await context.SaveChangesAsync();
            }
        }

        private async Task<SetpointsHFMDataBlob> GetPassScheduleHfmDataBlob(VMatStructEntry hmiVEntryMatStruct)
        {
            string[] sources = ["L", "M", "S", "E"];
            var setpointsHFMBlob = new SetpointsHFMDataBlob() 
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
                Srps = await _prdbContext.Srps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Ihps = await _prdbContext.Ihps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Rcps = await _prdbContext.Rcps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Dpfms = await _prdbContext.Dpfms.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Lps = await _prdbContext.Lps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Spord2pcs = await _prdbContext.SpOrd2Pcs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edordents = await _prdbContext.EdOrdEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edphyents = await _prdbContext.EdPhyEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnPhMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edlogents = await _prdbContext.EdLogEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnLoMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Mes = await _prdbContext.Mes.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId).AsNoTracking().ToListAsync(),
                DirFmPfcParaPs = await _prdbContext.DirFmPfcParaPs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync()
            };

            return setpointsHFMBlob;

        }

        private async Task<SetpointsHFMApxDataBlob> GetApxPassScheduleHfmDataBlob(VMatStructEntry hmiVEntryMatStruct)
        {
            string[] sources = ["L", "M", "S", "E"];

            return new SetpointsHFMApxDataBlob
            {
                Spord2pcs = await _prdbContext.SpOrd2Pcs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edordents = await _prdbContext.EdOrdEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edphyents = await _prdbContext.EdPhyEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnPhMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Edlogents = await _prdbContext.EdLogEnts.Where(x => x.MeId == hmiVEntryMatStruct.EnLoMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                DirFmPfcParaPs = await _prdbContext.DirFmPfcParaPs.Where(x => x.MeId == hmiVEntryMatStruct.EnLoMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Srppasses = await _prdbContext.Srppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnLoMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Wmppasses = await _prdbContext.Wmppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnLoMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Spord2pcstands = await _prdbContext.SpOrd2PcStands.Where(x => x.MeId == hmiVEntryMatStruct.EnLoMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Lppasses = await _prdbContext.Lppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnLoMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Dirfmpfccycshiftppasses = await _prdbContext.DirFmPfcCycShiftPpasses.Where(x => x.MeId == hmiVEntryMatStruct.EnLoMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Dirfmpfccycshiftps = await _prdbContext.DirFmPfcCycShiftPs.Where(x => x.MeId == hmiVEntryMatStruct.EnLoMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync()

            };
        }
    }
}