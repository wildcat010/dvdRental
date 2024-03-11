using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CsMe
{
    /// <summary>
    /// creator of material
    /// </summary>
    public string MeCreator { get; set; }

    /// <summary>
    /// material identification
    /// </summary>
    public int MeId { get; set; }

    /// <summary>
    /// Basis Id of material
    /// </summary>
    public short? BasId { get; set; }

    /// <summary>
    /// external material identification
    /// </summary>
    public string ExtId { get; set; }

    /// <summary>
    /// type of material
    /// </summary>
    public string MeTyp { get; set; }

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
}
