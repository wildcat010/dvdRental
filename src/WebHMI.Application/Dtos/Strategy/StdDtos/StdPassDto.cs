using System;

namespace WebHMI.Dtos.Strategy.StdDtos
{
    public abstract class StdPassDto
    {
        public int PlanNo { get; set; }
        public int ActiveFlag { get; set; }
        public int PassNo { get; set; }
    }
}
