namespace WebHMI.Dtos.Limit
{
    public class CreateLimitDto
    {
        public string Limitname { get; set; }
        public string Planttype { get; set; }
        public string Ctype { get; set; }
        public string Description { get; set; }
        public double? Lowerlimit { get; set; }
        public string Moddescr { get; set; }
        public string Sortorder { get; set; }
        public string Unit { get; set; }
        public double? Upperlimit { get; set; }
        public double? Upperwarning { get; set; }
        public double? Lowerwarning { get; set; }
    }
}
