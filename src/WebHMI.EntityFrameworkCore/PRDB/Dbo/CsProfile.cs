using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Material specific strategy Table with Effective (E), Manual (M) and original (X) lines for each material
/// </summary>
public partial class CsProfile
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

    public string Source { get; set; }

    public float? CoilTempProfileHead { get; set; }

    public float? CoilTempProfileTail { get; set; }

    /// <summary>
    /// description field
    /// </summary>
    public string Description { get; set; }

    public float? LengthProfileHead { get; set; }

    public float? LengthProfileHeadWedge { get; set; }

    public float? LengthProfileTail { get; set; }

    public float? LengthProfileTailWedge { get; set; }

    public float? LengthUncooledHead { get; set; }

    public float? LengthUncooledTail { get; set; }

    /// <summary>
    /// manual intervention in plan
    /// </summary>
    public short? ManInt { get; set; }

    /// <summary>
    /// Unit[0...999] plan number
    /// </summary>
    public int? PlanNo { get; set; }

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

    /// <summary>
    /// External material ID
    /// </summary>
    public string ToExtId { get; set; }

    public virtual Me1 Me1 { get; set; }
}
