using System.Collections.Generic;

namespace WebHMI.Dtos.Roll
{
    public class EmergencyRollChangeDto
    {
        public PlantType PlantType { get; set; }
        public List<SingleEmergencyRollChangePlantItemDto> PlantItemsToRollChange { get; set; }
    }
}
