using System.Collections.Generic;

namespace WebHMI.Application.Dtos.Roll
{
    public class CalCurveDataDto
    {
        public Dictionary<int, SingleCurveDataDto> CalCurvesDataSet { get; set; }
    }
}
