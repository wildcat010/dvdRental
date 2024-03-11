using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class SequenceStartEnd
{
    /// <summary>
    /// counter
    /// </summary>
    public short Counter { get; set; }

    /// <summary>
    /// time of action
    /// </summary>
    public DateTime RecTime { get; set; }

    /// <summary>
    /// heat identificaion
    /// </summary>
    public string HeatId { get; set; }

    /// <summary>
    /// heat treatment number
    /// </summary>
    public int? HeatTreatmentNo { get; set; }

    /// <summary>
    /// Unit[m] thickness of mold for dummy
    /// </summary>
    public float? MoldThickness { get; set; }

    /// <summary>
    /// Unit[m] width of mold for dummy
    /// </summary>
    public float? MoldWidth { get; set; }

    /// <summary>
    /// sequence identification
    /// </summary>
    public string SequenceId { get; set; }

    /// <summary>
    /// sequence number (increments with every start of cast)
    /// </summary>
    public int? SequenceNumber { get; set; }

    /// <summary>
    /// 1 - sequence start,  0  - sequence end
    /// </summary>
    public short? SequenceStart { get; set; }

    /// <summary>
    /// Unit[m] caster exit thickness ( cold at transfer to mill)
    /// </summary>
    public float? Thickness { get; set; }

    /// <summary>
    /// Unit[m] cold width
    /// </summary>
    public float? Width { get; set; }

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
