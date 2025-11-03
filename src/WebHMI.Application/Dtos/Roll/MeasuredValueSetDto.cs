using System.Collections.Generic;
using WebHMI.Dtos;

namespace WebHMI.Application.Dtos.Roll
{
    public class MeasValElementDto
    {
        public int SampleId { get; set; }
        public double? Position { get; set; }
        public double MeasuredValue { get; set; }
    }

    public class MeasuredValueSetDto
    {
        public string MVName { get; set; }
        public List<MeasValElementDto> MVArray { get; set; }
    }
    public class MeasuredValueDataDto
    {
        public MeCodeDto MeCode { get; set; }
        public Dictionary<string, MeasuredValueSetDto> MeasuredValueSet { get; set; }
    }
}
