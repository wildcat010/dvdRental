using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// calc results roughing mill to MSM
/// </summary>
public partial class RmcalcResToMsm
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
    /// number of the run, keyvalue for database only, no setpoint
    /// </summary>
    public int PassNo { get; set; }

    /// <summary>
    /// 1=preCalculation, 2=postCalculation
    /// </summary>
    public int RmCalcType { get; set; }

    /// <summary>
    /// stand unit number (SP=1, R1=2, R2=3, FM=10 ...19)
    /// </summary>
    public int StandUnitNo { get; set; }

    /// <summary>
    /// strip point identification number
    /// </summary>
    public int StripPointId { get; set; }

    /// <summary>
    /// normalized plate length coordinate in [-0.5,0.5] x [-0.5,0.5]; centre = {0,0}
    /// </summary>
    public float? CoordLen { get; set; }

    /// <summary>
    /// normalized plate width coordinate in [-0.5,0.5] x [-0.5,0.5]; centre = {0,0}
    /// </summary>
    public float? CoordWidth { get; set; }

    /// <summary>
    /// Unit[m] work roll diameter bottom
    /// </summary>
    public float? DRollBot { get; set; }

    /// <summary>
    /// Unit[m] work roll diameter top
    /// </summary>
    public float? DRollTop { get; set; }

    /// <summary>
    /// 1 = data complete
    /// </summary>
    public int? DataComplete { get; set; }

    /// <summary>
    /// rougher:  forward slip
    /// </summary>
    public float? FSlip { get; set; }

    /// <summary>
    /// Unit[m] edger: entry thickness
    /// </summary>
    public float? HEntry { get; set; }

    /// <summary>
    /// Unit[m] rough strip exit thickness
    /// </summary>
    public float? HExit { get; set; }

    /// <summary>
    /// preStrain
    /// </summary>
    public float? PreStrain { get; set; }

    /// <summary>
    /// rolling direction 0=length direction (X), 1=widthdirection (Y)
    /// </summary>
    public int? RollDir { get; set; }

    /// <summary>
    /// Unit[N] rolling force
    /// </summary>
    public float? RollForce { get; set; }

    /// <summary>
    /// Unit[Nm] rolling torque
    /// </summary>
    public float? RollTorque { get; set; }

    /// <summary>
    /// Unit[s] break time for specific point (time from tEntry to tExit), if not known, -1 and tbreak will be calculated from tLoadPrev, tLoadNext and tRevers [s]
    /// </summary>
    public float? TBreak { get; set; }

    /// <summary>
    /// Unit[_C] entry strip temperature
    /// </summary>
    public float? TEntry { get; set; }

    /// <summary>
    /// Unit[_C] exit strip temperature
    /// </summary>
    public float? TExit { get; set; }

    /// <summary>
    /// Unit[s] time stand loaded in next pass (while RollForce &gt; 0). If tbreak is known, -1 will be used here. [s]
    /// </summary>
    public float? TLoadNext { get; set; }

    /// <summary>
    /// Unit[s] time stand loaded in previous pass (while RollForce &gt; 0). If tbreak is known, -1 will be used here. [s]
    /// </summary>
    public float? TLoadPrev { get; set; }

    /// <summary>
    /// Unit[s] reversing time (time from stand unloaded until stand loaded in next pass). If tbreak is known, -1 will be used here. [s]
    /// </summary>
    public float? TRevers { get; set; }

    /// <summary>
    /// External material ID
    /// </summary>
    public string ToExtId { get; set; }

    /// <summary>
    /// Unit[m/s] rougher:  circumferential speed
    /// </summary>
    public float? VRoll { get; set; }

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
