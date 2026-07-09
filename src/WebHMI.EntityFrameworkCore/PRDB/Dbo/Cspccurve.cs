using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Cspccurve
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public int Numpoint { get; set; }

    public double? Distpoint { get; set; }

    public double? Temp { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual Me1 Me1 { get; set; }
}
