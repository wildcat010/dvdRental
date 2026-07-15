using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Tp
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
    /// Unit[N/m2] coiler Tension
    /// </summary>
    public double? CoilerTension { get; set; }

    /// <summary>
    /// Unit[N/m2] decoiler tension
    /// </summary>
    public double? DecoilerTension { get; set; }

    /// <summary>
    /// description field
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Unit[0...999] t p number
    /// </summary>
    public int? PlanNo { get; set; }

    /// <summary>
    /// Unit[N/m2] yield stress
    /// </summary>
    public double? YieldStress { get; set; }

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
