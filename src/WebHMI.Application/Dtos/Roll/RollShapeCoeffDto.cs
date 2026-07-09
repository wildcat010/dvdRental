using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.Dtos.Roll
{
    public class RollShapeCoeffDto
    {
        public int ShapeCode { get; set; }
        public string Description { get; set; }
        public int? ShapeType { get; set; }
        public double? ShapeX1 { get; set; }
        public double? ShapeX2 { get; set; }
        public double? ShapeX3 { get; set; }
        public double? ShapeX4 { get; set; }
        public double? ShapeX5 { get; set; }
        public double? ShapeX6 { get; set; }
        public double? ShapeX7 { get; set; }
        public double? ShapeX8 { get; set; }
        public double? ShapeX9 { get; set; }
        public string StandRange { get; set; }
        public int? ShapeCurveCode { get; set; }
    }
}
