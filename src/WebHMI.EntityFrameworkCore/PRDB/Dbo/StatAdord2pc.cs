using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StatAdOrd2Pc
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
    /// exit thickness
    /// </summary>
    public short? HExit { get; set; }

    /// <summary>
    /// profile
    /// </summary>
    public short? Profile { get; set; }

    /// <summary>
    /// exit width
    /// </summary>
    public short? WExit { get; set; }

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
