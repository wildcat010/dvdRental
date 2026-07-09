using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Rglppass
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public int Passno { get; set; }

    public string Source { get; set; }

    public string Description { get; set; }

    public int? Planno { get; set; }

    public double? Rollgapluboilflowbot { get; set; }

    public double? Rollgapluboilflowtop { get; set; }

    public double? Rollgaplubramptimestart { get; set; }

    public double? Rollgaplubramptimestop { get; set; }

    public double? Rollgaplubsensitivity { get; set; }

    public int? Rollgaplubstate { get; set; }

    public double? Rollgaplubswitchlength { get; set; }

    public double? Rollgaplubswitchlengthtail { get; set; }

    public double? Rollgaplubwaterflow { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual Me1 Me1 { get; set; }
}
