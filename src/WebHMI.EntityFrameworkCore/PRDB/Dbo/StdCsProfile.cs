using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Standard strategy Table for APS plan
/// </summary>
public partial class StdCsProfile
{
    /// <summary>
    /// active flag
    /// </summary>
    public int ActiveFlag { get; set; }

    /// <summary>
    /// key for the compensation plan
    /// </summary>
    public int PlanNo { get; set; }

    public double? CoilTempProfileHead { get; set; }

    public double? CoilTempProfileTail { get; set; }

    /// <summary>
    /// description field
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// description field 2
    /// </summary>
    public string Description2 { get; set; }

    public double? LengthProfileHead { get; set; }

    public double? LengthProfileHeadWedge { get; set; }

    public double? LengthProfileTail { get; set; }

    public double? LengthProfileTailWedge { get; set; }

    public double? LengthUncooledHead { get; set; }

    public double? LengthUncooledTail { get; set; }

    /// <summary>
    /// modifying process
    /// </summary>
    public string Mop { get; set; }

    /// <summary>
    /// time of creation
    /// </summary>
    public DateTime? Toc { get; set; }

    /// <summary>
    /// time of modification
    /// </summary>
    public DateTime? Tom { get; set; }
}
