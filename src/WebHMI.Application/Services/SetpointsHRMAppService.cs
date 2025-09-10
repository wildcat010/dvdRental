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
        public async Task<SetpointsHRMDto> GetPassScheduleHRM(int meid, string matType)
        {
            var result = new SetpointsHRMDto();
            var hmiVEntryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(meid, matType);

            var dataBlob = await GetPassScheduleHrmDataBlob(hmiVEntryMatStruct);
            
            result.MeCode = hmiVEntryMatStruct.ToMeCodeDto();
            result.MapData(dataBlob);
            result.MapStandData(dataBlob, _standCount);

            return result;
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_Setpoints_RM_Edit)]
        public async Task UpdatePassScheduleHRM(SetpointsHRMDto input)
        {
            var context = _prdbContextProvider.GetDbContext();
            var vMatStructEntryOr = await _matStructEntryService.GetMaterialEntryStruct(input.MeCode.MeId, "OR");
            var vMatStructEntryLog = await _matStructEntryService.GetMaterialEntryStruct(vMatStructEntryOr.EnLoMeId, "LO");
            var vMatStructEntryPh = await _matStructEntryService.GetMaterialEntryStruct(vMatStructEntryOr.EnPhMeId, "PH");

            var edPhyEntM = await context.EdPhyEnts.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryPh.EnPhMeId && x.Source == "M");
            edPhyEntM = context.InsertIfNull(edPhyEntM, vMatStructEntryPh);
            edPhyEntM.AimSlabThickness = input.AimsLabThickness?.M;
            edPhyEntM.SlabWidth = input.SlabWidth?.M;
            edPhyEntM.TEntry = input.TEntry?.M;
            edPhyEntM.SlabLength = input.SlabLength?.M;

            var edOrdEntM = await context.EdOrdEnts.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            edOrdEntM = context.InsertIfNull(edOrdEntM, vMatStructEntryOr);
            edOrdEntM.HIntermediate = input.HIntermediate?.M;

            var dirFmPfcParapM = await context.DirFmPfcParaPs.FirstOrDefaultAsync(x =>x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            dirFmPfcParapM = context.InsertIfNull(dirFmPfcParapM, vMatStructEntryOr);
            dirFmPfcParapM.ProfileCorr = input.ProfileCorr?.M;

            var lpM = await context.Lps.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            lpM = context.InsertIfNull(lpM, vMatStructEntryOr);
            //lpM.REDDISTHRMHFM = input.RedDistHrmFm?.M;
            lpM.PlanNo = input.LpPlanNo?.M;

            var dphrmM = await context.Dphrms.FirstOrDefaultAsync(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M");
            dphrmM = context.InsertIfNull(dphrmM, vMatStructEntryOr);
            dphrmM.PlanNo = input.DpHrmPlanNo?.M;

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

            await context.SaveChangesAsync();

            UpdateLpPasses(input, vMatStructEntryOr);
            UpdateTpPasses(input, vMatStructEntryOr);
            await UpdateRcpPasses(input, vMatStructEntryOr);
            await UpdateIscpPasses(input, vMatStructEntryOr);
            await UpdateAopPasses(input, vMatStructEntryOr);
        }

        private void UpdateLpPasses(SetpointsHRMDto input, VMatStructEntry vMatStructEntryOr) 
        {
            var context = _prdbContextProvider.GetDbContext();

            var lpPassManuals = context.Lppasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToList();

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

                context.SaveChanges();
            }
        }

        private void UpdateTpPasses(SetpointsHRMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var tpPassManuals = context.Tppasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToList();

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

                context.SaveChanges();
            }
        }

        private async Task UpdateRcpPasses(SetpointsHRMDto input, VMatStructEntry vMatStructEntryOr)
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

        private async Task UpdateIscpPasses(SetpointsHRMDto input, VMatStructEntry vMatStructEntryOr)
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
                iscpPassM.LooperCool = pass.LooperCool?.M;
                iscpPassM.StripSprayBefor = pass.StripSprayBefor?.M;

                await context.SaveChangesAsync();
            }
        }

        private async Task UpdateAopPasses(SetpointsHRMDto input, VMatStructEntry vMatStructEntryOr)
        {
            var context = _prdbContextProvider.GetDbContext();

            var aopPassManuals = await context.Aoppasses.Where(x => x.MeId == vMatStructEntryOr.EnOrMeId && x.Source == "M").ToListAsync();

            foreach (var pass in input.StandDataDtos.OrderByDescending(x => x.PassNo))
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
                aopPassM.PassNo = pass.PassNo;
                aopPassM = _prdbContext.InsertIfNull(aopPassM, vMatStructEntryOr);
                aopPassM.AntiPeelingState = pass.AntiPeelingState?.M;

                await context.SaveChangesAsync();
            }
        }


        //[AbpAuthorize(Permissions.Pages_Setpoints_RM)]
        //public async Task<SetpointsRmApxDto> GetApxPassScheduleHRM(int meid, string matType)
        //{
        //    var result = new SetpointsRmApxDto();
        //    var hmiVEntryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(meid, matType);

        //   // var dataBlob = await GetApxPassScheduleHrmDataBlob(hmiVEntryMatStruct);

        //    result.MeCode = hmiVEntryMatStruct.ToMeCodeDto();
        //    result.MapPlans(dataBlob)
        //        .MapStands(dataBlob, 4);

        //    return result;
        //}

        //[Audited]
        //[AbpAuthorize(Permissions.Pages_Setpoints_RM_Edit)]
        //public async Task UpdateApxPassScheduleHRM(string connectionId, SetpointsRmApxDto input)
        //{
        //    var vMatStructEntry = await _matStructEntryService.GetMaterialEntryStruct(input.MeCode.MeId, input.MeCode.MatType);

        //    var transaction = await _prdbContext.Database.BeginTransactionAsync();

        //    var dirFmPfcCycShiftPManual = await _prdbContext.DirFmPfcCycShiftPs.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
        //    dirFmPfcCycShiftPManual = _prdbContext.InsertIfNull(dirFmPfcCycShiftPManual, vMatStructEntry);
        //    dirFmPfcCycShiftPManual.PlanNo = input.Plans.Shifting.M;

        //    var dirFmPfcParaPManual = await _prdbContext.DirFmPfcParaPs.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
        //    dirFmPfcParaPManual = _prdbContext.InsertIfNull(dirFmPfcParaPManual, vMatStructEntry);
        //    dirFmPfcParaPManual.PlanNo = input.Plans.Flatness.M;

        //    var dirFmPfcParaPpassManuals = await _prdbContext.DirFmPfcParaPpasses.Where(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M").ToListAsync();
        //    foreach (var pass in input.Stands.OrderByDescending(x => x.StandId))
        //    {
        //        var dirFmPfcParaPpassManual = dirFmPfcParaPpassManuals.FirstOrDefault(x => x.PassNo == pass.StandId);
        //        dirFmPfcParaPpassManual = _prdbContext.InsertIfNull(dirFmPfcParaPpassManual, vMatStructEntry);
        //        dirFmPfcParaPpassManual.PassNo = pass.StandId;
        //        dirFmPfcParaPpassManual.FbUl = pass.BendingForceUpperLimit.M;
        //        dirFmPfcParaPpassManual.FbLl = pass.BendingForceLowerLimit.M;
        //        dirFmPfcParaPpassManual.SrUl = pass.ShiftingUpperLimit.M;
        //        dirFmPfcParaPpassManual.SrLl = pass.ShiftingLowerLimit.M;
        //        dirFmPfcParaPpassManual.ObservedFlat = pass.ObsFlatness.M;
        //        await _prdbContext.SaveChangesAsync();
        //    }

        //    var dirFmPfcCycShiftPpassManuals = await _prdbContext.DirFmPfcCycShiftPpasses.Where(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M").ToListAsync();
        //    foreach (var pass in input.Stands.OrderByDescending(x => x.StandId))
        //    {
        //        var dirFmPfcCycShiftPpassManual = dirFmPfcCycShiftPpassManuals.FirstOrDefault(x => x.PassNo == pass.StandId);
        //        dirFmPfcCycShiftPpassManual = _prdbContext.InsertIfNull(dirFmPfcCycShiftPpassManual, vMatStructEntry);
        //        dirFmPfcCycShiftPpassManual.PassNo = pass.StandId;
        //        dirFmPfcCycShiftPpassManual.CSmaxLimit = pass.WearShiftingUpperLimit.M;
        //        dirFmPfcCycShiftPpassManual.CSminLimit = pass.WearShiftingLowerLimit.M;
        //        await _prdbContext.SaveChangesAsync();
        //    }

        //    await transaction.CommitAsync();
        //    _l2Sender.UpdateSetpointsRm(input.MeCode.ExtId, input.MeCode.MeId, input.MeCode.MesId, input.MeCode.MeCreator, connectionId);
        //}

        private async Task<SetpointsHRMDataBlob> GetPassScheduleHrmDataBlob(VMatStructEntry hmiVEntryMatStruct)
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
                DirFmPfcParaPs = await _prdbContext.DirFmPfcParaPs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync()
            };

            return setpointsHRMBlob;

        }
        
        //private async Task<SetpointsRmApxDataBlob> GetApxPassScheduleHrmDataBlob(VMatStructEntry hmiVEntryMatStruct)
        //{
        //    string[] sources = ["L", "X", "M", "S", "P", "E"];
            
        //    return new SetpointsRmApxDataBlob
        //    {
        //        LpPasses = await _prdbContext.Lppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
        //        DirFmPfcParaPpasses = await _prdbContext.DirFmPfcParaPpasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
        //        StatDirFmPfcParaPpassEffective = await _prdbContext.StatDirFmPfcParaPpasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").AsNoTracking().ToListAsync(),
        //        DirFmPfcCycShiftPpasses = await _prdbContext.DirFmPfcCycShiftPpasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
        //        SpOrd2PcStands = await _prdbContext.SpOrd2PcStands.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
        //        SrpPasses = await _prdbContext.Srppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
        //        DirFmPfcCycShiftPs = await _prdbContext.DirFmPfcCycShiftPs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
        //        DirFmPfcParaPs = await _prdbContext.DirFmPfcParaPs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
        //    };
        //}
    }
}