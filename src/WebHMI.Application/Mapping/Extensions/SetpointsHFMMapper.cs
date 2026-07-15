using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using WebHMI.DataBlobs;
using WebHMI.Dtos.Setpoints.CommonDtos;
using WebHMI.Dtos.Setpoints.CommonDtos.ApxDtos;
using WebHMI.Dtos.Setpoints.SetpointsHFM;
using WebHMI.Dtos.Setpoints.SetpointsHRM;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions
{
    public static class SetpointsHFMMapper
    {
        public static HFMMaterialOverviewDto MapOverview(this HFMMaterialOverviewDto result, SetpointsHFMDataBlob dataBlob)
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

            var srpL = dataBlob.Srps.Where(x => x.Source == "L").FirstOrDefault();
            var srpM = dataBlob.Srps.Where(x => x.Source == "M").FirstOrDefault();
            var srpS = dataBlob.Srps.Where(x => x.Source == "S").FirstOrDefault();
            var srpE = dataBlob.Srps.Where(x => x.Source == "E").FirstOrDefault();

            var IhpL = dataBlob.Ihps.Where(x => x.Source == "L").FirstOrDefault();
            var IhpM = dataBlob.Ihps.Where(x => x.Source == "M").FirstOrDefault();
            var IhpS = dataBlob.Ihps.Where(x => x.Source == "S").FirstOrDefault();
            var IhpE = dataBlob.Ihps.Where(x => x.Source == "E").FirstOrDefault();

            var rcpL = dataBlob.Rcps.Where(x => x.Source == "L").FirstOrDefault();
            var rcpM = dataBlob.Rcps.Where(x => x.Source == "M").FirstOrDefault();
            var rcpS = dataBlob.Rcps.Where(x => x.Source == "S").FirstOrDefault();
            var rcpE = dataBlob.Rcps.Where(x => x.Source == "E").FirstOrDefault();

            var dphfmL = dataBlob.DpFms.Where(x => x.Source == "L").FirstOrDefault();
            var dphfmM = dataBlob.DpFms.Where(x => x.Source == "M").FirstOrDefault();
            var dphfmS = dataBlob.DpFms.Where(x => x.Source == "S").FirstOrDefault();
            var dphfmE = dataBlob.DpFms.Where(x => x.Source == "E").FirstOrDefault();

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

            result.HExit.L = edOrdEntL?.HExit;
            result.HExit.E = edOrdEntE?.HExit;
            result.HExit.M = edOrdEntM?.HExit;
            result.HExit.S = dataBlob.Adord2PC?.HExit;
            result.HExit.DbSource = "EdOrdEnt.HExit";
            result.HExit.Status = dataBlob.StatEdordents?.HExit;

            result.WidthExit.L = edOrdEntL?.WidthExit;
            result.WidthExit.E = edOrdEntE?.WidthExit;
            result.WidthExit.M = edOrdEntM?.WidthExit;
            result.WidthExit.S = dataBlob.Adord2PC?.WExit;
            result.WidthExit.DbSource = "EdOrdEnt.WidthExit";
            result.WidthExit.Status = dataBlob.StatEdordents?.WidthExit;

            result.TExit.L = edOrdEntL?.TExit;
            result.TExit.E = edOrdEntE?.TExit;
            result.TExit.M = edOrdEntM?.TExit;
            result.TExit.DbSource = "EdOrdEnt.TExit";
            result.TExit.Status = dataBlob.StatEdordents?.TExit;

            result.ExitCrownc25.L = edOrdEntL?.ExitCrownC25;
            result.ExitCrownc25.E = edOrdEntE?.ExitCrownC25;
            result.ExitCrownc25.M = edOrdEntM?.ExitCrownC25;
            result.ExitCrownc25.S = dataBlob.Adord2PC?.Profile;
            result.ExitCrownc25.DbSource = "EdOrdEnt.ExitCrownC25";
            result.HExit.Status = dataBlob.StatEdordents?.HExit;

            result.HExitCold.L = spOrd2PcL?.HExitCold;
            result.HExitCold.E = spOrd2PcE?.HExitCold;
            result.HExitCold.DbSource = "SpOrd2Pc.HExitCold";
            result.HExitCold.Status = dataBlob.StatSpord2pcs?.HExitCold;

            result.WExitCold.L = spOrd2PcL?.WExitCold;
            result.WExitCold.E = spOrd2PcE?.WExitCold;
            result.WExitCold.DbSource = "SpOrd2Pc.WExitCold";
            result.WExitCold.Status = dataBlob.StatSpord2pcs?.WExitCold;

            result.TValue.L = spOrd2PcL?.T;
            result.TValue.E = spOrd2PcE?.T;
            result.TValue.DbSource = "SpOrd2Pc.T";
            result.TValue.Status = dataBlob.StatSpord2pcs?.T;

            result.ProfExCalc.L = spOrd2PcL?.Profexcalc;
            result.ProfExCalc.E = spOrd2PcE?.Profexcalc;
            result.ProfExCalc.DbSource = "SpOrd2Pc.Profexcalc";
            result.ProfExCalc.Status = dataBlob.StatSpord2pcs?.Profexcalc;

            result.HEntryColdFm.L = spOrd2PcL?.HEntryColdFm;
            result.HEntryColdFm.E = spOrd2PcE?.HEntryColdFm;
            result.HEntryColdFm.DbSource = "SpOrd2Pc.HEntryColdFm";
            result.HEntryColdFm.Status = dataBlob.StatSpord2pcs?.HEntryColdFm;

            result.T0MhHRM.L = spOrd2PcL?.T0MhHrm;
            result.T0MhHRM.E = spOrd2PcE?.T0MhHrm;
            result.T0MhHRM.DbSource = "SpOrd2Pc.T0MhHrm";
            result.T0MhHRM.Status = dataBlob.StatSpord2pcs?.T0MhHrm;

            result.RedDistHrmFm.L = lpL?.RedDistHrmHfm;
            result.RedDistHrmFm.E = lpE?.RedDistHrmHfm;
            result.RedDistHrmFm.M = lpM?.RedDistHrmHfm;
            result.RedDistHrmFm.DbSource = "Lp.RedDistHrmHfm";

            result.ProfileCorr.L = dirFmPfcParaPL?.ProfileCorr;
            result.ProfileCorr.E = dirFmPfcParaPE?.ProfileCorr;
            result.ProfileCorr.M = dirFmPfcParaPM?.ProfileCorr;
            result.ProfileCorr.DbSource = "DirFmPfcParaPL.ProfileCorr";
            result.ProfileCorr.Status = dataBlob.StatDirFmPfcParaPs?.ProfileCorr;

            result.TiHx.L = spOrd2PcL?.TIhhfmx;
            result.TiHx.E = spOrd2PcE?.TIhhfmx;
            result.TiHx.DbSource = "SpOrd2Pc.Tihhfmx";
            result.TiHx.Status = dataBlob.StatSpord2pcs?.TIhhfmx;

            result.LExit.L = spOrd2PcL?.LExit;
            result.LExit.E = spOrd2PcE?.LExit;
            result.LExit.DbSource = "SpOrd2Pc.LExit";
            result.LExit.Status = dataBlob.StatSpord2pcs?.LExit;

            result.SrpPlanNo.L = srpL?.PlanNo;
            result.SrpPlanNo.E = srpE?.PlanNo;
            result.SrpPlanNo.M = srpM?.PlanNo;
            result.SrpPlanNo.DbSource = "Srp.PlanNo";

            result.LpPlanNo.L = lpL?.PlanNo;
            result.LpPlanNo.E = lpE?.PlanNo;
            result.LpPlanNo.M = lpM?.PlanNo;
            result.LpPlanNo.DbSource = "Lp.PlanNo";

            result.DpHfmPlanNo.L = dphfmL?.PlanNo;
            result.DpHfmPlanNo.E = dphfmE?.PlanNo;
            result.DpHfmPlanNo.M = dphfmM?.PlanNo;
            result.DpHfmPlanNo.DbSource = "DphFm.PlanNo";

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

            result.SrpPlanNo.L = srpL?.PlanNo;
            result.SrpPlanNo.E = srpE?.PlanNo;
            result.SrpPlanNo.M = srpM?.PlanNo;
            result.SrpPlanNo.DbSource = "Srp.PlanNo";

            result.AntiLubricationPlanNo.L = aopL?.PlanNo;
            result.AntiLubricationPlanNo.E = aopE?.PlanNo;
            result.AntiLubricationPlanNo.M = aopM?.PlanNo;
            result.AntiLubricationPlanNo.DbSource = "Aop.PlanNo";

            result.Temperature.L = IhpL?.Temperature;
            result.Temperature.E = IhpE?.Temperature;
            result.Temperature.M = IhpM?.Temperature;
            result.Temperature.DbSource = "Ihp.Temperature";

            return result;
        }

        public static SetpointsHFMDto MapPassSchedule(this SetpointsHFMDto result, SetpointsHFMDataBlob dataBlob, short standCount, short standStartIdx)
        {
            var spOrd2PcL = dataBlob.Spord2pcs.Where(x => x.Source == "L").FirstOrDefault();
            var spOrd2PcM = dataBlob.Spord2pcs.Where(x => x.Source == "M").FirstOrDefault();
            var spOrd2PcS = dataBlob.Spord2pcs.Where(x => x.Source == "S").FirstOrDefault();
            var spOrd2PcE = dataBlob.Spord2pcs.Where(x => x.Source == "E").FirstOrDefault();

            for (short i = standStartIdx; i < standCount; i++)
            {
                var adordPC2StandS = dataBlob.Adord2PCStands.Where(x => x.StandId == i).SingleOrDefault();

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
                var statSpord2Pc = dataBlob.StatSpord2pcstands.FirstOrDefault(x => x.StandId == i);
                var statDirFmPfcParapPasses = dataBlob.StatDirFmPfcParapPasses.FirstOrDefault(x => x.PassNo == i);

                var stand = new PassScheduleDto();

                stand.PassNo = i;

                stand.LoadingType.L = lpPassL?.LoadingType;
                stand.LoadingType.E = lpPassE?.LoadingType;
                stand.LoadingType.M = lpPassM?.LoadingType;
                stand.LoadingType.DbSource = $"LpPass.LoadingType({i})";
                stand.LoadingType.Status = statLpPass?.LoadingType;

                stand.Red.L = spOrd2PcStandL?.Red;
                stand.Red.E = spOrd2PcStandE?.Red;
                stand.Red.DbSource = $"SpOrd2PcStand.Red({i})";
                stand.Red.Status = statSpord2Pc?.Red;

                stand.LoadingValue.L = lpPassL?.LoadingValue;
                stand.LoadingValue.E = lpPassE?.LoadingValue;
                stand.LoadingValue.M = lpPassM?.LoadingValue;
                stand.LoadingValue.DbSource = $"LpPass.LoadingValue({i})";
                stand.LoadingValue.Status = statLpPass?.LoadingValue;

                stand.LoadingValueCorrection.L = lpPassL?.LoadingValueCorrection;
                stand.LoadingValueCorrection.E = lpPassE?.LoadingValueCorrection;
                stand.LoadingValueCorrection.M = lpPassM?.LoadingValueCorrection;
                stand.LoadingValueCorrection.DbSource = $"LpPass.LoadingValueCorrection({i})";
                stand.LoadingValueCorrection.Status = statLpPass?.LoadingValueCorrection;

                stand.Fb.L = spOrd2PcStandL?.Fb;
                stand.Fb.E = spOrd2PcStandE?.Fb;
                stand.Fb.S = adordPC2StandS?.Fb;
                stand.Fb.DbSource = $"SpOrd2PcStand.Fb({i})";
                stand.Fb.Status = statSpord2Pc?.Fb;

                stand.PositionWRS.L = spOrd2PcStandL?.PositionWrs;
                stand.PositionWRS.E = spOrd2PcStandE?.PositionWrs;
                stand.PositionWRS.M = spOrd2PcStandM?.PositionWrs;
                stand.PositionWRS.S = adordPC2StandS?.PositionWrs;
                stand.PositionWRS.DbSource = $"SpOrd2PcStand.PositionWrs({i})";
                stand.PositionWRS.Status = statSpord2Pc?.PositionWrs;

                stand.Model.L = srpPassesL?.Model;
                stand.Model.E = srpPassesE?.Model;
                stand.Model.DbSource = $"SrpPasses.Model({i})";

                stand.SpecifFoTension.L = tpPassL?.SpecifFoTension;
                stand.SpecifFoTension.E = tpPassE?.SpecifFoTension;
                stand.SpecifFoTension.M = tpPassM?.SpecifFoTension;
                stand.SpecifFoTension.DbSource = $"TpPass.SpecifFoTension({i})";

                stand.ObservedFlat.L = dirFmPfcParapPassL?.ObservedFlat;
                stand.ObservedFlat.E = dirFmPfcParapPassE?.ObservedFlat;
                stand.ObservedFlat.M = dirFmPfcParapPassM?.ObservedFlat;
                stand.ObservedFlat.DbSource = $"DirFmPfcParapPass.ObservedFlat({i})";
                stand.ObservedFlat.Status = statDirFmPfcParapPasses?.ObservedFlat;


                // ADD ADORD2PC FR MS RPOWER VCIRCUM FB POSITIONWRS ABSPROFILE

                stand.Fr.L = spOrd2PcStandL?.Fr;
                stand.Fr.E = spOrd2PcStandE?.Fr;
                stand.Fr.S = adordPC2StandS?.Fr;
                stand.Fr.DbSource = $"SpOrd2PcStand.Fr({i})";
                stand.Fr.Status = statSpord2Pc?.Fr;

                stand.Sd.L = spOrd2PcStandL?.Sd;
                stand.Sd.E = spOrd2PcStandE?.Sd;
                stand.Sd.DbSource = $"SpOrd2PcStand.Sd({i})";
                stand.Sd.Status = statSpord2Pc?.Sd;

                stand.T0.L = spOrd2PcStandL?.T0;
                stand.T0.E = spOrd2PcStandE?.T0;
                stand.T0.DbSource = $"SpOrd2PcStand.T0({i})";
                stand.T0.Status = statSpord2Pc?.T0;

                stand.H0.L = spOrd2PcStandL?.H0;
                stand.H0.E = spOrd2PcStandE?.H0;
                stand.H0.DbSource = $"SpOrd2PcStand.H0({i})";
                stand.H0.Status = statSpord2Pc?.H0;

                stand.VCircum.L = spOrd2PcStandL?.VCircum;
                stand.VCircum.E = spOrd2PcStandE?.VCircum;
                stand.VCircum.S = adordPC2StandS?.VCircum;
                stand.VCircum.DbSource = $"SpOrd2PcStand.VCircum({i})";
                stand.VCircum.Status = statSpord2Pc?.VCircum;

                stand.TRoll.L = spOrd2PcStandL?.TRoll;
                stand.TRoll.E = spOrd2PcStandE?.TRoll;
                stand.TRoll.DbSource = $"SpOrd2PcStand.TRoll({i})";
                stand.TRoll.Status = statSpord2Pc?.TRoll;

                stand.DeltaSdPos.L = spOrd2PcStandL?.SdCorr;
                stand.DeltaSdPos.E = spOrd2PcStandE?.SdCorr;
                stand.DeltaSdPos.DbSource = $"SpOrd2PcStand.DeltaSdPos({i})";
                stand.DeltaSdPos.Status = statSpord2Pc?.SdCorr;

                stand.RelProfile.L = spOrd2PcStandL?.RelProfile;
                stand.RelProfile.E = spOrd2PcStandE?.RelProfile;
                stand.RelProfile.S = adordPC2StandS?.RelProfile;
                stand.RelProfile.DbSource = $"SpOrd2PcStand.RelProfile({i})";
                stand.RelProfile.Status = statSpord2Pc?.RelProfile;

                stand.Profile.L = spOrd2PcStandL?.Profile;
                stand.Profile.E = spOrd2PcStandE?.Profile;
                stand.Profile.S = adordPC2StandS?.AbsProfile;
                stand.Profile.DbSource = $"SpOrd2PcStand.Profile({i})";
                stand.Profile.Status = statSpord2Pc?.Profile;

                stand.Ms.L = spOrd2PcStandL?.Ms;
                stand.Ms.E = spOrd2PcStandE?.Ms;
                stand.Ms.S = adordPC2StandS?.Ms;
                stand.Ms.DbSource = $"SpOrd2PcStand.Ms({i})";
                stand.Ms.Status = statSpord2Pc?.Ms;

                stand.RPower.L = spOrd2PcStandL?.RPower;
                stand.RPower.E = spOrd2PcStandE?.RPower;
                stand.RPower.S = adordPC2StandS?.RPower;
                stand.RPower.DbSource = $"SpOrd2PcStand.RPower({i})";
                stand.RPower.Status = statSpord2Pc?.RPower;

                stand.CalcFlat.L = spOrd2PcStandL?.CalcFlat;
                stand.CalcFlat.E = spOrd2PcStandE?.CalcFlat;
                stand.CalcFlat.DbSource = $"SpOrd2PcStand.CalcFlat({i})";
                stand.CalcFlat.Status = statSpord2Pc?.CalcFlat;

                result.PassScheduleDtos.Add(stand);
            }

            return result;
        }

        public static SetpointsHFMDto MapLoading(this SetpointsHFMDto result, SetpointsHFMDataBlob dataBlob, short standCount, short standStartIdx)
        {

            var lpL = dataBlob.Lps.Where(x => x.Source == "L").FirstOrDefault();
            var lpM = dataBlob.Lps.Where(x => x.Source == "M").FirstOrDefault();
            var lpS = dataBlob.Lps.Where(x => x.Source == "S").FirstOrDefault();
            var lpE = dataBlob.Lps.Where(x => x.Source == "E").FirstOrDefault();

            for (short i = standStartIdx; i < standCount; i++)
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
                stand.LoadingPlan.DbSource = $"LpPass.PlanNo({i})";
                stand.LoadingPlan.Status = statLpPass?.PlanNo;

                stand.LoadingType.L = lpPassL?.LoadingType;
                stand.LoadingType.E = lpPassE?.LoadingType;
                stand.LoadingType.M = lpPassM?.LoadingType;
                stand.LoadingType.DbSource = $"LpPass.LoadingType({i})";
                stand.LoadingType.Status = statLpPass?.LoadingType;

                stand.LoadingValue.L = lpPassL?.LoadingValue;
                stand.LoadingValue.E = lpPassE?.LoadingValue;
                stand.LoadingValue.M = lpPassM?.LoadingValue;
                stand.LoadingValue.DbSource = $"LpPass.LoadingValue({i})";
                stand.LoadingValue.Status = statLpPass?.LoadingValue;

                stand.CircumSpeedCorrection.L = lpPassL?.CircumSpeedCorrection;
                stand.CircumSpeedCorrection.E = lpPassE?.CircumSpeedCorrection;
                stand.CircumSpeedCorrection.M = lpPassM?.CircumSpeedCorrection;
                stand.CircumSpeedCorrection.DbSource = $"LpPass.CircumSpeedCorrection({i})";
                stand.CircumSpeedCorrection.Status = statLpPass?.CircumSpeedCorrection;

                stand.BendingForce.L = lpPassL?.BendingForce;
                stand.BendingForce.E = lpPassE?.BendingForce;
                stand.BendingForce.M = lpPassM?.BendingForce;
                stand.BendingForce.DbSource = "LpPass.BendingForce";
                stand.BendingForce.Status = statLpPass?.BendingForce;

                result.LoadingDtos.Add(stand);

            }

            return result;
        }

        public static SetpointsHFMDto MapDescaling(this SetpointsHFMDto result, SetpointsHFMDataBlob dataBlob)
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

        public static SetpointsHFMDto MapAntiPeeling(this SetpointsHFMDto result, SetpointsHFMDataBlob dataBlob, short standCount, short standStartIdx)
        {
            var aopL = dataBlob.Aoppasses.Where(x => x.Source == "L").FirstOrDefault();
            var aopM = dataBlob.Aoppasses.Where(x => x.Source == "M").FirstOrDefault();
            var aopS = dataBlob.Aoppasses.Where(x => x.Source == "S").FirstOrDefault();
            var aopE = dataBlob.Aoppasses.Where(x => x.Source == "E").FirstOrDefault();

            for (short i = standStartIdx; i < standCount; i++)
            {

                var aopPassL = dataBlob.Aoppasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var aopPassM = dataBlob.Aoppasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var aopPassS = dataBlob.Aoppasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var aopPassE = dataBlob.Aoppasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();

                var stand = new AntiPeelingDto();

                stand.PassNo = i;

                stand.PlanNo.L = aopL?.PlanNo;
                stand.PlanNo.E = aopE?.PlanNo;
                stand.PlanNo.DbSource = "Aop.PlanNo";

                stand.AntiOxStateEntry.L = aopPassL?.AntiOxStateEntry;
                stand.AntiOxStateEntry.E = aopPassE?.AntiOxStateEntry;
                stand.AntiOxStateEntry.M = aopPassM?.AntiOxStateEntry;
                stand.AntiOxStateEntry.DbSource = $"AopPass.AntiOxStateEntry({i})";

                stand.AntiOxidationEntry.L = aopPassL?.AntiOxidationEntry;
                stand.AntiOxidationEntry.E = aopPassE?.AntiOxidationEntry;
                stand.AntiOxidationEntry.M = aopPassM?.AntiOxidationEntry;
                stand.AntiOxidationEntry.DbSource = $"AopPass.AntiOxidationEntry({i})";

                stand.AntiOxStateExit.L = aopPassL?.AntiOxStateExit;
                stand.AntiOxStateExit.E = aopPassE?.AntiOxStateExit;
                stand.AntiOxStateExit.M = aopPassM?.AntiOxStateExit;
                stand.AntiOxStateExit.DbSource = $"AopPass.AntiOxStateExit({i})";

                stand.AntiOxidationExit.L = aopPassL?.AntiOxidationExit;
                stand.AntiOxidationExit.E = aopPassE?.AntiOxidationExit;
                stand.AntiOxidationExit.M = aopPassM?.AntiOxidationExit;
                stand.AntiOxidationExit.DbSource = $"AopPass.AntiOxidationExit({i})";

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

        public static SetpointsHFMDto MapWorkCooling(this SetpointsHFMDto result, SetpointsHFMDataBlob dataBlob, short standCount, short standStartIdx)
        {
            var iscpL = dataBlob.Iscpasses.Where(x => x.Source == "L").FirstOrDefault();
            var iscpM = dataBlob.Iscpasses.Where(x => x.Source == "M").FirstOrDefault();
            var iscpS = dataBlob.Iscpasses.Where(x => x.Source == "S").FirstOrDefault();
            var iscpE = dataBlob.Iscpasses.Where(x => x.Source == "E").FirstOrDefault();

            var rcpL = dataBlob.Rcppasses.Where(x => x.Source == "L").FirstOrDefault();
            var rcpM = dataBlob.Rcppasses.Where(x => x.Source == "M").FirstOrDefault();
            var rcpS = dataBlob.Rcppasses.Where(x => x.Source == "S").FirstOrDefault();
            var rcpE = dataBlob.Rcppasses.Where(x => x.Source == "E").FirstOrDefault();

            for (short i = standStartIdx; i < standCount; i++)
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
                stand.RcpPlanNo.DbSource = "Rcp.PlanNo";

                stand.IscpPlanNo.L = iscpL?.PlanNo;
                stand.IscpPlanNo.E = iscpE?.PlanNo;
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

                stand.IscVolumeInd0.L = iscpPassL?.IscVolumeInd0;
                stand.IscVolumeInd0.E = iscpPassE?.IscVolumeInd0;
                stand.IscVolumeInd0.M = iscpPassM?.IscVolumeInd0;
                stand.IscVolumeInd0.DbSource = $"IscPass.IscVolumeInd0({i})";

                stand.IscVolumeInd1.L = iscpPassL?.IscVolumeInd1;
                stand.IscVolumeInd1.E = iscpPassE?.IscVolumeInd1;
                stand.IscVolumeInd1.M = iscpPassM?.IscVolumeInd1;
                stand.IscVolumeInd1.DbSource = $"IscPass.IscVolumeInd1({i})";

                stand.IscVolumeInd2.L = iscpPassL?.IscVolumeInd2;
                stand.IscVolumeInd2.E = iscpPassE?.IscVolumeInd2;
                stand.IscVolumeInd2.M = iscpPassM?.IscVolumeInd2;
                stand.IscVolumeInd2.DbSource = $"IscPass.IscVolumeInd2({i})";

                stand.IscVolumeInd3.L = iscpPassL?.IscVolumeInd3;
                stand.IscVolumeInd3.E = iscpPassE?.IscVolumeInd3;
                stand.IscVolumeInd3.M = iscpPassM?.IscVolumeInd3;
                stand.IscVolumeInd3.DbSource = $"IscPass.IscVolumeInd3({i})";

                stand.FumesuppSprayBehind.L = iscpPassL?.FumeSuppSprayBehind;
                stand.FumesuppSprayBehind.E = iscpPassE?.FumeSuppSprayBehind;
                stand.FumesuppSprayBehind.M = iscpPassM?.FumeSuppSprayBehind;
                stand.FumesuppSprayBehind.DbSource = $"IscPass.FumeSuppSprayBehind({i})";

                stand.LooperCooling.L = iscpPassL?.LooperCool;
                stand.LooperCooling.E = iscpPassE?.LooperCool;
                stand.LooperCooling.M = iscpPassM?.LooperCool;
                stand.LooperCooling.DbSource = "IscpPass.LooperCool";

                result.WorkCoolingDtos.Add(stand);
            }

            return result;
        }

        public static SetpointsHFMDto MapTension(this SetpointsHFMDto result, SetpointsHFMDataBlob dataBlob, short standCount, short standStartIdx)
        {

            var tpL = dataBlob.Tps.Where(x => x.Source == "L").FirstOrDefault();
            var tpM = dataBlob.Tps.Where(x => x.Source == "M").FirstOrDefault();
            var tpS = dataBlob.Tps.Where(x => x.Source == "S").FirstOrDefault();
            var tpE = dataBlob.Tps.Where(x => x.Source == "E").FirstOrDefault();

            for (short i = standStartIdx; i < standCount; i++)
            {
                var tpPassL = dataBlob.Tppasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var tpPassM = dataBlob.Tppasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var tpPassS = dataBlob.Tppasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var tpPassE = dataBlob.Tppasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();

                var stand = new TensionDto();

                stand.PassNo = i;

                stand.PlanNo.L = tpL?.PlanNo;
                stand.PlanNo.E = tpE?.PlanNo;
                stand.PlanNo.DbSource = "Tp.PlanNo";

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

        public static SetpointsHFMDto MapLubrication(this SetpointsHFMDto result, SetpointsHFMDataBlob dataBlob, short standCount, short standStartIdx)
        {
            var rglpL = dataBlob.Rglps.Where(x => x.Source == "L").FirstOrDefault();
            var rglpM = dataBlob.Rglps.Where(x => x.Source == "M").FirstOrDefault();
            var rglpS = dataBlob.Rglps.Where(x => x.Source == "S").FirstOrDefault();
            var rglpE = dataBlob.Rglps.Where(x => x.Source == "E").FirstOrDefault();

            for (short i = standStartIdx; i < standCount; i++)
            {
                var rglpPassL = dataBlob.Rglppasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var rglpPassM = dataBlob.Rglppasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var rglpPassS = dataBlob.Rglppasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var rglpPassE = dataBlob.Rglppasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();

                var stand = new LubricationDto();

                stand.PassNo = i;

                stand.PlanNo.L = rglpL?.PlanNo;
                stand.PlanNo.E = rglpE?.PlanNo;
                stand.PlanNo.DbSource = "Rglp.PlanNo";

                stand.RollGapLubState.L = rglpPassL?.RollGapLubState;
                stand.RollGapLubState.E = rglpPassE?.RollGapLubState;
                stand.RollGapLubState.M = rglpPassM?.RollGapLubState;
                stand.RollGapLubState.DbSource = $"RglpPass.RollGapLubState({i})";
                
                stand.RollGapLubRampTimeStart.L = rglpPassL?.RollGapLubRampTimeStart;
                stand.RollGapLubRampTimeStart.E = rglpPassE?.RollGapLubRampTimeStart;
                stand.RollGapLubRampTimeStart.M = rglpPassM?.RollGapLubRampTimeStart;
                stand.RollGapLubRampTimeStart.DbSource = $"RglpPass.RollGapLubRampTimeStart({i})";

                stand.RollGapLubRampTimeStop.L = rglpPassL?.RollGapLubRampTimeStop;
                stand.RollGapLubRampTimeStop.E = rglpPassE?.RollGapLubRampTimeStop;
                stand.RollGapLubRampTimeStop.M = rglpPassM?.RollGapLubRampTimeStop;
                stand.RollGapLubRampTimeStop.DbSource = $"RglpPass.RollGapLubRampTimeStop({i})";

                stand.RollGapLubSwitchLength.L = rglpPassL?.RollGapLubSwitchLength;
                stand.RollGapLubSwitchLength.E = rglpPassE?.RollGapLubSwitchLength;
                stand.RollGapLubSwitchLength.M = rglpPassM?.RollGapLubSwitchLength;
                stand.RollGapLubSwitchLength.DbSource = $"RglpPass.RollGapLubSwitchLength({i})";

                stand.RollGapLubOilFlowTop.L = rglpPassL?.RollGapLubOilFlowTop;
                stand.RollGapLubOilFlowTop.E = rglpPassE?.RollGapLubOilFlowTop;
                stand.RollGapLubOilFlowTop.M = rglpPassM?.RollGapLubOilFlowTop;
                stand.RollGapLubOilFlowTop.DbSource = $"RglpPass.RollGapLubOilFlowTop({i})";

                stand.RollGapLubOilFlowBot.L = rglpPassL?.RollGapLubOilFlowBot;
                stand.RollGapLubOilFlowBot.E = rglpPassE?.RollGapLubOilFlowBot;
                stand.RollGapLubOilFlowBot.M = rglpPassM?.RollGapLubOilFlowBot;
                stand.RollGapLubOilFlowBot.DbSource = $"RglpPass.RollGapLubOilFlowBot({i})";

                result.LubricationDtos.Add(stand);
            }

            return result;
        }

        public static SetpointsHFMDto MapTaperShifting(this SetpointsHFMDto result, SetpointsHFMDataBlob dataBlob, short standCount, short standStartIdx)
        {

            var srpL = dataBlob.Srps.Where(x => x.Source == "L").FirstOrDefault();
            var srpM = dataBlob.Srps.Where(x => x.Source == "M").FirstOrDefault();
            var srpS = dataBlob.Srps.Where(x => x.Source == "S").FirstOrDefault();
            var srpE = dataBlob.Srps.Where(x => x.Source == "E").FirstOrDefault();

            for (short i = standStartIdx; i < standCount; i++)
            {
                var srpPassesL = dataBlob.Srppasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var srpPassesM = dataBlob.Srppasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var srpPassesS = dataBlob.Srppasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var srpPassesE = dataBlob.Srppasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();

                var stand = new TaperShiftingDto();

                stand.PassNo = i;

                stand.PlanNo.L = srpL?.PlanNo;
                stand.PlanNo.E = srpE?.PlanNo;
                stand.PlanNo.DbSource = "Srp.PlanNo";

                stand.Model.L = srpPassesL?.Model;
                stand.Model.E = srpPassesE?.Model;
                stand.Model.M = srpPassesM?.Model;
                stand.Model.DbSource = $"SrpPasses.Model({i})";

                result.TaperShiftingDtos.Add(stand);
            }

            return result;
        }

        public static SetpointsHFMApxDto MapTaperShifting(this SetpointsHFMApxDto result, SetpointsHFMApxDataBlob dataBlob, short standCount, short standStartIdx)
        {

            var srpL = dataBlob.Srps.Where(x => x.Source == "L").FirstOrDefault();
            var srpM = dataBlob.Srps.Where(x => x.Source == "M").FirstOrDefault();
            var srpS = dataBlob.Srps.Where(x => x.Source == "S").FirstOrDefault();
            var srpE = dataBlob.Srps.Where(x => x.Source == "E").FirstOrDefault();

            for (short i = standStartIdx; i < standCount; i++)
            {
                var srpPassesL = dataBlob.Srppasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var srpPassesM = dataBlob.Srppasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var srpPassesS = dataBlob.Srppasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var srpPassesE = dataBlob.Srppasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();

                var stand = new TaperShiftingDto();

                stand.PassNo = i;

                stand.PlanNo.L = srpL?.PlanNo;
                stand.PlanNo.E = srpE?.PlanNo;
                stand.PlanNo.DbSource = "Srp.PlanNo";

                stand.Model.L = srpPassesL?.Model;
                stand.Model.E = srpPassesE?.Model;
                stand.Model.M = srpPassesM?.Model;
                stand.Model.DbSource = $"SrpPasses.Model({i})";

                result.TaperShiftingDtos.Add(stand);
            }

            return result;
        }

        public static HFMApxMaterialOverviewDto MapApxOverview(this HFMApxMaterialOverviewDto result, SetpointsHFMApxDataBlob dataBlob)
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

            var srpL = dataBlob.Srps.Where(x => x.Source == "L").FirstOrDefault();
            var srpM = dataBlob.Srps.Where(x => x.Source == "M").FirstOrDefault();
            var srpS = dataBlob.Srps.Where(x => x.Source == "S").FirstOrDefault();
            var srpE = dataBlob.Srps.Where(x => x.Source == "E").FirstOrDefault();

            var lpL = dataBlob.Lps.Where(x => x.Source == "L").FirstOrDefault();
            var lpM = dataBlob.Lps.Where(x => x.Source == "M").FirstOrDefault();
            var lpS = dataBlob.Lps.Where(x => x.Source == "S").FirstOrDefault();
            var lpE = dataBlob.Lps.Where(x => x.Source == "E").FirstOrDefault();

            var IhpL = dataBlob.Ihps.Where(x => x.Source == "L").FirstOrDefault();
            var IhpM = dataBlob.Ihps.Where(x => x.Source == "M").FirstOrDefault();
            var IhpS = dataBlob.Ihps.Where(x => x.Source == "S").FirstOrDefault();
            var IhpE = dataBlob.Ihps.Where(x => x.Source == "E").FirstOrDefault();

            var dirFmPfcCycShiftE = dataBlob.Dirfmpfccycshiftps.Where(x => x.Source == "E").FirstOrDefault();
            var dirFmPfcCycShiftM = dataBlob.Dirfmpfccycshiftps.Where(x => x.Source == "M").FirstOrDefault();
            var dirFmPfcCycShiftS = dataBlob.Dirfmpfccycshiftps.Where(x => x.Source == "S").FirstOrDefault();
            var dirFmPfcCycShiftL = dataBlob.Dirfmpfccycshiftps.Where(x => x.Source == "L").FirstOrDefault();

            result.HExit.L = edOrdEntL?.HExit;
            result.HExit.E = edOrdEntE?.HExit;
            result.HExit.M = edOrdEntM?.HExit;
            result.HExit.S = dataBlob.Adord2Pc?.HExit;
            result.HExit.DbSource = "EdOrdEnt.HExit";
            result.HExit.Status = dataBlob.StatEdordents?.HExit;

            result.WidthExit.L = edOrdEntL?.WidthExit;
            result.WidthExit.E = edOrdEntE?.WidthExit;
            result.WidthExit.M = edOrdEntM?.WidthExit;
            result.WidthExit.S = dataBlob.Adord2Pc?.WExit;
            result.WidthExit.DbSource = "EdOrdEnt.WidthExit";
            result.WidthExit.Status = dataBlob.StatEdordents?.WidthExit;

            result.TExit.L = edOrdEntL?.TExit;
            result.TExit.E = edOrdEntE?.TExit;
            result.TExit.M = edOrdEntM?.TExit;
            result.TExit.DbSource = "EdOrdEnt.TExit";
            result.TExit.Status = dataBlob.StatEdordents?.TExit;

            result.ExitCrownC25.L = edOrdEntL?.ExitCrownC25;
            result.ExitCrownC25.E = edOrdEntE?.ExitCrownC25;
            result.ExitCrownC25.M = edOrdEntM?.ExitCrownC25;
            result.ExitCrownC25.S = dataBlob.Adord2Pc?.Profile;
            result.ExitCrownC25.DbSource = "EdOrdEnt.ExitCrownC25";
            result.HExit.Status = dataBlob.StatEdordents?.HExit;

            result.HExitCold.L = spOrd2PcL?.HExitCold;
            result.HExitCold.E = spOrd2PcE?.HExitCold;
            result.HExitCold.DbSource = "SpOrd2Pc.HExitCold";
            result.HExitCold.Status = dataBlob.StatSpord2pcs?.HExitCold;

            result.WExitCold.L = spOrd2PcL?.WExitCold;
            result.WExitCold.E = spOrd2PcE?.WExitCold;
            result.WExitCold.DbSource = "SpOrd2Pc.WExitCold";
            result.WExitCold.Status = dataBlob.StatSpord2pcs?.WExitCold;

            result.TValue.L = spOrd2PcL?.T;
            result.TValue.E = spOrd2PcE?.T;
            result.TValue.DbSource = "SpOrd2Pc.T";
            result.TValue.Status = dataBlob.StatSpord2pcs?.T;

            result.ProfExCalc.L = spOrd2PcL?.Profexcalc;
            result.ProfExCalc.E = spOrd2PcE?.Profexcalc;
            result.ProfExCalc.DbSource = "SpOrd2Pc.Profexcalc";
            result.ProfExCalc.Status = dataBlob.StatSpord2pcs?.Profexcalc;

            result.HEntryColdFm.L = spOrd2PcL?.HEntryColdFm;
            result.HEntryColdFm.E = spOrd2PcE?.HEntryColdFm;
            result.HEntryColdFm.DbSource = "SpOrd2Pc.HEntryColdFm";
            result.HEntryColdFm.Status = dataBlob.StatSpord2pcs?.HEntryColdFm;

            result.T0MhHRM.L = spOrd2PcL?.T0MhHrm;
            result.T0MhHRM.E = spOrd2PcE?.T0MhHrm;
            result.T0MhHRM.DbSource = "SpOrd2Pc.T0MhHrm";
            result.T0MhHRM.Status = dataBlob.StatSpord2pcs?.T0MhHrm;

            result.RedDistHrmHfm.L = lpL?.RedDistHrmHfm;
            result.RedDistHrmHfm.E = lpE?.RedDistHrmHfm;
            result.RedDistHrmHfm.M = lpM?.RedDistHrmHfm;
            result.RedDistHrmHfm.DbSource = "Lp.RedDistHrmHfm";

            result.ProfileCorr.L = dirFmPfcParaPL?.ProfileCorr;
            result.ProfileCorr.E = dirFmPfcParaPE?.ProfileCorr;
            result.ProfileCorr.M = dirFmPfcParaPM?.ProfileCorr;
            result.ProfileCorr.DbSource = "DirFmPfcParaPL.ProfileCorr";
            result.ProfileCorr.Status = dataBlob.StatDirFmPfcParaPs?.ProfileCorr;

            result.TiHx.L = spOrd2PcL?.TIhhfmx;
            result.TiHx.E = spOrd2PcE?.TIhhfmx;
            result.TiHx.DbSource = "SpOrd2Pc.Tihhfmx";
            result.TiHx.Status = dataBlob.StatSpord2pcs?.TIhhfmx;

            result.LExit.L = spOrd2PcL?.LExit;
            result.LExit.E = spOrd2PcE?.LExit;
            result.LExit.DbSource = "SpOrd2Pc.LExit";
            result.LExit.Status = dataBlob.StatSpord2pcs?.LExit;

            result.InherPfc.L = spOrd2PcL?.InherPfc;
            result.InherPfc.E = spOrd2PcE?.InherPfc;
            result.InherPfc.DbSource = "SpOrd2Pc.InherPfc";
            result.InherPfc.Status = dataBlob.StatSpord2pcs?.InherPfc;

            result.InherPfcId.L = spOrd2PcL?.InherPfcId;
            result.InherPfcId.E = spOrd2PcE?.InherPfcId;
            result.InherPfcId.DbSource = "SpOrd2Pc.InherPfcId";
            result.InherPfcId.Status = dataBlob.StatSpord2pcs?.InherPfcId;

            result.SrpPlanNo.L = srpL?.PlanNo;
            result.SrpPlanNo.E = srpE?.PlanNo;
            result.SrpPlanNo.M = srpM?.PlanNo;
            result.SrpPlanNo.DbSource = "DirFmPfcCycShiftPass.PlanNo";
            result.SrpPlanNo.Status = dataBlob.StatDirfmpfccycshiftps?.PlanNo;

            result.DirFmPfcParaPlanNo.L = dirFmPfcParaPL?.PlanNo;
            result.DirFmPfcParaPlanNo.E = dirFmPfcParaPE?.PlanNo;
            result.DirFmPfcParaPlanNo.M = dirFmPfcParaPM?.PlanNo;
            result.DirFmPfcParaPlanNo.DbSource = "DirFmPfcParaP.PlanNo";
            result.DirFmPfcParaPlanNo.Status = dataBlob.StatDirFmPfcParaPs?.PlanNo;

            result.ShiftingPlan.L = dirFmPfcCycShiftL?.PlanNo;
            result.ShiftingPlan.E = dirFmPfcCycShiftE?.PlanNo;
            result.ShiftingPlan.M = dirFmPfcCycShiftM?.PlanNo;
            result.ShiftingPlan.DbSource = "Dirfmpfccycshiftp.PlanNo";
            result.ShiftingPlan.Status = dataBlob.StatDirfmpfccycshiftps?.PlanNo;

            result.Temperature.L = IhpL?.Temperature;
            result.Temperature.E = IhpE?.Temperature;
            result.Temperature.M = IhpM?.Temperature;
            result.Temperature.DbSource = "Ihp.Temperature";

            result.SrpPlanNo.L = srpL?.PlanNo;
            result.SrpPlanNo.E = srpE?.PlanNo;
            result.SrpPlanNo.M = srpM?.PlanNo;
            result.SrpPlanNo.DbSource = "Srp.PlanNo";

            return result;
        }

        public static SetpointsHFMApxDto MapApxPassSchedule(this SetpointsHFMApxDto result, SetpointsHFMApxDataBlob dataBlob, short standCount, short standStartIdx)
        {
            for (short i = standStartIdx; i < standCount; i++)
            {
                var adordPc2StandS = dataBlob.Adord2PcStands.Where(x => x.StandId == i).SingleOrDefault();
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

                var statLpPass = dataBlob.StatLppasses.FirstOrDefault(x => x.PassNo == i);
                var statDirFmPfcParaPasses = dataBlob.StatDirFmPfcParaPasses.FirstOrDefault(x => x.PassNo == i);
                var statDirfmpfccycshiftppasses = dataBlob.StatDirfmpfccycshiftppasses.FirstOrDefault(x => x.PassNo == i);
                var statSpordPc2Stand = dataBlob.StatSpord2pcstands.FirstOrDefault(x => x.StandId == i);

                var stand = new ApxPassScheduleDto();

                stand.PassNo = i;

                stand.BendingForce.L = lpPassL?.BendingForce;
                stand.BendingForce.E = lpPassE?.BendingForce;
                stand.BendingForce.M = lpPassM?.BendingForce;
                stand.BendingForce.DbSource = $"LpPass.BendingForce({i})";
                stand.BendingForce.Status = statLpPass?.BendingForce;

                stand.Fbul.L = dirFmPfcParaPassesL?.FbUl;
                stand.Fbul.E = dirFmPfcParaPassesE?.FbUl;
                stand.Fbul.M = dirFmPfcParaPassesM?.FbUl;
                stand.Fbul.DbSource = $"DirFmPfcParaPasses.FbUl({i})";
                stand.Fbul.Status = statDirFmPfcParaPasses?.FbUl;

                stand.Fbll.L = dirFmPfcParaPassesL?.FbLl;
                stand.Fbll.E = dirFmPfcParaPassesE?.FbLl;
                stand.Fbll.M = dirFmPfcParaPassesM?.FbLl;
                stand.Fbll.DbSource = $"DirFmPfcParaPasses.FbLl({i})";
                stand.Fbll.Status = statDirFmPfcParaPasses?.FbLl;

                stand.CvcShifting.L = lpPassL?.CVcshifting;
                stand.CvcShifting.E = lpPassE?.CVcshifting;
                stand.CvcShifting.M = lpPassM?.CVcshifting;
                stand.CvcShifting.DbSource = $"LpPass.CvcShifting({i})";
                stand.CvcShifting.Status = statLpPass?.CVcshifting;

                stand.Srul.L = dirFmPfcParaPassesL?.SrUl;
                stand.Srul.E = dirFmPfcParaPassesE?.SrUl;
                stand.Srul.E = dirFmPfcParaPassesM?.SrUl;
                stand.Srul.DbSource = $"DirFmPfcParaPasses.SrUl({i})";
                stand.Srul.Status = statDirFmPfcParaPasses?.SrUl;

                stand.Srll.L = dirFmPfcParaPassesL?.SrLl;
                stand.Srll.E = dirFmPfcParaPassesE?.SrLl;
                stand.Srll.E = dirFmPfcParaPassesM?.SrLl;
                stand.Srll.DbSource = $"DirFmPfcParaPasses.SrLl({i})";
                stand.Srll.Status = statDirFmPfcParaPasses?.SrLl;

                stand.CsMaxLimit.L = dirFmPfcCycShiftPassL?.CSmaxLimit;
                stand.CsMaxLimit.E = dirFmPfcCycShiftPassE?.CSmaxLimit;
                stand.CsMaxLimit.DbSource = $"DirFmPfcCycShiftPass.CSmaxLimit({i})";
                stand.CsMaxLimit.Status = statDirfmpfccycshiftppasses?.CSmaxLimit;

                stand.CsMinLimit.L = dirFmPfcCycShiftPassL?.CSminLimit;
                stand.CsMinLimit.E = dirFmPfcCycShiftPassE?.CSminLimit;
                stand.CsMinLimit.DbSource = $"DirFmPfcCycShiftPass.CSminLimit({i})";
                stand.CsMinLimit.Status = statDirfmpfccycshiftppasses?.CSminLimit;

                stand.Fb.L = spOrd2PcStandL?.Fb;
                stand.Fb.E = spOrd2PcStandE?.Fb;
                stand.Fb.S = adordPc2StandS?.Fb;
                stand.Fb.DbSource = $"SpOrd2PcStand.Fb({i})";
                stand.Fb.Status = statSpordPc2Stand?.Fb;

                stand.PositionWrs.L = spOrd2PcStandL?.PositionWrs;
                stand.PositionWrs.E = spOrd2PcStandE?.PositionWrs;
                stand.PositionWrs.S = adordPc2StandS?.PositionWrs;
                stand.PositionWrs.DbSource = $"SpOrd2PcStand.PositionWrs({i})";
                stand.PositionWrs.Status = statSpordPc2Stand?.PositionWrs;

                stand.WearCorr.L = wmppassesL?.Model;
                stand.WearCorr.E = wmppassesE?.Model;
                stand.WearCorr.DbSource = $"Wmppasses.Model({i})";

                stand.TaperShiftSpeedCorr.L = srpPassesL?.Model;
                stand.TaperShiftSpeedCorr.E = srpPassesE?.Model;
                stand.TaperShiftSpeedCorr.DbSource = $"SrpPasses.Model({i})";

                stand.ObservedFlat.L = dirFmPfcParaPassesL?.ObservedFlat;
                stand.ObservedFlat.E = dirFmPfcParaPassesE?.ObservedFlat;
                stand.ObservedFlat.M = dirFmPfcParaPassesM?.ObservedFlat;
                stand.ObservedFlat.DbSource = $"DirFmPfcParaPasses.ObservedFlat({i})";
                stand.ObservedFlat.Status = statDirFmPfcParaPasses?.ObservedFlat;


                // ADD ADORD2PC FR MS RPOWER VCIRCUM FB POSITIONWRS ABSPROFILE

                stand.Fr.L = spOrd2PcStandL?.Fr;
                stand.Fr.E = spOrd2PcStandE?.Fr;
                stand.Fr.S = adordPc2StandS?.Fr;
                stand.Fr.DbSource = $"SpOrd2PcStand.Fr({i})";
                stand.Fr.Status = statSpordPc2Stand?.Fr;

                stand.WrCrownEff.L = spOrd2PcStandL?.WrCrownEff;
                stand.WrCrownEff.E = spOrd2PcStandE?.WrCrownEff;
                stand.WrCrownEff.DbSource = $"SpOrd2PcStand.WrCrownEff({i})";
                stand.WrCrownEff.Status = statSpordPc2Stand?.WrCrownEff;

                stand.ThermCrown.L = spOrd2PcStandL?.TCrown;
                stand.ThermCrown.E = spOrd2PcStandE?.TCrown;
                stand.ThermCrown.DbSource = $"SpOrd2PcStand.Tcrown({i})";
                stand.ThermCrown.Status = statSpordPc2Stand?.TCrown;

                stand.Troll.L = spOrd2PcStandL?.TRoll;
                stand.Troll.E = spOrd2PcStandE?.TRoll;
                stand.Troll.DbSource = $"SpOrd2PcStand.TRoll({i})";
                stand.Troll.Status = statSpordPc2Stand?.TRoll;

                stand.RelProfile.L = spOrd2PcStandL?.RelProfile;
                stand.RelProfile.E = spOrd2PcStandE?.RelProfile;
                stand.RelProfile.S = adordPc2StandS?.RelProfile;
                stand.RelProfile.DbSource = $"SpOrd2PcStand.RelProfile({i})";
                stand.RelProfile.Status = statSpordPc2Stand?.RelProfile;

                stand.Profile.L = spOrd2PcStandL?.Profile;
                stand.Profile.E = spOrd2PcStandE?.Profile;
                stand.Profile.S = adordPc2StandS?.AbsProfile;
                stand.Profile.DbSource = $"SpOrd2PcStand.Profile({i})";
                stand.Profile.Status = statSpordPc2Stand?.Profile;

                stand.Wear.L = spOrd2PcStandL?.WCrown;
                stand.Wear.E = spOrd2PcStandE?.WCrown;
                stand.Wear.DbSource = $"SpOrd2PcStand.Wcrown({i})";
                stand.Wear.Status = statSpordPc2Stand?.WCrown;

                result.PassScheduleDtos.Add(stand);
            }

            return result;
        }

        public static SetpointsHFMApxDto MapShifting(this SetpointsHFMApxDto result, SetpointsHFMApxDataBlob dataBlob, short standCount, short standStartIdx)
        {
            var dirFmPfcCycShiftL = dataBlob.Dirfmpfccycshiftps.Where(x => x.Source == "L").FirstOrDefault();
            var dirFmPfcCycShiftM = dataBlob.Dirfmpfccycshiftps.Where(x => x.Source == "M").FirstOrDefault();
            var dirFmPfcCycShiftS = dataBlob.Dirfmpfccycshiftps.Where(x => x.Source == "S").FirstOrDefault();
            var dirFmPfcCycShiftE = dataBlob.Dirfmpfccycshiftps.Where(x => x.Source == "E").FirstOrDefault();

            for (short i = standStartIdx; i < standCount; i++)
            {

                var dirFmPfcCycShiftPassL = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var dirFmPfcCycShiftPassM = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var dirFmPfcCycShiftPassS = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var dirFmPfcCycShiftPassE = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();

                var statDirFmPfcCycShiftPass = dataBlob.StatDirfmpfccycshiftppasses.Where(x => x.PassNo == i).SingleOrDefault();

                var stand = new ApxShiftingDto();

                stand.PassNo = i;

                stand.PlanNo.L = dirFmPfcCycShiftL?.PlanNo;
                stand.PlanNo.E = dirFmPfcCycShiftE?.PlanNo;
                stand.PlanNo.DbSource = "DirFmPfcCycShift.PlanNo";
                stand.PlanNo.Status = dataBlob.StatDirfmpfccycshiftps?.PlanNo;

                stand.CsMaxLimit.L = dirFmPfcCycShiftPassL?.CSmaxLimit;
                stand.CsMaxLimit.E = dirFmPfcCycShiftPassE?.CSmaxLimit;
                stand.CsMaxLimit.M = dirFmPfcCycShiftPassM?.CSmaxLimit;
                stand.CsMaxLimit.DbSource = $"DirFmPfcCycShiftPass.CSmaxLimit({i})";
                stand.CsMaxLimit.Status = statDirFmPfcCycShiftPass?.CSmaxLimit;

                stand.CsMinLimit.L = dirFmPfcCycShiftPassL?.CSminLimit;
                stand.CsMinLimit.E = dirFmPfcCycShiftPassE?.CSminLimit;
                stand.CsMinLimit.M = dirFmPfcCycShiftPassM?.CSminLimit;
                stand.CsMinLimit.DbSource = $"DirFmPfcCycShiftPass.CSminLimit({i})";
                stand.CsMinLimit.Status = statDirFmPfcCycShiftPass?.CSminLimit;

                stand.CsStartPos.L = dirFmPfcCycShiftPassL?.CSstartPos;
                stand.CsStartPos.E = dirFmPfcCycShiftPassE?.CSstartPos;
                stand.CsStartPos.M = dirFmPfcCycShiftPassM?.CSstartPos;
                stand.CsStartPos.DbSource = $"DirFmPfcCycShiftPass.CSstartPos({i})";
                stand.CsStartPos.Status = statDirFmPfcCycShiftPass?.CSstartPos;

                stand.CsShiftDir.L = dirFmPfcCycShiftPassL?.CSshiftDir;
                stand.CsShiftDir.E = dirFmPfcCycShiftPassE?.CSshiftDir;
                stand.CsShiftDir.M = dirFmPfcCycShiftPassM?.CSshiftDir;
                stand.CsShiftDir.DbSource = $"DirFmPfcCycShiftPass.CSshiftDir({i})";
                stand.CsShiftDir.Status = statDirFmPfcCycShiftPass?.CSshiftDir;

                stand.CsShiftStep1.L = dirFmPfcCycShiftPassL?.CSshiftStep1;
                stand.CsShiftStep1.E = dirFmPfcCycShiftPassE?.CSshiftStep1;
                stand.CsShiftStep1.M = dirFmPfcCycShiftPassM?.CSshiftStep1;
                stand.CsShiftStep1.DbSource = $"DirFmPfcCycShiftPass.CSshiftStep1({i})";
                stand.CsShiftStep1.Status = statDirFmPfcCycShiftPass?.CSshiftStep1;

                stand.CsShiftStep2.L = dirFmPfcCycShiftPassL?.CSshiftStep2;
                stand.CsShiftStep2.E = dirFmPfcCycShiftPassE?.CSshiftStep2;
                stand.CsShiftStep2.M = dirFmPfcCycShiftPassM?.CSshiftStep2;
                stand.CsShiftStep2.DbSource = $"DirFmPfcCycShiftPass.CSshiftStep2({i})";
                stand.CsShiftStep2.Status = statDirFmPfcCycShiftPass?.CSshiftStep2;

                stand.CsShiftStep3.L = dirFmPfcCycShiftPassL?.CSshiftStep3;
                stand.CsShiftStep3.E = dirFmPfcCycShiftPassE?.CSshiftStep3;
                stand.CsShiftStep3.M = dirFmPfcCycShiftPassM?.CSshiftStep3;
                stand.CsShiftStep3.DbSource = $"DirFmPfcCycShiftPass.CSshiftStep3({i})";
                stand.CsShiftStep3.Status = statDirFmPfcCycShiftPass?.CSshiftStep3;

                stand.Description.L = dirFmPfcCycShiftPassL?.Description;
                stand.Description.E = dirFmPfcCycShiftPassE?.Description;
                stand.Description.M = dirFmPfcCycShiftPassM?.Description;
                stand.Description.DbSource = $"DirFmPfcCycShiftPass.Description({i})";
                stand.Description.Status = statDirFmPfcCycShiftPass?.Description;

                stand.Manint.L = dirFmPfcCycShiftPassL?.ManInt;
                stand.Manint.E = dirFmPfcCycShiftPassE?.ManInt;
                stand.Manint.M = dirFmPfcCycShiftPassM?.ManInt;
                stand.Manint.DbSource = $"DirFmPfcCycShiftPass.Manint({i})";
                stand.Manint.Status = statDirFmPfcCycShiftPass?.ManInt;

                stand.Toextid.L = dirFmPfcCycShiftPassL?.ToExtId;
                stand.Toextid.E = dirFmPfcCycShiftPassE?.ToExtId;
                stand.Toextid.M = dirFmPfcCycShiftPassM?.ToExtId;
                stand.Toextid.DbSource = $"DirFmPfcCycShiftPass.Toextid({i})";

                stand.CsmaxlimitparabolicInd0.L = dirFmPfcCycShiftPassL?.CSmaxLimitParabolicInd0;
                stand.CsmaxlimitparabolicInd0.E = dirFmPfcCycShiftPassE?.CSmaxLimitParabolicInd0;
                stand.CsmaxlimitparabolicInd0.M = dirFmPfcCycShiftPassM?.CSmaxLimitParabolicInd0;
                stand.CsmaxlimitparabolicInd0.DbSource = $"DirFmPfcCycShiftPass.CsmaxlimitparabolicInd0({i})";
                stand.CsmaxlimitparabolicInd0.Status = statDirFmPfcCycShiftPass?.CSmaxLimitParabolicInd0;

                stand.CsmaxlimitparabolicInd1.L = dirFmPfcCycShiftPassL?.CSmaxLimitParabolicInd1;
                stand.CsmaxlimitparabolicInd1.E = dirFmPfcCycShiftPassE?.CSmaxLimitParabolicInd1;
                stand.CsmaxlimitparabolicInd1.M = dirFmPfcCycShiftPassM?.CSmaxLimitParabolicInd1;
                stand.CsmaxlimitparabolicInd1.DbSource = $"DirFmPfcCycShiftPass.CsmaxlimitparabolicInd1({i})";
                stand.CsmaxlimitparabolicInd1.Status = statDirFmPfcCycShiftPass?.CSmaxLimitParabolicInd1;

                stand.CsmaxlimitparabolicInd2.L = dirFmPfcCycShiftPassL?.CSmaxLimitParabolicInd2;
                stand.CsmaxlimitparabolicInd2.E = dirFmPfcCycShiftPassE?.CSmaxLimitParabolicInd2;
                stand.CsmaxlimitparabolicInd2.M = dirFmPfcCycShiftPassM?.CSmaxLimitParabolicInd2;
                stand.CsmaxlimitparabolicInd2.DbSource = $"DirFmPfcCycShiftPass.CsmaxlimitparabolicInd2({i})";
                stand.CsmaxlimitparabolicInd2.Status = statDirFmPfcCycShiftPass?.CSmaxLimitParabolicInd2;

                stand.CsminlimitparabolicInd0.L = dirFmPfcCycShiftPassL?.CSminLimitParabolicInd0;
                stand.CsminlimitparabolicInd0.E = dirFmPfcCycShiftPassE?.CSminLimitParabolicInd0;
                stand.CsminlimitparabolicInd0.M = dirFmPfcCycShiftPassM?.CSminLimitParabolicInd0;
                stand.CsminlimitparabolicInd0.DbSource = $"DirFmPfcCycShiftPass.CsminlimitparabolicInd0({i})";
                stand.CsminlimitparabolicInd0.Status = statDirFmPfcCycShiftPass?.CSminLimitParabolicInd0;

                stand.CsminlimitparabolicInd1.L = dirFmPfcCycShiftPassL?.CSminLimitParabolicInd1;
                stand.CsminlimitparabolicInd1.E = dirFmPfcCycShiftPassE?.CSminLimitParabolicInd1;
                stand.CsminlimitparabolicInd1.M = dirFmPfcCycShiftPassM?.CSminLimitParabolicInd1;
                stand.CsminlimitparabolicInd1.DbSource = $"DirFmPfcCycShiftPass.CsminlimitparabolicInd1({i})";
                stand.CsminlimitparabolicInd1.Status = statDirFmPfcCycShiftPass?.CSminLimitParabolicInd1;

                stand.CsminlimitparabolicInd2.L = dirFmPfcCycShiftPassL?.CSminLimitParabolicInd2;
                stand.CsminlimitparabolicInd2.E = dirFmPfcCycShiftPassE?.CSminLimitParabolicInd2;
                stand.CsminlimitparabolicInd2.M = dirFmPfcCycShiftPassM?.CSminLimitParabolicInd2;
                stand.CsminlimitparabolicInd2.DbSource = $"DirFmPfcCycShiftPass.CsminlimitparabolicInd2({i})";
                stand.CsminlimitparabolicInd2.Status = statDirFmPfcCycShiftPass?.CSminLimitParabolicInd2;

                stand.CsstepparabolicInd0.L = dirFmPfcCycShiftPassL?.CSstepParabolicInd0;
                stand.CsstepparabolicInd0.E = dirFmPfcCycShiftPassE?.CSstepParabolicInd0;
                stand.CsstepparabolicInd0.M = dirFmPfcCycShiftPassM?.CSstepParabolicInd0;
                stand.CsstepparabolicInd0.DbSource = $"DirFmPfcCycShiftPass.CsstepparabolicInd0({i})";
                stand.CsstepparabolicInd0.Status = statDirFmPfcCycShiftPass?.CSstepParabolicInd0;

                stand.CsstepparabolicInd1.L = dirFmPfcCycShiftPassL?.CSstepParabolicInd1;
                stand.CsstepparabolicInd1.E = dirFmPfcCycShiftPassE?.CSstepParabolicInd1;
                stand.CsstepparabolicInd1.M = dirFmPfcCycShiftPassM?.CSstepParabolicInd1;
                stand.CsstepparabolicInd1.DbSource = $"DirFmPfcCycShiftPass.CsstepparabolicInd1({i})";
                stand.CsstepparabolicInd1.Status = statDirFmPfcCycShiftPass?.CSstepParabolicInd1;

                stand.CsstepparabolicInd2.L = dirFmPfcCycShiftPassL?.CSstepParabolicInd2;
                stand.CsstepparabolicInd2.E = dirFmPfcCycShiftPassE?.CSstepParabolicInd2;
                stand.CsstepparabolicInd2.M = dirFmPfcCycShiftPassM?.CSstepParabolicInd2;
                stand.CsstepparabolicInd2.DbSource = $"DirFmPfcCycShiftPass.CsstepparabolicInd2({i})";
                stand.CsstepparabolicInd2.Status = statDirFmPfcCycShiftPass?.CSstepParabolicInd2;

                stand.CsstepsmartcrownInd0.L = dirFmPfcCycShiftPassL?.CSstepSmartCrownInd0;
                stand.CsstepsmartcrownInd0.E = dirFmPfcCycShiftPassE?.CSstepSmartCrownInd0;
                stand.CsstepsmartcrownInd0.M = dirFmPfcCycShiftPassM?.CSstepSmartCrownInd0;
                stand.CsstepsmartcrownInd0.DbSource = $"DirFmPfcCycShiftPass.CsstepsmartcrownInd0({i})";
                stand.CsstepsmartcrownInd0.Status = statDirFmPfcCycShiftPass?.CSstepSmartCrownInd0;

                stand.CsstepsmartcrownInd1.L = dirFmPfcCycShiftPassL?.CSstepSmartCrownInd1;
                stand.CsstepsmartcrownInd1.E = dirFmPfcCycShiftPassE?.CSstepSmartCrownInd1;
                stand.CsstepsmartcrownInd1.M = dirFmPfcCycShiftPassM?.CSstepSmartCrownInd1;
                stand.CsstepsmartcrownInd1.DbSource = $"DirFmPfcCycShiftPass.CsstepsmartcrownInd1({i})";
                stand.CsstepsmartcrownInd1.Status = statDirFmPfcCycShiftPass?.CSstepSmartCrownInd2;

                stand.CsstepsmartcrownInd2.L = dirFmPfcCycShiftPassL?.CSstepSmartCrownInd2;
                stand.CsstepsmartcrownInd2.E = dirFmPfcCycShiftPassE?.CSstepSmartCrownInd2;
                stand.CsstepsmartcrownInd2.M = dirFmPfcCycShiftPassM?.CSstepSmartCrownInd2;
                stand.CsstepsmartcrownInd2.DbSource = $"DirFmPfcCycShiftPass.CsstepsmartcrownInd0({i})";
                stand.CsstepsmartcrownInd2.Status = statDirFmPfcCycShiftPass?.CSstepSmartCrownInd2;

                result.ShiftingDtos.Add(stand);
            }

            return result;
        }

        public static SetpointsHFMApxDto MapFlatness(this SetpointsHFMApxDto result, SetpointsHFMApxDataBlob dataBlob, short standCount, short standStartIdx)
        {
            var dirFmPfcParaL = dataBlob.DirFmPfcParaPs.Where(x => x.Source == "L").FirstOrDefault();
            var dirFmPfcParaM = dataBlob.DirFmPfcParaPs.Where(x => x.Source == "M").FirstOrDefault();
            var dirFmPfcParaS = dataBlob.DirFmPfcParaPs.Where(x => x.Source == "S").FirstOrDefault();
            var dirFmPfcParaE = dataBlob.DirFmPfcParaPs.Where(x => x.Source == "E").FirstOrDefault();

            for (short i = standStartIdx; i < standCount; i++)
            {

                var dirFmPfcParaPassesL = dataBlob.DirFmPfcParaPasses.Where(x => x.Source == "L" && x.PassNo == i).FirstOrDefault();
                var dirFmPfcParaPassesM = dataBlob.DirFmPfcParaPasses.Where(x => x.Source == "M" && x.PassNo == i).FirstOrDefault();
                var dirFmPfcParaPassesS = dataBlob.DirFmPfcParaPasses.Where(x => x.Source == "S" && x.PassNo == i).FirstOrDefault();
                var dirFmPfcParaPassesE = dataBlob.DirFmPfcParaPasses.Where(x => x.Source == "E" && x.PassNo == i).FirstOrDefault();
                var statDirFmPfcParapPass = dataBlob.StatDirFmPfcParaPasses.Where(x => x.PassNo == i).SingleOrDefault();

                var stand = new ApxFlatnessDto();

                stand.PassNo = i;

                stand.PlanNo.L = dirFmPfcParaL?.PlanNo;
                stand.PlanNo.E = dirFmPfcParaE?.PlanNo;
                stand.PlanNo.DbSource = "DirFmPfcParaP.PlanNo";
                stand.PlanNo.Status = dataBlob.StatDirFmPfcParaPs?.PlanNo;

                stand.Fbul.L = dirFmPfcParaPassesL?.FbUl;
                stand.Fbul.E = dirFmPfcParaPassesE?.FbUl;
                stand.Fbul.M = dirFmPfcParaPassesM?.FbUl;
                stand.Fbul.DbSource = $"DirFmPfcParaPasses.FbUl({i})";
                stand.Fbul.Status = statDirFmPfcParapPass?.FbUl;

                stand.Fbll.L = dirFmPfcParaPassesL?.FbLl;
                stand.Fbll.E = dirFmPfcParaPassesE?.FbLl;
                stand.Fbll.M = dirFmPfcParaPassesM?.FbLl;
                stand.Fbll.DbSource = $"DirFmPfcParaPasses.FbLl({i})";
                stand.Fbll.Status = statDirFmPfcParapPass?.FbLl;

                stand.Srul.L = dirFmPfcParaPassesL?.SrUl;
                stand.Srul.E = dirFmPfcParaPassesE?.SrUl;
                stand.Srul.E = dirFmPfcParaPassesM?.SrUl;
                stand.Srul.DbSource = $"DirFmPfcParaPasses.SrUl({i})";
                stand.Srul.Status = statDirFmPfcParapPass?.SrUl;

                stand.Srll.L = dirFmPfcParaPassesL?.SrLl;
                stand.Srll.E = dirFmPfcParaPassesE?.SrLl;
                stand.Srll.E = dirFmPfcParaPassesM?.SrLl;
                stand.Srll.DbSource = $"DirFmPfcParaPasses.SrLl({i})";
                stand.Srll.Status = statDirFmPfcParapPass?.SrLl;

                stand.Facdfbdfr.L = dirFmPfcParaPassesL?.FacDfbDfr;
                stand.Facdfbdfr.E = dirFmPfcParaPassesE?.FacDfbDfr;
                stand.Facdfbdfr.E = dirFmPfcParaPassesM?.FacDfbDfr;
                stand.Facdfbdfr.DbSource = $"DirFmPfcParaPasses.FacDfbDfr({i})";
                stand.Facdfbdfr.Status = statDirFmPfcParapPass?.FacDfbDfr;

                stand.Facdfbdiu.L = dirFmPfcParaPassesL?.FacDfbDiu;
                stand.Facdfbdiu.E = dirFmPfcParaPassesE?.FacDfbDiu;
                stand.Facdfbdiu.E = dirFmPfcParaPassesM?.FacDfbDiu;
                stand.Facdfbdiu.DbSource = $"DirFmPfcParaPasses.FacDfbDiu({i})";
                stand.Facdfbdiu.Status = statDirFmPfcParapPass?.FacDfbDiu;

                result.FlatnessDtos.Add(stand);
            }

            return result;
        }

    }
}

