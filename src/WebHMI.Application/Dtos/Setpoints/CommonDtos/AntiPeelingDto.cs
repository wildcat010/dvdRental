using Microsoft.AspNetCore.Mvc.Formatters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Setpoints.CommonDtos
{
    public class AntiPeelingDto
    {
        public short PassNo { get; set; }
        public SourceSet<int?> PlanNo { get; set; } = new();
        public SourceSet<int?> AntiOxStateEntry { get; set; } = new();
        public SourceSet<double?> AntiOxidationEntryTop { get; set; } = new();
        public SourceSet<double?> AntiOxidationEntryBottom { get; set; } = new();
        public SourceSet<int?> AntiOxStateExit { get; set; } = new();
        public SourceSet<double?> AntiOxidationExitTop { get; set; } = new();
        public SourceSet<double?> AntiOxidationExitBottom { get; set; } = new();
        public SourceSet<int?> AntiPeelingState { get; set; } = new();
        public SourceSet<double?> AntiPeeling { get; set; } = new();
    }
}
