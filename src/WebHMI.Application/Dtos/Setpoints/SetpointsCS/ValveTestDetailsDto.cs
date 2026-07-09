namespace WebHMI.Dtos.Setpoints.SetpointsCS
{
    public class ValveTestDetailsDto
    {
        public int Id { get; set; }
        public int SqId { get; set; }
        public int MId { get; set; }
        public short? Ampldes { get; set; }
        public double? FlowDesDown { get; set; }
        public double? FlowDesUp { get; set; }
        public double? FlowMeasDown { get; set; }
        public double? FlowMeasUp { get; set; }
        public double? FlowObsDown { get; set; }
        public double? FlowObsUp { get; set; }
    }
}
