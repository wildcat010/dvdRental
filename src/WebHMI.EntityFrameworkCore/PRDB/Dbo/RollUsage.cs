using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Roll history
/// </summary>
public partial class RollUsage
{
    /// <summary>
    /// installation counter
    /// </summary>
    public int InstallCt { get; set; }

    /// <summary>
    /// roll ID
    /// </summary>
    public string RollId { get; set; }

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
    /// diameter
    /// </summary>
    public float? Diameter { get; set; }

    /// <summary>
    /// dismount time (historic)
    /// </summary>
    public DateTime? DismountTime { get; set; }

    /// <summary>
    /// Strip Id of the first strip after roll change
    /// </summary>
    public string FirstStripId { get; set; }

    /// <summary>
    /// number of ghost strips
    /// </summary>
    public int? GhostStrips { get; set; }

    /// <summary>
    /// indicates is freshly ground (1=Yes, 0=No)
    /// </summary>
    public int? GrindingFlag { get; set; }

    /// <summary>
    /// Strip Id of the last strip before roll change
    /// </summary>
    public string LastStripId { get; set; }

    /// <summary>
    /// mount time (historic)
    /// </summary>
    public DateTime? MountTime { get; set; }

    /// <summary>
    /// plant type (HRM, HFM)
    /// </summary>
    public string PlantType { get; set; }

    /// <summary>
    /// notes, comment by operator
    /// </summary>
    public string Remarks { get; set; }

    /// <summary>
    /// remove reason
    /// </summary>
    public int? RemoveReason { get; set; }

    /// <summary>
    /// Code for the chamfer parameters
    /// </summary>
    public short? RollChamferCode { get; set; }

    /// <summary>
    /// Unit[N] maximum roll force for all passes
    /// </summary>
    public float? RollForceMax { get; set; }

    /// <summary>
    /// Unit[N] mean roll force for all passes
    /// </summary>
    public float? RollForceMean { get; set; }

    /// <summary>
    /// roll position (u=upper, l= lower, r=right, l=left (edger))
    /// </summary>
    public string RollPos { get; set; }

    /// <summary>
    /// Code for the shape parameters
    /// </summary>
    public short? RollShapeCode { get; set; }

    /// <summary>
    /// type of roll (BUR, IMR, WKR, EWR)
    /// </summary>
    public string RollType { get; set; }

    /// <summary>
    /// Unit[m] rolled length
    /// </summary>
    public float? RolledLength { get; set; }

    /// <summary>
    /// number of rolled slabs
    /// </summary>
    public int? RolledStrips { get; set; }

    /// <summary>
    /// Unit[s] rolled time
    /// </summary>
    public float? RolledTime { get; set; }

    /// <summary>
    /// Unit[kg] rolled tons
    /// </summary>
    public float? RolledWeight { get; set; }

    /// <summary>
    /// Shape type ( 1 CVC | 2 smart crown | 3 cosine)
    /// </summary>
    public int? ShapeType { get; set; }

    /// <summary>
    /// Shape coefficient x(exp1) - diameter related and normelized -1 to 1
    /// </summary>
    public float? ShapeX1 { get; set; }

    /// <summary>
    /// Unit[1/m] Shape coefficient x(exp2) - diameter related and normelized -1 to 1
    /// </summary>
    public float? ShapeX2 { get; set; }

    /// <summary>
    /// Unit[1/m2] Shape coefficient x(exp3) - diameter related and normelized -1 to 1
    /// </summary>
    public float? ShapeX3 { get; set; }

    /// <summary>
    /// Unit[1/m3] Shape coefficient x(exp4) - diameter related and normelized -1 to 1
    /// </summary>
    public float? ShapeX4 { get; set; }

    /// <summary>
    /// Unit[1/m4] Shape coefficient x(exp5) - diameter related and normelized -1 to 1
    /// </summary>
    public float? ShapeX5 { get; set; }

    /// <summary>
    /// Unit[1/m5] Shape coefficient x(exp6) - diameter related and normelized -1 to 1
    /// </summary>
    public float? ShapeX6 { get; set; }

    /// <summary>
    /// Unit[1/m6] Shape coefficient x(exp7) - diameter related and normelized -1 to 1
    /// </summary>
    public float? ShapeX7 { get; set; }

    /// <summary>
    /// Unit[1/m7] Shape coefficient x(exp8) - diameter related and normelized -1 to 1
    /// </summary>
    public float? ShapeX8 { get; set; }

    /// <summary>
    /// Unit[1/m8] Shape coefficient x(exp9) - diameter related and normelized -1 to 1
    /// </summary>
    public float? ShapeX9 { get; set; }

    /// <summary>
    /// stand number
    /// </summary>
    public short? StandId { get; set; }

    /// <summary>
    /// Unit[m] thermal crown
    /// </summary>
    public float? TCrown { get; set; }

    /// <summary>
    /// Unit[s] Rotation time without load/force
    /// </summary>
    public float? TimeRotNoLoad { get; set; }

    /// <summary>
    /// Unit[m] wear crown
    /// </summary>
    public float? WCrown { get; set; }

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

    public virtual RollDatum Roll { get; set; }
}
