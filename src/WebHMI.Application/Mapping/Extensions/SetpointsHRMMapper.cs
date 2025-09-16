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

        public static HRMMaterialOverviewDto MapOverview(this HRMMaterialOverviewDto result,List<SpOrd2Pc> spOrd2Pcs, List<EdOrdEnt> edOrdEnts, List<EdPhyEnt> edPhyEnts)
        {
            var spOrd2PcL = spOrd2Pcs.Where(x => x.Source == "L").FirstOrDefault();
            var spOrd2PcM = spOrd2Pcs.Where(x => x.Source == "M").FirstOrDefault();
            var spOrd2PcS = spOrd2Pcs.Where(x => x.Source == "S").FirstOrDefault();
            var spOrd2PcE = spOrd2Pcs.Where(x => x.Source == "E").FirstOrDefault();

            var edOrdEntL = edOrdEnts.Where(x => x.Source == "L").FirstOrDefault();
            var edOrdEntM = edOrdEnts.Where(x => x.Source == "M").FirstOrDefault();
            var edOrdEntS = edOrdEnts.Where(x => x.Source == "S").FirstOrDefault();
            var edOrdEntE = edOrdEnts.Where(x => x.Source == "E").FirstOrDefault();

            var edPhyEntL = edPhyEnts.Where(x => x.Source == "L").FirstOrDefault();
            var edPhyEntM = edPhyEnts.Where(x => x.Source == "M").FirstOrDefault();
            var edPhyEntS = edPhyEnts.Where(x => x.Source == "S").FirstOrDefault();
            var edPhyEntE = edPhyEnts.Where(x => x.Source == "E").FirstOrDefault();

            result.WEntry.L = edPhyEntL?.WidthExitCustomer;
            result.WEntry.E = edPhyEntE?.WidthExitCustomer;
            result.WEntry.M = edPhyEntM?.WidthExitCustomer;
            result.WEntry.S = edPhyEntS?.WidthExitCustomer;
            result.WEntry.DbSource = "EdPhyEnt.WidthExitCustomer";

            result.HEntry.L = edPhyEntL?.HEntry;
            result.HEntry.E = edPhyEntE?.HEntry;
            result.HEntry.M = edPhyEntM?.HEntry;
            result.HEntry.S = edPhyEntS?.HEntry;
            result.HEntry.DbSource = "EdPhyEnt.HEntry";

            result.TEntry.L = edPhyEntL?.TEntry;
            result.TEntry.E = edPhyEntE?.TEntry;
            result.TEntry.M = edPhyEntM?.TEntry;
            result.TEntry.S = edPhyEntS?.TEntry;
            result.TEntry.DbSource = "EdPhyEnt.TEntry";

            result.LEntry.L = edPhyEntL?.LEntryFm;
            result.LEntry.E = edPhyEntE?.LEntryFm;
            result.LEntry.M = edPhyEntM?.LEntryFm;
            result.LEntry.S = edPhyEntS?.LEntryFm;
            result.LEntry.DbSource = "EdPhyEnt.LEntryFm";

            result.WExitRM.L = edOrdEntL?.HIntermediate;
            result.WExitRM.E = edOrdEntE?.HIntermediate;
            result.WExitRM.M = edOrdEntM?.HIntermediate;
            result.WExitRM.S = edOrdEntS?.HIntermediate;
            result.WExitRM.DbSource = "EdOrdEnt.HIntermediate";

            result.WExitRMOrd.E = spOrd2PcE?.WEntryColdFm;
            result.WExitRMOrd.DbSource = "SpOrd2Pc.WEntryColdFm";

            result.HExitRM.E = spOrd2PcE?.HEntryColdFm;
            result.HExitRM.DbSource = "SpOrd2Pc.HEntryColdFm";

            result.TExitRM.E = spOrd2PcE?.TEntry;
            result.TExitRM.DbSource = "SpOrd2Pc.TEntry";

            result.ProfileCalc.E = spOrd2PcE?.ProfexcalcHrm;
            result.ProfileCalc.M = spOrd2PcM?.ProfexcalcHrm;
            result.ProfileCalc.DbSource = "SpOrd2Pc.ProfexcalcHrm";

            result.ProfileTarget.E = spOrd2PcE?.ProfextargetHrm;
            result.ProfileTarget.M = spOrd2PcM?.ProfextargetHrm;
            result.ProfileTarget.DbSource = "SpOrd2Pc.ProfextargetHrm";

            return result;
        }
        public static SetpointsHRMDto MapData(this SetpointsHRMDto result, SetpointsHRMDataBlob dataBlob)
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

            result.ApsKey.L = edLogEntL?.ApsKey;
            result.ApsKey.E = edLogEntE?.ApsKey;
            result.ApsKey.DbSource = "EdLogEnt.ApsKey";

            result.AlloyCode.L = edLogEntL?.AlloyCode;
            result.AlloyCode.E = edLogEntE?.AlloyCode;
            result.AlloyCode.DbSource = "EdLogEnt.AlloyCode";

            result.SetPointsHrmOk.L = spOrd2PcL?.SetpointsHrmOk;
            result.SetPointsHrmOk.E = spOrd2PcE?.SetpointsHrmOk;
            result.SetPointsHrmOk.DbSource = "SpOrd2Pc.SetpointsHrmOk";

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

            result.Tom.L = spOrd2PcL?.Tom;
            result.Tom.E = spOrd2PcE?.Tom;
            result.Tom.DbSource = "SpOrd2Pc.Tom";

            result.OkAll.L = edPhyEntL?.OkAll;
            result.OkAll.E = edPhyEntE?.OkAll;
            result.OkAll.DbSource = "EdPhyEnt.OkAll";

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
        
        public static SetpointsHRMDto MapStandData(this SetpointsHRMDto result, SetpointsHRMDataBlob dataBlob, short standCount)
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

                var stand = new SingleSetpointsHRMStandDataDto();

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

                stand.LooperCool.L = iscpPassL?.LooperCool;
                stand.LooperCool.E = iscpPassE?.LooperCool;
                stand.LooperCool.M = iscpPassM?.LooperCool;
                stand.LooperCool.DbSource = $"IscpPass.LooperCool({i})";

                stand.StripSprayBefor.L = iscpPassL?.StripSprayBefor;
                stand.StripSprayBefor.E = iscpPassE?.StripSprayBefor;
                stand.StripSprayBefor.M = iscpPassM?.StripSprayBefor;
                stand.StripSprayBefor.DbSource = $"IscpPass.StripSprayBefor({i})";

                stand.AntiPeelingState.L = aopPassL?.AntiPeelingState;
                stand.AntiPeelingState.E = aopPassE?.AntiPeelingState;
                stand.AntiPeelingState.M = aopPassM?.AntiPeelingState;
                stand.AntiPeelingState.DbSource = $"AopPass.AntiPeelingState({i})";

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

                result.StandDataDtos.Add(stand);
            }

            return result;
        }
    }
}