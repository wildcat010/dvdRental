using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Standard descaler plan HRM
/// </summary>
public partial class StdDphrm
{
    /// <summary>
    /// active flag
    /// </summary>
    public int ActiveFlag { get; set; }

    /// <summary>
    /// Unit[0...999] d p number
    /// </summary>
    public int PlanNo { get; set; }

    /// <summary>
    /// Unit[m] delay length for descaler switch ON
    /// </summary>
    public float? DelayLength { get; set; }

    /// <summary>
    /// Unit[0.... 2] number of descaler ramps
    /// </summary>
    public int? NoRamps { get; set; }

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
