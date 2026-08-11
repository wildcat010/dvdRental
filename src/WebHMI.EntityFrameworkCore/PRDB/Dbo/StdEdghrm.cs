using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StdEdghrm
{
    public int ActiveFlag { get; set; }

    public int PlanNo { get; set; }

    public string Description { get; set; }

    public double? Dw { get; set; }

    public int? EdgMode { get; set; }

    public int? EdgerActive { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
