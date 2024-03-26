namespace WebHMI.Dtos.Roll
{
    public class RollClassDto
    {
        public int RollClass { get; set; }
        public double? CaliberDiaDiff { get; set; }
        public double? CaliberDiaFac1 { get; set; }
        public double? CaliberDiaFac2 { get; set; }
        public double? CaliberLength { get; set; }
        public double? DNeck { get; set; }
        public string Description { get; set; }
        public double? FillGap { get; set; }
        public double? FillHard { get; set; }
        public double? FillL { get; set; }
        public double? LNeck { get; set; }
        public double? Length { get; set; }
        public double? NutDist { get; set; }
        public double? NutH { get; set; }
        public double? NutL { get; set; }
        public string PlantType { get; set; }
        public string RollType { get; set; }
        public string StandRange { get; set; }
    }
}
