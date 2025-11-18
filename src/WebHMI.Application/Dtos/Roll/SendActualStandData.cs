using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Roll
{
    public class SendActualStandDataDto
    {
        public string PlantType { get; set; }
        public List<short> StandIds { get; set; }
    }

}
