using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Dphrm
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
    /// owner
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// Unit[m] delay length for descaler switch ON
    /// </summary>
    public float? DelayLength { get; set; }

    /// <summary>
    /// Unit[0.... 2] number of descaler ramps
    /// </summary>
    public int? NoRamps { get; set; }

    /// <summary>
    /// Unit[0...999] d p number
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

    public virtual Me1 Me1 { get; set; }
}
