using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Roll
{
    public class CustomRollShapeCurveItem
    {
        public int ShapeCurveCode { get; set; }
        public int ValidPoints { get; set; }
        public string Description { get; set; }
    }
}
