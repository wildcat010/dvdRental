using System;
using System.Collections.Generic;

namespace WebHMI.Events
{
    public class HmiTwmDataDto
    {
        public DateTime TimeStamp { get; set; }
        public string PlantType { get; set; }
        public List<HmiTwmStandDto> Stands { get; set; }
    }

    public class HmiTwmStandDto
    {
        public double StripWidth { get; set; }
        public short StandId { get; set; }
        public ME_CODEDto MeCode { get; set; }
        public List<HmiTwmRollStackDto> RollStacks { get; set; }
    }

    public class ME_CODEDto
    {
        public string ExtId { get; set; }
        public string MeTyp { get; set; }

        public ME_STRUCTDto Actual { get; set; }

        public ME_STRUCTDto Original { get; set; }

        public short BasId { get; set; }
    }

    public class HmiTwmRollStackDto
    {
        public string RollPos { get; set; }
        public List<HmiTwmRollDto> Rolls { get; set; }
    }

    public class HmiTwmRollDto
    {
        public bool RollExist { get; set; }
        public string RollId { get; set; }
        public string RollType { get; set; }
        public double RolledLength { get; set; }
        public double BarrelLength { get; set; }
        public double Shifting { get; set; }
        public double SummaryTempCrown { get; set; }
        public double SummaryWearCrown { get; set; }
        public double SummaryTempWearCrown { get; set; }
        public double RollMeanTemp { get; set; }
        public double[] TemperatureCrownArray { get; set; }
        public double[] WearCrownArray { get; set; }
        public double[] MechanicalCrownArray { get; set; }
        public List<HmiTwmSingleDiscDataDto> DiscsArray { get; set; }
    }

    public class HmiTwmSingleDiscDataDto
    {
        public int DiscId { get; set; }
        public int[] TempDistArray { get; set; }

    }

    public class ME_STRUCTDto
    {
        public int MeId { get; set; }

        public string MeCreator { get; set; }

        public short MesId { get; set; }
    }
}
