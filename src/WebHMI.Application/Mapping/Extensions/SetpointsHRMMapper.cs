using System.Linq;
using WebHMI.DataBlobs;
using WebHMI.Dtos.Setpoints.CommonDtos;
using WebHMI.Dtos.Setpoints.CommonDtos.ApxDtos;
using WebHMI.Dtos.Setpoints.SetpointsHRM;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions
{
    public static class SetpointsHRMMapper
    {
        //function to map the overview data from the data blob to the dto
        public static HRMMaterialOverviewDto MapOverview(this HRMMaterialOverviewDto result, SetpointsHRMDataBlob dataBlob)
        {
            var iscpL = dataBlob.Iscps.Where(x => x.Source == "L").FirstOrDefault();
            var iscpM = dataBlob.Iscps.Where(x => x.Source == "M").FirstOrDefault();
            var iscpS = dataBlob.Iscps.Where(x => x.Source == "S").FirstOrDefault();
            var iscpE = dataBlob.Iscps.Where(x => x.Source == "E").FirstOrDefault();

            var rglpL = dataBlob.Rglps.Where(x => x.Source == "L").FirstOrDefault();
            var rglpM = dataBlob.Rglps.Where(x => x.Source == "M").FirstOrDefault();
            var rglpS = dataBlob.Rglps.Where(x => x.Source == "S").FirstOrDefault();
            var rglpE = dataBlob.Rglps.Where(x => x.Source == "E").FirstOrDefault();

            var tpL = dataBlob.Tps.Where(x => x.Source == "L").FirstOrDefault();
            var tpM = dataBlob.Tps.Where(x => x.Source == "M").FirstOrDefault();
            var tpS = dataBlob.Tps.Where(x => x.Source == "S").FirstOrDefault();
            var tpE = dataBlob.Tps.Where(x => x.Source == "E").FirstOrDefault();

            var rcpL = dataBlob.Rcps.Where(x => x.Source == "L").FirstOrDefault();
            var rcpM = dataBlob.Rcps.Where(x => x.Source == "M").FirstOrDefault();
            var rcpS = dataBlob.Rcps.Where(x => x.Source == "S").FirstOrDefault();
            var rcpE = dataBlob.Rcps.Where(x => x.Source == "E").FirstOrDefault();

            var dphrmL = dataBlob.DpRms.Where(x => x.Source == "L").FirstOrDefault();
            var dphrmM = dataBlob.DpRms.Where(x => x.Source == "M").FirstOrDefault();
            var dphrmS = dataBlob.DpRms.Where(x => x.Source == "S").FirstOrDefault();
            var dphrmE = dataBlob.DpRms.Where(x => x.Source == "E").FirstOrDefault();

            var lpL = dataBlob.Lps.Where(x => x.Source == "L").FirstOrDefault();
            var lpM = dataBlob.Lps.Where(x => x.Source == "M").FirstOrDefault();
            var lpS = dataBlob.Lps.Where(x => x.Source == "S").FirstOrDefault();
            var lpE = dataBlob.Lps.Where(x => x.Source == "E").FirstOrDefault();

            var spOrd2PcL = dataBlob.Spord2pcs.Where(x => x.Source == "L").FirstOrDefault();
            var spOrd2PcM = dataBlob.Spord2pcs.Where(x => x.Source == "M").FirstOrDefault();
            var spOrd2PcS = dataBlob.Spord2pcs.Where(x => x.Source == "S").FirstOrDefault();
            var spOrd2PcE = dataBlob.Spord2pcs.Where(x => x.Source == "E").FirstOrDefault();

            var edOrdEntL = dataBlob.Edordents.Where(x => x.Source == "L").FirstOrDefault();
            var edOrdEntM = dataBlob.Edordents.Where(x => x.Source == "M").FirstOrDefault();
            var edOrdEntS = dataBlob.Edordents.Where(x => x.Source == "S").FirstOrDefault();
            var edOrdEntE = dataBlob.Edordents.Where(x => x.Source == "E").FirstOrDefault();

            var edPhyEntL = dataBlob.Edphyents.Where(x => x.Source == "L").FirstOrDefault();
            var edPhyEntM = dataBlob.Edphyents.Where(x => x.Source == "M").FirstOrDefault();
            var edPhyEntS = dataBlob.Edphyents.Where(x => x.Source == "S").FirstOrDefault();
            var edPhyEntE = dataBlob.Edphyents.Where(x => x.Source == "E").FirstOrDefault();

            var edLogEntL = dataBlob.Edlogents.Where(x => x.Source == "L").FirstOrDefault();
            var edLogEntM = dataBlob.Edlogents.Where(x => x.Source == "M").FirstOrDefault();
            var edLogEntS = dataBlob.Edlogents.Where(x => x.Source == "S").FirstOrDefault();
            var edLogEntE = dataBlob.Edlogents.Where(x => x.Source == "E").FirstOrDefault();

            var dirFmPfcParaPL = dataBlob.DirFmPfcParaPs.Where(x => x.Source == "L").FirstOrDefault();
            var dirFmPfcParaPM = dataBlob.DirFmPfcParaPs.Where(x => x.Source == "M").FirstOrDefault();
            var dirFmPfcParaPS = dataBlob.DirFmPfcParaPs.Where(x => x.Source == "S").FirstOrDefault();
            var dirFmPfcParaPE = dataBlob.DirFmPfcParaPs.Where(x => x.Source == "E").FirstOrDefault();

            var dirFmPfcCycShiftL = dataBlob.Dirfmpfccycshiftps.Where(x => x.Source == "L").FirstOrDefault();
            var dirFmPfcCycShiftM = dataBlob.Dirfmpfccycshiftps.Where(x => x.Source == "M").FirstOrDefault();
            var dirFmPfcCycShiftS = dataBlob.Dirfmpfccycshiftps.Where(x => x.Source == "S").FirstOrDefault();
            var dirFmPfcCycShiftE = dataBlob.Dirfmpfccycshiftps.Where(x => x.Source == "E").FirstOrDefault();

            var aopL = dataBlob.Aoppasses.Where(x => x.Source == "L").FirstOrDefault();
            var aopM = dataBlob.Aoppasses.Where(x => x.Source == "M").FirstOrDefault();
            var aopS = dataBlob.Aoppasses.Where(x => x.Source == "S").FirstOrDefault();
            var aopE = dataBlob.Aoppasses.Where(x => x.Source == "E").FirstOrDefault();

            var edgHrmL = dataBlob.Edghrm.Where(x => x.Source == "L").FirstOrDefault();
            var edgHrmM = dataBlob.Edghrm.Where(x => x.Source == "M").FirstOrDefault();
            var edgHrmS = dataBlob.Edghrm.Where(x => x.Source == "S").FirstOrDefault();
            var edgHrmE = dataBlob.Edghrm.Where(x => x.Source == "E").FirstOrDefault();

            result.AimsLabThickness.L = edPhyEntL?.AimSlabThickness;
            result.AimsLabThickness.E = edPhyEntE?.AimSlabThickness;
            result.AimsLabThickness.M = edPhyEntM?.AimSlabThickness;
            result.AimsLabThickness.S = dataBlob.adordPc2?.HExit;
            result.AimsLabThickness.DbSource = $"{nameof(EdPhyEnt)}.{nameof(EdPhyEnt.AimSlabThickness)}";
            result.AimsLabThickness.Status = dataBlob.StatEdphyents?.AimSlabThickness;

            result.SlabWidth.L = edPhyEntL?.SlabWidth;
            result.SlabWidth.E = edPhyEntE?.SlabWidth;
            result.SlabWidth.M = edPhyEntM?.SlabWidth;
            result.SlabWidth.S = dataBlob.adordPc2?.WExit;
            result.SlabWidth.DbSource = $"{nameof(EdPhyEnt)}.{nameof(EdPhyEnt.SlabWidth)}";
            result.SlabWidth.Status = dataBlob.StatEdphyents?.SlabWidth;

            result.ExitCrownC25.L = edOrdEntL?.ExitCrownC40;
            result.ExitCrownC25.E = edOrdEntE?.ExitCrownC40;
            result.ExitCrownC25.M = edOrdEntM?.ExitCrownC40;
            result.ExitCrownC25.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.ExitCrownC40)}";
            result.ExitCrownC25.Status = dataBlob.StatEdordents?.ExitCrownC40;

            result.TEntry.L = edPhyEntL?.TEntry;
            result.TEntry.E = edPhyEntE?.TEntry;
            result.TEntry.M = edPhyEntM?.TEntry;
            result.TEntry.DbSource = $"{nameof(EdPhyEnt)}.{nameof(EdPhyEnt.TEntry)}";
            result.TEntry.Status = dataBlob.StatEdphyents?.TEntry;

            result.SlabLength.L = edPhyEntL?.SlabLength;
            result.SlabLength.E = edPhyEntE?.SlabLength;
            result.SlabLength.M = edPhyEntM?.SlabLength;
            result.SlabLength.DbSource = $"{nameof(EdPhyEnt)}.{nameof(EdPhyEnt.SlabLength)}";
            result.SlabLength.Status = dataBlob.StatEdphyents?.SlabLength;

            result.HIntermediate.L = edOrdEntL?.HIntermediate;
            result.HIntermediate.E = edOrdEntE?.HIntermediate;
            result.HIntermediate.M = edOrdEntM?.HIntermediate;
            result.HIntermediate.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.HIntermediate)}";
            result.HIntermediate.Status = dataBlob.StatEdordents?.HIntermediate;

            result.HEntryColdFm.L = spOrd2PcL?.HEntryColdFm;
            result.HEntryColdFm.E = spOrd2PcE?.HEntryColdFm;
            result.HEntryColdFm.DbSource = $"{nameof(SpOrd2Pc)}.{nameof(SpOrd2Pc.HEntryColdFm)}";
            result.HEntryColdFm.Status = dataBlob.StatSpord2pcs?.HEntryColdFm;

            result.WEntryColdFm.L = spOrd2PcL?.WEntryColdFm;
            result.WEntryColdFm.E = spOrd2PcE?.WEntryColdFm;
            result.WEntryColdFm.DbSource = $"{nameof(SpOrd2Pc)}.{nameof(SpOrd2Pc.WEntryColdFm)}";
            result.WEntryColdFm.Status = dataBlob.StatSpord2pcs?.WEntryColdFm;

            result.ProfExCalcHrm.L = spOrd2PcL?.ProfexcalcHrm;
            result.ProfExCalcHrm.E = spOrd2PcE?.ProfexcalcHrm;
            result.ProfExCalcHrm.DbSource = $"{nameof(SpOrd2Pc)}.{nameof(SpOrd2Pc.ProfexcalcHrm)}";
            result.ProfExCalcHrm.Status = dataBlob.StatSpord2pcs?.ProfexcalcHrm;

            result.ProfExTargetHrm.L = spOrd2PcL?.ProfextargetHrm;
            result.ProfExTargetHrm.E = spOrd2PcE?.ProfextargetHrm;
            result.ProfExTargetHrm.DbSource = $"{nameof(SpOrd2Pc)}.{nameof(SpOrd2Pc.ProfextargetHrm)}";
            result.ProfExTargetHrm.Status = dataBlob.StatSpord2pcs?.ProfextargetHrm;

            result.RedDistHrmFm.L = lpL?.RedDistHrmHfm;
            result.RedDistHrmFm.E = lpE?.RedDistHrmHfm;
            result.RedDistHrmFm.M = lpM?.RedDistHrmHfm;
            result.RedDistHrmFm.DbSource = $"{nameof(Lp)}.{nameof(Lp.RedDistHrmHfm)}";

            result.ProfileCorr.L = dirFmPfcParaPL?.ProfileCorr;
            result.ProfileCorr.E = dirFmPfcParaPE?.ProfileCorr;
            result.ProfileCorr.M = dirFmPfcParaPM?.ProfileCorr;
            result.ProfileCorr.S = dataBlob.adordPc2?.Profile;
            result.ProfileCorr.DbSource = $"{nameof(DirFmPfcParaP)}.{nameof(DirFmPfcParaP.ProfileCorr)}";
            result.ProfileCorr.Status = dataBlob.StatDirFmPfcParaPs?.ProfileCorr;

            result.LpPlanNo.L = lpL?.PlanNo;
            result.LpPlanNo.E = lpE?.PlanNo;
            result.LpPlanNo.M = lpM?.PlanNo;
            result.LpPlanNo.DbSource = $"{nameof(Lp)}.{nameof(Lp.PlanNo)}";

            result.DpHrmPlanNo.L = dphrmL?.PlanNo;
            result.DpHrmPlanNo.E = dphrmE?.PlanNo;
            result.DpHrmPlanNo.M = dphrmM?.PlanNo;
            result.DpHrmPlanNo.DbSource = $"{nameof(Dphrm)}.{nameof(Dphrm.PlanNo)}";

            result.RcpPlanNo.L = rcpL?.PlanNo;
            result.RcpPlanNo.E = rcpE?.PlanNo;
            result.RcpPlanNo.M = rcpM?.PlanNo;
            result.RcpPlanNo.DbSource = $"{nameof(Rcp)}.{nameof(Rcp.PlanNo)}";

            result.TpPlanNo.L = tpL?.PlanNo;
            result.TpPlanNo.E = tpE?.PlanNo;
            result.TpPlanNo.M = tpM?.PlanNo;
            result.TpPlanNo.DbSource = $"{nameof(Tp)}.{nameof(Tp.PlanNo)}";

            result.RglpPlanNo.L = rglpL?.PlanNo;
            result.RglpPlanNo.E = rglpE?.PlanNo;
            result.RglpPlanNo.M = rglpM?.PlanNo;
            result.RglpPlanNo.DbSource = $"{nameof(Rglp)}.{nameof(Rglp.PlanNo)}";

            result.IscpPlanNo.L = iscpL?.PlanNo;
            result.IscpPlanNo.E = iscpE?.PlanNo;
            result.IscpPlanNo.M = iscpM?.PlanNo;
            result.IscpPlanNo.DbSource = $"{nameof(Iscp)}.{nameof(Iscp.PlanNo)}";

            result.DirFmPfcCycShiftPlanNo.L = dirFmPfcCycShiftL?.PlanNo;
            result.DirFmPfcCycShiftPlanNo.E = dirFmPfcCycShiftE?.PlanNo;
            result.DirFmPfcCycShiftPlanNo.M = dirFmPfcCycShiftM?.PlanNo;
            result.DirFmPfcCycShiftPlanNo.DbSource = $"{nameof(DirFmPfcCycShiftP)}.{nameof(DirFmPfcCycShiftP.PlanNo)}";
            result.DirFmPfcCycShiftPlanNo.Status = dataBlob.StatDirfmpfccycshiftps?.PlanNo;

            result.AntiLubricationPlanNo.L = aopL?.PlanNo;
            result.AntiLubricationPlanNo.E = aopE?.PlanNo;
            result.AntiLubricationPlanNo.M = aopM?.PlanNo;
            result.AntiLubricationPlanNo.DbSource = $"{nameof(Aoppass)}.{nameof(Aoppass.PlanNo)}";

            result.EdgerPlanNo.L = edgHrmL?.PlanNo;
            result.EdgerPlanNo.E = edgHrmE?.PlanNo;
            result.EdgerPlanNo.M = edgHrmM?.PlanNo;
            result.EdgerPlanNo.DbSource = $"{nameof(Edghrm)}.{nameof(Edghrm.PlanNo)}";

            return result;
        }

        //function to map the pass schedule data from the data blob to the dto
        public static SetpointsHRMDto MapPassSchedule(this SetpointsHRMDto result, SetpointsHRMDataBlob dataBlob, int standCount)
        {
            for (short i = 0; i < standCount; i++)
            {
                var adordPc2StandS = dataBlob.adordPc2Stands.Where(x => x.StandId == i).SingleOrDefault();

                var srpPassesL = dataBlob.Srppasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var srpPassesM = dataBlob.Srppasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var srpPassesS = dataBlob.Srppasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var srpPassesE = dataBlob.Srppasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();

                var spOrd2PcStandL = dataBlob.Spord2pcstands.Where(x => x.Source == "L" && x.StandId == i).FirstOrDefault();
                var spOrd2PcStandM = dataBlob.Spord2pcstands.Where(x => x.Source == "M" && x.StandId == i).FirstOrDefault();
                var spOrd2PcStandS = dataBlob.Spord2pcstands.Where(x => x.Source == "S" && x.StandId == i).FirstOrDefault();
                var spOrd2PcStandE = dataBlob.Spord2pcstands.Where(x => x.Source == "E" && x.StandId == i).FirstOrDefault();

                var aopPassL = dataBlob.Aoppasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var aopPassM = dataBlob.Aoppasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var aopPassS = dataBlob.Aoppasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var aopPassE = dataBlob.Aoppasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();

                var iscpPassL = dataBlob.Iscpasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var iscpPassM = dataBlob.Iscpasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var iscpPassS = dataBlob.Iscpasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var iscpPassE = dataBlob.Iscpasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();

                var rcpPassL = dataBlob.Rcppasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var rcpPassM = dataBlob.Rcppasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var rcpPassS = dataBlob.Rcppasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var rcpPassE = dataBlob.Rcppasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();

                var lpPassL = dataBlob.Lppasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var lpPassM = dataBlob.Lppasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var lpPassS = dataBlob.Lppasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var lpPassE = dataBlob.Lppasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();

                var tpPassL = dataBlob.Tppasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var tpPassM = dataBlob.Tppasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var tpPassS = dataBlob.Tppasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var tpPassE = dataBlob.Tppasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();

                var dirFmPfcCycShiftPassL = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var dirFmPfcCycShiftPassM = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var dirFmPfcCycShiftPassS = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var dirFmPfcCycShiftPassE = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();

                var dirFmPfcParapPassL = dataBlob.DirFmPfcParapPasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var dirFmPfcParapPassM = dataBlob.DirFmPfcParapPasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var dirFmPfcParapPassS = dataBlob.DirFmPfcParapPasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var dirFmPfcParapPassE = dataBlob.DirFmPfcParapPasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();

                var statLpPass = dataBlob.StatLppasses.FirstOrDefault(x => x.PassNo == i);
                var statSpord2PcStand = dataBlob.StatSpord2pcstands.FirstOrDefault(x => x.StandId == i);
                var statDirFmPfcParapPassL = dataBlob.StatDirFmPfcParapPasses.FirstOrDefault(x => x.PassNo == i);


                var stand = new PassScheduleDto();

                stand.PassNo = i;

                stand.LoadingType.L = lpPassL?.LoadingType;
                stand.LoadingType.E = lpPassE?.LoadingType;
                stand.LoadingType.M = lpPassM?.LoadingType;
                stand.LoadingType.DbSource = $"{nameof(Lppass)}.{nameof(Lppass.LoadingType)}{i}";
                stand.LoadingType.Status = statLpPass?.LoadingType;

                stand.Red.L = spOrd2PcStandL?.Red;
                stand.Red.E = spOrd2PcStandE?.Red;
                stand.Red.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.Red)}{i}";
                stand.Red.Status = statSpord2PcStand?.Red;

                stand.LoadingValue.L = lpPassL?.LoadingValue;
                stand.LoadingValue.E = lpPassE?.LoadingValue;
                stand.LoadingValue.M = lpPassM?.LoadingValue;
                stand.LoadingValue.DbSource = $"{nameof(Lppass)}.{nameof(Lppass.LoadingValue)}{i}";
                stand.LoadingValue.Status = statLpPass?.LoadingValue;

                stand.LoadingValueCorrection.L = lpPassL?.LoadingValueCorrection;
                stand.LoadingValueCorrection.E = lpPassE?.LoadingValueCorrection;
                stand.LoadingValueCorrection.M = lpPassM?.LoadingValueCorrection;
                stand.LoadingValueCorrection.DbSource = $"{nameof(Lppass)}.{nameof(Lppass.LoadingValueCorrection)}{i}";
                stand.LoadingValueCorrection.Status = statLpPass?.LoadingValueCorrection;

                stand.Fb.L = spOrd2PcStandL?.Fb;
                stand.Fb.E = spOrd2PcStandE?.Fb;
                stand.Fb.S = adordPc2StandS?.Fb;
                stand.Fb.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.Fb)}{i}";
                stand.Fb.Status = statSpord2PcStand?.Fb;

                stand.PositionWRS.L = spOrd2PcStandL?.PositionWrs;
                stand.PositionWRS.E = spOrd2PcStandE?.PositionWrs;
                stand.PositionWRS.S = adordPc2StandS?.PositionWrs;
                stand.PositionWRS.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.PositionWrs)}{i}";
                stand.PositionWRS.Status = statSpord2PcStand?.PositionWrs;

                stand.Model.L = srpPassesL?.Model;
                stand.Model.E = srpPassesE?.Model;
                stand.Model.M = srpPassesM?.Model;
                stand.Model.DbSource = $"{nameof(Srppass)}.{nameof(Srppass.Model)}{i}";

                stand.SpecifFoTension.L = tpPassL?.SpecifFoTension;
                stand.SpecifFoTension.E = tpPassE?.SpecifFoTension;
                stand.SpecifFoTension.M = tpPassM?.SpecifFoTension;
                stand.SpecifFoTension.DbSource = $"{nameof(Tppass)}.{nameof(Tppass.SpecifFoTension)}{i}";

                stand.ObservedFlat.L = dirFmPfcParapPassL?.ObservedFlat;
                stand.ObservedFlat.E = dirFmPfcParapPassE?.ObservedFlat;
                stand.ObservedFlat.M = dirFmPfcParapPassM?.ObservedFlat;
                stand.ObservedFlat.DbSource = $"{nameof(DirFmPfcParaPpass)}.{nameof(DirFmPfcParaPpass.ObservedFlat)}{i}";
                stand.ObservedFlat.Status = statDirFmPfcParapPassL?.ObservedFlat;

                stand.Fr.L = spOrd2PcStandL?.Fr;
                stand.Fr.E = spOrd2PcStandE?.Fr;
                stand.Fr.S = adordPc2StandS?.Fr;
                stand.Fr.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.Fr)}{i}";
                stand.Fr.Status = statSpord2PcStand?.Fr;

                stand.Sd.L = spOrd2PcStandL?.Sd;
                stand.Sd.E = spOrd2PcStandE?.Sd;
                stand.Sd.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.Sd)}{i}";
                stand.Sd.Status = statSpord2PcStand?.Sd;

                stand.T0.L = spOrd2PcStandL?.T0;
                stand.T0.E = spOrd2PcStandE?.T0;
                stand.T0.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.T0)}{i}";
                stand.T0.Status = statSpord2PcStand?.T0;

                stand.H0.L = spOrd2PcStandL?.H0;
                stand.H0.E = spOrd2PcStandE?.H0;
                stand.H0.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.H0)}{i}";
                stand.H0.Status = statSpord2PcStand?.H0;

                stand.VCircum.L = spOrd2PcStandL?.VCircum;
                stand.VCircum.E = spOrd2PcStandE?.VCircum;
                stand.VCircum.S = adordPc2StandS?.VCircum;
                stand.VCircum.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.VCircum)}{i}";
                stand.VCircum.Status = statSpord2PcStand?.VCircum;

                stand.TRoll.L = spOrd2PcStandL?.TRoll;
                stand.TRoll.E = spOrd2PcStandE?.TRoll;
                stand.TRoll.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.TRoll)}{i}";
                stand.TRoll.Status = statSpord2PcStand?.TRoll;

                stand.DeltaSdPos.L = spOrd2PcStandL?.SdCorr;
                stand.DeltaSdPos.E = spOrd2PcStandE?.SdCorr;
                stand.DeltaSdPos.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.SdCorr)}{i}";
                stand.DeltaSdPos.Status = statSpord2PcStand?.SdCorr;

                stand.RelProfile.L = spOrd2PcStandL?.RelProfile;
                stand.RelProfile.E = spOrd2PcStandE?.RelProfile;
                stand.RelProfile.S = adordPc2StandS?.RelProfile;
                stand.RelProfile.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.RelProfile)}{i}";
                stand.RelProfile.Status = statSpord2PcStand?.RelProfile;

                stand.Profile.L = spOrd2PcStandL?.Profile;
                stand.Profile.E = spOrd2PcStandE?.Profile;
                stand.Profile.S = adordPc2StandS?.AbsProfile;
                stand.Profile.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.Profile)}{i}";
                stand.Profile.Status = statSpord2PcStand?.Profile;

                stand.Ms.L = spOrd2PcStandL?.Ms;
                stand.Ms.E = spOrd2PcStandE?.Ms;
                stand.Ms.S = adordPc2StandS?.Ms;
                stand.Ms.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.Ms)}{i}";
                stand.Ms.Status = statSpord2PcStand?.Ms;

                stand.RPower.L = spOrd2PcStandL?.RPower;
                stand.RPower.E = spOrd2PcStandE?.RPower;
                stand.RPower.S = adordPc2StandS?.RPower;
                stand.RPower.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.RPower)}{i}";
                stand.RPower.Status = statSpord2PcStand?.RPower;

                stand.CalcFlat.L = spOrd2PcStandL?.CalcFlat;
                stand.CalcFlat.E = spOrd2PcStandE?.CalcFlat;
                stand.CalcFlat.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.CalcFlat)}{i}";
                stand.CalcFlat.Status = statSpord2PcStand?.CalcFlat;

                result.PassScheduleDtos.Add(stand);
            }

            return result;
        }

        public static SetpointsHRMDto MapEdger(this SetpointsHRMDto result, SetpointsHRMDataBlob dataBlob)
        {
            var spOrd2PcStandL = dataBlob.Spord2pcstands.Where(x => x.Source == "L" && x.StandId == 0).FirstOrDefault();
            var spOrd2PcStandM = dataBlob.Spord2pcstands.Where(x => x.Source == "M" && x.StandId == 0).FirstOrDefault();
            var spOrd2PcStandS = dataBlob.Spord2pcstands.Where(x => x.Source == "S" && x.StandId == 0).FirstOrDefault();
            var spOrd2PcStandE = dataBlob.Spord2pcstands.Where(x => x.Source == "E" && x.StandId == 0).FirstOrDefault();
            var statSpord2PcStand = dataBlob.StatSpord2pcstands.FirstOrDefault(x => x.StandId == 0);

            var edgHrmL = dataBlob.Edghrm.Where(x => x.Source == "L").FirstOrDefault();
            var edgHrmM = dataBlob.Edghrm.Where(x => x.Source == "M").FirstOrDefault();
            var edgHrmS = dataBlob.Edghrm.Where(x => x.Source == "S").FirstOrDefault();
            var edgHrmE = dataBlob.Edghrm.Where(x => x.Source == "E").FirstOrDefault();

            result.EdgerDto.Fr.L = spOrd2PcStandL?.FrE;
            result.EdgerDto.Fr.E = spOrd2PcStandE?.FrE;
            result.EdgerDto.Fr.M = spOrd2PcStandM?.FrE;
            result.EdgerDto.Fr.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.FrE)}0";
            result.EdgerDto.Fr.Status = statSpord2PcStand?.FrE;

            result.EdgerDto.Sd.L = spOrd2PcStandL?.SdE;
            result.EdgerDto.Sd.E = spOrd2PcStandE?.SdE;
            result.EdgerDto.Sd.M = spOrd2PcStandM?.SdE;
            result.EdgerDto.Sd.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.SdE)}0";
            result.EdgerDto.Sd.Status = statSpord2PcStand?.SdE;

            result.EdgerDto.VCircum.L = spOrd2PcStandL?.VCircumE;
            result.EdgerDto.VCircum.E = spOrd2PcStandE?.VCircumE;
            result.EdgerDto.VCircum.M = spOrd2PcStandM?.VCircumE;
            result.EdgerDto.VCircum.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.VCircumE)}0";
            result.EdgerDto.VCircum.Status = statSpord2PcStand?.VCircumE;

            result.EdgerDto.Ms.L = spOrd2PcStandL?.MsE;
            result.EdgerDto.Ms.E = spOrd2PcStandE?.MsE;
            result.EdgerDto.Ms.M = spOrd2PcStandM?.MsE;
            result.EdgerDto.Ms.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.MsE)}0";
            result.EdgerDto.Ms.Status = statSpord2PcStand?.MsE;

            result.EdgerDto.RPower.L = spOrd2PcStandL?.RPowerE;
            result.EdgerDto.RPower.E = spOrd2PcStandE?.RPowerE;
            result.EdgerDto.RPower.M = spOrd2PcStandM?.RPowerE;
            result.EdgerDto.RPower.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.RPowerE)}0";
            result.EdgerDto.RPower.Status = statSpord2PcStand?.RPowerE;

            result.EdgerDto.PlanNo.L = edgHrmL?.PlanNo;
            result.EdgerDto.PlanNo.E = edgHrmE?.PlanNo;
            result.EdgerDto.PlanNo.M = edgHrmM?.PlanNo;
            result.EdgerDto.PlanNo.DbSource = $"{nameof(Edghrm)}.{nameof(Edghrm.PlanNo)}";

            result.EdgerDto.EdgerMode.L = edgHrmL?.EdgMode;
            result.EdgerDto.EdgerMode.E = edgHrmE?.EdgMode;
            result.EdgerDto.EdgerMode.M = edgHrmM?.EdgMode;
            result.EdgerDto.EdgerMode.DbSource = $"{nameof(Edghrm)}.{nameof(Edghrm.EdgMode)}";

            result.EdgerDto.EdgerActive.L = edgHrmL?.EdgerActive;
            result.EdgerDto.EdgerActive.E = edgHrmE?.EdgerActive;
            result.EdgerDto.EdgerActive.M = edgHrmM?.EdgerActive;
            result.EdgerDto.EdgerActive.DbSource = $"{nameof(Edghrm)}.{nameof(Edghrm.EdgerActive)}";

            result.EdgerDto.WidthReduction.L = edgHrmL?.Dw;
            result.EdgerDto.WidthReduction.E = edgHrmE?.Dw;
            result.EdgerDto.WidthReduction.M = edgHrmM?.Dw;
            result.EdgerDto.WidthReduction.DbSource = $"{nameof(Edghrm)}.{nameof(Edghrm.Dw)}";

            return result;
        }

        //function to map the loading data from the data blob to the dto
        public static SetpointsHRMDto MapLoading(this SetpointsHRMDto result, SetpointsHRMDataBlob dataBlob, int standCount)
        {

            var lpL = dataBlob.Lps.Where(x => x.Source == "L").FirstOrDefault();
            var lpM = dataBlob.Lps.Where(x => x.Source == "M").FirstOrDefault();
            var lpS = dataBlob.Lps.Where(x => x.Source == "S").FirstOrDefault();
            var lpE = dataBlob.Lps.Where(x => x.Source == "E").FirstOrDefault();

            for (short i = 0; i < standCount; i++)
            {
                var lpPassL = dataBlob.Lppasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var lpPassM = dataBlob.Lppasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var lpPassS = dataBlob.Lppasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var lpPassE = dataBlob.Lppasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();
                var statLpPass = dataBlob.StatLppasses.FirstOrDefault(x => x.PassNo == i);

                var stand = new LoadingDto();

                stand.PassNo = i;

                stand.LoadingPlan.L = lpL?.PlanNo;
                stand.LoadingPlan.E = lpE?.PlanNo;
                stand.LoadingPlan.DbSource = $"{nameof(Lppass)}.{nameof(Lppass.PlanNo)}{i}";

                stand.LoadingType.L = lpPassL?.LoadingType;
                stand.LoadingType.E = lpPassE?.LoadingType;
                stand.LoadingType.M = lpPassM?.LoadingType;
                stand.LoadingType.DbSource = $"{nameof(Lppass)}.{nameof(Lppass.LoadingType)}{i}";
                stand.LoadingType.Status = statLpPass?.LoadingType;

                stand.LoadingValue.L = lpPassL?.LoadingValue;
                stand.LoadingValue.E = lpPassE?.LoadingValue;
                stand.LoadingValue.M = lpPassM?.LoadingValue;
                stand.LoadingValue.DbSource = $"{nameof(Lppass)}.{nameof(Lppass.LoadingValue)}{i}";
                stand.LoadingValue.Status = statLpPass?.LoadingValue;

                stand.CircumSpeedCorrection.L = lpPassL?.CircumSpeedCorrection;
                stand.CircumSpeedCorrection.E = lpPassE?.CircumSpeedCorrection;
                stand.CircumSpeedCorrection.M = lpPassM?.CircumSpeedCorrection;
                stand.CircumSpeedCorrection.DbSource = $"{nameof(Lppass)}.{nameof(Lppass.CircumSpeedCorrection)}{i}";
                stand.CircumSpeedCorrection.Status = statLpPass?.CircumSpeedCorrection;

                stand.BendingForce.L = lpPassL?.BendingForce;
                stand.BendingForce.E = lpPassE?.BendingForce;
                stand.BendingForce.M = lpPassM?.BendingForce;
                stand.BendingForce.DbSource = $"{nameof(Lppass)}.{nameof(Lppass.BendingForce)}";
                stand.BendingForce.Status = statLpPass?.BendingForce;

                result.LoadingDtos.Add(stand);

            }

            return result;
        }

        //function to map the descaling data from the data blob to the dto
        public static SetpointsHRMDto MapDescaling(this SetpointsHRMDto result, SetpointsHRMDataBlob dataBlob)
        {
            var dprmL = dataBlob.DpRms.Where(x => x.Source == "L").FirstOrDefault();
            var dprmM = dataBlob.DpRms.Where(x => x.Source == "M").FirstOrDefault();
            var dprmS = dataBlob.DpRms.Where(x => x.Source == "S").FirstOrDefault();
            var dprmE = dataBlob.DpRms.Where(x => x.Source == "E").FirstOrDefault();

            var dpramprmL = dataBlob.Dpramprms.Where(x => x.Source == "L").FirstOrDefault();
            var dpramprmM = dataBlob.Dpramprms.Where(x => x.Source == "M").FirstOrDefault();
            var dpramprmS = dataBlob.Dpramprms.Where(x => x.Source == "S").FirstOrDefault();
            var dpramprmE = dataBlob.Dpramprms.Where(x => x.Source == "E").FirstOrDefault();

            result.Descaling.PlanNo.L = dprmL?.PlanNo;
            result.Descaling.PlanNo.E = dprmE?.PlanNo;
            result.Descaling.PlanNo.M = dprmM?.PlanNo;
            result.Descaling.PlanNo.DbSource = $"{nameof(Dphrm)}.{nameof(Dphrm.PlanNo)}";

            result.Descaling.DescrampAuto.L = dpramprmL?.DescRampAuto;
            result.Descaling.DescrampAuto.E = dpramprmE?.DescRampAuto;
            result.Descaling.DescrampAuto.M = dpramprmM?.DescRampAuto;
            result.Descaling.DescrampAuto.DbSource = $"{nameof(DprampHrm)}.{nameof(DprampHrm.DescRampAuto)}";

            result.Descaling.DescrampState.L = dpramprmL?.DescRampState;
            result.Descaling.DescrampState.E = dpramprmE?.DescRampState;
            result.Descaling.DescrampState.M = dpramprmM?.DescRampState;
            result.Descaling.DescrampState.DbSource = $"{nameof(DprampHrm)}.{nameof(DprampHrm.DescRampState)}";

            result.Descaling.DescrampVolume.L = dpramprmL?.DescRampVolume;
            result.Descaling.DescrampVolume.E = dpramprmE?.DescRampVolume;
            result.Descaling.DescrampVolume.M = dpramprmM?.DescRampVolume;
            result.Descaling.DescrampVolume.DbSource = $"{nameof(DprampHrm)}.{nameof(DprampHrm.DescRampVolume)}";

            return result;
        }

        //function to map the anti peeling data from the data blob to the dto
        public static SetpointsHRMDto MapAntiPeeling(this SetpointsHRMDto result, SetpointsHRMDataBlob dataBlob, int standCount)
        {
            var aopL = dataBlob.Aoppasses.Where(x => x.Source == "L").FirstOrDefault();
            var aopM = dataBlob.Aoppasses.Where(x => x.Source == "M").FirstOrDefault();
            var aopS = dataBlob.Aoppasses.Where(x => x.Source == "S").FirstOrDefault();
            var aopE = dataBlob.Aoppasses.Where(x => x.Source == "E").FirstOrDefault();

            for (short i = 0; i < standCount; i++)
            {

                var aopPassL = dataBlob.Aoppasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var aopPassM = dataBlob.Aoppasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var aopPassS = dataBlob.Aoppasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var aopPassE = dataBlob.Aoppasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();

                var stand = new AntiPeelingDto();

                stand.PassNo = i;

                stand.PlanNo.L = aopL?.PlanNo;
                stand.PlanNo.E = aopE?.PlanNo;
                stand.PlanNo.M = aopM?.PlanNo;
                stand.PlanNo.DbSource = $"{nameof(Aoppass)}.{nameof(Aoppass.PlanNo)}";

                stand.AntiPeelingState.L = aopPassL?.AntiPeelingState;
                stand.AntiPeelingState.E = aopPassE?.AntiPeelingState;
                stand.AntiPeelingState.M = aopPassM?.AntiPeelingState;
                stand.AntiPeelingState.DbSource = $"{nameof(Aoppass)}.{nameof(Aoppass.AntiPeelingState)}{i}";

                stand.AntiPeeling.L = aopPassL?.AntiPeeling;
                stand.AntiPeeling.E = aopPassE?.AntiPeeling;
                stand.AntiPeeling.M = aopPassM?.AntiPeeling;
                stand.AntiPeeling.DbSource = $"{nameof(Aoppass)}.{nameof(Aoppass.AntiPeeling)}{i}";

                result.AntiPeelingDtos.Add(stand);
            }

            return result;
        }

        //function to map the work cooling data from the data blob to the dto
        public static SetpointsHRMDto MapWorkCooling(this SetpointsHRMDto result, SetpointsHRMDataBlob dataBlob, int standCount)
        {
            var iscpL = dataBlob.Iscpasses.Where(x => x.Source == "L").FirstOrDefault();
            var iscpM = dataBlob.Iscpasses.Where(x => x.Source == "M").FirstOrDefault();
            var iscpS = dataBlob.Iscpasses.Where(x => x.Source == "S").FirstOrDefault();
            var iscpE = dataBlob.Iscpasses.Where(x => x.Source == "E").FirstOrDefault();

            var rcpL = dataBlob.Rcppasses.Where(x => x.Source == "L").FirstOrDefault();
            var rcpM = dataBlob.Rcppasses.Where(x => x.Source == "M").FirstOrDefault();
            var rcpS = dataBlob.Rcppasses.Where(x => x.Source == "S").FirstOrDefault();
            var rcpE = dataBlob.Rcppasses.Where(x => x.Source == "E").FirstOrDefault();

            for (short i = 0; i < standCount; i++)
            {
                var iscpPassL = dataBlob.Iscpasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var iscpPassM = dataBlob.Iscpasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var iscpPassS = dataBlob.Iscpasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var iscpPassE = dataBlob.Iscpasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();

                var rcpPassL = dataBlob.Rcppasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var rcpPassM = dataBlob.Rcppasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var rcpPassS = dataBlob.Rcppasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var rcpPassE = dataBlob.Rcppasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();

                var stand = new WorkCoolingDto();

                stand.PassNo = i;

                stand.RcpPlanNo.L = rcpL?.PlanNo;
                stand.RcpPlanNo.E = rcpE?.PlanNo;
                stand.RcpPlanNo.DbSource = $"{nameof(Rcp)}.{nameof(Rcp.PlanNo)}";

                stand.IscpPlanNo.L = iscpL?.PlanNo;
                stand.IscpPlanNo.E = iscpE?.PlanNo;
                stand.IscpPlanNo.DbSource = $"{nameof(Iscp)}.{nameof(Iscp.PlanNo)}";

                stand.RollCoolState.L = rcpPassL?.RollCoolState;
                stand.RollCoolState.E = rcpPassE?.RollCoolState;
                stand.RollCoolState.M = rcpPassM?.RollCoolState;
                stand.RollCoolState.DbSource = $"{nameof(Rcppass)}.{nameof(Rcppass.RollCoolState)}{i}";

                stand.FlowWrLoadedInd0.L = rcpPassL?.FlowWrLoadedInd0;
                stand.FlowWrLoadedInd0.E = rcpPassE?.FlowWrLoadedInd0;
                stand.FlowWrLoadedInd0.M = rcpPassM?.FlowWrLoadedInd0;
                stand.FlowWrLoadedInd0.DbSource = $"{nameof(Rcppass)}.{nameof(Rcppass.FlowWrLoadedInd0)}{i}";

                stand.FlowWrLoadedInd1.L = rcpPassL?.FlowWrLoadedInd1;
                stand.FlowWrLoadedInd1.E = rcpPassE?.FlowWrLoadedInd1;
                stand.FlowWrLoadedInd1.M = rcpPassM?.FlowWrLoadedInd1;
                stand.FlowWrLoadedInd1.DbSource = $"{nameof(Rcppass)}.{nameof(Rcppass.FlowWrLoadedInd1)}{i}";

                stand.FlowWrLoadedInd2.L = rcpPassL?.FlowWrLoadedInd2;
                stand.FlowWrLoadedInd2.E = rcpPassE?.FlowWrLoadedInd2;
                stand.FlowWrLoadedInd2.M = rcpPassM?.FlowWrLoadedInd2;
                stand.FlowWrLoadedInd2.DbSource = $"{nameof(Rcppass)}.{nameof(Rcppass.FlowWrLoadedInd2)}{i}";

                stand.StripSprayBefor.L = iscpPassL?.StripSprayBefor;
                stand.StripSprayBefor.E = iscpPassE?.StripSprayBefor;
                stand.StripSprayBefor.M = iscpPassM?.StripSprayBefor;
                stand.StripSprayBefor.DbSource = $"{nameof(Iscppass)}.{nameof(Iscppass.StripSprayBefor)}{i}";

                stand.StripSprayBehind.L = iscpPassL?.StripSprayBehind;
                stand.StripSprayBehind.E = iscpPassE?.StripSprayBehind;
                stand.StripSprayBehind.M = iscpPassM?.StripSprayBehind;
                stand.StripSprayBehind.DbSource = $"{nameof(Iscppass)}.{nameof(Iscppass.StripSprayBehind)}{i}";

                stand.LooperCooling.L = iscpPassL?.LooperCool;
                stand.LooperCooling.E = iscpPassE?.LooperCool;
                stand.LooperCooling.M = iscpPassM?.LooperCool;
                stand.LooperCooling.DbSource = $"{nameof(Iscppass)}.{nameof(Iscppass.LooperCool)}";

                result.WorkCoolingDtos.Add(stand);
            }

            return result;
        }

        //function to map the tension data from the data blob to the dto
        public static SetpointsHRMDto MapTension(this SetpointsHRMDto result, SetpointsHRMDataBlob dataBlob, int standCount)
        {
            for (short i = 0; i < standCount; i++)
            {
                var tpPassL = dataBlob.Tppasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var tpPassM = dataBlob.Tppasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var tpPassS = dataBlob.Tppasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var tpPassE = dataBlob.Tppasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();

                var stand = new TensionDto();

                stand.PassNo = i;

                stand.PlanNo.L = tpPassL?.PlanNo;
                stand.PlanNo.E = tpPassE?.PlanNo;
                stand.PlanNo.DbSource = $"{nameof(Tppass)}.{nameof(Tppass.PlanNo)}";

                stand.SpeciffoTension.L = tpPassL?.SpecifFoTension;
                stand.SpeciffoTension.E = tpPassE?.SpecifFoTension;
                stand.SpeciffoTension.M = tpPassM?.SpecifFoTension;
                stand.SpeciffoTension.DbSource = $"{nameof(Tppass)}.{nameof(Tppass.SpecifFoTension)}{i}";

                stand.LooperStripLen.L = tpPassL?.LooperStripLen;
                stand.LooperStripLen.E = tpPassE?.LooperStripLen;
                stand.LooperStripLen.M = tpPassM?.LooperStripLen;
                stand.LooperStripLen.DbSource = $"{nameof(Tppass)}.{nameof(Tppass.LooperStripLen)}{i}";

                result.TensionDtos.Add(stand);
            }

            return result;
        }

        //function to map the lubrication data from the data blob to the dto
        public static SetpointsHRMDto MapLubrication(this SetpointsHRMDto result, SetpointsHRMDataBlob dataBlob)
        {
            var rglpL = dataBlob.Rglps.Where(x => x.Source == "L").FirstOrDefault();
            var rglpM = dataBlob.Rglps.Where(x => x.Source == "M").FirstOrDefault();
            var rglpS = dataBlob.Rglps.Where(x => x.Source == "S").FirstOrDefault();
            var rglpE = dataBlob.Rglps.Where(x => x.Source == "E").FirstOrDefault();

            result.Lubrication.PlanNo.L = rglpL?.PlanNo;
            result.Lubrication.PlanNo.E = rglpE?.PlanNo;
            result.Lubrication.PlanNo.DbSource = $"{nameof(Rglp)}.{nameof(Rglp.PlanNo)}";

            return result;
        }

        //function to map the taper shifting data from the data blob to the dto
        public static SetpointsHRMDto MapTaperShifting(this SetpointsHRMDto result, SetpointsHRMDataBlob dataBlob, int standCount)
        {
            for (short i = 0; i < standCount; i++)
            {
                var srpPassesL = dataBlob.Srppasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var srpPassesM = dataBlob.Srppasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var srpPassesS = dataBlob.Srppasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var srpPassesE = dataBlob.Srppasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();

                var stand = new TaperShiftingDto();

                stand.PassNo = i;

                stand.PlanNo.L = srpPassesL?.PlanNo;
                stand.PlanNo.E = srpPassesE?.PlanNo;
                stand.PlanNo.M = srpPassesM?.PlanNo;
                stand.PlanNo.DbSource = $"{nameof(Srppass)}.{nameof(Srppass.PlanNo)}{i}";

                stand.Model.L = srpPassesL?.Model;
                stand.Model.E = srpPassesE?.Model;
                stand.Model.M = srpPassesM?.Model;
                stand.Model.DbSource = $"{nameof(Srppass)}.{nameof(Srppass.Model)}{i}";

                result.TaperShiftingDtos.Add(stand);
            }

            return result;
        }

        //function to map the overview data from the data blob to the dto
        public static HRMApxMaterialOverviewDto MapApxOverview(this HRMApxMaterialOverviewDto result, SetpointsHRMApxDataBlob dataBlob)
        {
            var spOrd2PcL = dataBlob.Spord2pcs.Where(x => x.Source == "L").FirstOrDefault();
            var spOrd2PcM = dataBlob.Spord2pcs.Where(x => x.Source == "M").FirstOrDefault();
            var spOrd2PcS = dataBlob.Spord2pcs.Where(x => x.Source == "S").FirstOrDefault();
            var spOrd2PcE = dataBlob.Spord2pcs.Where(x => x.Source == "E").FirstOrDefault();

            var edOrdEntL = dataBlob.Edordents.Where(x => x.Source == "L").FirstOrDefault();
            var edOrdEntM = dataBlob.Edordents.Where(x => x.Source == "M").FirstOrDefault();
            var edOrdEntS = dataBlob.Edordents.Where(x => x.Source == "S").FirstOrDefault();
            var edOrdEntE = dataBlob.Edordents.Where(x => x.Source == "E").FirstOrDefault();

            var edPhyEntL = dataBlob.Edphyents.Where(x => x.Source == "L").FirstOrDefault();
            var edPhyEntM = dataBlob.Edphyents.Where(x => x.Source == "M").FirstOrDefault();
            var edPhyEntS = dataBlob.Edphyents.Where(x => x.Source == "S").FirstOrDefault();
            var edPhyEntE = dataBlob.Edphyents.Where(x => x.Source == "E").FirstOrDefault();

            var edLogEntL = dataBlob.Edlogents.Where(x => x.Source == "L").FirstOrDefault();
            var edLogEntM = dataBlob.Edlogents.Where(x => x.Source == "M").FirstOrDefault();
            var edLogEntS = dataBlob.Edlogents.Where(x => x.Source == "S").FirstOrDefault();
            var edLogEntE = dataBlob.Edlogents.Where(x => x.Source == "E").FirstOrDefault();

            var dirFmPfcParaPL = dataBlob.DirFmPfcParaPs.Where(x => x.Source == "L").FirstOrDefault();
            var dirFmPfcParaPM = dataBlob.DirFmPfcParaPs.Where(x => x.Source == "M").FirstOrDefault();
            var dirFmPfcParaPS = dataBlob.DirFmPfcParaPs.Where(x => x.Source == "S").FirstOrDefault();
            var dirFmPfcParaPE = dataBlob.DirFmPfcParaPs.Where(x => x.Source == "E").FirstOrDefault();

            var dirFmPfcCycShiftL = dataBlob.Dirfmpfccycshiftps.Where(x => x.Source == "L").FirstOrDefault();
            var dirFmPfcCycShiftM = dataBlob.Dirfmpfccycshiftps.Where(x => x.Source == "M").FirstOrDefault();
            var dirFmPfcCycShiftS = dataBlob.Dirfmpfccycshiftps.Where(x => x.Source == "S").FirstOrDefault();
            var dirFmPfcCycShiftE = dataBlob.Dirfmpfccycshiftps.Where(x => x.Source == "E").FirstOrDefault();

            var lpL = dataBlob.Lps.Where(x => x.Source == "L").FirstOrDefault();
            var lpM = dataBlob.Lps.Where(x => x.Source == "M").FirstOrDefault();
            var lpS = dataBlob.Lps.Where(x => x.Source == "S").FirstOrDefault();
            var lpE = dataBlob.Lps.Where(x => x.Source == "E").FirstOrDefault();

            var srpL = dataBlob.Srp.Where(x => x.Source == "L").FirstOrDefault();
            var srpM = dataBlob.Srp.Where(x => x.Source == "M").FirstOrDefault();
            var srpS = dataBlob.Srp.Where(x => x.Source == "S").FirstOrDefault();
            var srpE = dataBlob.Srp.Where(x => x.Source == "E").FirstOrDefault();

            var rcpL = dataBlob.Rcps.Where(x => x.Source == "L").FirstOrDefault();
            var rcpM = dataBlob.Rcps.Where(x => x.Source == "M").FirstOrDefault();
            var rcpS = dataBlob.Rcps.Where(x => x.Source == "S").FirstOrDefault();
            var rcpE = dataBlob.Rcps.Where(x => x.Source == "E").FirstOrDefault();

            result.AimsLabThickness.L = edPhyEntL?.AimSlabThickness;
            result.AimsLabThickness.E = edPhyEntE?.AimSlabThickness;
            result.AimsLabThickness.M = edPhyEntM?.AimSlabThickness;
            result.AimsLabThickness.S = dataBlob.AdordPc2?.HExit;
            result.AimsLabThickness.DbSource = $"{nameof(EdPhyEnt)}.{nameof(EdPhyEnt.AimSlabThickness)}";
            result.AimsLabThickness.Status = dataBlob.StatEdphyents?.AimSlabThickness;

            result.SlabWidth.L = edPhyEntL?.SlabWidth;
            result.SlabWidth.E = edPhyEntE?.SlabWidth;
            result.SlabWidth.M = edPhyEntM?.SlabWidth;
            result.SlabWidth.S = dataBlob.AdordPc2?.WExit;
            result.SlabWidth.DbSource = $"{nameof(EdPhyEnt)}.{nameof(EdPhyEnt.SlabWidth)}";
            result.SlabWidth.Status = dataBlob.StatEdphyents?.SlabWidth;

            result.ExitCrownC25.L = edOrdEntL?.ExitCrownC40;
            result.ExitCrownC25.E = edOrdEntE?.ExitCrownC40;
            result.ExitCrownC25.M = edOrdEntM?.ExitCrownC40;
            result.ExitCrownC25.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.ExitCrownC40)}";
            result.ExitCrownC25.Status = dataBlob.StatEdordents?.ExitCrownC40;

            result.TEntry.L = edPhyEntL?.TEntry;
            result.TEntry.E = edPhyEntE?.TEntry;
            result.TEntry.M = edPhyEntM?.TEntry;
            result.TEntry.DbSource = $"{nameof(EdPhyEnt)}.{nameof(EdPhyEnt.TEntry)}";
            result.TEntry.Status = dataBlob.StatEdphyents?.TEntry;

            result.SlabLength.L = edPhyEntL?.SlabLength;
            result.SlabLength.E = edPhyEntE?.SlabLength;
            result.SlabLength.M = edPhyEntM?.SlabLength;
            result.SlabLength.DbSource = $"{nameof(EdPhyEnt)}.{nameof(EdPhyEnt.SlabLength)}";
            result.SlabLength.Status = dataBlob.StatEdphyents?.SlabLength;

            result.HIntermediate.L = edOrdEntL?.HIntermediate;
            result.HIntermediate.E = edOrdEntE?.HIntermediate;
            result.HIntermediate.M = edOrdEntM?.HIntermediate;
            result.HIntermediate.DbSource = $"{nameof(EdOrdEnt)}.{nameof(EdOrdEnt.HIntermediate)}";
            result.HIntermediate.Status = dataBlob.StatEdordents?.HIntermediate;

            result.HEntryColdFm.L = spOrd2PcL?.HEntryColdFm;
            result.HEntryColdFm.E = spOrd2PcE?.HEntryColdFm;
            result.HEntryColdFm.DbSource = $"{nameof(SpOrd2Pc)}.{nameof(SpOrd2Pc.HEntryColdFm)}";
            result.HEntryColdFm.Status = dataBlob.StatSpord2pcs?.HEntryColdFm;

            result.WEntryColdFm.L = spOrd2PcL?.WEntryColdFm;
            result.WEntryColdFm.E = spOrd2PcE?.WEntryColdFm;
            result.WEntryColdFm.DbSource = $"{nameof(SpOrd2Pc)}.{nameof(SpOrd2Pc.WEntryColdFm)}";
            result.WEntryColdFm.Status = dataBlob.StatSpord2pcs?.WEntryColdFm;

            result.ProfExTargetHrm.L = spOrd2PcL?.ProfextargetHrm;
            result.ProfExTargetHrm.E = spOrd2PcE?.ProfextargetHrm;
            result.ProfExTargetHrm.M = spOrd2PcM?.ProfextargetHrm;
            result.ProfExTargetHrm.DbSource = $"{nameof(SpOrd2Pc)}.{nameof(SpOrd2Pc.ProfextargetHrm)}";
            result.ProfExTargetHrm.Status = dataBlob.StatSpord2pcs?.ProfextargetHrm;

            result.ProfExCalcHrm.L = spOrd2PcL?.ProfexcalcHrm;
            result.ProfExCalcHrm.E = spOrd2PcE?.ProfexcalcHrm;
            result.ProfExCalcHrm.M = spOrd2PcM?.ProfexcalcHrm;
            result.ProfExCalcHrm.DbSource = $"{nameof(SpOrd2Pc)}.{nameof(SpOrd2Pc.ProfexcalcHrm)}";
            result.ProfExCalcHrm.Status = dataBlob.StatSpord2pcs?.ProfexcalcHrm;

            result.ProfileCorr.L = dirFmPfcParaPL?.ProfileCorr;
            result.ProfileCorr.E = dirFmPfcParaPE?.ProfileCorr;
            result.ProfileCorr.M = dirFmPfcParaPM?.ProfileCorr;
            result.ProfileCorr.S = dataBlob.AdordPc2?.Profile;
            result.ProfileCorr.DbSource = $"{nameof(DirFmPfcParaP)}.{nameof(DirFmPfcParaP.ProfileCorr)}";
            result.ProfileCorr.Status = dataBlob.StatDirFmPfcParaPs?.ProfileCorr;

            result.RedDistHrmFm.L = lpL?.RedDistHrmHfm;
            result.RedDistHrmFm.E = lpE?.RedDistHrmHfm;
            result.RedDistHrmFm.M = lpM?.RedDistHrmHfm;
            result.RedDistHrmFm.DbSource = $"{nameof(Lp)}.{nameof(Lp.RedDistHrmHfm)}";

            result.InherPfc.L = spOrd2PcL?.InherPfc;
            result.InherPfc.E = spOrd2PcE?.InherPfc;
            result.InherPfc.DbSource = $"{nameof(SpOrd2Pc)}.{nameof(SpOrd2Pc.InherPfc)}";
            result.HEntryColdFm.Status = dataBlob.StatSpord2pcs?.HEntryColdFm;

            result.InherPfcId.L = spOrd2PcL?.InherPfcId;
            result.InherPfcId.E = spOrd2PcE?.InherPfcId;
            result.InherPfcId.DbSource = $"{nameof(SpOrd2Pc)}.{nameof(SpOrd2Pc.InherPfcId)}";
            result.InherPfcId.Status = dataBlob.StatSpord2pcs?.InherPfcId;

            result.SrpPlanNo.L = srpL?.PlanNo;
            result.SrpPlanNo.E = srpE?.PlanNo;
            result.SrpPlanNo.M = srpM?.PlanNo;
            result.SrpPlanNo.DbSource = $"{nameof(Srp)}.{nameof(Srp.PlanNo)}";
            result.SrpPlanNo.Status = dataBlob.StatDirfmpfccycshiftps?.PlanNo;

            result.DirFmPfcParaPlanNo.L = dirFmPfcParaPL?.PlanNo;
            result.DirFmPfcParaPlanNo.E = dirFmPfcParaPE?.PlanNo;
            result.DirFmPfcParaPlanNo.M = dirFmPfcParaPM?.PlanNo;
            result.DirFmPfcParaPlanNo.DbSource = $"{nameof(DirFmPfcParaP)}.{nameof(DirFmPfcParaP.PlanNo)}";
            result.DirFmPfcParaPlanNo.Status = dataBlob.StatDirFmPfcParaPs?.PlanNo;

            result.DirFmPfcCycShiftPlanNo.L = dirFmPfcCycShiftL?.PlanNo;
            result.DirFmPfcCycShiftPlanNo.E = dirFmPfcCycShiftE?.PlanNo;
            result.DirFmPfcCycShiftPlanNo.M = dirFmPfcCycShiftM?.PlanNo;
            result.DirFmPfcCycShiftPlanNo.DbSource = $"{nameof(DirFmPfcCycShiftP)}.{nameof(DirFmPfcCycShiftP.PlanNo)}";
            result.DirFmPfcCycShiftPlanNo.Status = dataBlob.StatDirfmpfccycshiftps?.PlanNo;

            result.RcpPlanNo.L = rcpL?.PlanNo;
            result.RcpPlanNo.E = rcpE?.PlanNo;
            result.RcpPlanNo.M = rcpM?.PlanNo;
            result.RcpPlanNo.DbSource = $"{nameof(Rcp)}.{nameof(Rcp.PlanNo)}";

            return result;
        }

        //function to map the pass schedule data from the data blob to the dto
        public static SetpointsHRMApxDto MapApxPassSchedule(this SetpointsHRMApxDto result, SetpointsHRMApxDataBlob dataBlob, short standCount)
        {
            for (short i = 0; i < standCount; i++)
            {
                var adordPc2StandS = dataBlob.AdordPc2Stands.Where(x => x.StandId == i).SingleOrDefault();

                var srpPassesL = dataBlob.Srppasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var srpPassesM = dataBlob.Srppasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var srpPassesS = dataBlob.Srppasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var srpPassesE = dataBlob.Srppasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();

                var wmppassesL = dataBlob.Wmppasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var wmppassesM = dataBlob.Wmppasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var wmppassesS = dataBlob.Wmppasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var wmppassesE = dataBlob.Wmppasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();

                var spOrd2PcStandL = dataBlob.Spord2pcstands.Where(x => x.Source == "L" && x.StandId == i).FirstOrDefault();
                var spOrd2PcStandM = dataBlob.Spord2pcstands.Where(x => x.Source == "M" && x.StandId == i).FirstOrDefault();
                var spOrd2PcStandS = dataBlob.Spord2pcstands.Where(x => x.Source == "S" && x.StandId == i).FirstOrDefault();
                var spOrd2PcStandE = dataBlob.Spord2pcstands.Where(x => x.Source == "E" && x.StandId == i).FirstOrDefault();

                var lpPassL = dataBlob.Lppasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var lpPassM = dataBlob.Lppasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var lpPassS = dataBlob.Lppasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var lpPassE = dataBlob.Lppasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();

                var dirFmPfcCycShiftPassL = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var dirFmPfcCycShiftPassM = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var dirFmPfcCycShiftPassS = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var dirFmPfcCycShiftPassE = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();

                var dirFmPfcParaPassesL = dataBlob.DirFmPfcParaPasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var dirFmPfcParaPassesM = dataBlob.DirFmPfcParaPasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var dirFmPfcParaPassesS = dataBlob.DirFmPfcParaPasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var dirFmPfcParaPassesE = dataBlob.DirFmPfcParaPasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();

                var spOrd2PcL = dataBlob.Spord2pcs.Where(x => x.Source == "L").FirstOrDefault();
                var spOrd2PcM = dataBlob.Spord2pcs.Where(x => x.Source == "M").FirstOrDefault();
                var spOrd2PcS = dataBlob.Spord2pcs.Where(x => x.Source == "S").FirstOrDefault();
                var spOrd2PcE = dataBlob.Spord2pcs.Where(x => x.Source == "E").FirstOrDefault();

                var statLpPass = dataBlob.StatLppasses.FirstOrDefault(x => x.PassNo == 1);
                var statDirFmPfcParaPasses = dataBlob.StatDirFmPfcParapPasses.FirstOrDefault(x => x.PassNo == i);
                var statDirFmPfcCycShiftPassE = dataBlob.StatDirfmpfccycshiftppasses.FirstOrDefault(x => x.PassNo == i);
                var statSpord2PcStand = dataBlob.StatSpord2pcstands.FirstOrDefault(x => x.StandId == i);

                var stand = new ApxPassScheduleDto();

                stand.PassNo = i;

                stand.BendingForce.L = lpPassL?.BendingForce;
                stand.BendingForce.E = lpPassE?.BendingForce;
                stand.BendingForce.M = lpPassM?.BendingForce;
                stand.BendingForce.DbSource = $"{nameof(Lppass)}.{nameof(Lppass.BendingForce)}{i}";
                stand.BendingForce.Status = statLpPass?.BendingForce;

                stand.Fbul.L = dirFmPfcParaPassesL?.FbUl;
                stand.Fbul.E = dirFmPfcParaPassesE?.FbUl;
                stand.Fbul.M = dirFmPfcParaPassesM?.FbUl;
                stand.Fbul.DbSource = $"{nameof(DirFmPfcParaPpass)}.{nameof(DirFmPfcParaPpass.FbUl)}{i}";
                stand.Fbul.Status = statDirFmPfcParaPasses?.FbUl;

                stand.Fbll.L = dirFmPfcParaPassesL?.FbLl;
                stand.Fbll.E = dirFmPfcParaPassesE?.FbLl;
                stand.Fbll.M = dirFmPfcParaPassesM?.FbLl;
                stand.Fbll.DbSource = $"{nameof(DirFmPfcParaPpass)}.{nameof(DirFmPfcParaPpass.FbLl)}{i}";
                stand.Fbll.Status = statDirFmPfcParaPasses?.FbLl;

                stand.CvcShifting.L = lpPassL?.CVcshifting;
                stand.CvcShifting.E = lpPassE?.CVcshifting;
                stand.CvcShifting.M = lpPassM?.CVcshifting;
                stand.CvcShifting.DbSource = $"{nameof(Lppass)}.{nameof(Lppass.CVcshifting)}{i}";
                stand.CvcShifting.Status = statLpPass?.CVcshifting;

                stand.Srul.L = dirFmPfcParaPassesL?.SrUl;
                stand.Srul.E = dirFmPfcParaPassesE?.SrUl;
                stand.Srul.M = dirFmPfcParaPassesM?.SrUl;
                stand.Srul.DbSource = $"{nameof(DirFmPfcParaPpass)}.{nameof(DirFmPfcParaPpass.SrUl)}{i}";
                stand.Srul.Status = statDirFmPfcParaPasses?.SrUl;

                stand.Srll.L = dirFmPfcParaPassesL?.SrLl;
                stand.Srll.E = dirFmPfcParaPassesE?.SrLl;
                stand.Srll.M = dirFmPfcParaPassesM?.SrLl;
                stand.Srll.DbSource = $"{nameof(DirFmPfcParaPpass)}.{nameof(DirFmPfcParaPpass.SrLl)}{i}";
                stand.Srll.Status = statDirFmPfcParaPasses?.SrLl;

                stand.CsMaxLimit.L = dirFmPfcCycShiftPassL?.CSmaxLimit;
                stand.CsMaxLimit.E = dirFmPfcCycShiftPassE?.CSmaxLimit;
                stand.CsMaxLimit.DbSource = $"{nameof(DirFmPfcCycShiftPpass)}.{nameof(DirFmPfcCycShiftPpass.CSmaxLimit)}{i}";
                stand.CsMaxLimit.Status = statDirFmPfcCycShiftPassE?.CSmaxLimit;

                stand.CsMinLimit.L = dirFmPfcCycShiftPassL?.CSminLimit;
                stand.CsMinLimit.E = dirFmPfcCycShiftPassE?.CSminLimit;
                stand.CsMinLimit.DbSource = $"{nameof(DirFmPfcCycShiftPpass)}.{nameof(DirFmPfcCycShiftPpass.CSminLimit)}{i}";
                stand.CsMinLimit.Status = statDirFmPfcCycShiftPassE?.CSminLimit;

                stand.Fb.L = spOrd2PcStandL?.Fb;
                stand.Fb.E = spOrd2PcStandE?.Fb;
                stand.Fb.S = adordPc2StandS?.Fb;
                stand.Fb.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.Fb)}{i}";
                stand.Fb.Status = statSpord2PcStand?.Fb;

                stand.PositionWrs.L = spOrd2PcStandL?.PositionWrs;
                stand.PositionWrs.E = spOrd2PcStandE?.PositionWrs;
                stand.PositionWrs.S = adordPc2StandS?.PositionWrs;
                stand.PositionWrs.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.PositionWrs)}{i}";
                stand.PositionWrs.Status = statSpord2PcStand?.PositionWrs;

                stand.TaperShiftSpeedCorr.L = srpPassesL?.Model;
                stand.TaperShiftSpeedCorr.E = srpPassesL?.Model;
                stand.TaperShiftSpeedCorr.M = srpPassesM?.Model;
                stand.TaperShiftSpeedCorr.DbSource = $"{nameof(Srppass)}.{nameof(Srppass.Model)}{i}";

                stand.WearCorr.L = wmppassesL?.Model;
                stand.WearCorr.E = wmppassesE?.Model;
                stand.WearCorr.M = wmppassesM?.Model;
                stand.WearCorr.DbSource = $"{nameof(Wmppass)}.{nameof(Wmppass.Model)}{i}";

                stand.ObservedFlat.L = dirFmPfcParaPassesL?.ObservedFlat;
                stand.ObservedFlat.E = dirFmPfcParaPassesE?.ObservedFlat;
                stand.ObservedFlat.M = dirFmPfcParaPassesM?.ObservedFlat;
                stand.ObservedFlat.DbSource = $"{nameof(DirFmPfcParaPpass)}.{nameof(DirFmPfcParaPpass.ObservedFlat)}{i}";
                stand.ObservedFlat.Status = statDirFmPfcParaPasses?.ObservedFlat;

                stand.Fr.L = spOrd2PcStandL?.Fr;
                stand.Fr.E = spOrd2PcStandE?.Fr;
                stand.Fr.S = adordPc2StandS?.Fr;
                stand.Fr.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.Fr)}{i}";
                stand.Fr.Status = statSpord2PcStand?.Fr;

                stand.WrCrownEff.L = spOrd2PcStandL?.WrCrownEff;
                stand.WrCrownEff.E = spOrd2PcStandE?.WrCrownEff;
                stand.WrCrownEff.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.WrCrownEff)}{i}";
                stand.WrCrownEff.Status = statSpord2PcStand?.WrCrownEff;

                stand.ThermCrown.L = spOrd2PcStandL?.TCrown;
                stand.ThermCrown.E = spOrd2PcStandE?.TCrown;
                stand.ThermCrown.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.TCrown)}{i}";
                stand.ThermCrown.Status = statSpord2PcStand?.TCrown;

                stand.Troll.L = spOrd2PcStandL?.TRoll;
                stand.Troll.E = spOrd2PcStandE?.TRoll;
                stand.Troll.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.TRoll)}{i}";
                stand.Troll.Status = statSpord2PcStand?.TRoll;

                stand.RelProfile.L = spOrd2PcStandL?.RelProfile;
                stand.RelProfile.E = spOrd2PcStandE?.RelProfile;
                stand.RelProfile.S = adordPc2StandS?.RelProfile;
                stand.RelProfile.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.RelProfile)}{i}";
                stand.RelProfile.Status = statSpord2PcStand?.RelProfile;

                stand.Profile.L = spOrd2PcStandL?.Profile;
                stand.Profile.E = spOrd2PcStandE?.Profile;
                stand.Profile.S = adordPc2StandS?.AbsProfile;
                stand.Profile.DbSource = $"{nameof(SpOrd2PcStand)}.{nameof(SpOrd2PcStand.Profile)}{i}";
                stand.Profile.Status = statSpord2PcStand?.Profile;

                result.PassScheduleDtos.Add(stand);
            }

            return result;
        }

        //function to map the shifting data from the data blob to the dto
        public static SetpointsHRMApxDto MapShifting(this SetpointsHRMApxDto result, SetpointsHRMApxDataBlob dataBlob, short standCount)
        {
            var dirFmPfcCycShiftL = dataBlob.Dirfmpfccycshiftps.Where(x => x.Source == "L").FirstOrDefault();
            var dirFmPfcCycShiftM = dataBlob.Dirfmpfccycshiftps.Where(x => x.Source == "M").FirstOrDefault();
            var dirFmPfcCycShiftS = dataBlob.Dirfmpfccycshiftps.Where(x => x.Source == "S").FirstOrDefault();
            var dirFmPfcCycShiftE = dataBlob.Dirfmpfccycshiftps.Where(x => x.Source == "E").FirstOrDefault();

            for (short i = 0; i < standCount; i++)
            {

                var dirFmPfcCycShiftPassL = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var dirFmPfcCycShiftPassM = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var dirFmPfcCycShiftPassS = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var dirFmPfcCycShiftPassE = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();
                var statDirFmPfcCycShiftPassE = dataBlob.StatDirfmpfccycshiftppasses.FirstOrDefault(x => x.PassNo == i);

                var stand = new ApxShiftingDto();

                stand.PassNo = i;

                stand.PlanNo.L = dirFmPfcCycShiftL?.PlanNo;
                stand.PlanNo.E = dirFmPfcCycShiftE?.PlanNo;
                stand.PlanNo.DbSource = $"{nameof(DirFmPfcCycShiftP)}.{nameof(DirFmPfcCycShiftP.PlanNo)}";
                stand.PlanNo.Status = dataBlob.StatDirfmpfccycshiftps?.PlanNo;

                stand.CsMaxLimit.L = dirFmPfcCycShiftPassL?.CSmaxLimit;
                stand.CsMaxLimit.E = dirFmPfcCycShiftPassE?.CSmaxLimit;
                stand.CsMaxLimit.M = dirFmPfcCycShiftPassM?.CSmaxLimit;
                stand.CsMaxLimit.DbSource = $"{nameof(DirFmPfcCycShiftPpass)}.{nameof(DirFmPfcCycShiftPpass.CSmaxLimit)}{i}";
                stand.CsMaxLimit.Status = statDirFmPfcCycShiftPassE?.CSmaxLimit;

                stand.CsMode.L = dirFmPfcCycShiftPassL?.CSmode;
                stand.CsMode.E = dirFmPfcCycShiftPassE?.CSmode;
                stand.CsMode.M = dirFmPfcCycShiftPassM?.CSmode;
                stand.CsMode.DbSource = $"{nameof(DirFmPfcCycShiftPpass)}.{nameof(DirFmPfcCycShiftPpass.CSmode)}{i}";
                stand.CsMode.Status = statDirFmPfcCycShiftPassE?.CSmode;

                stand.CsMinLimit.L = dirFmPfcCycShiftPassL?.CSminLimit;
                stand.CsMinLimit.E = dirFmPfcCycShiftPassE?.CSminLimit;
                stand.CsMinLimit.M = dirFmPfcCycShiftPassM?.CSminLimit;
                stand.CsMinLimit.DbSource = $"{nameof(DirFmPfcCycShiftPpass)}.{nameof(DirFmPfcCycShiftPpass.CSminLimit)}{i}";
                stand.CsMinLimit.Status = statDirFmPfcCycShiftPassE?.CSminLimit;

                stand.CsStartPos.L = dirFmPfcCycShiftPassL?.CSstartPos;
                stand.CsStartPos.E = dirFmPfcCycShiftPassE?.CSstartPos;
                stand.CsStartPos.M = dirFmPfcCycShiftPassM?.CSstartPos;
                stand.CsStartPos.DbSource = $"{nameof(DirFmPfcCycShiftPpass)}.{nameof(DirFmPfcCycShiftPpass.CSstartPos)}{i}";
                stand.CsStartPos.Status = statDirFmPfcCycShiftPassE?.CSstartPos;

                stand.CsShiftDir.L = dirFmPfcCycShiftPassL?.CSshiftDir;
                stand.CsShiftDir.E = dirFmPfcCycShiftPassE?.CSshiftDir;
                stand.CsShiftDir.M = dirFmPfcCycShiftPassM?.CSshiftDir;
                stand.CsShiftDir.DbSource = $"{nameof(DirFmPfcCycShiftPpass)}.{nameof(DirFmPfcCycShiftPpass.CSshiftDir)}{i}";
                stand.CsShiftDir.Status = statDirFmPfcCycShiftPassE?.CSshiftDir;

                stand.CsShiftStep1.L = dirFmPfcCycShiftPassL?.CSshiftStep1;
                stand.CsShiftStep1.E = dirFmPfcCycShiftPassE?.CSshiftStep1;
                stand.CsShiftStep1.M = dirFmPfcCycShiftPassM?.CSshiftStep1;
                stand.CsShiftStep1.DbSource = $"{nameof(DirFmPfcCycShiftPpass)}.{nameof(DirFmPfcCycShiftPpass.CSshiftStep1)}{i}";
                stand.CsShiftStep1.Status = statDirFmPfcCycShiftPassE?.CSshiftStep1;

                stand.CsShiftStep2.L = dirFmPfcCycShiftPassL?.CSshiftStep2;
                stand.CsShiftStep2.E = dirFmPfcCycShiftPassE?.CSshiftStep2;
                stand.CsShiftStep2.M = dirFmPfcCycShiftPassM?.CSshiftStep3;
                stand.CsShiftStep2.DbSource = $"{nameof(DirFmPfcCycShiftPpass)}.{nameof(DirFmPfcCycShiftPpass.CSshiftStep2)}{i}";
                stand.CsShiftStep2.Status = statDirFmPfcCycShiftPassE?.CSshiftStep2;

                stand.CsShiftStep3.L = dirFmPfcCycShiftPassL?.CSshiftStep3;
                stand.CsShiftStep3.E = dirFmPfcCycShiftPassE?.CSshiftStep3;
                stand.CsShiftStep3.M = dirFmPfcCycShiftPassM?.CSshiftStep3;
                stand.CsShiftStep3.DbSource = $"{nameof(DirFmPfcCycShiftPpass)}.{nameof(DirFmPfcCycShiftPpass.CSshiftStep3)}{i}";
                stand.CsShiftStep3.Status = statDirFmPfcCycShiftPassE?.CSshiftStep3;

                stand.Description.L = dirFmPfcCycShiftPassL?.Description;
                stand.Description.E = dirFmPfcCycShiftPassE?.Description;
                stand.Description.M = dirFmPfcCycShiftPassM?.Description;
                stand.Description.DbSource = $"{nameof(DirFmPfcCycShiftPpass)}.{nameof(DirFmPfcCycShiftPpass.Description)}{i}";
                stand.Description.Status = statDirFmPfcCycShiftPassE?.Description;

                stand.Manint.L = dirFmPfcCycShiftPassL?.ManInt;
                stand.Manint.E = dirFmPfcCycShiftPassE?.ManInt;
                stand.Manint.M = dirFmPfcCycShiftPassM?.ManInt;
                stand.Manint.DbSource = $"{nameof(DirFmPfcCycShiftPpass)}.{nameof(DirFmPfcCycShiftPpass.ManInt)}{i}";
                stand.Manint.Status = statDirFmPfcCycShiftPassE?.ManInt;

                stand.Toextid.L = dirFmPfcCycShiftPassL?.ToExtId;
                stand.Toextid.E = dirFmPfcCycShiftPassE?.ToExtId;
                stand.Toextid.M = dirFmPfcCycShiftPassM?.ToExtId;
                stand.Toextid.DbSource = $"{nameof(DirFmPfcCycShiftPpass)}.{nameof(DirFmPfcCycShiftPpass.ToExtId)}{i}";

                stand.CsmaxlimitparabolicInd0.L = dirFmPfcCycShiftPassL?.CSmaxLimitParabolicInd0;
                stand.CsmaxlimitparabolicInd0.E = dirFmPfcCycShiftPassE?.CSmaxLimitParabolicInd0;
                stand.CsmaxlimitparabolicInd0.M = dirFmPfcCycShiftPassM?.CSmaxLimitParabolicInd0;
                stand.CsmaxlimitparabolicInd0.DbSource = $"{nameof(DirFmPfcCycShiftPpass)}.{nameof(DirFmPfcCycShiftPpass.CSmaxLimitParabolicInd0)}{i}";
                stand.CsmaxlimitparabolicInd0.Status = statDirFmPfcCycShiftPassE?.CSmaxLimitParabolicInd0;

                stand.CsmaxlimitparabolicInd1.L = dirFmPfcCycShiftPassL?.CSmaxLimitParabolicInd1;
                stand.CsmaxlimitparabolicInd1.E = dirFmPfcCycShiftPassE?.CSmaxLimitParabolicInd1;
                stand.CsmaxlimitparabolicInd1.M = dirFmPfcCycShiftPassM?.CSmaxLimitParabolicInd1;
                stand.CsmaxlimitparabolicInd1.DbSource = $"{nameof(DirFmPfcCycShiftPpass)}.{nameof(DirFmPfcCycShiftPpass.CSmaxLimitParabolicInd1)}{i}";
                stand.CsmaxlimitparabolicInd1.Status = statDirFmPfcCycShiftPassE?.CSmaxLimitParabolicInd1;

                stand.CsmaxlimitparabolicInd2.L = dirFmPfcCycShiftPassL?.CSmaxLimitParabolicInd2;
                stand.CsmaxlimitparabolicInd2.E = dirFmPfcCycShiftPassE?.CSmaxLimitParabolicInd2;
                stand.CsmaxlimitparabolicInd2.M = dirFmPfcCycShiftPassM?.CSmaxLimitParabolicInd2;
                stand.CsmaxlimitparabolicInd2.DbSource = $"{nameof(DirFmPfcCycShiftPpass)}.{nameof(DirFmPfcCycShiftPpass.CSmaxLimitParabolicInd2)}{i}";
                stand.CsmaxlimitparabolicInd2.Status = statDirFmPfcCycShiftPassE?.CSmaxLimitParabolicInd2;

                stand.CsminlimitparabolicInd0.L = dirFmPfcCycShiftPassL?.CSminLimitParabolicInd0;
                stand.CsminlimitparabolicInd0.E = dirFmPfcCycShiftPassE?.CSminLimitParabolicInd0;
                stand.CsminlimitparabolicInd0.M = dirFmPfcCycShiftPassM?.CSminLimitParabolicInd0;
                stand.CsminlimitparabolicInd0.DbSource = $"{nameof(DirFmPfcCycShiftPpass)}.{nameof(DirFmPfcCycShiftPpass.CSminLimitParabolicInd0)}{i}";
                stand.CsminlimitparabolicInd0.Status = statDirFmPfcCycShiftPassE?.CSminLimitParabolicInd0;

                stand.CsminlimitparabolicInd1.L = dirFmPfcCycShiftPassL?.CSminLimitParabolicInd1;
                stand.CsminlimitparabolicInd1.E = dirFmPfcCycShiftPassE?.CSminLimitParabolicInd1;
                stand.CsminlimitparabolicInd1.M = dirFmPfcCycShiftPassM?.CSminLimitParabolicInd1;
                stand.CsminlimitparabolicInd1.DbSource = $"{nameof(DirFmPfcCycShiftPpass)}.{nameof(DirFmPfcCycShiftPpass.CSminLimitParabolicInd1)}{i}";
                stand.CsminlimitparabolicInd1.Status = statDirFmPfcCycShiftPassE?.CSminLimitParabolicInd1;

                stand.CsminlimitparabolicInd2.L = dirFmPfcCycShiftPassL?.CSminLimitParabolicInd2;
                stand.CsminlimitparabolicInd2.E = dirFmPfcCycShiftPassE?.CSminLimitParabolicInd2;
                stand.CsminlimitparabolicInd2.M = dirFmPfcCycShiftPassM?.CSminLimitParabolicInd2;
                stand.CsminlimitparabolicInd2.DbSource = $"{nameof(DirFmPfcCycShiftPpass)}.{nameof(DirFmPfcCycShiftPpass.CSminLimitParabolicInd2)}{i}";
                stand.CsminlimitparabolicInd2.Status = statDirFmPfcCycShiftPassE?.CSminLimitParabolicInd2;

                stand.CsstepparabolicInd0.L = dirFmPfcCycShiftPassL?.CSstepParabolicInd0;
                stand.CsstepparabolicInd0.E = dirFmPfcCycShiftPassE?.CSstepParabolicInd0;
                stand.CsstepparabolicInd0.M = dirFmPfcCycShiftPassM?.CSstepParabolicInd0;
                stand.CsstepparabolicInd0.DbSource = $"{nameof(DirFmPfcCycShiftPpass)}.{nameof(DirFmPfcCycShiftPpass.CSstepParabolicInd0)}{i}";
                stand.CsstepparabolicInd0.Status = statDirFmPfcCycShiftPassE?.CSstepParabolicInd0;

                stand.CsstepparabolicInd1.L = dirFmPfcCycShiftPassL?.CSstepParabolicInd1;
                stand.CsstepparabolicInd1.E = dirFmPfcCycShiftPassE?.CSstepParabolicInd1;
                stand.CsstepparabolicInd1.M = dirFmPfcCycShiftPassM?.CSstepParabolicInd1;
                stand.CsstepparabolicInd1.DbSource = $"{nameof(DirFmPfcCycShiftPpass)}.{nameof(DirFmPfcCycShiftPpass.CSstepParabolicInd1)}{i}";
                stand.CsstepparabolicInd1.Status = statDirFmPfcCycShiftPassE?.CSstepParabolicInd1;

                stand.CsstepparabolicInd2.L = dirFmPfcCycShiftPassL?.CSstepParabolicInd2;
                stand.CsstepparabolicInd2.E = dirFmPfcCycShiftPassE?.CSstepParabolicInd2;
                stand.CsstepparabolicInd2.M = dirFmPfcCycShiftPassM?.CSstepParabolicInd2;
                stand.CsstepparabolicInd2.DbSource = $"{nameof(DirFmPfcCycShiftPpass)}.{nameof(DirFmPfcCycShiftPpass.CSstepParabolicInd2)}{i}";
                stand.CsstepparabolicInd2.Status = statDirFmPfcCycShiftPassE?.CSstepParabolicInd2;

                stand.CsstepsmartcrownInd0.L = dirFmPfcCycShiftPassL?.CSstepSmartCrownInd0;
                stand.CsstepsmartcrownInd0.E = dirFmPfcCycShiftPassE?.CSstepSmartCrownInd0;
                stand.CsstepsmartcrownInd0.M = dirFmPfcCycShiftPassM?.CSstepSmartCrownInd0;
                stand.CsstepsmartcrownInd0.DbSource = $"{nameof(DirFmPfcCycShiftPpass)}.{nameof(DirFmPfcCycShiftPpass.CSstepSmartCrownInd0)}{i}";
                stand.CsstepsmartcrownInd0.Status = statDirFmPfcCycShiftPassE?.CSstepSmartCrownInd0;

                stand.CsstepsmartcrownInd1.L = dirFmPfcCycShiftPassL?.CSstepSmartCrownInd1;
                stand.CsstepsmartcrownInd1.E = dirFmPfcCycShiftPassE?.CSstepSmartCrownInd1;
                stand.CsstepsmartcrownInd1.M = dirFmPfcCycShiftPassM?.CSstepSmartCrownInd1;
                stand.CsstepsmartcrownInd1.DbSource = $"{nameof(DirFmPfcCycShiftPpass)}.{nameof(DirFmPfcCycShiftPpass.CSstepSmartCrownInd1)}{i}";
                stand.CsstepsmartcrownInd1.Status = statDirFmPfcCycShiftPassE?.CSstepSmartCrownInd2;

                stand.CsstepsmartcrownInd2.L = dirFmPfcCycShiftPassL?.CSstepSmartCrownInd2;
                stand.CsstepsmartcrownInd2.E = dirFmPfcCycShiftPassE?.CSstepSmartCrownInd2;
                stand.CsstepsmartcrownInd2.M = dirFmPfcCycShiftPassM?.CSstepSmartCrownInd2;
                stand.CsstepsmartcrownInd2.DbSource = $"{nameof(DirFmPfcCycShiftPpass)}.{nameof(DirFmPfcCycShiftPpass.CSstepSmartCrownInd0)}{i}";
                stand.CsstepsmartcrownInd2.Status = statDirFmPfcCycShiftPassE?.CSstepSmartCrownInd2;

                result.ShiftingDtos.Add(stand);
            }

            return result;
        }

        //map the taper shifting data from the data blob to the dto
        public static SetpointsHRMApxDto MapTaperShifting(this SetpointsHRMApxDto result, SetpointsHRMApxDataBlob dataBlob, int standCount)
        {
            for (short i = 0; i < standCount; i++)
            {
                var srpPassesL = dataBlob.Srppasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var srpPassesM = dataBlob.Srppasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var srpPassesS = dataBlob.Srppasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var srpPassesE = dataBlob.Srppasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();

                var stand = new TaperShiftingDto();

                stand.PassNo = i;

                stand.PlanNo.L = srpPassesL?.PlanNo;
                stand.PlanNo.E = srpPassesE?.PlanNo;
                stand.PlanNo.M = srpPassesM?.PlanNo;
                stand.PlanNo.DbSource = $"{nameof(Srppass)}.{nameof(Srppass.PlanNo)}{i}";

                stand.Model.L = srpPassesL?.Model;
                stand.Model.E = srpPassesE?.Model;
                stand.Model.M = srpPassesM?.Model;
                stand.Model.DbSource = $"{nameof(Srppass)}.{nameof(Srppass.Model)}{i}";

                result.TaperShiftingDtos.Add(stand);
            }

            return result;
        }

        //function to map the flatness data from the data blob to the dto
        public static SetpointsHRMApxDto MapFlatness(this SetpointsHRMApxDto result, SetpointsHRMApxDataBlob dataBlob, short standCount)
        {
            var dirFmPfcParaL = dataBlob.DirFmPfcParaPs.Where(x => x.Source == "L").FirstOrDefault();
            var dirFmPfcParaM = dataBlob.DirFmPfcParaPs.Where(x => x.Source == "M").FirstOrDefault();
            var dirFmPfcParaS = dataBlob.DirFmPfcParaPs.Where(x => x.Source == "S").FirstOrDefault();
            var dirFmPfcParaE = dataBlob.DirFmPfcParaPs.Where(x => x.Source == "E").FirstOrDefault();

            for (short i = 0; i < standCount; i++)
            {

                var dirFmPfcParaPassesL = dataBlob.DirFmPfcParaPasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var dirFmPfcParaPassesM = dataBlob.DirFmPfcParaPasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var dirFmPfcParaPassesS = dataBlob.DirFmPfcParaPasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var dirFmPfcParaPassesE = dataBlob.DirFmPfcParaPasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();
                var statDirFmPfcParaPasses = dataBlob.StatDirFmPfcParapPasses.FirstOrDefault(x => x.PassNo == i);

                var stand = new ApxFlatnessDto();

                stand.PassNo = i;

                stand.PlanNo.L = dirFmPfcParaL?.PlanNo;
                stand.PlanNo.E = dirFmPfcParaE?.PlanNo;
                stand.PlanNo.DbSource = $"{nameof(DirFmPfcParaP)}.{nameof(DirFmPfcParaP.PlanNo)}";
                stand.PlanNo.Status = dataBlob.StatDirFmPfcParaPs?.PlanNo;

                stand.Fbul.L = dirFmPfcParaPassesL?.FbUl;
                stand.Fbul.E = dirFmPfcParaPassesE?.FbUl;
                stand.Fbul.M = dirFmPfcParaPassesM?.FbUl;
                stand.Fbul.DbSource = $"{nameof(DirFmPfcParaPpass)}.{nameof(DirFmPfcParaPpass.FbUl)}{i}";
                stand.Fbul.Status = statDirFmPfcParaPasses?.FbUl;

                stand.Fbll.L = dirFmPfcParaPassesL?.FbLl;
                stand.Fbll.E = dirFmPfcParaPassesE?.FbLl;
                stand.Fbll.M = dirFmPfcParaPassesM?.FbLl;
                stand.Fbll.DbSource = $"{nameof(DirFmPfcParaPpass)}.{nameof(DirFmPfcParaPpass.FbLl)}{i}";
                stand.Fbll.Status = statDirFmPfcParaPasses?.FbLl;

                stand.Srul.L = dirFmPfcParaPassesL?.SrUl;
                stand.Srul.E = dirFmPfcParaPassesE?.SrUl;
                stand.Srul.M = dirFmPfcParaPassesM?.SrUl;
                stand.Srul.DbSource = $"{nameof(DirFmPfcParaPpass)}.{nameof(DirFmPfcParaPpass.SrUl)}{i}";
                stand.Srul.Status = statDirFmPfcParaPasses?.SrUl;

                stand.Srll.L = dirFmPfcParaPassesL?.SrLl;
                stand.Srll.E = dirFmPfcParaPassesE?.SrLl;
                stand.Srll.M = dirFmPfcParaPassesM?.SrLl;
                stand.Srll.DbSource = $"{nameof(DirFmPfcParaPpass)}.{nameof(DirFmPfcParaPpass.SrLl)}{i}";
                stand.Srll.Status = statDirFmPfcParaPasses?.SrLl;

                stand.Facdfbdfr.L = dirFmPfcParaPassesL?.FacDfbDfr;
                stand.Facdfbdfr.E = dirFmPfcParaPassesE?.FacDfbDfr;
                stand.Facdfbdfr.M = dirFmPfcParaPassesM?.FacDfbDfr;
                stand.Facdfbdfr.DbSource = $"{nameof(DirFmPfcParaPpass)}.{nameof(DirFmPfcParaPpass.FacDfbDfr)}{i}";
                stand.Facdfbdfr.Status = statDirFmPfcParaPasses?.FacDfbDfr;

                stand.Facdfbdiu.L = dirFmPfcParaPassesL?.FacDfbDiu;
                stand.Facdfbdiu.E = dirFmPfcParaPassesE?.FacDfbDiu;
                stand.Facdfbdiu.M = dirFmPfcParaPassesM?.FacDfbDiu;
                stand.Facdfbdiu.DbSource = $"{nameof(DirFmPfcParaPpass)}.{nameof(DirFmPfcParaPpass.FacDfbDiu)}{i}";
                stand.Facdfbdiu.Status = statDirFmPfcParaPasses?.FacDfbDiu;

                result.FlatnessDtos.Add(stand);
            }

            return result;
        }
    }
}