using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class IntCcmMeasurement
{
    /// <summary>
    /// (PK) Unique id (from INT_SEND)
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// (PK) Measurement time
    /// </summary>
    public DateTime Time { get; set; }

    /// <summary>
    /// (PK) Measurement type:1 Sporadic Measurement  An entry is generated for each sporadic measurement    2 _Continuous MeasurementAn entry is generated every time the temperature changes for morethan 1_C while the measurement is within the valid range
    /// </summary>
    public int Type { get; set; }

    public string HeatNumber { get; set; }

    /// <summary>
    /// Speed(m/s)
    /// </summary>
    public float? Speed { get; set; }

    /// <summary>
    /// Unit[_C] 
    /// </summary>
    public int? Temperature { get; set; }

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
