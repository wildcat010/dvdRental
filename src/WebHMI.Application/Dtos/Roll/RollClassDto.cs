using System;

namespace WebHMI.Dtos.Roll
{
    public class RollClassDto
    {
        public int RollClass { get; set; }
        public double? CaliberDiaDiff { get; set; }
        public double? CaliberLength { get; set; }
        public float? CheckerHeight { get; set; }
        public int? CheckerRoll { get; set; }
        public double? DNeck { get; set; }
        public string Description { get; set; }
        public double? LNeck { get; set; }
        public double? Length { get; set; }
        public string PlantType { get; set; }
        public string RollType { get; set; }
        public string StandRange { get; set; }
        public DateTime? Toc { get; set; }
        public DateTime? Tom { get; set; }
    }
}
