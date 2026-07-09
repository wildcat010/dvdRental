using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Stddirfmpfcparappass
{
    public int Activeflag { get; set; }

    public int Passno { get; set; }

    public int Planno { get; set; }

    public string Description { get; set; }

    public double? Facdfbdfr { get; set; }

    public double? Facdfbdiu { get; set; }

    public double? Fbll { get; set; }

    public double? Fbul { get; set; }

    public double? Observedflat { get; set; }

    public double? Paircrossll { get; set; }

    public double? Paircrossul { get; set; }

    public string Planttype { get; set; }

    public double? Srll { get; set; }

    public double? Srul { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
