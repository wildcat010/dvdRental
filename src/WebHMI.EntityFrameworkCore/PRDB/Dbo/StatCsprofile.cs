using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Material specific strategy Table with Effective (E), Manual (M) and original (X) lines for each material
/// </summary>
public partial class StatCsProfile
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

    public short? CoilTempProfileHead { get; set; }

    public short? CoilTempProfileTail { get; set; }

    /// <summary>
    /// description field
    /// </summary>
    public short? Description { get; set; }

    public short? LengthProfileHead { get; set; }

    public short? LengthProfileHeadWedge { get; set; }

    public short? LengthProfileTail { get; set; }

    public short? LengthProfileTailWedge { get; set; }

    public short? LengthUncooledHead { get; set; }

    public short? LengthUncooledTail { get; set; }

    /// <summary>
    /// manual intervention in plan
    /// </summary>
    public short? ManInt { get; set; }

    /// <summary>
    /// plan number
    /// </summary>
    public short? PlanNo { get; set; }

    /// <summary>
    /// External material ID
    /// </summary>
    public string ToExtId { get; set; }

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
