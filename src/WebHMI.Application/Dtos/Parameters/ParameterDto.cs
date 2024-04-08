using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Parameters
{
    public class ParameterDto
    {
        public string Paramname { get; set; }
        public string Planttype { get; set; }
        public string Ctype { get; set; }
        public string Curvalc { get; set; }
        public double? Curvaln { get; set; }
        public string Description { get; set; }
        public string Moddescr { get; set; }
        public string Unit { get; set; }
    }
}
