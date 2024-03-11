using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CsPcResult
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
    /// Precalculated valves on bottom
    /// </summary>
    public string VPrecalcBot { get; set; }

    /// <summary>
    /// Precalculated fm valves
    /// </summary>
    public string VPrecalcFm { get; set; }

    /// <summary>
    /// Precalculated valves on top
    /// </summary>
    public string VPrecalcTop { get; set; }

    /// <summary>
    /// [m3/h] expected total wateramount calculated for body target temperature
    /// </summary>
    public double? WaterAmount { get; set; }

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
