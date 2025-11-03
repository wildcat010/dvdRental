using System;

namespace WebHMI.Application.Dtos.Roll
{
    public class SingleCurveDataDto
    {
        public DateTime? CalibrationDatetime { get; set; }
        public MeasuredValueSetDto CurveData { get; set; }
    }
}
