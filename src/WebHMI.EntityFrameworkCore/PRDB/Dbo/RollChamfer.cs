using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Roll chamfer
/// </summary>
public partial class RollChamfer
{
    /// <summary>
    /// Classification number of rolls with different class chamfer related to rolldata)
    /// </summary>
    public int RollChamferClass { get; set; }

    /// <summary>
    /// Unit[m] Distance from roll neck to cone (drive side)
    /// </summary>
    public double? ConeDistDs { get; set; }

    /// <summary>
    /// Unit[m] Distance from roll neck to cone (operator side)
    /// </summary>
    public double? ConeDistOs { get; set; }

    /// <summary>
    /// Unit[m] Diameter decrease at roll edge (drive side)
    /// </summary>
    public double? ConeHeightDs { get; set; }

    /// <summary>
    /// Unit[m] Diameter decrease at roll edge (operators side)
    /// </summary>
    public double? ConeHeightOs { get; set; }

    /// <summary>
    /// Unit[m] Cone length (drive side)
    /// </summary>
    public double? ConeLengthDs { get; set; }

    /// <summary>
    /// Unit[m] Cone length (operators side)
    /// </summary>
    public double? ConeLengthOs { get; set; }

    /// <summary>
    /// Typ cone 1-linear, 2-quadratic, 5-taper, 7 - biquadratic, 8 - quadraticlinear
    /// </summary>
    public int? ConeType { get; set; }

    /// <summary>
    /// Desscription
    /// </summary>
    public string Description { get; set; }

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

    /// <summary>
    /// Unit[m] Distance from roll neck to cone (operator side)
    /// </summary>
    public double? ConeRadiusOs { get; set; }

    /// <summary>
    /// Unit[m] Distance from roll neck to cone (drive side)
    /// </summary>
    public double? ConeRadiusDs { get; set; }
}
