namespace WebHMI.Dtos.Setpoints.SetpointsCS
{
    public struct CsSpeedDiagramLine
    {
        public CsSpeedDiagramPoint Start { get; set; }
        public CsSpeedDiagramPoint End { get; set; }
    }

    public struct CsSpeedDiagramPoint
    {
        public double? XPosition { get; set; }
        public double? YSpeed { get; set; }
    }
}
