using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CsReportStatistic
{
    /// <summary>
    /// calculated segment
    /// </summary>
    public short Segment { get; set; }

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
    /// calculated average
    /// </summary>
    public double? Average { get; set; }

    /// <summary>
    /// number of calculated items
    /// </summary>
    public int? Items { get; set; }

    /// <summary>
    /// calculated maximum value
    /// </summary>
    public double? Maximum { get; set; }

    /// <summary>
    /// calculated minimum value
    /// </summary>
    public double? Minimum { get; set; }

    /// <summary>
    /// setpoint or target value
    /// </summary>
    public double? Setpoint { get; set; }

    /// <summary>
    /// Maximum limit of target value
    /// </summary>
    public double? SetpointMax { get; set; }

    /// <summary>
    /// Minimum limit of target value
    /// </summary>
    public double? SetpointMin { get; set; }

    /// <summary>
    /// end possition in strip
    /// </summary>
    public double? PosEnd { get; set; }

    /// <summary>
    /// start possition in strip
    /// </summary>
    public double? PosStart { get; set; }

    /// <summary>
    /// calculated pqe
    /// </summary>
    public double? Pqe { get; set; }

    /// <summary>
    /// calculated quality
    /// </summary>
    public double? Qty { get; set; }

    /// <summary>
    /// calculated one sigma
    /// </summary>
    public double? SigmaOne { get; set; }

    /// <summary>
    /// calculated two sigma
    /// </summary>
    public double? SigmaTwo { get; set; }

    /// <summary>
    /// calculated standard deviation
    /// </summary>
    public double? StdDeviation { get; set; }

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
