using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class MaterialBreak
{
    /// <summary>
    /// Material owner
    /// </summary>
    public string MeCreator { get; set; }

    /// <summary>
    /// Material ID
    /// </summary>
    public int MeId { get; set; }

    /// <summary>
    /// Unit[Unit] Position in broken material
    /// </summary>
    public int PosInOldMe { get; set; }

    /// <summary>
    /// Unit[Unit] Time of dividing
    /// </summary>
    public DateTime? BreakageTime { get; set; }

    /// <summary>
    /// First break flag  0 = no further breakages 1 = further breakages
    /// </summary>
    public short? LookBack { get; set; }

    /// <summary>
    /// Unit[Unit] Owner of divided part
    /// </summary>
    public string NewMeCreator { get; set; }

    /// <summary>
    /// Unit[Unit] New Material ID
    /// </summary>
    public int? NewMeId { get; set; }

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
