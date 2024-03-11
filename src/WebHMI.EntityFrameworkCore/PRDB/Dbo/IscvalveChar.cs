using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// ISC Valve characteristics
/// </summary>
public partial class IscvalveChar
{
    /// <summary>
    /// index of point of the curve flow = f(amplitude)
    /// </summary>
    public int PointIdx { get; set; }

    /// <summary>
    /// valve type index
    /// </summary>
    public int ValveType { get; set; }

    /// <summary>
    /// Unit[0, 1.0] relative amplitude for which the corresponding flow was measured
    /// </summary>
    public double? Amplitude { get; set; }

    /// <summary>
    /// Unit[0, 1.0] relative flow
    /// </summary>
    public double? Flow { get; set; }

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
