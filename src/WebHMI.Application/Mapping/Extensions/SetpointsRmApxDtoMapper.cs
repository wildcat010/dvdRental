using System.Linq;
using WebHMI.DataBlobs;
using WebHMI.Dtos.SetpointsRM;

namespace WebHMI.Mapping.Extensions
{
    public static class SetpointsRmApxDtoMapper
    {
        public static SetpointsRmApxDto MapPlans(this SetpointsRmApxDto result, SetpointsRmApxDataBlob dataBlob)
        {
            result.Plans.Shifting.M = dataBlob.DirFmPfcCycShiftPs.FirstOrDefault(x => x.Source == "M")?.PlanNo;
            result.Plans.Shifting.E = dataBlob.DirFmPfcCycShiftPs.FirstOrDefault(x => x.Source == "E")?.PlanNo;
            
            result.Plans.Flatness.M = dataBlob.DirFmPfcParaPs.FirstOrDefault(x => x.Source == "M")?.PlanNo;
            result.Plans.Flatness.E = dataBlob.DirFmPfcParaPs.FirstOrDefault(x => x.Source == "E")?.PlanNo;
            
            return result;
        }

        public static SetpointsRmApxDto MapStands(this SetpointsRmApxDto result, SetpointsRmApxDataBlob dataBlob,
            short standCount)
        {
            for (short i = 0; i < standCount; i++)
            {
                var stand = new SetpointsRmApxSingleStand();
                stand.StandId = i;
                
                stand.BendingForceUpperLimit.M = dataBlob.DirFmPfcParaPpasses.FirstOrDefault(x => x.Source == "M" && x.PassNo == i)?.FbUl;
                stand.BendingForceUpperLimit.E = dataBlob.DirFmPfcParaPpasses.FirstOrDefault(x => x.Source == "E" && x.PassNo == i)?.FbUl;

                stand.BendingForceLowerLimit.M = dataBlob.DirFmPfcParaPpasses.FirstOrDefault(x => x.Source == "M" && x.PassNo == i)?.FbLl;
                stand.BendingForceLowerLimit.E = dataBlob.DirFmPfcParaPpasses.FirstOrDefault(x => x.Source == "E" && x.PassNo == i)?.FbLl;

                stand.ShiftingUpperLimit.M = dataBlob.DirFmPfcParaPpasses.FirstOrDefault(x => x.Source == "M" && x.PassNo == i)?.SrUl;
                stand.ShiftingUpperLimit.E = dataBlob.DirFmPfcParaPpasses.FirstOrDefault(x => x.Source == "E" && x.PassNo == i)?.SrUl;

                stand.ShiftingLowerLimit.M = dataBlob.DirFmPfcParaPpasses.FirstOrDefault(x => x.Source == "M" && x.PassNo == i)?.SrLl;
                stand.ShiftingLowerLimit.E = dataBlob.DirFmPfcParaPpasses.FirstOrDefault(x => x.Source == "E" && x.PassNo == i)?.SrLl;

                stand.WearShiftingUpperLimit.M = dataBlob.DirFmPfcCycShiftPpasses.FirstOrDefault(x => x.Source == "M" && x.PassNo == i)?.CSmaxLimit;
                stand.WearShiftingUpperLimit.E = dataBlob.DirFmPfcCycShiftPpasses.FirstOrDefault(x => x.Source == "E" && x.PassNo == i)?.CSmaxLimit;

                stand.WearShiftingLowerLimit.M = dataBlob.DirFmPfcCycShiftPpasses.FirstOrDefault(x => x.Source == "M" && x.PassNo == i)?.CSminLimit;
                stand.WearShiftingLowerLimit.E = dataBlob.DirFmPfcCycShiftPpasses.FirstOrDefault(x => x.Source == "E" && x.PassNo == i)?.CSminLimit;

                stand.ObsFlatness.M = dataBlob.DirFmPfcParaPpasses.FirstOrDefault(x => x.Source == "M" && x.PassNo == i)?.ObservedFlat;
                stand.ObsFlatness.E = dataBlob.DirFmPfcParaPpasses.FirstOrDefault(x => x.Source == "E" && x.PassNo == i)?.ObservedFlat;
                stand.ObsFlatness.Status = dataBlob.StatDirFmPfcParaPpassEffective.FirstOrDefault(x => x.PassNo == i)?.ObservedFlat;

                stand.RollForce.E = dataBlob.SpOrd2PcStands.FirstOrDefault(x => x.Source == "E" && x.StandId == i)?.Fr;

                stand.EffGrinding.E = dataBlob.SpOrd2PcStands.FirstOrDefault(x => x.Source == "E" && x.StandId == i)?.WrCrownEff;

                stand.ThermalCrown.E = dataBlob.SpOrd2PcStands.FirstOrDefault(x => x.Source == "E" && x.StandId == i)?.ThermCrown;

                stand.WearCrown.E = dataBlob.SpOrd2PcStands.FirstOrDefault(x => x.Source == "E" && x.StandId == i)?.Wear;

                stand.RollTemp.E = dataBlob.SpOrd2PcStands.FirstOrDefault(x => x.Source == "E" && x.StandId == i)?.TRoll;

                stand.ExitProfileRel.E = dataBlob.SpOrd2PcStands.FirstOrDefault(x => x.Source == "E" && x.StandId == i)?.RelProfile;

                stand.ExitProfileAbs.E = dataBlob.SpOrd2PcStands.FirstOrDefault(x => x.Source == "E" && x.StandId == i)?.Profile;

                stand.Bend .E = dataBlob.SpOrd2PcStands.FirstOrDefault(x => x.Source == "E" && x.StandId == i)?.Fb;

                stand.Shift.E = dataBlob.SpOrd2PcStands.FirstOrDefault(x => x.Source == "E" && x.StandId == i)?.PositionWrs;
                
                result.Stands.Add(stand);
            }

            return result;
        }
    }
}