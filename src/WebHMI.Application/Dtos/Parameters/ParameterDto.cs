using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Parameters
{
    public class ParameterDto
    {
        public string ParamName { get; set; }
        public string PlantType { get; set; }
        public string CType { get; set; }
        public string CurValC { get; set; }
        public double? CurValN { get; set; }
        public string Description { get; set; }
        public string Moddescr { get; set; }
        public string Unit { get; set; }
    }
}
