using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class InspCut
{
    /// <summary>
    /// cut time
    /// </summary>
    public DateTime CutTime { get; set; }

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
    /// Unit[m] inspection material length
    /// </summary>
    public float CutLength { get; set; }

    /// <summary>
    /// cut position 
    /// </summary>
    public string CutPos { get; set; }

    /// <summary>
    /// Unit[m] start of inspection cut
    /// </summary>
    public float CutStart { get; set; }

    /// <summary>
    /// Start position of the cut in material
    /// </summary>
    public float? CutStartPos { get; set; }

    /// <summary>
    /// working level identification
    /// </summary>
    public short WorklevelId { get; set; }

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
