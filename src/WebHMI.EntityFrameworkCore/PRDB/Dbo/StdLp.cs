using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Stdlp
{
    public int Activeflag { get; set; }

    public int Planno { get; set; }

    public string Description { get; set; }

    public double? Factorthickhead { get; set; }

    public double? Factorthicktail { get; set; }

    public double? Maxspeed { get; set; }

    public double? Offsettimespeedup { get; set; }

    public double? Powerspeedup { get; set; }

    public int? Powerspeedupstate { get; set; }

    public double? Reddisthrmhfm { get; set; }

    public double? Rollspeed { get; set; }

    public double? Speedbeforeredstand1 { get; set; }

    public double? Speedup { get; set; }

    public int? Speedupstate { get; set; }

    public int? Statspeedup { get; set; }

    public int? Thickhead { get; set; }

    public int? Thicktail { get; set; }

    public double? Threadspeed { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
