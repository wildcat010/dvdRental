using System.Collections.Generic;

namespace WebHMI.Dtos.Setpoints.SetpointsCS
{
    public class PreCalculationTabDto
    {
        public List<CsTemperatureCurvePoint> TemperatureCurve { get; set; } = new();
        public List<CsValveSetting> ValveSettings { get; set; } = new();
        public List<CsSpeedDiagramLine> SpeedDiagram { get; set; } = new();
        public OrderData OrderData { get; set; } = new();
    }
}
