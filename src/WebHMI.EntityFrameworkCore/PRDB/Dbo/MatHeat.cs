using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class MatHeat
{
    /// <summary>
    /// counter of the segments for this material
    /// </summary>
    public short Counter { get; set; }

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
    /// heat identification
    /// </summary>
    public string HeatId { get; set; }

    /// <summary>
    /// Unit[m] position of material in the sequence
    /// </summary>
    public float? Position { get; set; }

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
