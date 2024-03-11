using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CsReportSeries
{
    /// <summary>
    /// material identification
    /// </summary>
    public int MeId { get; set; }

    /// <summary>
    /// type of measured value: 1 - FM temp, 2 - CS temp, 3 - f4t, 4 - pressure
    /// </summary>
    public short MeasType { get; set; }

    /// <summary>
    /// index of meter
    /// </summary>
    public short MeterId { get; set; }

    /// <summary>
    /// number of the point
    /// </summary>
    public short PointNo { get; set; }

    /// <summary>
    /// Unit[m] possition in the strip [m]
    /// </summary>
    public double? Possition { get; set; }

    /// <summary>
    /// Unit[s] time at the location [s]
    /// </summary>
    public double? Time { get; set; }

    /// <summary>
    /// measured value
    /// </summary>
    public double? Value { get; set; }

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
