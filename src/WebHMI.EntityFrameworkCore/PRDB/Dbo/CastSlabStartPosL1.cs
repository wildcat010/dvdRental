using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CastSlabStartPosL1
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
    /// external material identification
    /// </summary>
    public string ExtId { get; set; }

    public string HeatId { get; set; }

    /// <summary>
    /// Unit[m] casted width at startPos
    /// </summary>
    public float? MoldWidth { get; set; }

    public string SequenceId { get; set; }

    /// <summary>
    /// Unit[m] start position of slab in cast
    /// </summary>
    public float? StartPos { get; set; }

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
