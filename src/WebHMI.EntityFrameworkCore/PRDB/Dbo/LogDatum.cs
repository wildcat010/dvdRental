using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class LogDatum
{
    public int Entryid { get; set; }

    public string Lang { get; set; }

    public DateTime Clock { get; set; }

    public DateTime? Confirmedat { get; set; }

    public string Confirmedby { get; set; }

    public short Id { get; set; }

    public string Loggroup { get; set; }

    public string Logorigin { get; set; }

    public string Logtext { get; set; }

    public DateTime? Statusendat { get; set; }

    public string Userdata1 { get; set; }

    public string Userdata2 { get; set; }

    public string Userdata3 { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
