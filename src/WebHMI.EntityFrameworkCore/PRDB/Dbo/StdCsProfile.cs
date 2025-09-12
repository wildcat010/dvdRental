using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StdCsProfile
{
    public int ActiveFlag { get; set; }

    public int PlanNo { get; set; }

    public double? CoilTempProfileHead { get; set; }

    public double? CoilTempProfileTail { get; set; }

    public string Description { get; set; }

    public string Description2 { get; set; }

    public double? LengthProfileHead { get; set; }

    public double? LengthProfileHeadWedge { get; set; }

    public double? LengthProfileTail { get; set; }

    public double? LengthProfileTailWedge { get; set; }

    public double? LengthUncooledHead { get; set; }

    public double? LengthUncooledTail { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
