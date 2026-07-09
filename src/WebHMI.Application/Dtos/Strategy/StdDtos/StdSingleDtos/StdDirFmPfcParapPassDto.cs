using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos
{
    public class StdDirFmPfcParapPassDto :StdPassDto
    {
        public double? Fbul { get; set; }
        public double? Fbll { get; set; }
        public double? Srul { get; set; }
        public double? Srll { get; set; }
        public double? Facdfbdfr { get; set; }
        public double? Facdfbdiu { get; set; }
        public string Description { get; internal set; }
    }
}
