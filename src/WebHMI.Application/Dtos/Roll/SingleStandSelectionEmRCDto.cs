
namespace WebHMI.Dtos.Roll
{
    public class SingleEmergencyRollChangePlantItemDto
    {
        public PlantItem PlantItem { get; set; }
        public short StandId { get; set; }
        public short TopBackupRoll { get; set; }
        public short Topshortermediateoll { get; set; }
        public short TopWorkRollRoll { get; set; }
        public short BottomWorkRollRoll { get; set; }
        public short Bottomshortermediateoll { get; set; }
        public short BottomBackupRoll { get; set; }
    }
}
