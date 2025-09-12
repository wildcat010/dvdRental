using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using WebHMI.DataBlobs;
using WebHMI.Dtos.SetpointsHRM;
using WebHMI.Dtos.SetpointsRM;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions
{
    public static class SetpointsHRMApxMapper
    {

        //public static HRMMaterialOverviewDto MapOverview(this HRMMaterialOverviewDto result,List<SpOrd2Pc> spOrd2Pcs, List<EdOrdEnt> edOrdEnts, List<EdPhyEnt> edPhyEnts)
        //{
        //    var spOrd2PcL = spOrd2Pcs.Where(x => x.Source == "L").FirstOrDefault();
        //    var spOrd2PcM = spOrd2Pcs.Where(x => x.Source == "M").FirstOrDefault();
        //    var spOrd2PcS = spOrd2Pcs.Where(x => x.Source == "S").FirstOrDefault();
        //    var spOrd2PcE = spOrd2Pcs.Where(x => x.Source == "E").FirstOrDefault();

        //    var edOrdEntL = edOrdEnts.Where(x => x.Source == "L").FirstOrDefault();
        //    var edOrdEntM = edOrdEnts.Where(x => x.Source == "M").FirstOrDefault();
        //    var edOrdEntS = edOrdEnts.Where(x => x.Source == "S").FirstOrDefault();
        //    var edOrdEntE = edOrdEnts.Where(x => x.Source == "E").FirstOrDefault();

        //    var edPhyEntL = edPhyEnts.Where(x => x.Source == "L").FirstOrDefault();
        //    var edPhyEntM = edPhyEnts.Where(x => x.Source == "M").FirstOrDefault();
        //    var edPhyEntS = edPhyEnts.Where(x => x.Source == "S").FirstOrDefault();
        //    var edPhyEntE = edPhyEnts.Where(x => x.Source == "E").FirstOrDefault();

        //    result.WEntry.L = edPhyEntL?.WidthExitCustomer;
        //    result.WEntry.E = edPhyEntE?.WidthExitCustomer;
        //    result.WEntry.M = edPhyEntM?.WidthExitCustomer;
        //    result.WEntry.S = edPhyEntS?.WidthExitCustomer;
        //    result.WEntry.DbSource = "EdPhyEnt.WidthExitCustomer";

        //    result.HEntry.L = edPhyEntL?.HEntry;
        //    result.HEntry.E = edPhyEntE?.HEntry;
        //    result.HEntry.M = edPhyEntM?.HEntry;
        //    result.HEntry.S = edPhyEntS?.HEntry;
        //    result.HEntry.DbSource = "EdPhyEnt.HEntry";

        //    result.TEntry.L = edPhyEntL?.TEntry;
        //    result.TEntry.E = edPhyEntE?.TEntry;
        //    result.TEntry.M = edPhyEntM?.TEntry;
        //    result.TEntry.S = edPhyEntS?.TEntry;
        //    result.TEntry.DbSource = "EdPhyEnt.TEntry";

        //    result.LEntry.L = edPhyEntL?.LEntryFm;
        //    result.LEntry.E = edPhyEntE?.LEntryFm;
        //    result.LEntry.M = edPhyEntM?.LEntryFm;
        //    result.LEntry.S = edPhyEntS?.LEntryFm;
        //    result.LEntry.DbSource = "EdPhyEnt.LEntryFm";

        //    result.WExitRM.L = edOrdEntL?.HIntermediate;
        //    result.WExitRM.E = edOrdEntE?.HIntermediate;
        //    result.WExitRM.M = edOrdEntM?.HIntermediate;
        //    result.WExitRM.S = edOrdEntS?.HIntermediate;
        //    result.WExitRM.DbSource = "EdOrdEnt.HIntermediate";

        //    result.WExitRMOrd.E = spOrd2PcE?.WEntryColdFm;
        //    result.WExitRMOrd.DbSource = "SpOrd2Pc.WEntryColdFm";

        //    result.HExitRM.E = spOrd2PcE?.HEntryColdFm;
        //    result.HExitRM.DbSource = "SpOrd2Pc.HEntryColdFm";

        //    result.TExitRM.E = spOrd2PcE?.TEntry;
        //    result.TExitRM.DbSource = "SpOrd2PcE.TEntry";

        //    result.ProfileCalc.E = spOrd2PcE?.ProfexcalcHrm;
        //    result.ProfileCalc.DbSource = "SpOrd2PcE.ProfexcalcHrm";

        //    result.ProfileTarget.E = spOrd2PcE?.ProfextargetHrm;
        //    result.ProfileTarget.DbSource = "SpOrd2PcE.ProfextargetHrm";

        //    return result;
        //}
        public static SetpointsHRMApxDto MapData(this SetpointsHRMApxDto result, SetpointsHRMApxDataBlob dataBlob)
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

            result.ApsKey.L = edLogEntL?.ApsKey;
            result.ApsKey.E = edLogEntE?.ApsKey;
            result.ApsKey.DbSource = "EdLogEnt.ApsKey";

            result.AlloyCode.L = edLogEntL?.AlloyCode;
            result.AlloyCode.E = edLogEntE?.AlloyCode;
            result.AlloyCode.DbSource = "EdLogEnt.AlloyCode";

            result.SetPointSfmOk.L = spOrd2PcL?.SetpointsFmOk;
            result.SetPointSfmOk.E = spOrd2PcE?.SetpointsFmOk;
            result.SetPointSfmOk.DbSource = "SpOrd2Pc.SetpointsFmOk";

            result.OkAll.L = edPhyEntL?.OkAll;
            result.OkAll.E = edPhyEntE?.OkAll;
            result.OkAll.DbSource = "EdPhyEnt.OkAll";

            result.HExit.L = edOrdEntL?.HExit;
            result.HExit.E = edOrdEntE?.HExit;
            result.HExit.M = edOrdEntM?.HExit;
            result.HExit.DbSource = "EdOrdEnt.HExit";

            result.WidthExit.L = edOrdEntL?.WidthExit;
            result.WidthExit.E = edOrdEntE?.WidthExit;
            result.WidthExit.M = edOrdEntM?.WidthExit;
            result.WidthExit.DbSource = "EdOrdEnt.WidthExit";

            result.ExitCrownC25.L = edOrdEntL?.ExitCrownC25;
            result.ExitCrownC25.E = edOrdEntE?.ExitCrownC25;
            result.ExitCrownC25.M = edOrdEntM?.ExitCrownC25;
            result.ExitCrownC25.DbSource = "EdOrdEnt.ExitCrownC25";

            result.HEntryColdFm.L = spOrd2PcL?.HEntryColdFm;
            result.HEntryColdFm.E = spOrd2PcE?.HEntryColdFm;
            result.HEntryColdFm.DbSource = "SpOrd2Pc.HEntryColdFm";

            result.ProfileCorr.L = dirFmPfcParaPL?.ProfileCorr;
            result.ProfileCorr.E = dirFmPfcParaPE?.ProfileCorr;
            result.ProfileCorr.M = dirFmPfcParaPM?.ProfileCorr;
            result.ProfileCorr.DbSource = "DirFmPfcParaP.ProfileCorr";

            result.HExitCold.L = spOrd2PcL?.HExitCold;
            result.HExitCold.E = spOrd2PcE?.HExitCold;
            result.HExitCold.DbSource = "SpOrd2Pc.HExitCold";

            result.WExitCold.L = spOrd2PcL?.WExitCold;
            result.WExitCold.E = spOrd2PcE?.WExitCold;
            result.WExitCold.DbSource = "SpOrd2Pc.WExitCold";

            result.ClassMinCrownDelta.L = edOrdEntL?.ClassMinCrownDelta;
            result.ClassMinCrownDelta.E = edOrdEntE?.ClassMinCrownDelta;
            result.ClassMinCrownDelta.DbSource = "EdOrdEnt.ClassMinCrownDelta";

            result.ProfExCalc.L = spOrd2PcL?.Profexcalc;
            result.ProfExCalc.E = spOrd2PcE?.Profexcalc;
            result.ProfExCalc.DbSource = "SpOrd2Pc.Profexcalc";

            result.ClassMaxCrownDelta.L = edOrdEntL?.ClassMaxCrownDelta;
            result.ClassMaxCrownDelta.E = edOrdEntE?.ClassMaxCrownDelta;
            result.ClassMaxCrownDelta.DbSource = "EdOrdEnt.ClassMaxCrownDelta";

            result.DirFmPfcParaPlanNo.L = dirFmPfcParaPL?.PlanNo;
            result.DirFmPfcParaPlanNo.E = dirFmPfcParaPE?.PlanNo;
            result.DirFmPfcParaPlanNo.M = dirFmPfcParaPM?.PlanNo;
            result.DirFmPfcParaPlanNo.DbSource = "DirFmPfcParaP.PlanNo";

            result.DirFmPfcParaDescription.L = dirFmPfcParaPL?.Description;
            result.DirFmPfcParaDescription.E = dirFmPfcParaPE?.Description;
            result.DirFmPfcParaDescription.DbSource = "DirFmPfcParaP.Description";

            result.DirFmPfcCycShiftPlanNo.L = dirFmPfcCycShiftL?.PlanNo;
            result.DirFmPfcCycShiftPlanNo.E = dirFmPfcCycShiftE?.PlanNo;
            result.DirFmPfcCycShiftPlanNo.M = dirFmPfcCycShiftM?.PlanNo;
            result.DirFmPfcCycShiftPlanNo.DbSource = "DirFmPfcCycShift.PlanNo";

            result.DirFmPfcCycShiftDescription.L = dirFmPfcCycShiftL?.Description;
            result.DirFmPfcCycShiftDescription.E = dirFmPfcCycShiftE?.Description;
            result.DirFmPfcCycShiftDescription.DbSource = "DirFmPfcCycShift.Description";

            result.InherPfc.L = spOrd2PcL?.InherPfc;
            result.InherPfc.E = spOrd2PcE?.InherPfc;
            result.InherPfc.DbSource = "SpOrd2Pc.InherPfc";

            result.InherPfcId.L = spOrd2PcL?.InherPfcId;
            result.InherPfcId.E = spOrd2PcE?.InherPfcId;
            result.InherPfcId.DbSource = "SpOrd2Pc.InherPfcId";

            result.Tom.L = spOrd2PcL?.Tom;
            result.Tom.E = spOrd2PcE?.Tom;
            result.Tom.DbSource = "SpOrd2Pc.Tom";

            return result;
        }

        public static SetpointsHRMApxDto MapStandData(this SetpointsHRMApxDto result, SetpointsHRMApxDataBlob dataBlob, short standCount)
        {
            for (short i = 0; i < standCount; i++)
            {
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

                var stand = new SingleHRMApxStandData();

                stand.PassNo = i;

                stand.BendingForce.L = lpPassL?.BendingForce;
                stand.BendingForce.E = lpPassE?.BendingForce;
                stand.BendingForce.M = lpPassM?.BendingForce;
                stand.BendingForce.DbSource = $"LpPass.BendingForce({i})";

                stand.Fbul.L = dirFmPfcParaPassesL?.FbUl;
                stand.Fbul.E = dirFmPfcParaPassesE?.FbUl;
                stand.Fbul.M = dirFmPfcParaPassesM?.FbUl;
                stand.Fbul.DbSource = $"DirFmPfcParaPasses.FbUl({i})";

                stand.Fbll.L = dirFmPfcParaPassesL?.FbLl;
                stand.Fbll.E = dirFmPfcParaPassesE?.FbLl;
                stand.Fbll.M = dirFmPfcParaPassesM?.FbLl;
                stand.Fbll.DbSource = $"DirFmPfcParaPasses.FbLl({i})";

                stand.CvcShifting.L = lpPassL?.CVcshifting;
                stand.CvcShifting.E = lpPassE?.CVcshifting;
                stand.CvcShifting.E = lpPassM?.CVcshifting;
                stand.CvcShifting.DbSource = $"LpPass.CVcshifting({i})";

                stand.Srul.L = dirFmPfcParaPassesL?.SrUl;
                stand.Srul.E = dirFmPfcParaPassesE?.SrUl;
                stand.Srul.E = dirFmPfcParaPassesM?.SrUl;
                stand.Srul.DbSource = $"DirFmPfcParaPasses.SrUl({i})";

                stand.Srll.L = dirFmPfcParaPassesL?.SrLl;
                stand.Srll.E = dirFmPfcParaPassesE?.SrLl;
                stand.Srll.E = dirFmPfcParaPassesM?.SrLl;
                stand.Srll.DbSource = $"DirFmPfcParaPasses.SrLl({i})";

                stand.ObservedFlat.L = dirFmPfcParaPassesL?.ObservedFlat;
                stand.ObservedFlat.E = dirFmPfcParaPassesE?.ObservedFlat;
                stand.ObservedFlat.E = dirFmPfcParaPassesM?.ObservedFlat;
                stand.ObservedFlat.DbSource = $"DirFmPfcParaPasses.ObservedFlat({i})";

                stand.Fr.L = spOrd2PcStandL?.Fr;
                stand.Fr.E = spOrd2PcStandE?.Fr;
                stand.Fr.DbSource = $"SpOrd2PcStand.Fr({i})";

                stand.Fb.L = spOrd2PcStandL?.Fb;
                stand.Fb.E = spOrd2PcStandE?.Fb;
                stand.Fb.DbSource = $"SpOrd2PcStand.Fb({i})";

                stand.PositionWrs.L = spOrd2PcStandL?.PositionWrs;
                stand.PositionWrs.E = spOrd2PcStandE?.PositionWrs;
                stand.PositionWrs.DbSource = $"SpOrd2PcStand.PositionWrs({i})";

                stand.RelProfile.L = spOrd2PcStandL?.RelProfile;
                stand.RelProfile.E = spOrd2PcStandE?.RelProfile;
                stand.RelProfile.DbSource = $"SpOrd2PcStand.RelProfile({i})";

                stand.Profile.L = spOrd2PcStandL?.Profile;
                stand.Profile.E = spOrd2PcStandE?.Profile;
                stand.Profile.DbSource = $"SpOrd2PcStand.Profile({i})";

                stand.WrCrownEff.L = spOrd2PcStandL?.WrCrownEff;
                stand.WrCrownEff.E = spOrd2PcStandE?.WrCrownEff;
                stand.WrCrownEff.DbSource = $"SpOrd2PcStand.WrCrownEff({i})";

                stand.ThermCrown.L = spOrd2PcStandL?.ThermCrown;
                stand.ThermCrown.E = spOrd2PcStandE?.ThermCrown;
                stand.ThermCrown.DbSource = $"SpOrd2PcStand.ThermCrown({i})";

                stand.Wear.L = spOrd2PcStandL?.Wear;
                stand.Wear.E = spOrd2PcStandE?.Wear;
                stand.Wear.DbSource = $"SpOrd2PcStand.Wear({i})";

                stand.Troll.L = spOrd2PcStandL?.TRoll;
                stand.Troll.E = spOrd2PcStandE?.TRoll;
                stand.Troll.DbSource = $"SpOrd2PcStand.TRoll({i})";

                stand.SptlFaultFm.L = spOrd2PcL?.SptlFaultFm;
                stand.SptlFaultFm.E = spOrd2PcE?.SptlFaultFm;
                stand.SptlFaultFm.DbSource = $"SpOrd2Pc.SptlFaultFm({i})";

                stand.WmpModel.L = wmppassesL?.Model;
                stand.WmpModel.E = wmppassesE?.Model;
                stand.WmpModel.DbSource = $"Wmppasses.Model({i})";

                stand.SrpModel.L = srpPassesL?.Model;
                stand.SrpModel.E = srpPassesL?.Model;
                stand.SrpModel.DbSource = $"SrpPasses.Model({i})";

                stand.CsMaxLimit.L = dirFmPfcCycShiftPassL?.CSmaxLimit;
                stand.CsMaxLimit.E = dirFmPfcCycShiftPassE?.CSmaxLimit;
                stand.CsMaxLimit.DbSource = $"DirFmPfcCycShiftPass.CSmaxLimit({i})";

                stand.CsMinLimit.L = dirFmPfcCycShiftPassL?.CSminLimit;
                stand.CsMinLimit.E = dirFmPfcCycShiftPassE?.CSminLimit;
                stand.CsMinLimit.DbSource = $"DirFmPfcCycShiftPass.CSminLimit({i})";

                result.StandDataDtos.Add(stand);
            }

            return result;
        }
    }
}