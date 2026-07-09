using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Calpade
{
    public int Curvetype { get; set; }

    public string Planttype { get; set; }

    public int Standno { get; set; }

    public double? Padea0 { get; set; }

    public double? Padea1 { get; set; }

    public double? Padea2 { get; set; }

    public double? Padeb1 { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
