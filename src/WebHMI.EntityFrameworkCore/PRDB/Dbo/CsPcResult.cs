using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Cspcresult
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public string Vprecalcbot { get; set; }

    public string Vprecalcfm { get; set; }

    public string Vprecalctop { get; set; }

    public double? Wateramount { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual Me1 Me1 { get; set; }
}
