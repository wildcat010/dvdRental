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

    public float? CoilTempProfileHead { get; set; }

    public float? CoilTempProfileTail { get; set; }

    /// <summary>
    /// description field
    /// </summary>
    public string Description { get; set; }

    public float? LengthProfileHead { get; set; }

    public float? LengthProfileHeadWedge { get; set; }

    public float? LengthProfileTail { get; set; }

    public float? LengthProfileTailWedge { get; set; }

    public float? LengthUncooledHead { get; set; }

    public float? LengthUncooledTail { get; set; }

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
