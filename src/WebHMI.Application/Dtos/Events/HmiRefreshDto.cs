using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Events
{
    public class HmiRefreshDto
    {
        public List<string> EventKey { get; set; } = new();
        public MeCodeDto MeCode { get; set; }
        public string LocationName { get; set; }
        public int LocationId { get; set; }
    }
}
