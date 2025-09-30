using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos
{
    public class StdAopPassDto :StdPassDto
    {
        public int? AntiOxStateEntry { get; set; }
        public double? AntiOxidationEntry { get; set; }
        public int? AntiOxStateExit { get; set; }
        public double? AntiOxidationExit { get; set; }
        public int? AntiPeelingState { get; set; }
        public double? AntiPeeling { get; set; }

    }
}