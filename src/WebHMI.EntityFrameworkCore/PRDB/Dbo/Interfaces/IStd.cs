using System;

namespace WebHMI.PRDB.Dbo.Interfaces
{
    public interface IStd
    {
        public int ActiveFlag { get; set; }
        public int PlanNo { get; set; }
        string Description { get; set; }
        public DateTime? Tom { get; set; }
    }
}
