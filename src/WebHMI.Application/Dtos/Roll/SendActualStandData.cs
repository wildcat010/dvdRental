using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Roll
{
    public class SendActualStandDataDto
    {
        public PlantType PlantType { get; set; }
        public List<SendActualStandDataPlantItemDto> PlantItemsToSend { get; set; }
    }

    public class SendActualStandDataPlantItemDto
    {
        public short StandId { get; set; }
        public short Status { get; set; }
    }
}
