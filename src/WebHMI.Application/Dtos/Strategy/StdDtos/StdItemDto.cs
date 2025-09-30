using System;

namespace WebHMI.Dtos.Strategy.StdDtos
{
    public class StdItemDto
    {
        public int PlanNo { get; set; }
        public int ActiveFlag { get; set; }
        public string Description { get; set; }
        public short Nodes { get; set; }
        public int AssignmentsCount { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
