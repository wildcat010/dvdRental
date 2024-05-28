using System.Linq;
using System.Threading.Tasks;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebHMI.DataBlobs;
using WebHMI.Dtos.SetpointsRM;
using WebHMI.Helpers;
using WebHMI.L2Adapter.Senders;
using WebHMI.Mapping.Extensions;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Services
{
    public class SetpointsRmAppService : ApplicationServiceBase
    {
        private readonly MatStructEntryService _matStructEntryService;
        private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
        private readonly IL2Sender _l2Sender;

        private PrdbContext _prdbContext => _prdbContextProvider.GetDbContext();

        public SetpointsRmAppService(
            MatStructEntryService matStructEntryService, 
            IDbContextProvider<PrdbContext> prdbContextProvider, 
            IL2Sender l2Sender)
        {
            _matStructEntryService = matStructEntryService;
            _prdbContextProvider = prdbContextProvider;
            _l2Sender = l2Sender;
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_RM)]
        public async Task<SetpointsRmDto> GetPassScheduleHRM(int meid, string matType)
        {
            var result = new SetpointsRmDto();
            var hmiVEntryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(meid, matType);

            var dataBlob = await GetPassScheduleHrmDataBlob(hmiVEntryMatStruct);
            
            result.MeCode = hmiVEntryMatStruct.ToMeCodeDto();
            result.MapPlans(dataBlob)
                .MapStands(dataBlob, 4);

            return result;
        }

        [Audited]
        [AbpAuthorize(Permissions.Pages_Setpoints_RM_Edit)]
        public async Task UpdatePassScheduleHRM(SetpointsRmDto input)
        {
            var vMatStructEntry = await _matStructEntryService.GetMaterialEntryStruct(input.MeCode.MeId, input.MeCode.MatType);

            var transaction = await _prdbContext.Database.BeginTransactionAsync();

            var lpManual = await _prdbContext.Lps.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            lpManual = _prdbContext.InsertIfNull(lpManual, vMatStructEntry);
            lpManual.PlanNo = input.Plans.Loading.M;

            var dphrmManual = await _prdbContext.Dphrms.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            dphrmManual = _prdbContext.InsertIfNull(dphrmManual, vMatStructEntry);
            dphrmManual.PlanNo = input.Plans.Descaling.M;

            var rcpManual = await _prdbContext.Rcps.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            rcpManual = _prdbContext.InsertIfNull(rcpManual, vMatStructEntry);
            rcpManual.PlanNo = input.Plans.RollCooling.M;

            var tpManual = await _prdbContext.Tps.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            tpManual = _prdbContext.InsertIfNull(tpManual, vMatStructEntry);
            tpManual.PlanNo = input.Plans.Tension.M;

            var rglpManual = await _prdbContext.Rglps.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            rglpManual = _prdbContext.InsertIfNull(rglpManual, vMatStructEntry);
            rglpManual.PlanNo = input.Plans.RollGap.M;

            var iscpManual = await _prdbContext.Iscps.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            iscpManual = _prdbContext.InsertIfNull(iscpManual, vMatStructEntry);
            iscpManual.PlanNo = input.Plans.Isc.M;

            var lpPassManuals = await _prdbContext.Lppasses.Where(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M").ToListAsync();
            foreach (var pass in input.Stands.OrderByDescending(x => x.StandId))
            {
                var lpPassManual = lpPassManuals.FirstOrDefault(x => x.PassNo == pass.StandId);
                lpPassManual = _prdbContext.InsertIfNull(lpPassManual, vMatStructEntry);
                lpPassManual.PassNo = pass.StandId;
                lpPassManual.LoadingType = pass.LType.M;
                lpPassManual.LoadingValue = pass.Lv.M;
                lpPassManual.LoadingValueCorrection = pass.LvCorr.M;

                await _prdbContext.SaveChangesAsync();
            }

            await transaction.CommitAsync();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_RM)]
        public async Task<SetpointsRmApxDto> GetApxPassScheduleHRM(int meid, string matType)
        {
            var result = new SetpointsRmApxDto();
            var hmiVEntryMatStruct = await _matStructEntryService.GetMaterialEntryStruct(meid, matType);

            var dataBlob = await GetApxPassScheduleHrmDataBlob(hmiVEntryMatStruct);
            
            result.MeCode = hmiVEntryMatStruct.ToMeCodeDto();
            result.MapPlans(dataBlob)
                .MapStands(dataBlob, 4);

            return result;
        }
        
        [Audited]
        [AbpAuthorize(Permissions.Pages_Setpoints_RM_Edit)]
        public async Task UpdateApxPassScheduleHRM(string connectionId, SetpointsRmApxDto input)
        {
            var vMatStructEntry = await _matStructEntryService.GetMaterialEntryStruct(input.MeCode.MeId, input.MeCode.MatType);

            var transaction = await _prdbContext.Database.BeginTransactionAsync();

            var dirFmPfcCycShiftPManual = await _prdbContext.DirFmPfcCycShiftPs.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            dirFmPfcCycShiftPManual = _prdbContext.InsertIfNull(dirFmPfcCycShiftPManual, vMatStructEntry);
            dirFmPfcCycShiftPManual.PlanNo = input.Plans.Shifting.M;
            
            var dirFmPfcParaPManual = await _prdbContext.DirFmPfcParaPs.FirstOrDefaultAsync(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M");
            dirFmPfcParaPManual = _prdbContext.InsertIfNull(dirFmPfcParaPManual, vMatStructEntry);
            dirFmPfcParaPManual.PlanNo = input.Plans.Flatness.M;
            
            var dirFmPfcParaPpassManuals = await _prdbContext.DirFmPfcParaPpasses.Where(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M").ToListAsync();
            foreach (var pass in input.Stands.OrderByDescending(x => x.StandId))
            {
                var dirFmPfcParaPpassManual = dirFmPfcParaPpassManuals.FirstOrDefault(x => x.PassNo == pass.StandId);
                dirFmPfcParaPpassManual = _prdbContext.InsertIfNull(dirFmPfcParaPpassManual, vMatStructEntry);
                dirFmPfcParaPpassManual.PassNo = pass.StandId;
                dirFmPfcParaPpassManual.FbUl = pass.BendingForceUpperLimit.M;
                dirFmPfcParaPpassManual.FbLl = pass.BendingForceLowerLimit.M;
                dirFmPfcParaPpassManual.SrUl = pass.ShiftingUpperLimit.M;
                dirFmPfcParaPpassManual.SrLl = pass.ShiftingLowerLimit.M;
                dirFmPfcParaPpassManual.ObservedFlat = pass.ObsFlatness.M;
                await _prdbContext.SaveChangesAsync();
            }

            var dirFmPfcCycShiftPpassManuals = await _prdbContext.DirFmPfcCycShiftPpasses.Where(x => x.MeId == vMatStructEntry.EnOrMeId && x.Source == "M").ToListAsync();
            foreach (var pass in input.Stands.OrderByDescending(x => x.StandId))
            {
                var dirFmPfcCycShiftPpassManual = dirFmPfcCycShiftPpassManuals.FirstOrDefault(x => x.PassNo == pass.StandId);
                dirFmPfcCycShiftPpassManual = _prdbContext.InsertIfNull(dirFmPfcCycShiftPpassManual, vMatStructEntry);
                dirFmPfcCycShiftPpassManual.PassNo = pass.StandId;
                dirFmPfcCycShiftPpassManual.CSmaxLimit = pass.WearShiftingUpperLimit.M;
                dirFmPfcCycShiftPpassManual.CSminLimit = pass.WearShiftingLowerLimit.M;
                await _prdbContext.SaveChangesAsync();
            }

            await transaction.CommitAsync();
            _l2Sender.UpdateSetpointsRm(input.MeCode.ExtId, input.MeCode.MeId, input.MeCode.MesId, input.MeCode.MeCreator, connectionId);
        }

        private async Task<SetpointsRmDataBlob> GetPassScheduleHrmDataBlob(VMatStructEntry hmiVEntryMatStruct)
        {
            string[] sources = ["L", "X", "M", "S", "P", "E"];
            
            return new SetpointsRmDataBlob
            {
                LpPasses = await _prdbContext.Lppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                SpOrd2PcStands = await _prdbContext.SpOrd2PcStands.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Tppasses = await _prdbContext.Tppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                DirFmPfcParaPpasses = await _prdbContext.DirFmPfcParaPpasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                StatDirFmPfcParaPpassEffective = await _prdbContext.StatDirFmPfcParaPpasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").AsNoTracking().ToListAsync(),
                Lps = await _prdbContext.Lps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Dphrms = await _prdbContext.Dphrms.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Rcps = await _prdbContext.Rcps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Tps = await _prdbContext.Tps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Rglps = await _prdbContext.Rglps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                Iscps = await _prdbContext.Iscps.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                SrpPasses = await _prdbContext.Srppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
            };
        }
        
        private async Task<SetpointsRmApxDataBlob> GetApxPassScheduleHrmDataBlob(VMatStructEntry hmiVEntryMatStruct)
        {
            string[] sources = ["L", "X", "M", "S", "P", "E"];
            
            return new SetpointsRmApxDataBlob
            {
                LpPasses = await _prdbContext.Lppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                DirFmPfcParaPpasses = await _prdbContext.DirFmPfcParaPpasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                StatDirFmPfcParaPpassEffective = await _prdbContext.StatDirFmPfcParaPpasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && x.Source == "E").AsNoTracking().ToListAsync(),
                DirFmPfcCycShiftPpasses = await _prdbContext.DirFmPfcCycShiftPpasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                SpOrd2PcStands = await _prdbContext.SpOrd2PcStands.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                SrpPasses = await _prdbContext.Srppasses.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                DirFmPfcCycShiftPs = await _prdbContext.DirFmPfcCycShiftPs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
                DirFmPfcParaPs = await _prdbContext.DirFmPfcParaPs.Where(x => x.MeId == hmiVEntryMatStruct.EnOrMeId && sources.Contains(x.Source)).AsNoTracking().ToListAsync(),
            };
        }
    }
}