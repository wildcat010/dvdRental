using System.Collections.Generic;

namespace WebHMI.Dtos.Roll
{
    public class SingleStandDataCoreDto
    {
        /// <summary>
        /// 0..n depending on number of stands
        /// </summary>
        public int StandId { get; set; }
        /// <summary>
        /// HRM, HFM... aligned with L2 data in table RollData
        /// </summary>
        public string PlantType { get; set; }
        /// <summary>
        /// I - Installed, P - Planned, R - Removed
        /// </summary>
        public string Stat { get; set; }
        public IList<SingleRollDataCoreDto> Rolls { get; set; }
    }
}
