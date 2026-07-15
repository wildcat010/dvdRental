using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Roll data
/// </summary>
public partial class RollDatum
{
    /// <summary>
    /// roll ID
    /// </summary>
    public string RollId { get; set; }

    /// <summary>
    /// Actual used caliber
    /// </summary>
    public int? ActUsedCal { get; set; }

    /// <summary>
    /// producing diamond strips (off: 0, on 1)
    /// </summary>
    public int? CheckerPlate { get; set; }

    /// <summary>
    /// Unit[m] maxmum difference between max. and min outer diameter of the roll
    /// </summary>
    public double? DiamDiff { get; set; }

    /// <summary>
    /// Unit[m] nominal diameter
    /// </summary>
    public double Diameter { get; set; }

    /// <summary>
    /// Unit[m] diameter of the roll core
    /// </summary>
    public double? DiameterCore { get; set; }

    /// <summary>
    /// dismounting time
    /// </summary>
    public DateTime? DismountTime { get; set; }

    /// <summary>
    /// indicates is freshly ground (1=Yes, 0=No)
    /// </summary>
    public int? Grinding { get; set; }

    /// <summary>
    /// indicates roll ground at install (1=Yes, 0=No)
    /// </summary>
    public int? GrindingInstall { get; set; }

    /// <summary>
    /// Unit[grdC] Initial roll temperature (eg. from preheating)
    /// </summary>
    public double? InitTemp { get; set; }

    /// <summary>
    /// Unit[sec] interrupt time on grinder machine
    /// </summary>
    public double? IntTime { get; set; }

    /// <summary>
    /// Unit[m] maximum outer diameter of roll
    /// </summary>
    public double? MaxDiameter { get; set; }

    /// <summary>
    /// Unit[m] minimum outer diameter of roll
    /// </summary>
    public double? MinDiameter { get; set; }

    /// <summary>
    /// mounting time
    /// </summary>
    public DateTime? MountTime { get; set; }

    /// <summary>
    /// Planned Time for install
    /// </summary>
    public DateTime? PlannedInstallTime { get; set; }

    /// <summary>
    /// roll position where the roll is planed (u=upper, l=lower)
    /// </summary>
    public string PlannedRollPos { get; set; }

    /// <summary>
    /// stand ID where the roll is planed
    /// </summary>
    public int? PlannedStandId { get; set; }

    /// <summary>
    /// plant type: HRM, HFM
    /// </summary>
    public string PlantType { get; set; }

    /// <summary>
    /// roll id of opposite roll position
    /// </summary>
    public string RelatedRollId { get; set; }

    /// <summary>
    /// notes, comment by operator
    /// </summary>
    public string Remarks { get; set; }

    /// <summary>
    /// remove reason
    /// </summary>
    public int? RemoveReason { get; set; }

    /// <summary>
    /// Code for the chamfer parameter
    /// </summary>
    public short RollChamferCode { get; set; }

    /// <summary>
    /// Kind of rolls (CVC, UC, X2...)
    /// </summary>
    public int? RollClass { get; set; }

    /// <summary>
    /// roll position (u=upper, l= lower)
    /// </summary>
    public string RollPos { get; set; }

    /// <summary>
    /// roll property class
    /// </summary>
    public int RollPropertyClass { get; set; }

    /// <summary>
    /// Code for the shape parameters
    /// </summary>
    public short RollShapeCode { get; set; }

    /// <summary>
    /// type of roll (BUR; IMR; WKR)
    /// </summary>
    public string RollType { get; set; }

    /// <summary>
    /// installation number
    /// </summary>
    public int? RollUsage { get; set; }

    /// <summary>
    /// Unit[m] initial rolled length
    /// </summary>
    public double? RolledLength { get; set; }

    /// <summary>
    /// Unit[m] rolled length actual cycle
    /// </summary>
    public double? RolledLengthAct { get; set; }

    /// <summary>
    /// initial rolled slabs
    /// </summary>
    public int? RolledStrips { get; set; }

    /// <summary>
    /// Unit[kg] initial rolled weight
    /// </summary>
    public double? RolledWeight { get; set; }

    /// <summary>
    /// Unit[kg] rolled weight actual cycle
    /// </summary>
    public double? RolledWeigthAct { get; set; }

    /// <summary>
    /// surface roughness of  roll
    /// </summary>
    public double? Roughness { get; set; }

    /// <summary>
    /// Unit[m] shimm plate thickness
    /// </summary>
    public double? Shimm { get; set; }

    /// <summary>
    /// number of stand whre the roll is installed
    /// </summary>
    public int? StandId { get; set; }

    /// <summary>
    /// Stand range for this roll can be used
    /// </summary>
    public string StandRange { get; set; }

    /// <summary>
    /// status= I(nstalled) or P(repared) or R(emoved)
    /// </summary>
    public string Stat { get; set; }

    /// <summary>
    /// type of surface teatment (e.g. by laser)
    /// </summary>
    public string Surface { get; set; }

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
