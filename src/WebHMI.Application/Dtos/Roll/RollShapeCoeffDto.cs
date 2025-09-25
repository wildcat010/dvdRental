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
        public float? ShapeX1 { get; set; }
        public float? ShapeX2 { get; set; }
        public float? ShapeX3 { get; set; }
        public float? ShapeX4 { get; set; }
        public float? ShapeX5 { get; set; }
        public float? ShapeX6 { get; set; }
        public float? ShapeX7 { get; set; }
        public float? ShapeX8 { get; set; }
        public float? ShapeX9 { get; set; }
        public string StandRange { get; set; }
        public int? ShapeCurveCode { get; set; }
    }
}
