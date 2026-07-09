using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Stdcsperf
{
    public int Activeflag { get; set; }

    public int Planno { get; set; }

    public string Description { get; set; }

    public string Description2 { get; set; }

    public double? Performatorcontrolratio { get; set; }

    public double? Performatordistancetoapply { get; set; }

    public short? Performatorenable { get; set; }

    public short? Performatorenableforf4tcooling { get; set; }

    public short? Performatormanualno { get; set; }

    public double? Performatormaxlimit { get; set; }

    public double? Performatorminlimit { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
