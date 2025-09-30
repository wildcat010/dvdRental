using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos
{
    public class StdDprampFmDto : StdItemDto
    {
        public int? DescrampAuto { get; set; }
        public int? DescrampState { get; set; }
        public double? DescrampVolume { get; set; }
    }
}
