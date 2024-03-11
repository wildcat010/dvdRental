using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class MillCasCutInfo
{
    /// <summary>
    /// unique communication ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Unit[m] cut position in sequence (cast length)
    /// </summary>
    public float? CutPosition { get; set; }

    /// <summary>
    /// 0 = head cut, 1 = product cut, 2 = scrap cut
    /// </summary>
    public int? CutReason { get; set; }

    /// <summary>
    /// heatId
    /// </summary>
    public string HeatId { get; set; }

    /// <summary>
    /// Virtual slab ID (of the piece following the cut)
    /// </summary>
    public string L3SlabId { get; set; }

    /// <summary>
    /// 0 = strip, 1 = plate
    /// </summary>
    public int? PlateProduction { get; set; }

    /// <summary>
    /// sequence identification (plan number)
    /// </summary>
    public string SequenceId { get; set; }

    /// <summary>
    /// shear identification
    /// </summary>
    public int? ShearId { get; set; }

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
