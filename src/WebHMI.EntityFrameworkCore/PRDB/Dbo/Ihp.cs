using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Ihp
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

    public int? PlanNo { get; set; }

    /// <summary>
    /// Unit[m] target temperature to IH
    /// </summary>
    public float? Temperature { get; set; }

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
    /// description field
    /// </summary>
    public string Description { get; set; }

    public virtual Me1 Me1 { get; set; }
}
