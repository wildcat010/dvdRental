using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Roll
{
    public class ShortRollChangeDto
    {
        public short StandNo { get; set; }
        public short ChangeWKR { get; set; }
        public short ChangeBURTop { get; set; }
        public short ChangeBURBot { get; set; }

    }
}
