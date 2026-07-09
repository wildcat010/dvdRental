using System;

namespace WebHMI.PRDB.Dbo
{
    public interface IStd
    {
        public int Activeflag { get; set; }
        public int Planno { get; set; }
        string Description { get; set; }
        public DateTime? Tom { get; set; }
    }
}
