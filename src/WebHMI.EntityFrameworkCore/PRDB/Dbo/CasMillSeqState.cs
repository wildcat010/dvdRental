using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CasMillSeqState
{
    /// <summary>
    /// unique communication ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// heat identification
    /// </summary>
    public string HeatId { get; set; }

    /// <summary>
    /// treatment number of the heat
    /// </summary>
    public int? HeatTreatmentNo { get; set; }

    /// <summary>
    /// Unit[m] thickness of mold
    /// </summary>
    public float? MoldThickness { get; set; }

    /// <summary>
    /// Unit[m] width of mold
    /// </summary>
    public float? MoldWidth { get; set; }

    /// <summary>
    /// sequence identification (plan number)
    /// </summary>
    public string SequenceId { get; set; }

    /// <summary>
    /// sequence number (increments with every start of cast)
    /// </summary>
    public int? SequenceNumber { get; set; }

    /// <summary>
    /// 1=sequence start, 0=sequence end
    /// </summary>
    public int? SequenceStart { get; set; }

    /// <summary>
    /// Unit[m] caster exit thickness (cold at transfer to mill)
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
