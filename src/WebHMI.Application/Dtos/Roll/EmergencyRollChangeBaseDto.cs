using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Roll
{
    public class EmergencyRollChangeBaseDto
    {
        public string PlantType { get; set; }

        public List<ShortRollChangeDto> RollChangeDtos { get; set; } = new();
    }
}
