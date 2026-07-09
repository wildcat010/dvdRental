using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Cspcspeeddiag
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public int Phaseindex { get; set; }

    public double? Acceleration { get; set; }

    public double? Endposition { get; set; }

    public double? Endspeed { get; set; }

    public double? Startposition { get; set; }

    public double? Startspeed { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual Me1 Me1 { get; set; }
}
