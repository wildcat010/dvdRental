using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Stdpcramp
{
    public int Activeflag { get; set; }

    public int Planno { get; set; }

    public int Rampno { get; set; }

    public string Description { get; set; }

    public int? Pcrampauto { get; set; }

    public int? Pcrampstate { get; set; }

    public double? Pcrampvolume { get; set; }

    public int? Priopowerc { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
