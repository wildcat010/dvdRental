using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Stdrglppass
{
    public int Activeflag { get; set; }

    public int Passno { get; set; }

    public int Planno { get; set; }

    public string Description { get; set; }

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
}
