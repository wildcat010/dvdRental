using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class MillCasSegmentDatum
{
    /// <summary>
    /// Unique communication ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// ????? Marked characters on coil
    /// </summary>
    public string CoilMarkingString { get; set; }

    /// <summary>
    /// Coil ID (external ID)
    /// </summary>
    public string CoilName { get; set; }

    /// <summary>
    /// Running number of coil within heat
    /// </summary>
    public int? CoilNo { get; set; }

    /// <summary>
    /// Unit[kg] Coil weight
    /// </summary>
    public float? CoilWeight { get; set; }

    /// <summary>
    /// Coiler no
    /// </summary>
    public int? CoilerNo { get; set; }

    /// <summary>
    /// 0 = endless mode  1 = batch mode
    /// </summary>
    public int? EndlessBatch { get; set; }

    /// <summary>
    /// Heat identification
    /// </summary>
    public string HeatId { get; set; }

    /// <summary>
    /// Treatment number of the heat
    /// </summary>
    public int? HeatTreatmentNo { get; set; }

    /// <summary>
    /// Unit[m] Planned thickness rolled (cold value form primary data)
    /// </summary>
    public float? PlannedThickness { get; set; }

    /// <summary>
    /// Unit[m] Planned width rolled (cold value from primary data )
    /// </summary>
    public float? PlannedWidth { get; set; }

    /// <summary>
    /// Number of segments
    /// </summary>
    public int? Segments { get; set; }

    /// <summary>
    /// Unit[m] End position of the coil in the sequence (cast elngth)
    /// </summary>
    public float? SeqEndPositionCaster { get; set; }

    /// <summary>
    /// Unit[m] End position of the coil in the sequence (rolled length)
    /// </summary>
    public float? SeqEndPositionMill { get; set; }

    /// <summary>
    /// Unit[m] Start position of the coil in the sequence (cast length)
    /// </summary>
    public float? SeqStartPositionCaster { get; set; }

    /// <summary>
    /// Unit[m] Start position of the coil in the sequence (rolled length)
    /// </summary>
    public float? SeqStartPositionMill { get; set; }

    /// <summary>
    /// Sequence identification
    /// </summary>
    public string SequenceId { get; set; }

    /// <summary>
    /// Sequence number
    /// </summary>
    public int? SequenceNumber { get; set; }

    /// <summary>
    /// slabId
    /// </summary>
    public string SlabId { get; set; }

    /// <summary>
    /// Steel grade
    /// </summary>
    public string SteelGrade { get; set; }

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
