using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Qemea
{
    /// <summary>
    /// Material owner
    /// </summary>
    public string MeCreator { get; set; }

    /// <summary>
    /// Material idendification number
    /// </summary>
    public int MeId { get; set; }

    /// <summary>
    /// Line status
    /// </summary>
    public short MesId { get; set; }

    /// <summary>
    /// Marked characters on coil
    /// </summary>
    public string CoilMarkingString { get; set; }

    /// <summary>
    /// coil ID
    /// </summary>
    public string CoilName { get; set; }

    /// <summary>
    /// Running number of coil within heat
    /// </summary>
    public int? CoilNo { get; set; }

    /// <summary>
    /// Unit[kg] Measured coil weight
    /// </summary>
    public float? CoilWeight { get; set; }

    /// <summary>
    /// Coiler no
    /// </summary>
    public int? CoilerNo { get; set; }

    /// <summary>
    /// 0: endless mode  1: batch mode
    /// </summary>
    public int? EndlessBatch { get; set; }

    /// <summary>
    /// heat identification
    /// </summary>
    public string HeatId { get; set; }

    /// <summary>
    /// treatment number of the heat
    /// </summary>
    public short? HeatTreatmentNo { get; set; }

    /// <summary>
    /// Unit[m] planned thickness rolled (cold value form primary data)
    /// </summary>
    public float? PlannedThickness { get; set; }

    /// <summary>
    /// Unit[m] planned width rolled (cold value from primary data )
    /// </summary>
    public float? PlannedWidth { get; set; }

    /// <summary>
    /// Number of segments
    /// </summary>
    public int? Segments { get; set; }

    /// <summary>
    /// Unit[m] End position of the coil in the sequence (cast length)
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
    /// sequence identification (plan number)
    /// </summary>
    public string SequenceId { get; set; }

    /// <summary>
    /// sequence number (increments with every start cast)
    /// </summary>
    public int? SequenceNumber { get; set; }

    /// <summary>
    /// steel grade
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

    public virtual Me1 Me1 { get; set; }
}
