using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Stddprampfm
{
    public int Activeflag { get; set; }

    public int Planno { get; set; }

    public int Rampno { get; set; }

    public int? Descrampauto { get; set; }

    public int? Descrampstate { get; set; }

    public double? Descrampvolume { get; set; }

    public string Description { get; set; }

    public int? Priodescaler { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
