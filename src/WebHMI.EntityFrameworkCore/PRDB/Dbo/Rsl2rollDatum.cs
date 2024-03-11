using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Rsl2rollDatum
{
    /// <summary>
    /// unique communication ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Unit[m] Actual diameter of first roll
    /// </summary>
    public float? Diameter1 { get; set; }

    /// <summary>
    /// Unit[m] Actual diameter of second roll
    /// </summary>
    public float? Diameter2 { get; set; }

    /// <summary>
    /// Flag: rolls have been ground (1=Y,0=N)
    /// </summary>
    public int? Grinding { get; set; }

    /// <summary>
    /// Unit[_C] Initial Temperature
    /// </summary>
    public float? InitTemp { get; set; }

    /// <summary>
    /// For BUR and WKR U: Upper L: Lower
    /// </summary>
    public string PlannedRollPos1 { get; set; }

    /// <summary>
    /// For BUR and WKR U: Upper L: Lower
    /// </summary>
    public string PlannedRollPos2 { get; set; }

    /// <summary>
    /// Here roll shop enters for which stand the roll is scheduled counting from 0 to (n-1), counting is done for each plant type separate
    /// </summary>
    public int? PlannedStandId { get; set; }

    /// <summary>
    /// Plant type:HRM / HFM
    /// </summary>
    public string PlantType { get; set; }

    /// <summary>
    /// Roll class (geometrical description) Neck, Taper etc.
    /// </summary>
    public int? RollClass { get; set; }

    /// <summary>
    /// Roll Id 1 (first own of the pair)
    /// </summary>
    public string RollId1 { get; set; }

    /// <summary>
    /// Roll Id 2 (second own of the pair)
    /// </summary>
    public string RollId2 { get; set; }

    /// <summary>
    /// Roll property class. (physical description) ce, density, etc
    /// </summary>
    public int? RollPropertyClass { get; set; }

    /// <summary>
    /// Roll type: WKR / BUR
    /// </summary>
    public string RollType { get; set; }

    /// <summary>
    /// Unit[m] surface roughness of roll
    /// </summary>
    public float? Roughness { get; set; }

    /// <summary>
    /// Code for the shape parametersShape coefficient
    /// </summary>
    public int? ShapeCode { get; set; }

    /// <summary>
    /// Unit[m] shimm plate thickness, only for backup rolls
    /// </summary>
    public int? Shimm { get; set; }

    /// <summary>
    /// Unit[N/m2] surface hardness of roll
    /// </summary>
    public int? SurfHard { get; set; }

    /// <summary>
    /// Type of surface treatment (e.g. by laser ,polished) sand blasted, etc.)
    /// </summary>
    public string Surface { get; set; }

    /// <summary>
    /// Handling of roll surface (bright=stonefinish or dull=textured)
    /// </summary>
    public string Texture { get; set; }

    /// <summary>
    /// Factor for wear model based on manufacturer
    /// </summary>
    public float? WearFacMan1 { get; set; }

    public float? WearFacMan2 { get; set; }

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
