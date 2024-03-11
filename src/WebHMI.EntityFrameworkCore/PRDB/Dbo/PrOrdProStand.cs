using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class PrOrdProStand
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
    /// Owner
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// stand number
    /// </summary>
    public short StandId { get; set; }

    /// <summary>
    /// Coolant between stands flag. 1: not used, 2: used
    /// </summary>
    public int? CoolantFlag { get; set; }

    /// <summary>
    /// actual bending force
    /// </summary>
    public float? Fb { get; set; }

    /// <summary>
    /// actual rolling force
    /// </summary>
    public float? Fr { get; set; }

    /// <summary>
    /// Unit[N/m2] tension behind the stand
    /// </summary>
    public float? Tension { get; set; }

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
