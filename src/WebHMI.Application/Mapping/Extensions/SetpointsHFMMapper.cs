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

            result.HExit.L = edOrdEntL?.Hexit;
            result.HExit.E = edOrdEntE?.Hexit;
            result.HExit.M = edOrdEntM?.Hexit;
            result.HExit.S = dataBlob.Adord2PC?.Hexit;
            result.HExit.DbSource = "EdOrdEnt.HExit";
            result.HExit.Status = dataBlob.StatEdordents?.Hexit;

            result.WidthExit.L = edOrdEntL?.Widthexit;
            result.WidthExit.E = edOrdEntE?.Widthexit;
            result.WidthExit.M = edOrdEntM?.Widthexit;
            result.WidthExit.S = dataBlob.Adord2PC?.Wexit;
            result.WidthExit.DbSource = "EdOrdEnt.WidthExit";
            result.WidthExit.Status = dataBlob.StatEdordents?.Widthexit;

            result.TExit.L = edOrdEntL?.Texit;
            result.TExit.E = edOrdEntE?.Texit;
            result.TExit.M = edOrdEntM?.Texit;
            result.TExit.DbSource = "EdOrdEnt.TExit";
            result.TExit.Status = dataBlob.StatEdordents?.Texit;

            result.ExitCrownc25.L = edOrdEntL?.Exitcrownc25;
            result.ExitCrownc25.E = edOrdEntE?.Exitcrownc25;
            result.ExitCrownc25.M = edOrdEntM?.Exitcrownc25;
            result.ExitCrownc25.S = dataBlob.Adord2PC?.Profile;
            result.ExitCrownc25.DbSource = "EdOrdEnt.ExitCrownC25";
            result.ExitCrownc25.Status = dataBlob.StatEdordents?.Exitcrownc25;

            result.HExitCold.L = spOrd2PcL?.Hexitcold;
            result.HExitCold.E = spOrd2PcE?.Hexitcold;
            result.HExitCold.DbSource = "SpOrd2Pc.HExitCold";
            result.HExitCold.Status = dataBlob.StatSpord2pcs?.Hexitcold;

            result.WExitCold.L = spOrd2PcL?.Wexitcold;
            result.WExitCold.E = spOrd2PcE?.Wexitcold;
            result.WExitCold.DbSource = "SpOrd2Pc.WExitCold";
            result.WExitCold.Status = dataBlob.StatSpord2pcs?.Wexitcold;

            result.TValue.L = spOrd2PcL?.T;
            result.TValue.E = spOrd2PcE?.T;
            result.TValue.DbSource = "SpOrd2Pc.T";
            result.TValue.Status = dataBlob.StatSpord2pcs?.T;

            result.ProfExCalc.L = spOrd2PcL?.Profexcalc;
            result.ProfExCalc.E = spOrd2PcE?.Profexcalc;
            result.ProfExCalc.DbSource = "SpOrd2Pc.Profexcalc";
            result.ProfExCalc.Status = dataBlob.StatSpord2pcs?.Profexcalc;

            result.HEntryColdFm.L = spOrd2PcL?.Hentrycoldfm;
            result.HEntryColdFm.E = spOrd2PcE?.Hentrycoldfm;
            result.HEntryColdFm.DbSource = "SpOrd2Pc.HEntryColdFm";
            result.HEntryColdFm.Status = dataBlob.StatSpord2pcs?.Hentrycoldfm;

            result.T0MhHRM.L = spOrd2PcL?.T0mhhrm;
            result.T0MhHRM.E = spOrd2PcE?.T0mhhrm;
            result.T0MhHRM.DbSource = "SpOrd2Pc.T0MhHrm";
            result.T0MhHRM.Status = dataBlob.StatSpord2pcs?.T0mhhrm;

            result.RedDistHrmFm.L = lpL?.Reddisthrmhfm;
            result.RedDistHrmFm.E = lpE?.Reddisthrmhfm;
            result.RedDistHrmFm.M = lpM?.Reddisthrmhfm;
            result.RedDistHrmFm.DbSource = "Lp.RedDistHrmHfm";

            result.ProfileCorr.L = dirFmPfcParaPL?.Profilecorr;
            result.ProfileCorr.E = dirFmPfcParaPE?.Profilecorr;
            result.ProfileCorr.M = dirFmPfcParaPM?.Profilecorr;
            result.ProfileCorr.DbSource = "DirFmPfcParaPL.ProfileCorr";
            result.ProfileCorr.Status = dataBlob.StatDirFmPfcParaPs?.Profilecorr;

            result.TiHx.L = spOrd2PcL?.Tihhfmx;
            result.TiHx.E = spOrd2PcE?.Tihhfmx;
            result.TiHx.DbSource = "SpOrd2Pc.Tihhfmx";
            result.TiHx.Status = dataBlob.StatSpord2pcs?.Tihhfmx;

            result.LExit.L = spOrd2PcL?.Lexit;
            result.LExit.E = spOrd2PcE?.Lexit;
            result.LExit.DbSource = "SpOrd2Pc.LExit";
            result.LExit.Status = dataBlob.StatSpord2pcs?.Lexit;

            result.LpPlanNo.L = lpL?.Planno;
            result.LpPlanNo.E = lpE?.Planno;
            result.LpPlanNo.M = lpM?.Planno;
            result.LpPlanNo.DbSource = "Lp.PlanNo";

            result.DpHfmPlanNo.L = dphfmL?.Planno;
            result.DpHfmPlanNo.E = dphfmE?.Planno;
            result.DpHfmPlanNo.M = dphfmM?.Planno;
            result.DpHfmPlanNo.DbSource = "DphFm.PlanNo";

            result.RcpPlanNo.L = rcpL?.Planno;
            result.RcpPlanNo.E = rcpE?.Planno;
            result.RcpPlanNo.M = rcpM?.Planno;
            result.RcpPlanNo.DbSource = "Rcp.PlanNo";

            result.TpPlanNo.L = tpL?.Planno;
            result.TpPlanNo.E = tpE?.Planno;
            result.TpPlanNo.M = tpM?.Planno;
            result.TpPlanNo.DbSource = "Tp.PlanNo";

            result.RglpPlanNo.L = rglpL?.Planno;
            result.RglpPlanNo.E = rglpE?.Planno;
            result.RglpPlanNo.M = rglpM?.Planno;
            result.RglpPlanNo.DbSource = "Rglp.PlanNo";

            result.IscpPlanNo.L = iscpL?.Planno;
            result.IscpPlanNo.E = iscpE?.Planno;
            result.IscpPlanNo.M = iscpM?.Planno;
            result.IscpPlanNo.DbSource = "Iscp.PlanNo";

            result.SrpPlanNo.L = srpL?.Planno;
            result.SrpPlanNo.E = srpE?.Planno;
            result.SrpPlanNo.M = srpM?.Planno;
            result.SrpPlanNo.DbSource = "Srp.PlanNo";

            result.AntiLubricationPlanNo.L = aopL?.Planno;
            result.AntiLubricationPlanNo.E = aopE?.Planno;
            result.AntiLubricationPlanNo.M = aopM?.Planno;
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
                var adordPC2StandS = dataBlob.Adord2PCStands.Where(x => x.Standid == i).SingleOrDefault();

                var srpPassesL = dataBlob.Srppasses.Where(x => x.Source == "L" && x.Passno == i).FirstOrDefault();
                var srpPassesM = dataBlob.Srppasses.Where(x => x.Source == "M" && x.Passno == i).FirstOrDefault();
                var srpPassesS = dataBlob.Srppasses.Where(x => x.Source == "S" && x.Passno == i).FirstOrDefault();
                var srpPassesE = dataBlob.Srppasses.Where(x => x.Source == "E" && x.Passno == i).FirstOrDefault();

                var spOrd2PcStandL = dataBlob.Spord2pcstands.Where(x => x.Source == "L" && x.Standid == i).FirstOrDefault();
                var spOrd2PcStandM = dataBlob.Spord2pcstands.Where(x => x.Source == "M" && x.Standid == i).FirstOrDefault();
                var spOrd2PcStandS = dataBlob.Spord2pcstands.Where(x => x.Source == "S" && x.Standid == i).FirstOrDefault();
                var spOrd2PcStandE = dataBlob.Spord2pcstands.Where(x => x.Source == "E" && x.Standid == i).FirstOrDefault();

                var aopPassL = dataBlob.Aoppasses.Where(x => x.Source == "L" && x.Passno == i).FirstOrDefault();
                var aopPassM = dataBlob.Aoppasses.Where(x => x.Source == "M" && x.Passno == i).FirstOrDefault();
                var aopPassS = dataBlob.Aoppasses.Where(x => x.Source == "S" && x.Passno == i).FirstOrDefault();
                var aopPassE = dataBlob.Aoppasses.Where(x => x.Source == "E" && x.Passno == i).FirstOrDefault();

                var iscpPassL = dataBlob.Iscpasses.Where(x => x.Source == "L" && x.Passno == i).FirstOrDefault();
                var iscpPassM = dataBlob.Iscpasses.Where(x => x.Source == "M" && x.Passno == i).FirstOrDefault();
                var iscpPassS = dataBlob.Iscpasses.Where(x => x.Source == "S" && x.Passno == i).FirstOrDefault();
                var iscpPassE = dataBlob.Iscpasses.Where(x => x.Source == "E" && x.Passno == i).FirstOrDefault();

                var rcpPassL = dataBlob.Rcppasses.Where(x => x.Source == "L" && x.Passno == i).FirstOrDefault();
                var rcpPassM = dataBlob.Rcppasses.Where(x => x.Source == "M" && x.Passno == i).FirstOrDefault();
                var rcpPassS = dataBlob.Rcppasses.Where(x => x.Source == "S" && x.Passno == i).FirstOrDefault();
                var rcpPassE = dataBlob.Rcppasses.Where(x => x.Source == "E" && x.Passno == i).FirstOrDefault();

                var lpPassL = dataBlob.Lppasses.Where(x => x.Source == "L" && x.Passno == i).FirstOrDefault();
                var lpPassM = dataBlob.Lppasses.Where(x => x.Source == "M" && x.Passno == i).FirstOrDefault();
                var lpPassS = dataBlob.Lppasses.Where(x => x.Source == "S" && x.Passno == i).FirstOrDefault();
                var lpPassE = dataBlob.Lppasses.Where(x => x.Source == "E" && x.Passno == i).FirstOrDefault();

                var tpPassL = dataBlob.Tppasses.Where(x => x.Source == "L" && x.Passno == i).FirstOrDefault();
                var tpPassM = dataBlob.Tppasses.Where(x => x.Source == "M" && x.Passno == i).FirstOrDefault();
                var tpPassS = dataBlob.Tppasses.Where(x => x.Source == "S" && x.Passno == i).FirstOrDefault();
                var tpPassE = dataBlob.Tppasses.Where(x => x.Source == "E" && x.Passno == i).FirstOrDefault();

                var dirFmPfcCycShiftPassL = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "L" && x.Passno == i).FirstOrDefault();
                var dirFmPfcCycShiftPassM = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "M" && x.Passno == i).FirstOrDefault();
                var dirFmPfcCycShiftPassS = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "S" && x.Passno == i).FirstOrDefault();
                var dirFmPfcCycShiftPassE = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "E" && x.Passno == i).FirstOrDefault();

                var dirFmPfcParapPassL = dataBlob.DirFmPfcParapPasses.Where(x => x.Source == "L" && x.Passno == i).FirstOrDefault();
                var dirFmPfcParapPassM = dataBlob.DirFmPfcParapPasses.Where(x => x.Source == "M" && x.Passno == i).FirstOrDefault();
                var dirFmPfcParapPassS = dataBlob.DirFmPfcParapPasses.Where(x => x.Source == "S" && x.Passno == i).FirstOrDefault();
                var dirFmPfcParapPassE = dataBlob.DirFmPfcParapPasses.Where(x => x.Source == "E" && x.Passno == i).FirstOrDefault();

                var statLpPass = dataBlob.StatLppasses.FirstOrDefault(x => x.Passno == i);
                var statSpord2Pc = dataBlob.StatSpord2pcstands.FirstOrDefault(x => x.Standid == i);
                var statDirFmPfcParapPasses = dataBlob.StatDirFmPfcParapPasses.FirstOrDefault(x => x.Passno == i);

                var stand = new PassScheduleDto();

                stand.PassNo = i;

                stand.LoadingType.L = lpPassL?.Loadingtype;
                stand.LoadingType.E = lpPassE?.Loadingtype;
                stand.LoadingType.M = lpPassM?.Loadingtype;
                stand.LoadingType.DbSource = $"LpPass.LoadingType({i})";
                stand.LoadingType.Status = statLpPass?.Loadingtype;

                stand.Red.L = spOrd2PcStandL?.Red;
                stand.Red.E = spOrd2PcStandE?.Red;
                stand.Red.DbSource = $"SpOrd2PcStand.Red({i})";
                stand.Red.Status = statSpord2Pc?.Red;

                stand.LoadingValue.L = lpPassL?.Loadingvalue;
                stand.LoadingValue.E = lpPassE?.Loadingvalue;
                stand.LoadingValue.M = lpPassM?.Loadingvalue;
                stand.LoadingValue.DbSource = $"LpPass.LoadingValue({i})";
                stand.LoadingValue.Status = statLpPass?.Loadingtype;

                stand.LoadingValueCorrection.L = lpPassL?.Loadingvaluecorrection;
                stand.LoadingValueCorrection.E = lpPassE?.Loadingvaluecorrection;
                stand.LoadingValueCorrection.M = lpPassM?.Loadingvaluecorrection;
                stand.LoadingValueCorrection.DbSource = $"LpPass.LoadingValueCorrection({i})";
                stand.LoadingValueCorrection.Status = statLpPass?.Loadingvaluecorrection;

                stand.Fb.L = spOrd2PcStandL?.Fb;
                stand.Fb.E = spOrd2PcStandE?.Fb;
                stand.Fb.S = adordPC2StandS?.Fb;
                stand.Fb.DbSource = $"SpOrd2PcStand.Fb({i})";
                stand.Fb.Status = statSpord2Pc?.Fb;

                stand.PositionWRS.L = spOrd2PcStandL?.Positionwrs;
                stand.PositionWRS.E = spOrd2PcStandE?.Positionwrs;
                stand.PositionWRS.M = spOrd2PcStandM?.Positionwrs;
                stand.PositionWRS.S = adordPC2StandS?.Positionwrs;
                stand.PositionWRS.DbSource = $"SpOrd2PcStand.PositionWrs({i})";
                stand.PositionWRS.Status = statSpord2Pc?.Positionwrs;

                stand.Model.L = srpPassesL?.Model;
                stand.Model.E = srpPassesE?.Model;
                stand.Model.DbSource = $"SrpPasses.Model({i})";

                stand.SpecifFoTension.L = tpPassL?.Speciffotension;
                stand.SpecifFoTension.E = tpPassE?.Speciffotension;
                stand.SpecifFoTension.M = tpPassM?.Speciffotension;
                stand.SpecifFoTension.DbSource = $"TpPass.SpecifFoTension({i})";

                stand.ObservedFlat.L = dirFmPfcParapPassL?.Observedflat;
                stand.ObservedFlat.E = dirFmPfcParapPassE?.Observedflat;
                stand.ObservedFlat.M = dirFmPfcParapPassM?.Observedflat;
                stand.ObservedFlat.DbSource = $"DirFmPfcParapPass.ObservedFlat({i})";
                stand.ObservedFlat.Status = statDirFmPfcParapPasses?.Observedflat;


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

                stand.VCircum.L = spOrd2PcStandL?.Vcircum;
                stand.VCircum.E = spOrd2PcStandE?.Vcircum;
                stand.VCircum.S = adordPC2StandS?.Vcircum;
                stand.VCircum.DbSource = $"SpOrd2PcStand.VCircum({i})";
                stand.VCircum.Status = statSpord2Pc?.Vcircum;

                stand.TRoll.L = spOrd2PcStandL?.Troll;
                stand.TRoll.E = spOrd2PcStandE?.Troll;
                stand.TRoll.DbSource = $"SpOrd2PcStand.TRoll({i})";
                stand.TRoll.Status = statSpord2Pc?.Troll;

                stand.DeltaSdPos.L = spOrd2PcStandL?.Sdcorr;
                stand.DeltaSdPos.E = spOrd2PcStandE?.Sdcorr;
                stand.DeltaSdPos.DbSource = $"SpOrd2PcStand.DeltaSdPos({i})";
                stand.DeltaSdPos.Status = statSpord2Pc?.Sdcorr;

                stand.RelProfile.L = spOrd2PcStandL?.Relprofile;
                stand.RelProfile.E = spOrd2PcStandE?.Relprofile;
                stand.RelProfile.S = adordPC2StandS?.Relprofile;
                stand.RelProfile.DbSource = $"SpOrd2PcStand.RelProfile({i})";
                stand.RelProfile.Status = statSpord2Pc?.Relprofile;

                stand.Profile.L = spOrd2PcStandL?.Profile;
                stand.Profile.E = spOrd2PcStandE?.Profile;
                stand.Profile.S = adordPC2StandS?.Absprofile;
                stand.Profile.DbSource = $"SpOrd2PcStand.Profile({i})";
                stand.Profile.Status = statSpord2Pc?.Profile;

                stand.Ms.L = spOrd2PcStandL?.Ms;
                stand.Ms.E = spOrd2PcStandE?.Ms;
                stand.Ms.S = adordPC2StandS?.Ms;
                stand.Ms.DbSource = $"SpOrd2PcStand.Ms({i})";
                stand.Ms.Status = statSpord2Pc?.Ms;

                stand.RPower.L = spOrd2PcStandL?.Rpower;
                stand.RPower.E = spOrd2PcStandE?.Rpower;
                stand.RPower.S = adordPC2StandS?.Rpower;
                stand.RPower.DbSource = $"SpOrd2PcStand.RPower({i})";
                stand.RPower.Status = statSpord2Pc?.Rpower;

                stand.CalcFlat.L = spOrd2PcStandL?.Calcflat;
                stand.CalcFlat.E = spOrd2PcStandE?.Calcflat;
                stand.CalcFlat.DbSource = $"SpOrd2PcStand.CalcFlat({i})";
                stand.CalcFlat.Status = statSpord2Pc?.Calcflat;

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
                var lpPassL = dataBlob.Lppasses.Where(x => x.Source == "L" && x.Passno == i).FirstOrDefault();
                var lpPassM = dataBlob.Lppasses.Where(x => x.Source == "M" && x.Passno == i).FirstOrDefault();
                var lpPassS = dataBlob.Lppasses.Where(x => x.Source == "S" && x.Passno == i).FirstOrDefault();
                var lpPassE = dataBlob.Lppasses.Where(x => x.Source == "E" && x.Passno == i).FirstOrDefault();

                var statLpPass = dataBlob.StatLppasses.FirstOrDefault(x => x.Passno == i);

                var stand = new LoadingDto();

                stand.PassNo = i;

                stand.LoadingPlan.L = lpL?.Planno;
                stand.LoadingPlan.E = lpE?.Planno;
                stand.LoadingPlan.DbSource = $"LpPass.PlanNo({i})";
                stand.LoadingPlan.Status = statLpPass?.Planno;

                stand.LoadingType.L = lpPassL?.Loadingtype;
                stand.LoadingType.E = lpPassE?.Loadingtype;
                stand.LoadingType.M = lpPassM?.Loadingtype;
                stand.LoadingType.DbSource = $"LpPass.LoadingType({i})";
                stand.LoadingType.Status = statLpPass?.Loadingtype;

                stand.LoadingValue.L = lpPassL?.Loadingvalue;
                stand.LoadingValue.E = lpPassE?.Loadingvalue;
                stand.LoadingValue.M = lpPassM?.Loadingvalue;
                stand.LoadingValue.DbSource = $"LpPass.LoadingValue({i})";
                stand.LoadingValue.Status = statLpPass?.Loadingvalue;

                stand.CircumSpeedCorrection.L = lpPassL?.Circumspeedcorrection;
                stand.CircumSpeedCorrection.E = lpPassE?.Circumspeedcorrection;
                stand.CircumSpeedCorrection.M = lpPassM?.Circumspeedcorrection;
                stand.CircumSpeedCorrection.DbSource = $"LpPass.CircumSpeedCorrection({i})";
                stand.CircumSpeedCorrection.Status = statLpPass?.Circumspeedcorrection;

                stand.BendingForce.L = lpPassL?.Bendingforce;
                stand.BendingForce.E = lpPassE?.Bendingforce;
                stand.BendingForce.M = lpPassM?.Bendingforce;
                stand.BendingForce.DbSource = "LpPass.BendingForce";
                stand.BendingForce.Status = statLpPass?.Bendingforce;

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

            result.Descaling.PlanNo.L = dpfmL?.Planno;
            result.Descaling.PlanNo.E = dpfmE?.Planno;
            result.Descaling.PlanNo.DbSource = "Dpfm.PlanNo";

            result.Descaling.DescrampAuto.L = dprampfmL?.Descrampauto;
            result.Descaling.DescrampAuto.E = dprampfmE?.Descrampauto;
            result.Descaling.DescrampAuto.M = dprampfmM?.Descrampauto;
            result.Descaling.DescrampAuto.DbSource = "Dprampfm.DescRampAuto";

            result.Descaling.DescrampState.L = dprampfmL?.Descrampstate;
            result.Descaling.DescrampState.E = dprampfmE?.Descrampstate;
            result.Descaling.DescrampState.M = dprampfmM?.Descrampstate;
            result.Descaling.DescrampState.DbSource = "Dprampfm.DescrampState";

            result.Descaling.DescrampVolume.L = dprampfmL?.Descrampvolume;
            result.Descaling.DescrampVolume.E = dprampfmE?.Descrampvolume;
            result.Descaling.DescrampVolume.M = dprampfmM?.Descrampvolume;
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

                var aopPassL = dataBlob.Aoppasses.Where(x => x.Source == "L" && x.Passno == i).FirstOrDefault();
                var aopPassM = dataBlob.Aoppasses.Where(x => x.Source == "M" && x.Passno == i).FirstOrDefault();
                var aopPassS = dataBlob.Aoppasses.Where(x => x.Source == "S" && x.Passno == i).FirstOrDefault();
                var aopPassE = dataBlob.Aoppasses.Where(x => x.Source == "E" && x.Passno == i).FirstOrDefault();

                var stand = new AntiPeelingDto();

                stand.PassNo = i;

                stand.PlanNo.L = aopL?.Planno;
                stand.PlanNo.E = aopE?.Planno;
                stand.PlanNo.DbSource = "Aop.PlanNo";

                stand.AntiOxStateEntry.L = aopPassL?.Antioxstateentry;
                stand.AntiOxStateEntry.E = aopPassE?.Antioxstateentry;
                stand.AntiOxStateEntry.M = aopPassM?.Antioxstateentry;
                stand.AntiOxStateEntry.DbSource = $"AopPass.AntiOxStateEntry({i})";

                stand.AntiOxidationEntry.L = aopPassL?.Antioxidationentry;
                stand.AntiOxidationEntry.E = aopPassE?.Antioxidationentry;
                stand.AntiOxidationEntry.M = aopPassM?.Antioxidationentry;
                stand.AntiOxidationEntry.DbSource = $"AopPass.AntiOxidationEntry({i})";

                stand.AntiOxStateExit.L = aopPassL?.Antioxstateexit;
                stand.AntiOxStateExit.E = aopPassE?.Antioxstateexit;
                stand.AntiOxStateExit.M = aopPassM?.Antioxstateexit;
                stand.AntiOxStateExit.DbSource = $"AopPass.AntiOxStateExit({i})";

                stand.AntiOxidationExit.L = aopPassL?.Antioxidationexit;
                stand.AntiOxidationExit.E = aopPassE?.Antioxidationexit;
                stand.AntiOxidationExit.M = aopPassM?.Antioxidationexit;
                stand.AntiOxidationExit.DbSource = $"AopPass.AntiOxidationExit({i})";

                stand.AntiPeelingState.L = aopPassL?.Antipeelingstate;
                stand.AntiPeelingState.E = aopPassE?.Antipeelingstate;
                stand.AntiPeelingState.M = aopPassM?.Antipeelingstate;
                stand.AntiPeelingState.DbSource = $"AopPass.AntiPeelingState({i})";

                stand.AntiPeeling.L = aopPassL?.Antipeeling;
                stand.AntiPeeling.E = aopPassE?.Antipeeling;
                stand.AntiPeeling.M = aopPassM?.Antipeeling;
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
                var iscpPassL = dataBlob.Iscpasses.Where(x => x.Source == "L" && x.Passno == i).FirstOrDefault();
                var iscpPassM = dataBlob.Iscpasses.Where(x => x.Source == "M" && x.Passno == i).FirstOrDefault();
                var iscpPassS = dataBlob.Iscpasses.Where(x => x.Source == "S" && x.Passno == i).FirstOrDefault();
                var iscpPassE = dataBlob.Iscpasses.Where(x => x.Source == "E" && x.Passno == i).FirstOrDefault();

                var rcpPassL = dataBlob.Rcppasses.Where(x => x.Source == "L" && x.Passno == i).FirstOrDefault();
                var rcpPassM = dataBlob.Rcppasses.Where(x => x.Source == "M" && x.Passno == i).FirstOrDefault();
                var rcpPassS = dataBlob.Rcppasses.Where(x => x.Source == "S" && x.Passno == i).FirstOrDefault();
                var rcpPassE = dataBlob.Rcppasses.Where(x => x.Source == "E" && x.Passno == i).FirstOrDefault();

                var stand = new WorkCoolingDto();

                stand.PassNo = i;

                stand.RcpPlanNo.L = rcpL?.Planno;
                stand.RcpPlanNo.E = rcpE?.Planno;
                stand.RcpPlanNo.DbSource = "Rcp.PlanNo";

                stand.IscpPlanNo.L = iscpL?.Planno;
                stand.IscpPlanNo.E = iscpE?.Planno;
                stand.IscpPlanNo.DbSource = "Iscp.PlanNo";

                stand.RollCoolState.L = rcpPassL?.Rollcoolstate;
                stand.RollCoolState.E = rcpPassE?.Rollcoolstate;
                stand.RollCoolState.M = rcpPassM?.Rollcoolstate;
                stand.RollCoolState.DbSource = $"RcpPass.RollCoolState({i})";

                stand.FlowWrLoadedInd0.L = rcpPassL?.FlowwrloadedInd0;
                stand.FlowWrLoadedInd0.E = rcpPassE?.FlowwrloadedInd0;
                stand.FlowWrLoadedInd0.M = rcpPassM?.FlowwrloadedInd0;
                stand.FlowWrLoadedInd0.DbSource = $"RcpPass.FlowWrLoadedInd0({i})";

                stand.FlowWrLoadedInd1.L = rcpPassL?.FlowwrloadedInd1;
                stand.FlowWrLoadedInd1.E = rcpPassE?.FlowwrloadedInd1;
                stand.FlowWrLoadedInd1.M = rcpPassM?.FlowwrloadedInd1;
                stand.FlowWrLoadedInd1.DbSource = $"RcpPass.FlowWrLoadedInd1({i})";

                stand.FlowWrLoadedInd2.L = rcpPassL?.FlowwrloadedInd2;
                stand.FlowWrLoadedInd2.E = rcpPassE?.FlowwrloadedInd2;
                stand.FlowWrLoadedInd2.M = rcpPassM?.FlowwrloadedInd2;
                stand.FlowWrLoadedInd2.DbSource = $"RcpPass.FlowWrLoadedInd2({i})";

                stand.StripSprayBefor.L = iscpPassL?.Stripspraybefor;
                stand.StripSprayBefor.E = iscpPassE?.Stripspraybefor;
                stand.StripSprayBefor.M = iscpPassM?.Stripspraybefor;
                stand.StripSprayBefor.DbSource = $"IscpPass.StripSprayBefor({i})";

                stand.IscVolumeInd0.L = iscpPassL?.IscvolumeInd0;
                stand.IscVolumeInd0.E = iscpPassE?.IscvolumeInd0;
                stand.IscVolumeInd0.M = iscpPassM?.IscvolumeInd0;
                stand.IscVolumeInd0.DbSource = $"IscPass.IscVolumeInd0({i})";

                stand.IscVolumeInd1.L = iscpPassL?.IscvolumeInd1;
                stand.IscVolumeInd1.E = iscpPassE?.IscvolumeInd1;
                stand.IscVolumeInd1.M = iscpPassM?.IscvolumeInd1;
                stand.IscVolumeInd1.DbSource = $"IscPass.IscVolumeInd1({i})";

                stand.IscVolumeInd2.L = iscpPassL?.IscvolumeInd2;
                stand.IscVolumeInd2.E = iscpPassE?.IscvolumeInd2;
                stand.IscVolumeInd2.M = iscpPassM?.IscvolumeInd2;
                stand.IscVolumeInd2.DbSource = $"IscPass.IscVolumeInd2({i})";

                stand.IscVolumeInd3.L = iscpPassL?.IscvolumeInd3;
                stand.IscVolumeInd3.E = iscpPassE?.IscvolumeInd3;
                stand.IscVolumeInd3.M = iscpPassM?.IscvolumeInd3;
                stand.IscVolumeInd3.DbSource = $"IscPass.IscVolumeInd3({i})";

                stand.FumesuppSprayBehind.L = iscpPassL?.Fumesuppspraybehind;
                stand.FumesuppSprayBehind.E = iscpPassE?.Fumesuppspraybehind;
                stand.FumesuppSprayBehind.M = iscpPassM?.Fumesuppspraybehind;
                stand.FumesuppSprayBehind.DbSource = $"IscPass.FumeSuppSprayBehind({i})";

                stand.LooperCooling.L = iscpPassL?.Loopercool;
                stand.LooperCooling.E = iscpPassE?.Loopercool;
                stand.LooperCooling.M = iscpPassM?.Loopercool;
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
                var tpPassL = dataBlob.Tppasses.Where(x => x.Source == "L" && x.Passno == i).FirstOrDefault();
                var tpPassM = dataBlob.Tppasses.Where(x => x.Source == "M" && x.Passno == i).FirstOrDefault();
                var tpPassS = dataBlob.Tppasses.Where(x => x.Source == "S" && x.Passno == i).FirstOrDefault();
                var tpPassE = dataBlob.Tppasses.Where(x => x.Source == "E" && x.Passno == i).FirstOrDefault();

                var stand = new TensionDto();

                stand.PassNo = i;

                stand.PlanNo.L = tpL?.Planno;
                stand.PlanNo.E = tpE?.Planno;
                stand.PlanNo.DbSource = "Tp.PlanNo";

                stand.SpeciffoTension.L = tpPassL?.Speciffotension;
                stand.SpeciffoTension.E = tpPassE?.Speciffotension;
                stand.SpeciffoTension.M = tpPassM?.Speciffotension;
                stand.SpeciffoTension.DbSource = $"TpPass.SpecifFoTension({i})";

                stand.LooperStripLen.L = tpPassL?.Looperstriplen;
                stand.LooperStripLen.E = tpPassE?.Looperstriplen;
                stand.LooperStripLen.M = tpPassM?.Looperstriplen;
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
                var rglpPassL = dataBlob.Rglppasses.Where(x => x.Source == "L" && x.Passno == i).FirstOrDefault();
                var rglpPassM = dataBlob.Rglppasses.Where(x => x.Source == "M" && x.Passno == i).FirstOrDefault();
                var rglpPassS = dataBlob.Rglppasses.Where(x => x.Source == "S" && x.Passno == i).FirstOrDefault();
                var rglpPassE = dataBlob.Rglppasses.Where(x => x.Source == "E" && x.Passno == i).FirstOrDefault();

                var stand = new LubricationDto();

                stand.PassNo = i;

                stand.PlanNo.L = rglpL?.Planno;
                stand.PlanNo.E = rglpE?.Planno;
                stand.PlanNo.DbSource = "Rglp.PlanNo";

                stand.RollGapLubState.L = rglpPassL?.Rollgaplubstate;
                stand.RollGapLubState.E = rglpPassE?.Rollgaplubstate;
                stand.RollGapLubState.M = rglpPassM?.Rollgaplubstate;
                stand.RollGapLubState.DbSource = $"RglpPass.RollGapLubState({i})";

                stand.RollGapLubRampTimeStart.L = rglpPassL?.Rollgaplubramptimestart;
                stand.RollGapLubRampTimeStart.E = rglpPassE?.Rollgaplubramptimestart;
                stand.RollGapLubRampTimeStart.M = rglpPassM?.Rollgaplubramptimestart;
                stand.RollGapLubRampTimeStart.DbSource = $"RglpPass.RollGapLubRampTimeStart({i})";

                stand.RollGapLubRampTimeStop.L = rglpPassL?.Rollgaplubramptimestop;
                stand.RollGapLubRampTimeStop.E = rglpPassE?.Rollgaplubramptimestop;
                stand.RollGapLubRampTimeStop.M = rglpPassM?.Rollgaplubramptimestop;
                stand.RollGapLubRampTimeStop.DbSource = $"RglpPass.RollGapLubRampTimeStop({i})";

                stand.RollGapLubSwitchLength.L = rglpPassL?.Rollgaplubswitchlength;
                stand.RollGapLubSwitchLength.E = rglpPassE?.Rollgaplubswitchlength;
                stand.RollGapLubSwitchLength.M = rglpPassM?.Rollgaplubswitchlength;
                stand.RollGapLubSwitchLength.DbSource = $"RglpPass.RollGapLubSwitchLength({i})";

                stand.RollGapLubOilFlowTop.L = rglpPassL?.Rollgapluboilflowtop;
                stand.RollGapLubOilFlowTop.E = rglpPassE?.Rollgapluboilflowtop;
                stand.RollGapLubOilFlowTop.M = rglpPassM?.Rollgapluboilflowtop;
                stand.RollGapLubOilFlowTop.DbSource = $"RglpPass.RollGapLubOilFlowTop({i})";

                stand.RollGapLubOilFlowBot.L = rglpPassL?.Rollgapluboilflowbot;
                stand.RollGapLubOilFlowBot.E = rglpPassE?.Rollgapluboilflowbot;
                stand.RollGapLubOilFlowBot.M = rglpPassM?.Rollgapluboilflowbot;
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
                var srpPassesL = dataBlob.Srppasses.Where(x => x.Source == "L" && x.Passno == i).FirstOrDefault();
                var srpPassesM = dataBlob.Srppasses.Where(x => x.Source == "M" && x.Passno == i).FirstOrDefault();
                var srpPassesS = dataBlob.Srppasses.Where(x => x.Source == "S" && x.Passno == i).FirstOrDefault();
                var srpPassesE = dataBlob.Srppasses.Where(x => x.Source == "E" && x.Passno == i).FirstOrDefault();

                var stand = new TaperShiftingDto();

                stand.PassNo = i;

                stand.PlanNo.L = srpL?.Planno;
                stand.PlanNo.E = srpE?.Planno;
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
                var srpPassesL = dataBlob.Srppasses.Where(x => x.Source == "L" && x.Passno == i).FirstOrDefault();
                var srpPassesM = dataBlob.Srppasses.Where(x => x.Source == "M" && x.Passno == i).FirstOrDefault();
                var srpPassesS = dataBlob.Srppasses.Where(x => x.Source == "S" && x.Passno == i).FirstOrDefault();
                var srpPassesE = dataBlob.Srppasses.Where(x => x.Source == "E" && x.Passno == i).FirstOrDefault();

                var stand = new TaperShiftingDto();

                stand.PassNo = i;

                stand.PlanNo.L = srpL?.Planno;
                stand.PlanNo.E = srpE?.Planno;
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

            result.HExit.L = edOrdEntL?.Hexit;
            result.HExit.E = edOrdEntE?.Hexit;
            result.HExit.M = edOrdEntM?.Hexit;
            result.HExit.S = dataBlob.Adord2Pc?.Hexit;
            result.HExit.DbSource = "EdOrdEnt.HExit";
            result.HExit.Status = dataBlob.StatEdordents?.Hexit;

            result.WidthExit.L = edOrdEntL?.Widthexit;
            result.WidthExit.E = edOrdEntE?.Widthexit;
            result.WidthExit.M = edOrdEntM?.Widthexit;
            result.WidthExit.S = dataBlob.Adord2Pc?.Wexit;
            result.WidthExit.DbSource = "EdOrdEnt.WidthExit";
            result.WidthExit.Status = dataBlob.StatEdordents?.Widthexit;

            result.TExit.L = edOrdEntL?.Texit;
            result.TExit.E = edOrdEntE?.Texit;
            result.TExit.M = edOrdEntM?.Texit;
            result.TExit.DbSource = "EdOrdEnt.TExit";
            result.TExit.Status = dataBlob.StatEdordents?.Texit;

            result.ExitCrownC25.L = edOrdEntL?.Exitcrownc25;
            result.ExitCrownC25.E = edOrdEntE?.Exitcrownc25;
            result.ExitCrownC25.M = edOrdEntM?.Exitcrownc25;
            result.ExitCrownC25.S = dataBlob.Adord2Pc?.Profile;
            result.ExitCrownC25.DbSource = "EdOrdEnt.ExitCrownC25";
            result.HExit.Status = dataBlob.StatEdordents?.Hexit;

            result.HExitCold.L = spOrd2PcL?.Hexitcold;
            result.HExitCold.E = spOrd2PcE?.Hexitcold;
            result.HExitCold.DbSource = "SpOrd2Pc.HExitCold";
            result.HExitCold.Status = dataBlob.StatSpord2pcs?.Hexitcold;

            result.WExitCold.L = spOrd2PcL?.Wexitcold;
            result.WExitCold.E = spOrd2PcE?.Wexitcold;
            result.WExitCold.DbSource = "SpOrd2Pc.WExitCold";
            result.WExitCold.Status = dataBlob.StatSpord2pcs?.Wexitcold;

            result.TValue.L = spOrd2PcL?.T;
            result.TValue.E = spOrd2PcE?.T;
            result.TValue.DbSource = "SpOrd2Pc.T";
            result.TValue.Status = dataBlob.StatSpord2pcs?.T;

            result.ProfExCalc.L = spOrd2PcL?.Profexcalc;
            result.ProfExCalc.E = spOrd2PcE?.Profexcalc;
            result.ProfExCalc.DbSource = "SpOrd2Pc.Profexcalc";
            result.ProfExCalc.Status = dataBlob.StatSpord2pcs?.Profexcalc;

            result.HEntryColdFm.L = spOrd2PcL?.Hentrycoldfm;
            result.HEntryColdFm.E = spOrd2PcE?.Hentrycoldfm;
            result.HEntryColdFm.DbSource = "SpOrd2Pc.HEntryColdFm";
            result.HEntryColdFm.Status = dataBlob.StatSpord2pcs?.Hentrycoldfm;

            result.T0MhHRM.L = spOrd2PcL?.T0mhhrm;
            result.T0MhHRM.E = spOrd2PcE?.T0mhhrm;
            result.T0MhHRM.DbSource = "SpOrd2Pc.T0MhHrm";
            result.T0MhHRM.Status = dataBlob.StatSpord2pcs?.T0mhhrm;

            result.RedDistHrmHfm.L = lpL?.Reddisthrmhfm;
            result.RedDistHrmHfm.E = lpE?.Reddisthrmhfm;
            result.RedDistHrmHfm.M = lpM?.Reddisthrmhfm;
            result.RedDistHrmHfm.DbSource = "Lp.RedDistHrmHfm";

            result.ProfileCorr.L = dirFmPfcParaPL?.Profilecorr;
            result.ProfileCorr.E = dirFmPfcParaPE?.Profilecorr;
            result.ProfileCorr.M = dirFmPfcParaPM?.Profilecorr;
            result.ProfileCorr.DbSource = "DirFmPfcParaPL.ProfileCorr";
            result.ProfileCorr.Status = dataBlob.StatDirFmPfcParaPs?.Profilecorr;

            result.TiHx.L = spOrd2PcL?.Tihhfmx;
            result.TiHx.E = spOrd2PcE?.Tihhfmx;
            result.TiHx.DbSource = "SpOrd2Pc.Tihhfmx";
            result.TiHx.Status = dataBlob.StatSpord2pcs?.Tihhfmx;

            result.LExit.L = spOrd2PcL?.Lexit;
            result.LExit.E = spOrd2PcE?.Lexit;
            result.LExit.DbSource = "SpOrd2Pc.LExit";
            result.LExit.Status = dataBlob.StatSpord2pcs?.Lexit;

            result.InherPfc.L = spOrd2PcL?.Inherpfc;
            result.InherPfc.E = spOrd2PcE?.Inherpfc;
            result.InherPfc.DbSource = "SpOrd2Pc.InherPfc";
            result.InherPfc.Status = dataBlob.StatSpord2pcs?.Inherpfc;

            result.InherPfcId.L = spOrd2PcL?.Inherpfcid;
            result.InherPfcId.E = spOrd2PcE?.Inherpfcid;
            result.InherPfcId.DbSource = "SpOrd2Pc.InherPfcId";
            result.InherPfcId.Status = dataBlob.StatSpord2pcs?.Inherpfcid;

            result.SrpPlanNo.L = srpL?.Planno;
            result.SrpPlanNo.E = srpE?.Planno;
            result.SrpPlanNo.M = srpM?.Planno;
            result.SrpPlanNo.DbSource = "DirFmPfcCycShiftPass.PlanNo";
            result.SrpPlanNo.Status = dataBlob.StatDirfmpfccycshiftps?.Planno;

            result.DirFmPfcParaPlanNo.L = dirFmPfcParaPL?.Planno;
            result.DirFmPfcParaPlanNo.E = dirFmPfcParaPE?.Planno;
            result.DirFmPfcParaPlanNo.M = dirFmPfcParaPM?.Planno;
            result.DirFmPfcParaPlanNo.DbSource = "DirFmPfcParaP.PlanNo";
            result.DirFmPfcParaPlanNo.Status = dataBlob.StatDirFmPfcParaPs?.Planno;

            result.ShiftingPlan.L = dirFmPfcCycShiftL?.Planno;
            result.ShiftingPlan.E = dirFmPfcCycShiftE?.Planno;
            result.ShiftingPlan.M = dirFmPfcCycShiftM?.Planno;
            result.ShiftingPlan.DbSource = "Dirfmpfccycshiftp.PlanNo";
            result.ShiftingPlan.Status = dataBlob.StatDirfmpfccycshiftps?.Planno;

            result.Temperature.L = IhpL?.Temperature;
            result.Temperature.E = IhpE?.Temperature;
            result.Temperature.M = IhpM?.Temperature;
            result.Temperature.DbSource = "Ihp.Temperature";

            result.SrpPlanNo.L = srpL?.Planno;
            result.SrpPlanNo.E = srpE?.Planno;
            result.SrpPlanNo.M = srpM?.Planno;
            result.SrpPlanNo.DbSource = "Srp.PlanNo";

            return result;
        }

        public static SetpointsHFMApxDto MapApxPassSchedule(this SetpointsHFMApxDto result, SetpointsHFMApxDataBlob dataBlob, short standCount, short standStartIdx)
        {
            for (short i = standStartIdx; i < standCount; i++)
            {
                var adordPc2StandS = dataBlob.Adord2PcStands.Where(x => x.Standid == i).SingleOrDefault();
                var srpPassesL = dataBlob.Srppasses.Where(x => x.Source == "L" && x.Passno == i).FirstOrDefault();
                var srpPassesM = dataBlob.Srppasses.Where(x => x.Source == "M" && x.Passno == i).FirstOrDefault();
                var srpPassesS = dataBlob.Srppasses.Where(x => x.Source == "S" && x.Passno == i).FirstOrDefault();
                var srpPassesE = dataBlob.Srppasses.Where(x => x.Source == "E" && x.Passno == i).FirstOrDefault();

                var wmppassesL = dataBlob.Wmppasses.Where(x => x.Source == "L" && x.Passno == i).FirstOrDefault();
                var wmppassesM = dataBlob.Wmppasses.Where(x => x.Source == "M" && x.Passno == i).FirstOrDefault();
                var wmppassesS = dataBlob.Wmppasses.Where(x => x.Source == "S" && x.Passno == i).FirstOrDefault();
                var wmppassesE = dataBlob.Wmppasses.Where(x => x.Source == "E" && x.Passno == i).FirstOrDefault();

                var spOrd2PcStandL = dataBlob.Spord2pcstands.Where(x => x.Source == "L" && x.Standid == i).FirstOrDefault();
                var spOrd2PcStandM = dataBlob.Spord2pcstands.Where(x => x.Source == "M" && x.Standid == i).FirstOrDefault();
                var spOrd2PcStandS = dataBlob.Spord2pcstands.Where(x => x.Source == "S" && x.Standid == i).FirstOrDefault();
                var spOrd2PcStandE = dataBlob.Spord2pcstands.Where(x => x.Source == "E" && x.Standid == i).FirstOrDefault();

                var lpPassL = dataBlob.Lppasses.Where(x => x.Source == "L" && x.Passno == i).FirstOrDefault();
                var lpPassM = dataBlob.Lppasses.Where(x => x.Source == "M" && x.Passno == i).FirstOrDefault();
                var lpPassS = dataBlob.Lppasses.Where(x => x.Source == "S" && x.Passno == i).FirstOrDefault();
                var lpPassE = dataBlob.Lppasses.Where(x => x.Source == "E" && x.Passno == i).FirstOrDefault();

                var dirFmPfcCycShiftPassL = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "L" && x.Passno == i).FirstOrDefault();
                var dirFmPfcCycShiftPassM = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "M" && x.Passno == i).FirstOrDefault();
                var dirFmPfcCycShiftPassS = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "S" && x.Passno == i).FirstOrDefault();
                var dirFmPfcCycShiftPassE = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "E" && x.Passno == i).FirstOrDefault();

                var dirFmPfcParaPassesL = dataBlob.DirFmPfcParaPasses.Where(x => x.Source == "L" && x.Passno == i).FirstOrDefault();
                var dirFmPfcParaPassesM = dataBlob.DirFmPfcParaPasses.Where(x => x.Source == "M" && x.Passno == i).FirstOrDefault();
                var dirFmPfcParaPassesS = dataBlob.DirFmPfcParaPasses.Where(x => x.Source == "S" && x.Passno == i).FirstOrDefault();
                var dirFmPfcParaPassesE = dataBlob.DirFmPfcParaPasses.Where(x => x.Source == "E" && x.Passno == i).FirstOrDefault();

                var spOrd2PcL = dataBlob.Spord2pcs.Where(x => x.Source == "L").FirstOrDefault();
                var spOrd2PcM = dataBlob.Spord2pcs.Where(x => x.Source == "M").FirstOrDefault();
                var spOrd2PcS = dataBlob.Spord2pcs.Where(x => x.Source == "S").FirstOrDefault();
                var spOrd2PcE = dataBlob.Spord2pcs.Where(x => x.Source == "E").FirstOrDefault();

                var statLpPass = dataBlob.StatLppasses.FirstOrDefault(x => x.Passno == i);
                var statDirFmPfcParaPasses = dataBlob.StatDirFmPfcParaPasses.FirstOrDefault(x => x.Passno == i);
                var statDirfmpfccycshiftppasses = dataBlob.StatDirfmpfccycshiftppasses.FirstOrDefault(x => x.Passno == i);
                var statSpordPc2Stand = dataBlob.StatSpord2pcstands.FirstOrDefault(x => x.Standid == i);

                var stand = new ApxPassScheduleDto();

                stand.PassNo = i;

                stand.BendingForce.L = lpPassL?.Bendingforce;
                stand.BendingForce.E = lpPassE?.Bendingforce;
                stand.BendingForce.M = lpPassM?.Bendingforce;
                stand.BendingForce.DbSource = $"LpPass.BendingForce({i})";
                stand.BendingForce.Status = statLpPass?.Bendingforce;

                stand.Fbul.L = dirFmPfcParaPassesL?.Fbul;
                stand.Fbul.E = dirFmPfcParaPassesE?.Fbul;
                stand.Fbul.M = dirFmPfcParaPassesM?.Fbul;
                stand.Fbul.DbSource = $"DirFmPfcParaPasses.FbUl({i})";
                stand.Fbul.Status = statDirFmPfcParaPasses?.Fbul;

                stand.Fbll.L = dirFmPfcParaPassesL?.Fbll;
                stand.Fbll.E = dirFmPfcParaPassesE?.Fbll;
                stand.Fbll.M = dirFmPfcParaPassesM?.Fbll;
                stand.Fbll.DbSource = $"DirFmPfcParaPasses.FbLl({i})";
                stand.Fbll.Status = statDirFmPfcParaPasses?.Fbll;

                stand.CvcShifting.L = lpPassL?.Cvcshifting;
                stand.CvcShifting.E = lpPassE?.Cvcshifting;
                stand.CvcShifting.M = lpPassM?.Cvcshifting;
                stand.CvcShifting.DbSource = $"LpPass.CvcShifting({i})";
                stand.CvcShifting.Status = statLpPass?.Cvcshifting;

                stand.Srul.L = dirFmPfcParaPassesL?.Srul;
                stand.Srul.E = dirFmPfcParaPassesE?.Srul;
                stand.Srul.E = dirFmPfcParaPassesM?.Srul;
                stand.Srul.DbSource = $"DirFmPfcParaPasses.SrUl({i})";
                stand.Srul.Status = statDirFmPfcParaPasses?.Srul;

                stand.Srll.L = dirFmPfcParaPassesL?.Srll;
                stand.Srll.E = dirFmPfcParaPassesE?.Srll;
                stand.Srll.E = dirFmPfcParaPassesM?.Srll;
                stand.Srll.DbSource = $"DirFmPfcParaPasses.SrLl({i})";
                stand.Srll.Status = statDirFmPfcParaPasses?.Srll;

                stand.CsMaxLimit.L = dirFmPfcCycShiftPassL?.Csmaxlimit;
                stand.CsMaxLimit.E = dirFmPfcCycShiftPassE?.Csmaxlimit;
                stand.CsMaxLimit.DbSource = $"DirFmPfcCycShiftPass.CSmaxLimit({i})";
                stand.CsMaxLimit.Status = statDirfmpfccycshiftppasses?.Csmaxlimit;

                stand.CsMinLimit.L = dirFmPfcCycShiftPassL?.Csminlimit;
                stand.CsMinLimit.E = dirFmPfcCycShiftPassE?.Csminlimit;
                stand.CsMinLimit.DbSource = $"DirFmPfcCycShiftPass.CSminLimit({i})";
                stand.CsMinLimit.Status = statDirfmpfccycshiftppasses?.Csminlimit;

                stand.Fb.L = spOrd2PcStandL?.Fb;
                stand.Fb.E = spOrd2PcStandE?.Fb;
                stand.Fb.S = adordPc2StandS?.Fb;
                stand.Fb.DbSource = $"SpOrd2PcStand.Fb({i})";
                stand.Fb.Status = statSpordPc2Stand?.Fb;

                stand.PositionWrs.L = spOrd2PcStandL?.Positionwrs;
                stand.PositionWrs.E = spOrd2PcStandE?.Positionwrs;
                stand.PositionWrs.S = adordPc2StandS?.Positionwrs;
                stand.PositionWrs.DbSource = $"SpOrd2PcStand.PositionWrs({i})";
                stand.PositionWrs.Status = statSpordPc2Stand?.Positionwrs;

                stand.WearCorr.L = wmppassesL?.Model;
                stand.WearCorr.E = wmppassesE?.Model;
                stand.WearCorr.DbSource = $"Wmppasses.Model({i})";

                stand.TaperShiftSpeedCorr.L = srpPassesL?.Model;
                stand.TaperShiftSpeedCorr.E = srpPassesE?.Model;
                stand.TaperShiftSpeedCorr.DbSource = $"SrpPasses.Model({i})";

                stand.ObservedFlat.L = dirFmPfcParaPassesL?.Observedflat;
                stand.ObservedFlat.E = dirFmPfcParaPassesE?.Observedflat;
                stand.ObservedFlat.M = dirFmPfcParaPassesM?.Observedflat;
                stand.ObservedFlat.DbSource = $"DirFmPfcParaPasses.ObservedFlat({i})";
                stand.ObservedFlat.Status = statDirFmPfcParaPasses?.Observedflat;

                stand.Fr.L = spOrd2PcStandL?.Fr;
                stand.Fr.E = spOrd2PcStandE?.Fr;
                stand.Fr.S = adordPc2StandS?.Fr;
                stand.Fr.DbSource = $"SpOrd2PcStand.Fr({i})";
                stand.Fr.Status = statSpordPc2Stand?.Fr;

                stand.WrCrownEff.L = spOrd2PcStandL?.Wrcrowneff;
                stand.WrCrownEff.E = spOrd2PcStandE?.Wrcrowneff;
                stand.WrCrownEff.DbSource = $"SpOrd2PcStand.WrCrownEff({i})";
                stand.WrCrownEff.Status = statSpordPc2Stand?.Wrcrowneff;

                stand.ThermCrown.L = spOrd2PcStandL?.Tcrown;
                stand.ThermCrown.E = spOrd2PcStandE?.Tcrown;
                stand.ThermCrown.DbSource = $"SpOrd2PcStand.Tcrown({i})";
                stand.ThermCrown.Status = statSpordPc2Stand?.Tcrown;

                stand.Troll.L = spOrd2PcStandL?.Troll;
                stand.Troll.E = spOrd2PcStandE?.Troll;
                stand.Troll.DbSource = $"SpOrd2PcStand.TRoll({i})";
                stand.Troll.Status = statSpordPc2Stand?.Troll;

                stand.RelProfile.L = spOrd2PcStandL?.Relprofile;
                stand.RelProfile.E = spOrd2PcStandE?.Relprofile;
                stand.RelProfile.S = adordPc2StandS?.Relprofile;
                stand.RelProfile.DbSource = $"SpOrd2PcStand.RelProfile({i})";
                stand.RelProfile.Status = statSpordPc2Stand?.Relprofile;

                stand.Profile.L = spOrd2PcStandL?.Profile;
                stand.Profile.E = spOrd2PcStandE?.Profile;
                stand.Profile.S = adordPc2StandS?.Absprofile;
                stand.Profile.DbSource = $"SpOrd2PcStand.Profile({i})";
                stand.Profile.Status = statSpordPc2Stand?.Profile;

                stand.Wear.L = spOrd2PcStandL?.Wcrown;
                stand.Wear.E = spOrd2PcStandE?.Wcrown;
                stand.Wear.DbSource = $"SpOrd2PcStand.Wcrown({i})";
                stand.Wear.Status = statSpordPc2Stand?.Wcrown;

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

                var dirFmPfcCycShiftPassL = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "L" && x.Passno == i).FirstOrDefault();
                var dirFmPfcCycShiftPassM = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "M" && x.Passno == i).FirstOrDefault();
                var dirFmPfcCycShiftPassS = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "S" && x.Passno == i).FirstOrDefault();
                var dirFmPfcCycShiftPassE = dataBlob.Dirfmpfccycshiftppasses.Where(x => x.Source == "E" && x.Passno == i).FirstOrDefault();

                var statDirFmPfcCycShiftPass = dataBlob.StatDirfmpfccycshiftppasses.Where(x => x.Passno == i).SingleOrDefault();

                var stand = new ApxShiftingDto();

                stand.PassNo = i;

                stand.PlanNo.L = dirFmPfcCycShiftL?.Planno;
                stand.PlanNo.E = dirFmPfcCycShiftE?.Planno;
                stand.PlanNo.DbSource = "DirFmPfcCycShift.PlanNo";
                stand.PlanNo.Status = dataBlob.StatDirfmpfccycshiftps?.Planno;

                stand.CsMaxLimit.L = dirFmPfcCycShiftPassL?.Csmaxlimit;
                stand.CsMaxLimit.E = dirFmPfcCycShiftPassE?.Csmaxlimit;
                stand.CsMaxLimit.M = dirFmPfcCycShiftPassM?.Csmaxlimit;
                stand.CsMaxLimit.DbSource = $"DirFmPfcCycShiftPass.CSmaxLimit({i})";
                stand.CsMaxLimit.Status = statDirFmPfcCycShiftPass?.Csmaxlimit;

                stand.CsMinLimit.L = dirFmPfcCycShiftPassL?.Csminlimit;
                stand.CsMinLimit.E = dirFmPfcCycShiftPassE?.Csminlimit;
                stand.CsMinLimit.M = dirFmPfcCycShiftPassM?.Csminlimit;
                stand.CsMinLimit.DbSource = $"DirFmPfcCycShiftPass.CSminLimit({i})";
                stand.CsMinLimit.Status = statDirFmPfcCycShiftPass?.Csminlimit;

                stand.CsStartPos.L = dirFmPfcCycShiftPassL?.Csstartpos;
                stand.CsStartPos.E = dirFmPfcCycShiftPassE?.Csstartpos;
                stand.CsStartPos.M = dirFmPfcCycShiftPassM?.Csstartpos;
                stand.CsStartPos.DbSource = $"DirFmPfcCycShiftPass.CSstartPos({i})";
                stand.CsStartPos.Status = statDirFmPfcCycShiftPass?.Csstartpos;

                stand.CsShiftDir.L = dirFmPfcCycShiftPassL?.Csshiftdir;
                stand.CsShiftDir.E = dirFmPfcCycShiftPassE?.Csshiftdir;
                stand.CsShiftDir.M = dirFmPfcCycShiftPassM?.Csshiftdir;
                stand.CsShiftDir.DbSource = $"DirFmPfcCycShiftPass.CSshiftDir({i})";
                stand.CsShiftDir.Status = statDirFmPfcCycShiftPass?.Csshiftdir;

                stand.CsShiftStep1.L = dirFmPfcCycShiftPassL?.Csshiftstep1;
                stand.CsShiftStep1.E = dirFmPfcCycShiftPassE?.Csshiftstep1;
                stand.CsShiftStep1.M = dirFmPfcCycShiftPassM?.Csshiftstep1;
                stand.CsShiftStep1.DbSource = $"DirFmPfcCycShiftPass.CSshiftStep1({i})";
                stand.CsShiftStep1.Status = statDirFmPfcCycShiftPass?.Csshiftstep1;

                stand.CsShiftStep2.L = dirFmPfcCycShiftPassL?.Csshiftstep2;
                stand.CsShiftStep2.E = dirFmPfcCycShiftPassE?.Csshiftstep2;
                stand.CsShiftStep2.M = dirFmPfcCycShiftPassM?.Csshiftstep2;
                stand.CsShiftStep2.DbSource = $"DirFmPfcCycShiftPass.CSshiftStep2({i})";
                stand.CsShiftStep2.Status = statDirFmPfcCycShiftPass?.Csshiftstep2;

                stand.CsShiftStep3.L = dirFmPfcCycShiftPassL?.Csshiftstep3;
                stand.CsShiftStep3.E = dirFmPfcCycShiftPassE?.Csshiftstep3;
                stand.CsShiftStep3.M = dirFmPfcCycShiftPassM?.Csshiftstep3;
                stand.CsShiftStep3.DbSource = $"DirFmPfcCycShiftPass.CSshiftStep3({i})";
                stand.CsShiftStep3.Status = statDirFmPfcCycShiftPass?.Csshiftstep3;

                stand.Description.L = dirFmPfcCycShiftPassL?.Description;
                stand.Description.E = dirFmPfcCycShiftPassE?.Description;
                stand.Description.M = dirFmPfcCycShiftPassM?.Description;
                stand.Description.DbSource = $"DirFmPfcCycShiftPass.Description({i})";
                stand.Description.Status = statDirFmPfcCycShiftPass?.Description;

                stand.Manint.L = dirFmPfcCycShiftPassL?.Manint;
                stand.Manint.E = dirFmPfcCycShiftPassE?.Manint;
                stand.Manint.M = dirFmPfcCycShiftPassM?.Manint;
                stand.Manint.DbSource = $"DirFmPfcCycShiftPass.Manint({i})";
                stand.Manint.Status = statDirFmPfcCycShiftPass?.Manint;

                stand.Toextid.L = dirFmPfcCycShiftPassL?.Toextid;
                stand.Toextid.E = dirFmPfcCycShiftPassE?.Toextid;
                stand.Toextid.M = dirFmPfcCycShiftPassM?.Toextid;
                stand.Toextid.DbSource = $"DirFmPfcCycShiftPass.Toextid({i})";

                stand.CsmaxlimitparabolicInd0.L = dirFmPfcCycShiftPassL?.CsmaxlimitparabolicInd0;
                stand.CsmaxlimitparabolicInd0.E = dirFmPfcCycShiftPassE?.CsmaxlimitparabolicInd0;
                stand.CsmaxlimitparabolicInd0.M = dirFmPfcCycShiftPassM?.CsmaxlimitparabolicInd0;
                stand.CsmaxlimitparabolicInd0.DbSource = $"DirFmPfcCycShiftPass.CsmaxlimitparabolicInd0({i})";
                stand.CsmaxlimitparabolicInd0.Status = statDirFmPfcCycShiftPass?.CsmaxlimitparabolicInd0;

                stand.CsmaxlimitparabolicInd1.L = dirFmPfcCycShiftPassL?.CsmaxlimitparabolicInd1;
                stand.CsmaxlimitparabolicInd1.E = dirFmPfcCycShiftPassE?.CsmaxlimitparabolicInd1;
                stand.CsmaxlimitparabolicInd1.M = dirFmPfcCycShiftPassM?.CsmaxlimitparabolicInd1;
                stand.CsmaxlimitparabolicInd1.DbSource = $"DirFmPfcCycShiftPass.CsmaxlimitparabolicInd1({i})";
                stand.CsmaxlimitparabolicInd1.Status = statDirFmPfcCycShiftPass?.CsmaxlimitparabolicInd1;

                stand.CsmaxlimitparabolicInd2.L = dirFmPfcCycShiftPassL?.CsmaxlimitparabolicInd2;
                stand.CsmaxlimitparabolicInd2.E = dirFmPfcCycShiftPassE?.CsmaxlimitparabolicInd2;
                stand.CsmaxlimitparabolicInd2.M = dirFmPfcCycShiftPassM?.CsmaxlimitparabolicInd2;
                stand.CsmaxlimitparabolicInd2.DbSource = $"DirFmPfcCycShiftPass.CsmaxlimitparabolicInd2({i})";
                stand.CsmaxlimitparabolicInd2.Status = statDirFmPfcCycShiftPass?.CsmaxlimitparabolicInd2;

                stand.CsminlimitparabolicInd0.L = dirFmPfcCycShiftPassL?.CsminlimitparabolicInd0;
                stand.CsminlimitparabolicInd0.E = dirFmPfcCycShiftPassE?.CsminlimitparabolicInd0;
                stand.CsminlimitparabolicInd0.M = dirFmPfcCycShiftPassM?.CsminlimitparabolicInd0;
                stand.CsminlimitparabolicInd0.DbSource = $"DirFmPfcCycShiftPass.CsminlimitparabolicInd0({i})";
                stand.CsminlimitparabolicInd0.Status = statDirFmPfcCycShiftPass?.CsminlimitparabolicInd0;

                stand.CsminlimitparabolicInd1.L = dirFmPfcCycShiftPassL?.CsminlimitparabolicInd1;
                stand.CsminlimitparabolicInd1.E = dirFmPfcCycShiftPassE?.CsminlimitparabolicInd1;
                stand.CsminlimitparabolicInd1.M = dirFmPfcCycShiftPassM?.CsminlimitparabolicInd1;
                stand.CsminlimitparabolicInd1.DbSource = $"DirFmPfcCycShiftPass.CsminlimitparabolicInd1({i})";
                stand.CsminlimitparabolicInd1.Status = statDirFmPfcCycShiftPass?.CsminlimitparabolicInd1;

                stand.CsminlimitparabolicInd2.L = dirFmPfcCycShiftPassL?.CsminlimitparabolicInd2;
                stand.CsminlimitparabolicInd2.E = dirFmPfcCycShiftPassE?.CsminlimitparabolicInd2;
                stand.CsminlimitparabolicInd2.M = dirFmPfcCycShiftPassM?.CsminlimitparabolicInd2;
                stand.CsminlimitparabolicInd2.DbSource = $"DirFmPfcCycShiftPass.CsminlimitparabolicInd2({i})";
                stand.CsminlimitparabolicInd2.Status = statDirFmPfcCycShiftPass?.CsminlimitparabolicInd2;

                stand.CsstepparabolicInd0.L = dirFmPfcCycShiftPassL?.CsstepparabolicInd0;
                stand.CsstepparabolicInd0.E = dirFmPfcCycShiftPassE?.CsstepparabolicInd0;
                stand.CsstepparabolicInd0.M = dirFmPfcCycShiftPassM?.CsstepparabolicInd0;
                stand.CsstepparabolicInd0.DbSource = $"DirFmPfcCycShiftPass.CsstepparabolicInd0({i})";
                stand.CsstepparabolicInd0.Status = statDirFmPfcCycShiftPass?.CsstepparabolicInd0;

                stand.CsstepparabolicInd1.L = dirFmPfcCycShiftPassL?.CsstepparabolicInd1;
                stand.CsstepparabolicInd1.E = dirFmPfcCycShiftPassE?.CsstepparabolicInd1;
                stand.CsstepparabolicInd1.M = dirFmPfcCycShiftPassM?.CsstepparabolicInd1;
                stand.CsstepparabolicInd1.DbSource = $"DirFmPfcCycShiftPass.CsstepparabolicInd1({i})";
                stand.CsstepparabolicInd1.Status = statDirFmPfcCycShiftPass?.CsstepparabolicInd1;

                stand.CsstepparabolicInd2.L = dirFmPfcCycShiftPassL?.CsstepparabolicInd2;
                stand.CsstepparabolicInd2.E = dirFmPfcCycShiftPassE?.CsstepparabolicInd2;
                stand.CsstepparabolicInd2.M = dirFmPfcCycShiftPassM?.CsstepparabolicInd2;
                stand.CsstepparabolicInd2.DbSource = $"DirFmPfcCycShiftPass.CsstepparabolicInd2({i})";
                stand.CsstepparabolicInd2.Status = statDirFmPfcCycShiftPass?.CsstepparabolicInd2;

                stand.CsstepsmartcrownInd0.L = dirFmPfcCycShiftPassL?.CsstepsmartcrownInd0;
                stand.CsstepsmartcrownInd0.E = dirFmPfcCycShiftPassE?.CsstepsmartcrownInd0;
                stand.CsstepsmartcrownInd0.M = dirFmPfcCycShiftPassM?.CsstepsmartcrownInd0;
                stand.CsstepsmartcrownInd0.DbSource = $"DirFmPfcCycShiftPass.CsstepsmartcrownInd0({i})";
                stand.CsstepsmartcrownInd0.Status = statDirFmPfcCycShiftPass?.CsstepsmartcrownInd0;

                stand.CsstepsmartcrownInd1.L = dirFmPfcCycShiftPassL?.CsstepsmartcrownInd1;
                stand.CsstepsmartcrownInd1.E = dirFmPfcCycShiftPassE?.CsstepsmartcrownInd1;
                stand.CsstepsmartcrownInd1.M = dirFmPfcCycShiftPassM?.CsstepsmartcrownInd1;
                stand.CsstepsmartcrownInd1.DbSource = $"DirFmPfcCycShiftPass.CsstepsmartcrownInd1({i})";
                stand.CsstepsmartcrownInd1.Status = statDirFmPfcCycShiftPass?.CsstepsmartcrownInd2;

                stand.CsstepsmartcrownInd2.L = dirFmPfcCycShiftPassL?.CsstepsmartcrownInd2;
                stand.CsstepsmartcrownInd2.E = dirFmPfcCycShiftPassE?.CsstepsmartcrownInd2;
                stand.CsstepsmartcrownInd2.M = dirFmPfcCycShiftPassM?.CsstepsmartcrownInd2;
                stand.CsstepsmartcrownInd2.DbSource = $"DirFmPfcCycShiftPass.CsstepsmartcrownInd0({i})";
                stand.CsstepsmartcrownInd2.Status = statDirFmPfcCycShiftPass?.CsstepsmartcrownInd2;

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

                var dirFmPfcParaPassesL = dataBlob.DirFmPfcParaPasses.Where(x => x.Source == "L" && x.Passno == i).FirstOrDefault();
                var dirFmPfcParaPassesM = dataBlob.DirFmPfcParaPasses.Where(x => x.Source == "M" && x.Passno == i).FirstOrDefault();
                var dirFmPfcParaPassesS = dataBlob.DirFmPfcParaPasses.Where(x => x.Source == "S" && x.Passno == i).FirstOrDefault();
                var dirFmPfcParaPassesE = dataBlob.DirFmPfcParaPasses.Where(x => x.Source == "E" && x.Passno == i).FirstOrDefault();
                var statDirFmPfcParapPass = dataBlob.StatDirFmPfcParaPasses.Where(x => x.Passno == i).SingleOrDefault();

                var stand = new ApxFlatnessDto();

                stand.PassNo = i;

                stand.PlanNo.L = dirFmPfcParaL?.Planno;
                stand.PlanNo.E = dirFmPfcParaE?.Planno;
                stand.PlanNo.DbSource = "DirFmPfcParaP.PlanNo";
                stand.PlanNo.Status = dataBlob.StatDirFmPfcParaPs?.Planno;

                stand.Fbul.L = dirFmPfcParaPassesL?.Fbul;
                stand.Fbul.E = dirFmPfcParaPassesE?.Fbul;
                stand.Fbul.M = dirFmPfcParaPassesM?.Fbul;
                stand.Fbul.DbSource = $"DirFmPfcParaPasses.FbUl({i})";
                stand.Fbul.Status = statDirFmPfcParapPass?.Fbul;

                stand.Fbll.L = dirFmPfcParaPassesL?.Fbll;
                stand.Fbll.E = dirFmPfcParaPassesE?.Fbll;
                stand.Fbll.M = dirFmPfcParaPassesM?.Fbll;
                stand.Fbll.DbSource = $"DirFmPfcParaPasses.FbLl({i})";
                stand.Fbll.Status = statDirFmPfcParapPass?.Fbll;

                stand.Srul.L = dirFmPfcParaPassesL?.Srul;
                stand.Srul.E = dirFmPfcParaPassesE?.Srul;
                stand.Srul.E = dirFmPfcParaPassesM?.Srul;
                stand.Srul.DbSource = $"DirFmPfcParaPasses.SrUl({i})";
                stand.Srul.Status = statDirFmPfcParapPass?.Srul;

                stand.Srll.L = dirFmPfcParaPassesL?.Srll;
                stand.Srll.E = dirFmPfcParaPassesE?.Srll;
                stand.Srll.E = dirFmPfcParaPassesM?.Srll;
                stand.Srll.DbSource = $"DirFmPfcParaPasses.SrLl({i})";
                stand.Srll.Status = statDirFmPfcParapPass?.Srll;

                stand.Facdfbdfr.L = dirFmPfcParaPassesL?.Facdfbdfr;
                stand.Facdfbdfr.E = dirFmPfcParaPassesE?.Facdfbdfr;
                stand.Facdfbdfr.E = dirFmPfcParaPassesM?.Facdfbdfr;
                stand.Facdfbdfr.DbSource = $"DirFmPfcParaPasses.FacDfbDfr({i})";
                stand.Facdfbdfr.Status = statDirFmPfcParapPass?.Facdfbdfr;

                stand.Facdfbdiu.L = dirFmPfcParaPassesL?.Facdfbdiu;
                stand.Facdfbdiu.E = dirFmPfcParaPassesE?.Facdfbdiu;
                stand.Facdfbdiu.E = dirFmPfcParaPassesM?.Facdfbdiu;
                stand.Facdfbdiu.DbSource = $"DirFmPfcParaPasses.FacDfbDiu({i})";
                stand.Facdfbdiu.Status = statDirFmPfcParapPass?.Facdfbdiu;

                result.FlatnessDtos.Add(stand);
            }

            return result;
        }

    }
}