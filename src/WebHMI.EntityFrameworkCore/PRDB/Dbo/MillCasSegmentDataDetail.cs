using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class MillCasSegmentDataDetail
{
    /// <summary>
    /// Unique communication ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Measured value name
    /// </summary>
    public string MeasurmentName { get; set; }

    /// <summary>
    /// Running number of segment in coil
    /// </summary>
    public int SegmentNo { get; set; }

    /// <summary>
    /// Average of measured values
    /// </summary>
    public float? AvgValue { get; set; }

    /// <summary>
    /// Maximum of measured values
    /// </summary>
    public float? MaxValue { get; set; }

    /// <summary>
    /// Minimum of measured values
    /// </summary>
    public float? MinValue { get; set; }

    /// <summary>
    /// Sigma of measured values
    /// </summary>
    public float? SigmaValue { get; set; }

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
