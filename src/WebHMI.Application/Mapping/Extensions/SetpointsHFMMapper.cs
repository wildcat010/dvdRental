using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using WebHMI.DataBlobs;
using WebHMI.Dtos.SetpointsHRM;
using WebHMI.Dtos.SetpointsRM;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions
{
    public static class SetpointsHFMMapper
    {
        public static SetpointsHFMDto MapData(this SetpointsHFMDto result, SetpointsHFMDataBlob dataBlob)
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

            var dphfmL = dataBlob.Dpfms.Where(x => x.Source == "L").FirstOrDefault();
            var dphfmM = dataBlob.Dpfms.Where(x => x.Source == "M").FirstOrDefault();
            var dphfmS = dataBlob.Dpfms.Where(x => x.Source == "S").FirstOrDefault();
            var dphfmE = dataBlob.Dpfms.Where(x => x.Source == "E").FirstOrDefault();

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

            result.ApsKey.L = edLogEntL?.ApsKey;
            result.ApsKey.E = edLogEntE?.ApsKey;
            result.ApsKey.DbSource = "EdLogEnt.ApsKey";

            result.AlloyCode.L = edLogEntL?.AlloyCode;
            result.AlloyCode.E = edLogEntE?.AlloyCode;
            result.AlloyCode.DbSource = "EdLogEnt.AlloyCode";

            result.HEntryColdFm.L = spOrd2PcL?.HEntryColdFm;
            result.HEntryColdFm.E = spOrd2PcE?.HEntryColdFm;
            result.HEntryColdFm.DbSource = "SpOrd2Pc.HEntryColdFm";

            result.TValue.L = spOrd2PcL?.T;
            result.TValue.E = spOrd2PcE?.T;
            result.TValue.DbSource = "SpOrd2Pc.T";

            result.OkAll.L = edPhyEntL?.OkAll;
            result.OkAll.E = edPhyEntE?.OkAll;
            result.OkAll.DbSource = "EdPhyEnt.OkAll";

            result.SetpointsHFMOk.L = spOrd2PcL?.SetpointsFmOk;
            result.SetpointsHFMOk.E = spOrd2PcE?.SetpointsFmOk;
            result.SetpointsHFMOk.DbSource = "SpOrd2Pc.SetpointsFmOk";

            result.HExit.L = edOrdEntL?.HExit;
            result.HExit.E = edOrdEntE?.HExit;
            result.HExit.M = edOrdEntM?.HExit;
            result.HExit.DbSource = "EdOrdEnt.HExit";

            result.WidthExit.L = edOrdEntL?.WidthExit;
            result.WidthExit.E = edOrdEntE?.WidthExit;
            result.WidthExit.M = edOrdEntM?.WidthExit;
            result.WidthExit.DbSource = "EdOrdEnt.WidthExit";

            result.TExit.L = edOrdEntL?.TExit;
            result.TExit.E = edOrdEntE?.TExit;
            result.TExit.M = edOrdEntM?.TExit;
            result.TExit.DbSource = "EdOrdEnt.TExit";

            result.ExitCrownc25.L = edOrdEntL?.ExitCrownC25;
            result.ExitCrownc25.E = edOrdEntE?.ExitCrownC25;
            result.ExitCrownc25.M = edOrdEntM?.ExitCrownC25;
            result.ExitCrownc25.DbSource = "EdOrdEnt.ExitCrownC25";

            result.T0MhHRM.L = spOrd2PcL?.T0MhHrm;
            result.T0MhHRM.E = spOrd2PcE?.T0MhHrm;
            result.T0MhHRM.DbSource = "SpOrd2Pc.T0MhHrm";

            //result.RedDistHrmFm.L = lpL?.SpeedBeforeRedStand1;
            //result.RedDistHrmFm.E = lpE?.SpeedBeforeRedStand1;
            //result.RedDistHrmFm.M = lpM?.SpeedBeforeRedStand1;
            //result.RedDistHrmFm.DbSource = "Lp.SpeedBeforeRedStand1";

            result.ProfileCorr.L = dirFmPfcParaPL?.ProfileCorr;
            result.ProfileCorr.E = dirFmPfcParaPE?.ProfileCorr;
            result.ProfileCorr.M = dirFmPfcParaPM?.ProfileCorr;
            result.ProfileCorr.DbSource = "DirFmPfcParaPL.ProfileCorr";

            result.TiHx.L = spOrd2PcL?.TIhx;
            result.TiHx.E = spOrd2PcE?.TIhx;
            result.TiHx.M = spOrd2PcM?.TIhx;
            result.TiHx.DbSource = "SpOrd2Pc.TIhx";

            result.HExitCold.L = spOrd2PcL?.HExitCold;
            result.HExitCold.E = spOrd2PcE?.HExitCold;
            result.HExitCold.M = spOrd2PcM?.HExitCold;
            result.HExitCold.DbSource = "SpOrd2Pc.HExitCold";

            result.WExitCold.L = spOrd2PcL?.HExitCold;
            result.WExitCold.E = spOrd2PcE?.HExitCold;
            result.WExitCold.M = spOrd2PcM?.HExitCold;
            result.WExitCold.DbSource = "SpOrd2Pc.HExitCold";

            result.ProfExCalc.L = spOrd2PcL?.Profexcalc;
            result.ProfExCalc.E = spOrd2PcE?.Profexcalc;
            result.ProfExCalc.M = spOrd2PcM?.Profexcalc;
            result.ProfExCalc.DbSource = "SpOrd2Pc.Profexcalc";

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

            result.Temperature.L = IhpL?.Temperature;
            result.Temperature.E = IhpE?.Temperature;
            result.Temperature.M = IhpM?.Temperature;
            result.Temperature.DbSource = "Ihp.Temperature";

            return result;
        }
        
        public static SetpointsHFMDto MapStandData(this SetpointsHFMDto result, SetpointsHFMDataBlob dataBlob, short standCount)
        {
            var spOrd2PcL = dataBlob.Spord2pcs.Where(x => x.Source == "L").FirstOrDefault();
            var spOrd2PcM = dataBlob.Spord2pcs.Where(x => x.Source == "M").FirstOrDefault();
            var spOrd2PcS = dataBlob.Spord2pcs.Where(x => x.Source == "S").FirstOrDefault();
            var spOrd2PcE = dataBlob.Spord2pcs.Where(x => x.Source == "E").FirstOrDefault();

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

                var stand = new SingleHFMStandDataDto();

                stand.PassNo = i;

                stand.LoadingType.L = lpPassL?.LoadingType;
                stand.LoadingType.E = lpPassE?.LoadingType;
                stand.LoadingType.M = lpPassM?.LoadingType;
                stand.LoadingType.DbSource = $"LpPass.LoadingType({i})";

                stand.LoadingValue.L = lpPassL?.LoadingValue;
                stand.LoadingValue.E = lpPassE?.LoadingValue;
                stand.LoadingValue.M = lpPassM?.LoadingValue;
                stand.LoadingValue.DbSource = $"LpPass.LoadingValue({i})";

                stand.LoadingValueCorrection.L = lpPassL?.LoadingValueCorrection;
                stand.LoadingValueCorrection.E = lpPassE?.LoadingValueCorrection;
                stand.LoadingValueCorrection.M = lpPassM?.LoadingValueCorrection;
                stand.LoadingValueCorrection.DbSource = $"LpPass.LoadingValueCorrection({i})";

                stand.BendingForce.L = lpPassL?.BendingForce;
                stand.BendingForce.E = lpPassE?.BendingForce;
                stand.BendingForce.M = lpPassM?.BendingForce;
                stand.BendingForce.DbSource = $"LpPass.BendingForce({i})";

                stand.SpecifFoTension.L = tpPassL?.SpecifFoTension;
                stand.SpecifFoTension.E = tpPassE?.SpecifFoTension;
                stand.SpecifFoTension.M = tpPassM?.SpecifFoTension;
                stand.SpecifFoTension.DbSource = $"TpPass.SpecifFoTension({i})";

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

                // ADD ADORD2PC FR MS RPOWER VCIRCUM FB POSITIONWRS ABSPROFILE

                stand.Fr.L = spOrd2PcStandL?.Fr;
                stand.Fr.E = spOrd2PcStandE?.Fr;
                stand.Fr.DbSource = $"SpOrd2PcStand.Fr({i})";

                stand.Ms.L = spOrd2PcStandL?.Ms;
                stand.Ms.E = spOrd2PcStandE?.Ms;
                stand.Ms.DbSource = $"SpOrd2PcStand.Ms({i})";

                stand.RPower.L = spOrd2PcStandL?.RPower;
                stand.RPower.E = spOrd2PcStandE?.RPower;
                stand.RPower.DbSource = $"SpOrd2PcStand.RPower({i})";

                stand.VCircum.L = spOrd2PcStandL?.VCircum;
                stand.VCircum.E = spOrd2PcStandE?.VCircum;
                stand.VCircum.DbSource = $"SpOrd2PcStand.VCircum({i})";

                stand.Fb.L = spOrd2PcStandL?.Fb;
                stand.Fb.E = spOrd2PcStandE?.Fb;
                stand.Fb.DbSource = $"SpOrd2PcStand.Fb({i})";

                stand.PositionWRS.L = spOrd2PcStandL?.PositionWrs;
                stand.PositionWRS.E = spOrd2PcStandE?.PositionWrs;
                stand.PositionWRS.DbSource = $"SpOrd2PcStand.PositionWrs({i})";

                stand.Profile.L = spOrd2PcStandL?.Profile;
                stand.Profile.E = spOrd2PcStandE?.Profile;
                stand.Profile.DbSource = $"SpOrd2PcStand.Profile({i})";

                stand.CalcFlat.L = spOrd2PcStandL?.CalcFlat;
                stand.CalcFlat.E = spOrd2PcStandE?.CalcFlat;
                stand.CalcFlat.DbSource = $"SpOrd2PcStand.CalcFlat({i})";

                stand.H0.L = spOrd2PcStandL?.H0;
                stand.H0.E = spOrd2PcStandE?.H0;
                stand.H0.DbSource = $"SpOrd2PcStand.H0({i})";

                stand.T0.L = spOrd2PcStandL?.T0;
                stand.T0.E = spOrd2PcStandE?.T0;
                stand.T0.DbSource = $"SpOrd2PcStand.T0({i})";

                stand.Red.L = spOrd2PcStandL?.Red;
                stand.Red.E = spOrd2PcStandE?.Red;
                stand.Red.DbSource = $"SpOrd2PcStand.Red({i})";

                stand.Sd.L = spOrd2PcStandL?.Sd;
                stand.Sd.E = spOrd2PcStandE?.Sd;
                stand.Sd.DbSource = $"SpOrd2PcStand.Sd({i})";

                stand.Model.L = srpPassesL?.Model;
                stand.Model.E = srpPassesE?.Model;
                stand.Model.DbSource = $"SrpPasses.Model({i})";

                stand.SpltlFaultFm.L = spOrd2PcL?.SptlFaultFm;
                stand.SpltlFaultFm.E = spOrd2PcE?.SptlFaultFm;
                stand.SpltlFaultFm.DbSource = $"SpOrd2Pc.SptlFaultFm({i})";

                result.StandDataDtos.Add(stand);
            }

            return result;
        }
    }
}