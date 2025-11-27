using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Standard tension plan
/// </summary>
public partial class StdTp
{
    /// <summary>
    /// active flag
    /// </summary>
    public int ActiveFlag { get; set; }

    /// <summary>
    /// Unit[0...999] t p number
    /// </summary>
    public int PlanNo { get; set; }

    /// <summary>
    /// Unit[N/m2] coiler Tension
    /// </summary>
    public double? CoilerTension { get; set; }

    /// <summary>
    /// Unit[N/m2] decoiler tension
    /// </summary>
    public double? DecoilerTension { get; set; }

    /// <summary>
    /// status coiler tension
    /// </summary>
    public int? StatCoilerTension { get; set; }

    /// <summary>
    /// status decoiler tension
    /// </summary>
    public int? StatDecoilerTension { get; set; }

    /// <summary>
    /// Unit[N/m2] yield stress
    /// </summary>
    public double? YieldStress { get; set; }

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

    /// <summary>
    /// description field
    /// </summary>
    public string Description { get; set; }
}
