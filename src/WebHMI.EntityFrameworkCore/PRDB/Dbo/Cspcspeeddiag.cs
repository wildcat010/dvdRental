using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CsPcSpeedDiag
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
    /// index of the point in the curve (starts with 0)
    /// </summary>
    public int PhaseIndex { get; set; }

    /// <summary>
    /// phase acceleration
    /// </summary>
    public double? Acceleration { get; set; }

    /// <summary>
    /// phase end position (ril)
    /// </summary>
    public double? EndPosition { get; set; }

    /// <summary>
    /// phase end speed [m/s]
    /// </summary>
    public double? EndSpeed { get; set; }

    /// <summary>
    /// phase start position (ril)
    /// </summary>
    public double? StartPosition { get; set; }

    /// <summary>
    /// phase start speed [m/s]
    /// </summary>
    public double? StartSpeed { get; set; }

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
