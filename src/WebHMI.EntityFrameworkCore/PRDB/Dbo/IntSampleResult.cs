using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class IntSampleResult
{
    /// <summary>
    /// (PK) Unique id (from INT_SEND)
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Heat number
    /// </summary>
    public string HeatNumber { get; set; }

    /// <summary>
    /// Starts with 1 for first sample on a place
    /// </summary>
    public short SampleNumber { get; set; }

    /// <summary>
    /// BOF, RH, LF, CCM
    /// </summary>
    public string SamplePlace { get; set; }

    /// <summary>
    /// 01, 02
    /// </summary>
    public short SamplePlaceNumber { get; set; }

    /// <summary>
    /// Timestamp when the sample processing was finished in the laboratory (time when LAB released the sample result).
    /// </summary>
    public DateTime? SampleReleaseTime { get; set; }

    /// <summary>
    /// Time when sample was taken at the plant.
    /// </summary>
    public DateTime SampleTakenTime { get; set; }

    /// <summary>
    /// 1 _ Steel, 2 _ Slag
    /// </summary>
    public short SampleType { get; set; }

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
