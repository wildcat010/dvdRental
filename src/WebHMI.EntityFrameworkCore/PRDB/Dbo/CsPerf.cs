using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Csperf
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public string Source { get; set; }

    public string Description { get; set; }

    public short? Manint { get; set; }

    public double? Performatorcontrolratio { get; set; }

    public double? Performatordistancetoapply { get; set; }

    public short? Performatorenable { get; set; }

    public short? Performatorenableforf4tcooling { get; set; }

    public short? Performatormanualno { get; set; }

    public double? Performatormaxlimit { get; set; }

    public double? Performatorminlimit { get; set; }

    public int? Planno { get; set; }

    public string Toextid { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual Me1 Me1 { get; set; }
}
