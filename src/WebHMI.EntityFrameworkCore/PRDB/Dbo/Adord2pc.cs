using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class AdOrd2Pc
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
    /// thick head flag
    /// </summary>
    public short ThickHead { get; set; }

    /// <summary>
    /// Unit[m] exit thickness
    /// </summary>
    public double? HExit { get; set; }

    /// <summary>
    /// Unit[m] profile
    /// </summary>
    public double? Profile { get; set; }

    /// <summary>
    /// exit width
    /// </summary>
    public double? WExit { get; set; }

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
