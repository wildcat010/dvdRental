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
        public double? AntiOxidationEntryTop { get; set; }
        public double? AntiOxidationEntryBot { get; set; }
        public int? AntiOxStateExit { get; set; }
        public double? AntiOxidationExitTop { get; set; }
        public double? AntiOxidationExitBot { get; set; }
        public int? AntiPeelingState { get; set; }
        public double? AntiPeeling { get; set; }
        public string Description { get; set; }
    }
}