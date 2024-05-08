using System.Linq;
using WebHMI.DataBlobs;
using WebHMI.Dtos.SetpointsRM;

namespace WebHMI.Mapping.Extensions
{
    public static class SetpointsRmDtoMapper
    {
        public static SetpointsRmDto MapPlans(this SetpointsRmDto result, SetpointsRmDataBlob dataBlob)
        {
            result.Plans.RollCooling.M = dataBlob.Rcps.FirstOrDefault(x => x.Source == "M")?.PlanNo;
            result.Plans.RollCooling.E = dataBlob.Rcps.FirstOrDefault(x => x.Source == "E")?.PlanNo;

            result.Plans.Loading.M = dataBlob.Lps.FirstOrDefault(x => x.Source == "M")?.PlanNo;
            result.Plans.Loading.E = dataBlob.Lps.FirstOrDefault(x => x.Source == "E")?.PlanNo;

            result.Plans.Descaling.M = dataBlob.Dphrms.FirstOrDefault(x => x.Source == "M")?.PlanNo;
            result.Plans.Descaling.E = dataBlob.Dphrms.FirstOrDefault(x => x.Source == "E")?.PlanNo;

            result.Plans.Tension.M = dataBlob.Tps.FirstOrDefault(x => x.Source == "M")?.PlanNo;
            result.Plans.Tension.E = dataBlob.Tps.FirstOrDefault(x => x.Source == "E")?.PlanNo;

            result.Plans.RollGap.M = dataBlob.Rglps.FirstOrDefault(x => x.Source == "M")?.PlanNo;
            result.Plans.RollGap.E = dataBlob.Rglps.FirstOrDefault(x => x.Source == "E")?.PlanNo;

            result.Plans.Isc.M = dataBlob.Iscps.FirstOrDefault(x => x.Source == "M")?.PlanNo;
            result.Plans.Isc.E = dataBlob.Iscps.FirstOrDefault(x => x.Source == "E")?.PlanNo;

            return result;
        }
        
        public static SetpointsRmDto MapStands(this SetpointsRmDto result, SetpointsRmDataBlob dataBlob, short standCount)
        {
            for (short i = 0; i < standCount; i++)
            {
                var stand = new SetpointsRmSingleStand();

                stand.StandId = i;

                stand.LType.L = dataBlob.LpPasses.FirstOrDefault(x => x.Source == "X" && x.PassNo == i)?.LoadingType;
                stand.LType.M = dataBlob.LpPasses.FirstOrDefault(x => x.Source == "M" && x.PassNo == i)?.LoadingType;
                stand.LType.E = dataBlob.LpPasses.FirstOrDefault(x => x.Source == "E" && x.PassNo == i)?.LoadingType;
                
                stand.Red.E = dataBlob.SpOrd2PcStands.FirstOrDefault(x => x.Source == "E" && x.StandId == i)?.Red;
                
                stand.Lv.L = dataBlob.LpPasses.FirstOrDefault(x => x.Source == "X" && x.PassNo == i)?.LoadingValue;
                stand.Lv.M = dataBlob.LpPasses.FirstOrDefault(x => x.Source == "M" && x.PassNo == i)?.LoadingValue;
                stand.Lv.E = dataBlob.LpPasses.FirstOrDefault(x => x.Source == "E" && x.PassNo == i)?.LoadingValue;
                
                stand.LvCorr.L = dataBlob.LpPasses.FirstOrDefault(x => x.Source == "X" && x.PassNo == i)?.LoadingValueCorrection;
                stand.LvCorr.M = dataBlob.LpPasses.FirstOrDefault(x => x.Source == "M" && x.PassNo == i)?.LoadingValueCorrection;
                stand.LvCorr.E = dataBlob.LpPasses.FirstOrDefault(x => x.Source == "E" && x.PassNo == i)?.LoadingValueCorrection;
                
                stand.Force.E = dataBlob.SpOrd2PcStands.FirstOrDefault(x => x.Source == "E" && x.StandId == i)?.Fr;
                
                stand.Sd.E = dataBlob.SpOrd2PcStands.FirstOrDefault(x => x.Source == "E" && x.StandId == i)?.Sd;
                
                stand.Temperature.E = dataBlob.SpOrd2PcStands.FirstOrDefault(x => x.Source == "E" && x.StandId == i)?.T0;         
                
                stand.CircSpeed.E = dataBlob.SpOrd2PcStands.FirstOrDefault(x => x.Source == "E" && x.StandId == i)?.VCircum;
                
                stand.EntryThickness.E = dataBlob.SpOrd2PcStands.FirstOrDefault(x => x.Source == "E" && x.StandId == i)?.H0;
                
                stand.RollTemp.E = dataBlob.SpOrd2PcStands.FirstOrDefault(x => x.Source == "E" && x.StandId == i)?.TRoll;

                stand.SdPosition.E =
                    dataBlob.SpOrd2PcStands.FirstOrDefault(x => x.Source == "E" && x.StandId == i)?.ThermCrown 
                    + dataBlob.SpOrd2PcStands.FirstOrDefault(x => x.Source == "E" && x.StandId == i)?.Wear;
                
                stand.ExitProfileRel.E = dataBlob.SpOrd2PcStands.FirstOrDefault(x => x.Source == "E" && x.StandId == i)?.RelProfile;
                
                stand.ExitProfileAbs.E = dataBlob.SpOrd2PcStands.FirstOrDefault(x => x.Source == "E" && x.StandId == i)?.Profile;
                
                stand.Bend.E = dataBlob.SpOrd2PcStands.FirstOrDefault(x => x.Source == "E" && x.StandId == i)?.Fb;
                
                stand.Shift.E = dataBlob.SpOrd2PcStands.FirstOrDefault(x => x.Source == "E" && x.StandId == i)?.PositionWrs;
                
                stand.ShiftSpeed.E = dataBlob.SrpPasses.FirstOrDefault(x => x.Source == "E" && x.PassNo == i)?.Model;
                
                stand.SpecTens.E = dataBlob.Tppasses.FirstOrDefault(x => x.Source == "E" && x.PassNo == i)?.SpecifFoTension;
                
                stand.ObsFlatness.M = dataBlob.DirFmPfcParaPpasses.FirstOrDefault(x => x.Source == "M" && x.PassNo == i)?.ObservedFlat;
                stand.ObsFlatness.E = dataBlob.DirFmPfcParaPpasses.FirstOrDefault(x => x.Source == "E" && x.PassNo == i)?.ObservedFlat;
                stand.ObsFlatness.Status = dataBlob.StatDirFmPfcParaPpassEffective.FirstOrDefault(x => x.PassNo == i)?.ObservedFlat;
                
                result.Stands.Add(stand);
            }

            return result;
        }
    }
}