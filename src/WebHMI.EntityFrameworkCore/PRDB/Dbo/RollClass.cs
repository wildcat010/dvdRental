using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Roll class
/// </summary>
public partial class RollClass
{
    /// <summary>
    /// classification number of rolls with different class propreties (for CVC,UC,X2...) related to rolldata)
    /// </summary>
    public int RollClass1 { get; set; }

    /// <summary>
    /// Unit[m] only for edger rolls: diameter difference caliber
    /// </summary>
    public double? CaliberDiaDiff { get; set; }

    /// <summary>
    /// Unit[m] only for edger rolls: caliber length from passline
    /// </summary>
    public double? CaliberLength { get; set; }

    /// <summary>
    /// Unit[m] Checker roll: height of checker
    /// </summary>
    public float? CheckerHeight { get; set; }

    /// <summary>
    /// Flag for checker roll: 0 = normal roll     1 = checker roll
    /// </summary>
    public int? CheckerRoll { get; set; }

    /// <summary>
    /// Unit[m] roll neck diameter
    /// </summary>
    public double? DNeck { get; set; }

    /// <summary>
    /// desscription
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Unit[m] roll neck length
    /// </summary>
    public double? LNeck { get; set; }

    /// <summary>
    /// Unit[m] roll length
    /// </summary>
    public double? Length { get; set; }

    /// <summary>
    /// plant type
    /// </summary>
    public string PlantType { get; set; }

    /// <summary>
    /// type of roll (BUR; IMR; WKR)
    /// </summary>
    public string RollType { get; set; }

    /// <summary>
    /// Stand range (for selection of roll class from WIS)
    /// </summary>
    public string StandRange { get; set; }

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

    public virtual ICollection<RollDatum> RollData { get; set; } = new List<RollDatum>();
}
