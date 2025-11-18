using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.L2Adapter.Dtos
{
    public class RollChangeDto
    {
        public string PlantType { get; set; }
        public short StandNo { get; set; }
        public short ChangeWKR { get; set; }
        public short ChangeIMR { get; set; }
        public short ChangeBURu { get; set; }
        public short ChangeBURl { get; set; }
        public short ChangeEWR { get; set; }
        public short ChangeSPT { get; set; }
        public short ChangeZR0 { get; set; }
        public short ChangeZR1 { get; set; }
        public short SendL1 { get; set; }
    }
}
