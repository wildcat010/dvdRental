using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Standard tension plan pass
/// </summary>
public partial class StdTppass
{
    /// <summary>
    /// active flag
    /// </summary>
    public int ActiveFlag { get; set; }

    /// <summary>
    /// pass number
    /// </summary>
    public int PassNo { get; set; }

    /// <summary>
    /// Unit[0...999] t p number
    /// </summary>
    public int PlanNo { get; set; }

    /// <summary>
    /// description field
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Unit[deg] looper angle
    /// </summary>
    public double? LooperAngle { get; set; }

    /// <summary>
    /// Unit[0 ...x] looper mode: 0=constant torque, 1=constant tension
    /// </summary>
    public int? LooperMode { get; set; }

    /// <summary>
    /// Unit[m] looper strip len
    /// </summary>
    public double? LooperStripLen { get; set; }

    /// <summary>
    /// Unit[N/m2] specific forward tension
    /// </summary>
    public double? SpecifFoTension { get; set; }

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
