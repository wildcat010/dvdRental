using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class L2rsrollDatum
{
    /// <summary>
    /// unique communication ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Cause for roll change (0: regularly scheduled change)
    /// </summary>
    public int? ChangeCause { get; set; }

    /// <summary>
    /// Unit[m] diameter new lower roll
    /// </summary>
    public float? DiameterLo { get; set; }

    /// <summary>
    /// Unit[m] diameter new upper roll
    /// </summary>
    public float? DiameterUp { get; set; }

    /// <summary>
    /// Roll Id lower dismounted roll
    /// </summary>
    public string DismRollIdLo { get; set; }

    /// <summary>
    /// Rollid upper dismounted roll
    /// </summary>
    public string DismRollIdUp { get; set; }

    /// <summary>
    /// Time of dismounting
    /// </summary>
    public DateTime? DismountTime { get; set; }

    /// <summary>
    /// ID of new lower roll
    /// </summary>
    public string MountRollIdLo { get; set; }

    /// <summary>
    /// ID of new upper roll
    /// </summary>
    public string MountRollIdUp { get; set; }

    /// <summary>
    /// Time of mounting
    /// </summary>
    public DateTime? MountTime { get; set; }

    /// <summary>
    /// Unit[s] (dismounting time - mount time)
    /// </summary>
    public float? RollPrTimeLo { get; set; }

    /// <summary>
    /// Unit[s] (dismounting time - mount time)
    /// </summary>
    public float? RollPrTimeUp { get; set; }

    /// <summary>
    /// Roll type (BUR,WKR)
    /// </summary>
    public string RollType { get; set; }

    /// <summary>
    /// Unit[m] Rolled length
    /// </summary>
    public float? RolledLengthLo { get; set; }

    /// <summary>
    /// Unit[m] Rolled length
    /// </summary>
    public float? RolledLengthUp { get; set; }

    /// <summary>
    /// Unit[kg] Rolled weight
    /// </summary>
    public float? RolledWeightLo { get; set; }

    /// <summary>
    /// Unit[kg] Rolled weight
    /// </summary>
    public float? RolledWeightUp { get; set; }

    /// <summary>
    /// Number of stand (0..n)
    /// </summary>
    public int? StandId { get; set; }

    /// <summary>
    /// (Bit coded warnings, details to be specified)
    /// </summary>
    public int? TemperatureWarning { get; set; }

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
