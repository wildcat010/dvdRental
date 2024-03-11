using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CsProtSimilar
{
    public int MeId { get; set; }

    /// <summary>
    /// from: 3.Similar strip
    /// </summary>
    public int MeIdSim { get; set; }

    /// <summary>
    /// inheritance segment
    /// </summary>
    public int Seg { get; set; }

    /// <summary>
    /// distance of similarity
    /// </summary>
    public float? Dist { get; set; }

    /// <summary>
    /// weight for similar strips
    /// </summary>
    public float? Weight { get; set; }

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
