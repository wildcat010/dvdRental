using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Roll
{
    public class CustomRollShapeCurveDto
    {
        public int Shapecurvecode { get; set; }
        public string Description { get; set; }
        public int Validpoints { get; set; }
        public List<double> Values { get; set; }
    }
}
