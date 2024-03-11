using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Standard Power Cooling plan
/// </summary>
public partial class StdPc
{
    /// <summary>
    /// active flag
    /// </summary>
    public int ActiveFlag { get; set; }

    /// <summary>
    /// Unit[0...999] pc p number
    /// </summary>
    public int PlanNo { get; set; }

    /// <summary>
    /// Unit[m] delay length for pc switch ON
    /// </summary>
    public float? DelayLength { get; set; }

    /// <summary>
    /// Unit[0.... 2] number of pc ramps
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
