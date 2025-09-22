using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using WebHMI.DataBlobs;
using WebHMI.Dtos.SetpointsHRM;
using WebHMI.Dtos.SetpointsRM;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions
{
    public static class SetpointsHRMMapper
    {

        public static HRMMaterialOverviewDto MapOverview(this HRMMaterialOverviewDto result,  SetpointsHRMDataBlob dataBlob)
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

            var dphrmL = dataBlob.Dphrms.Where(x => x.Source == "L").FirstOrDefault();
            var dphrmM = dataBlob.Dphrms.Where(x => x.Source == "M").FirstOrDefault();
            var dphrmS = dataBlob.Dphrms.Where(x => x.Source == "S").FirstOrDefault();
            var dphrmE = dataBlob.Dphrms.Where(x => x.Source == "E").FirstOrDefault();

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

            result.HEntryColdFm.L = spOrd2PcL?.HEntryColdFm;
            result.HEntryColdFm.E = spOrd2PcE?.HEntryColdFm;
            result.HEntryColdFm.DbSource = "SpOrd2Pc.HEntryColdFm";

            result.WEntryColdFm.L = spOrd2PcL?.WEntryColdFm;
            result.WEntryColdFm.E = spOrd2PcE?.WEntryColdFm;
            result.WEntryColdFm.DbSource = "SpOrd2Pc.WEntryColdFm";

            result.TValue.L = spOrd2PcL?.T;
            result.TValue.E = spOrd2PcE?.T;
            result.TValue.DbSource = "SpOrd2Pc.T";

            result.ProfExTargetHrm.L = spOrd2PcL?.ProfextargetHrm;
            result.ProfExTargetHrm.E = spOrd2PcE?.ProfextargetHrm;
            result.ProfExTargetHrm.DbSource = "SpOrd2Pc.ProfextargetHrm";

            result.ProfExCalcHrm.L = spOrd2PcL?.ProfexcalcHrm;
            result.ProfExCalcHrm.E = spOrd2PcE?.ProfexcalcHrm;
            result.ProfExCalcHrm.DbSource = "SpOrd2Pc.ProfExCalcHrm";

            //Add ADORD2PC Hexit

            result.AimsLabThickness.L = edPhyEntL?.AimSlabThickness;
            result.AimsLabThickness.E = edPhyEntE?.AimSlabThickness;
            result.AimsLabThickness.M = edPhyEntM?.AimSlabThickness;
            result.AimsLabThickness.DbSource = "EdPhyEnt.AimSlabThickness";

            //Add ADORD2PC WExit

            result.SlabWidth.L = edPhyEntL?.SlabWidth;
            result.SlabWidth.E = edPhyEntE?.SlabWidth;
            result.SlabWidth.M = edPhyEntM?.SlabWidth;
            result.SlabWidth.DbSource = "EdPhyEnt.SlabWidth";

            result.TEntry.L = edPhyEntL?.TEntry;
            result.TEntry.E = edPhyEntE?.TEntry;
            result.TEntry.M = edPhyEntM?.TEntry;
            result.TEntry.DbSource = "EdPhyEnt.TEntry";

            result.SlabLength.L = edPhyEntL?.SlabLength;
            result.SlabLength.E = edPhyEntE?.SlabLength;
            result.SlabLength.M = edPhyEntM?.SlabLength;
            result.SlabLength.DbSource = "EdPhyEnt.SlabLength";

            result.HIntermediate.L = edOrdEntL?.HIntermediate;
            result.HIntermediate.E = edOrdEntE?.HIntermediate;
            result.HIntermediate.M = edOrdEntM?.HIntermediate;
            result.HIntermediate.DbSource = "EdOrdEnt.HIntermediate";

            //Add ADORD2PC profile

            result.ProfileCorr.L = dirFmPfcParaPL?.ProfileCorr;
            result.ProfileCorr.E = dirFmPfcParaPE?.ProfileCorr;
            result.ProfileCorr.DbSource = "DirFmPfcParaP.ProfileCorr";

            //result.RedDistHrmFm.L = lpL?.RedDistHrmFm;
            //result.RedDistHrmFm.E = lpE?.RedDistHrmFm;
            //result.RedDistHrmFm.M = lpM?.RedDistHrmFm;
            //result.RedDistHrmFm.DbSource = "LP.RedDistHrmFm";

            result.LpPlanNo.L = lpL?.PlanNo;
            result.LpPlanNo.E = lpE?.PlanNo;
            result.LpPlanNo.M = lpM?.PlanNo;
            result.LpPlanNo.DbSource = "Lp.PlanNo";

            result.DpHrmPlanNo.L = dphrmL?.PlanNo;
            result.DpHrmPlanNo.E = dphrmE?.PlanNo;
            result.DpHrmPlanNo.M = dphrmM?.PlanNo;
            result.DpHrmPlanNo.DbSource = "DpHrm.PlanNo";

            result.RcpPlanNo.L = rcpL?.PlanNo;
            result.RcpPlanNo.E = rcpE?.PlanNo;
            result.RcpPlanNo.M = rcpM?.PlanNo;
            result.RcpPlanNo.DbSource = "Rcp.PlanNo";

            result.TpPlanNo.L = tpL?.PlanNo;
            result.TpPlanNo.E = tpE?.PlanNo;
            result.TpPlanNo.M = tpM?.PlanNo;
            result.TpPlanNo.DbSource = "Tp.PlanNo";

            result.RglpPlanNo.L = rglpL?.PlanNo;
            result.RglpPlanNo.E = rglpE?.PlanNo;
            result.RglpPlanNo.M = rglpM?.PlanNo;
            result.RglpPlanNo.DbSource = "Rglp.PlanNo";

            result.IscpPlanNo.L = iscpL?.PlanNo;
            result.IscpPlanNo.E = iscpE?.PlanNo;
            result.IscpPlanNo.M = iscpM?.PlanNo;
            result.IscpPlanNo.DbSource = "Iscp.PlanNo";

            result.DirFmPfcCycShiftPlanNo.L = dirFmPfcCycShiftL?.PlanNo;
            result.DirFmPfcCycShiftPlanNo.E = dirFmPfcCycShiftE?.PlanNo;
            result.DirFmPfcCycShiftPlanNo.M = dirFmPfcCycShiftM?.PlanNo;
            result.DirFmPfcCycShiftPlanNo.DbSource = "DirFmPfcCycShiftPass.PlanNo";

            return result;
        }

        public static SetpointsHRMDto MapPassSchedule(this SetpointsHRMDto result, SetpointsHRMDataBlob dataBlob, int standCount)
        {
            for (short i = 0; i < standCount; i++)
            {
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

                var stand = new PassScheduleDto();

                stand.PassNo = i;

                stand.LoadingType.L = lpPassL?.LoadingType;
                stand.LoadingType.E = lpPassE?.LoadingType;
                stand.LoadingType.M = lpPassM?.LoadingType;
                stand.LoadingType.DbSource = $"LpPass.LoadingType({i})";

                stand.Red.L = spOrd2PcStandL?.Red;
                stand.Red.E = spOrd2PcStandE?.Red;
                stand.Red.DbSource = $"SpOrd2PcStand.Red({i})";

                stand.LoadingValue.L = lpPassL?.LoadingValue;
                stand.LoadingValue.E = lpPassE?.LoadingValue;
                stand.LoadingValue.M = lpPassM?.LoadingValue;
                stand.LoadingValue.DbSource = $"LpPass.LoadingValue({i})";

                stand.LoadingValueCorrection.L = lpPassL?.LoadingValueCorrection;
                stand.LoadingValueCorrection.E = lpPassE?.LoadingValueCorrection;
                stand.LoadingValueCorrection.M = lpPassM?.LoadingValueCorrection;
                stand.LoadingValueCorrection.DbSource = $"LpPass.LoadingValueCorrection({i})";

                stand.Fb.L = spOrd2PcStandL?.Fb;
                stand.Fb.E = spOrd2PcStandE?.Fb;
                stand.Fb.DbSource = $"SpOrd2PcStand.Fb({i})";

                stand.PositionWRS.L = spOrd2PcStandL?.PositionWrs;
                stand.PositionWRS.E = spOrd2PcStandE?.PositionWrs;
                stand.PositionWRS.DbSource = $"SpOrd2PcStand.PositionWrs({i})";

                stand.Model.L = srpPassesL?.Model;
                stand.Model.E = srpPassesE?.Model;
                stand.Model.DbSource = $"SrpPasses.Model({i})";


                stand.SpecifFoTension.L = tpPassL?.SpecifFoTension;
                stand.SpecifFoTension.E = tpPassE?.SpecifFoTension;
                stand.SpecifFoTension.M = tpPassM?.SpecifFoTension;
                stand.SpecifFoTension.DbSource = $"TpPass.SpecifFoTension({i})";

                //stand.Corr.L = tpPassL?.Corr;
                //stand.Corr.E = tpPassE?.Corr;
                //stand.Corr.M = tpPassM?.Corr;
                //stand.Corr.DbSource = $"TpPass.Corr({i})";

                stand.ObservedFlat.L = dirFmPfcParapPassL?.ObservedFlat;
                stand.ObservedFlat.E = dirFmPfcParapPassE?.ObservedFlat;
                stand.ObservedFlat.M = dirFmPfcParapPassM?.ObservedFlat;
                stand.ObservedFlat.DbSource = $"DirFmPfcParapPass.ObservedFlat({i})";


                // ADD ADORD2PC FR MS RPOWER VCIRCUM FB POSITIONWRS ABSPROFILE

                stand.Fr.L = spOrd2PcStandL?.Fr;
                stand.Fr.E = spOrd2PcStandE?.Fr;
                stand.Fr.DbSource = $"SpOrd2PcStand.Fr({i})";

                stand.Sd.L = spOrd2PcStandL?.Sd;
                stand.Sd.E = spOrd2PcStandE?.Sd;
                stand.Sd.DbSource = $"SpOrd2PcStand.Sd({i})";

                stand.T0.L = spOrd2PcStandL?.T0;
                stand.T0.E = spOrd2PcStandE?.T0;
                stand.T0.DbSource = $"SpOrd2PcStand.T0({i})";

                stand.H0.L = spOrd2PcStandL?.H0;
                stand.H0.E = spOrd2PcStandE?.H0;
                stand.H0.DbSource = $"SpOrd2PcStand.H0({i})";

                stand.VCircum.L = spOrd2PcStandL?.VCircum;
                stand.VCircum.E = spOrd2PcStandE?.VCircum;
                stand.VCircum.DbSource = $"SpOrd2PcStand.VCircum({i})";

                stand.TRoll.L = spOrd2PcStandL?.TRoll;
                stand.TRoll.E = spOrd2PcStandE?.TRoll;
                stand.TRoll.DbSource = $"SpOrd2PcStand.TRoll({i})";

                //stand.DeltaSdPos.L = spOrd2PcStandL?.DeltaSdPos;
                //stand.DeltaSdPos.E = spOrd2PcStandE?.DeltaSdPos;
                //stand.DeltaSdPos.DbSource = $"SpOrd2PcStand.DeltaSdPos({i})";

                stand.RelProfile.L = spOrd2PcStandL?.RelProfile;
                stand.RelProfile.E = spOrd2PcStandE?.RelProfile;
                stand.RelProfile.DbSource = $"SpOrd2PcStand.RelProfile({i})";

                stand.AbsProfile.L = spOrd2PcStandL?.Profile;
                stand.AbsProfile.E = spOrd2PcStandE?.Profile;
                stand.AbsProfile.DbSource = $"SpOrd2PcStand.Profile({i})";

                stand.TRoll.L = spOrd2PcStandL?.TRoll;
                stand.TRoll.E = spOrd2PcStandE?.TRoll;
                stand.TRoll.DbSource = $"SpOrd2PcStand.TRoll({i})";

                stand.Ms.L = spOrd2PcStandL?.Ms;
                stand.Ms.E = spOrd2PcStandE?.Ms;
                stand.Ms.DbSource = $"SpOrd2PcStand.Ms({i})";

                stand.RPower.L = spOrd2PcStandL?.RPower;
                stand.RPower.E = spOrd2PcStandE?.RPower;
                stand.RPower.DbSource = $"SpOrd2PcStand.RPower({i})";

                stand.CalcFlat.L = spOrd2PcStandL?.CalcFlat;
                stand.CalcFlat.E = spOrd2PcStandE?.CalcFlat;
                stand.CalcFlat.DbSource = $"SpOrd2PcStand.CalcFlat({i})";

                result.PassScheduleDtos.Add(stand);
            }

            return result;
        }

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

                var stand = new LoadingDto();

                stand.PassNo = i;

                stand.LoadingPlan.L = lpL?.PlanNo;
                stand.LoadingPlan.E = lpE?.PlanNo;
                stand.LoadingPlan.M = lpM?.PlanNo;
                stand.LoadingPlan.DbSource = $"LpPass.PlanNo({i})";

                stand.LoadingType.L = lpPassL?.LoadingType;
                stand.LoadingType.E = lpPassE?.LoadingType;
                stand.LoadingType.M = lpPassM?.LoadingType;
                stand.LoadingType.DbSource = $"LpPass.LoadingType({i})";

                stand.LoadingValue.L = lpPassL?.LoadingValue;
                stand.LoadingValue.E = lpPassE?.LoadingValue;
                stand.LoadingValue.M = lpPassM?.LoadingValue;
                stand.LoadingValue.DbSource = $"LpPass.LoadingValue({i})";

                stand.CircumSpeedCorrection.L = lpPassL?.CircumSpeedCorrection;
                stand.CircumSpeedCorrection.E = lpPassE?.CircumSpeedCorrection;
                stand.CircumSpeedCorrection.M = lpPassM?.CircumSpeedCorrection;
                stand.CircumSpeedCorrection.DbSource = $"LpPass.CircumSpeedCorrection({i})";

                stand.BendingForce.L = lpPassL?.BendingForce;
                stand.BendingForce.E = lpPassE?.BendingForce;
                stand.BendingForce.M = lpPassM?.BendingForce;
                stand.BendingForce.DbSource = "LpPass.BendingForce";

                result.LoadingDtos.Add(stand);

            }

            return result;
        }

        public static SetpointsHRMDto MapDescaling(this SetpointsHRMDto result, SetpointsHRMDataBlob dataBlob)
        {
            var dpfmL = dataBlob.DpFms.Where(x => x.Source == "L").FirstOrDefault();
            var dpfmM = dataBlob.DpFms.Where(x => x.Source == "M").FirstOrDefault();
            var dpfmS = dataBlob.DpFms.Where(x => x.Source == "S").FirstOrDefault();
            var dpfmE = dataBlob.DpFms.Where(x => x.Source == "E").FirstOrDefault();

            var dprampfmL = dataBlob.Dprampfms.Where(x => x.Source == "L").FirstOrDefault();
            var dprampfmM = dataBlob.Dprampfms.Where(x => x.Source == "M").FirstOrDefault();
            var dprampfmS = dataBlob.Dprampfms.Where(x => x.Source == "S").FirstOrDefault();
            var dprampfmE = dataBlob.Dprampfms.Where(x => x.Source == "E").FirstOrDefault();

            result.Descaling.PlanNo.L = dpfmL?.PlanNo;
            result.Descaling.PlanNo.E = dpfmE?.PlanNo;
            result.Descaling.PlanNo.M = dpfmM?.PlanNo;
            result.Descaling.PlanNo.DbSource = "Dpfm.PlanNo";

            result.Descaling.DescrampAuto.L = dprampfmL?.DescRampAuto;
            result.Descaling.DescrampAuto.E = dprampfmE?.DescRampAuto;
            result.Descaling.DescrampAuto.M = dprampfmM?.DescRampAuto;
            result.Descaling.DescrampAuto.DbSource = "Dprampfm.DescRampAuto";

            result.Descaling.DescrampState.L = dprampfmL?.DescRampState;
            result.Descaling.DescrampState.E = dprampfmE?.DescRampState;
            result.Descaling.DescrampState.M = dprampfmM?.DescRampState;
            result.Descaling.DescrampState.DbSource = "Dprampfm.DescrampState";

            result.Descaling.DescrampVolume.L = dprampfmL?.DescRampVolume;
            result.Descaling.DescrampVolume.E = dprampfmE?.DescRampVolume;
            result.Descaling.DescrampVolume.M = dprampfmM?.DescRampVolume;
            result.Descaling.DescrampVolume.DbSource = "Dpfm.DescrampVolume";

            return result;
        }

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
                stand.PlanNo.DbSource = "Aop.PlanNo";

                stand.AntiPeelingState.L = aopPassL?.AntiPeelingState;
                stand.AntiPeelingState.E = aopPassE?.AntiPeelingState;
                stand.AntiPeelingState.M = aopPassM?.AntiPeelingState;
                stand.AntiPeelingState.DbSource = $"AopPass.AntiPeelingState({i})";

                stand.AntiPeeling.L = aopPassL?.AntiPeeling;
                stand.AntiPeeling.E = aopPassE?.AntiPeeling;
                stand.AntiPeeling.M = aopPassM?.AntiPeeling;
                stand.AntiPeeling.DbSource = $"AopPass.AntiPeeling({i})";

                result.AntiPeelingDtos.Add(stand);
            }

            return result;
        }

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
                stand.RcpPlanNo.M = rcpM?.PlanNo;
                stand.RcpPlanNo.DbSource = "Rcp.PlanNo";

                stand.IscpPlanNo.L = iscpL?.PlanNo;
                stand.IscpPlanNo.E = iscpE?.PlanNo;
                stand.IscpPlanNo.M = iscpM?.PlanNo;
                stand.IscpPlanNo.DbSource = "Iscp.PlanNo";

                stand.RollCoolState.L = rcpPassL?.RollCoolState;
                stand.RollCoolState.E = rcpPassE?.RollCoolState;
                stand.RollCoolState.M = rcpPassM?.RollCoolState;
                stand.RollCoolState.DbSource = $"RcpPass.RollCoolState({i})";

                stand.FlowWrLoadedInd0.L = rcpPassL?.FlowWrLoadedInd0;
                stand.FlowWrLoadedInd0.E = rcpPassE?.FlowWrLoadedInd0;
                stand.FlowWrLoadedInd0.M = rcpPassM?.FlowWrLoadedInd0;
                stand.FlowWrLoadedInd0.DbSource = $"RcpPass.FlowWrLoadedInd0({i})";

                stand.FlowWrLoadedInd1.L = rcpPassL?.FlowWrLoadedInd1;
                stand.FlowWrLoadedInd1.E = rcpPassE?.FlowWrLoadedInd1;
                stand.FlowWrLoadedInd1.M = rcpPassM?.FlowWrLoadedInd1;
                stand.FlowWrLoadedInd1.DbSource = $"RcpPass.FlowWrLoadedInd1({i})";

                stand.FlowWrLoadedInd2.L = rcpPassL?.FlowWrLoadedInd2;
                stand.FlowWrLoadedInd2.E = rcpPassE?.FlowWrLoadedInd2;
                stand.FlowWrLoadedInd2.M = rcpPassM?.FlowWrLoadedInd2;
                stand.FlowWrLoadedInd2.DbSource = $"RcpPass.FlowWrLoadedInd2({i})";

                stand.StripSprayBefor.L = iscpPassL?.StripSprayBefor;
                stand.StripSprayBefor.E = iscpPassE?.StripSprayBefor;
                stand.StripSprayBefor.M = iscpPassM?.StripSprayBefor;
                stand.StripSprayBefor.DbSource = $"IscpPass.StripSprayBefor({i})";

                stand.LooperCooling.L = iscpPassL?.LooperCool;
                stand.LooperCooling.E = iscpPassE?.LooperCool;
                stand.LooperCooling.M = iscpPassM?.LooperCool;
                stand.LooperCooling.DbSource = "IscpPass.LooperCool";

                result.WorkCoolingDtos.Add(stand);
            }

            return result;
        }

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
                stand.PlanNo.M = tpPassM?.PlanNo;
                stand.PlanNo.DbSource = "TpPass.PlanNo";

                stand.SpeciffoTension.L = tpPassL?.SpecifFoTension;
                stand.SpeciffoTension.E = tpPassE?.SpecifFoTension;
                stand.SpeciffoTension.M = tpPassM?.SpecifFoTension;
                stand.SpeciffoTension.DbSource = $"TpPass.SpecifFoTension({i})";

                stand.LooperStripLen.L = tpPassL?.LooperStripLen;
                stand.LooperStripLen.E = tpPassE?.LooperStripLen;
                stand.LooperStripLen.M = tpPassM?.LooperStripLen;
                stand.LooperStripLen.DbSource = $"TpPass.LooperStripLen({i})";

                result.TensionDtos.Add(stand);
            }

            return result;
        }

        public static SetpointsHRMDto MapLubrication(this SetpointsHRMDto result, SetpointsHRMDataBlob dataBlob)
        {
            var rglpL = dataBlob.Rglps.Where(x => x.Source == "L").FirstOrDefault();
            var rglpM = dataBlob.Rglps.Where(x => x.Source == "M").FirstOrDefault();
            var rglpS = dataBlob.Rglps.Where(x => x.Source == "S").FirstOrDefault();
            var rglpE = dataBlob.Rglps.Where(x => x.Source == "E").FirstOrDefault();

            result.Lubrication.PlanNo.L = rglpL?.PlanNo;
            result.Lubrication.PlanNo.E = rglpE?.PlanNo;
            result.Lubrication.PlanNo.M = rglpM?.PlanNo;
            result.Lubrication.PlanNo.DbSource = "Rglp.PlanNo";

            return result;
        }

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
                stand.PlanNo.DbSource = $"SrpPasses.PlanNo({i})";

                stand.Model.L = srpPassesL?.Model;
                stand.Model.E = srpPassesE?.Model;
                stand.Model.M = srpPassesM?.Model;
                stand.Model.DbSource = $"SrpPasses.Model({i})";

                result.TaperShiftingDtos.Add(stand);
            }

            return result;
        }

    }
}