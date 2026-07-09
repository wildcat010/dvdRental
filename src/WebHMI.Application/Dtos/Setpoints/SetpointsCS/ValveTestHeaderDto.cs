using System;

namespace WebHMI.Dtos.Setpoints.SetpointsCS
{
    public class ValveTestHeaderDto
    {
        public DateTime? TestTime { get; set; }
        public int MaintenanceId { get; set; }
        public int SequenceId { get; set; }
        public short? ValveGroup { get; set; }
        public short? ValveStart { get; set; }
        public short? ValveEnd { get; set; }
    }
}
