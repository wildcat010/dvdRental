using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// pade curve for stand spring
/// </summary>
public partial class CalPade
{
    /// <summary>
    /// curve type&gt; 0 - total curve, 1 -frame curve
    /// </summary>
    public int CurveType { get; set; }

    /// <summary>
    /// plant type (HRM, HFM, ...)
    /// </summary>
    public string PlantType { get; set; }

    /// <summary>
    /// [0|1|2|3|4] physical stand number
    /// </summary>
    public int StandNo { get; set; }

    /// <summary>
    /// Pade curve parameter A0
    /// </summary>
    public double? PadeA0 { get; set; }

    /// <summary>
    /// Pade curve parameter A1
    /// </summary>
    public double? PadeA1 { get; set; }

    /// <summary>
    /// Pade curve parameter A2
    /// </summary>
    public double? PadeA2 { get; set; }

    /// <summary>
    /// Pade curve parameter B1
    /// </summary>
    public double? PadeB1 { get; set; }

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
