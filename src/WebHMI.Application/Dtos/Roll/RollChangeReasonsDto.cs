using System.Collections.Generic;

namespace WebHMI.Dtos.Roll
{
    public class SingleStandReason
    {
        public int StandId { get; set; }
        public string RollPos { get; set; }
        public string RollType { get; set; }
    }
    public class RollChangeReasonsDto
    {
        public List<SingleStandReason> Stands { get; set; }
        public int ReasonId { get; set; }
        public string OperatorRemarks { get; set; }
    }
}
