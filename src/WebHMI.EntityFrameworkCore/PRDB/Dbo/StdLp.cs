using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Standard loading plan
/// </summary>
public partial class StdLp
{
    /// <summary>
    /// active flag
    /// </summary>
    public int ActiveFlag { get; set; }

    /// <summary>
    /// Unit[0...999] l p number
    /// </summary>
    public int PlanNo { get; set; }

    /// <summary>
    /// factor thick head ( h_exit X faktor = h_exit thick head )
    /// </summary>
    public double? FactorThickHead { get; set; }

    /// <summary>
    /// factor thick tail ( h_exit X factor = h_exit thick tail )
    /// </summary>
    public double? FactorThickTail { get; set; }

    /// <summary>
    /// Unit[m/s] max speed during rolling (strip speed exit fm LIMIT MAX)
    /// </summary>
    public double? MaxSpeed { get; set; }

    /// <summary>
    /// Unit[s] offset time for speedup
    /// </summary>
    public double? OffsetTimeSpeedUp { get; set; }

    /// <summary>
    /// Unit[m/s2] SPEED values, power speed up value
    /// </summary>
    public double? PowerSpeedUp { get; set; }

    /// <summary>
    /// power speed up state: 0=off, 1=on
    /// </summary>
    public int? PowerSpeedUpState { get; set; }

    /// <summary>
    /// Unit[m/s] normal speed during rolling (strip speed exit fm target rolling)
    /// </summary>
    public double? RollSpeed { get; set; }

    /// <summary>
    /// Unit[m/s] thread speed before reduction at stand 1 (strip speed entry fm LIMIT MAX )
    /// </summary>
    public double? SpeedBeforeRedStand1 { get; set; }

    /// <summary>
    /// Unit[m/s2] speed up value
    /// </summary>
    public double? SpeedUp { get; set; }

    /// <summary>
    /// speed up :1 = speedup with LAS, 2 = speedup with time, 3 = speedup at coiler
    /// </summary>
    public int? SpeedUpState { get; set; }

    /// <summary>
    /// status max speed
    /// </summary>
    public int? StatMaxSpeed { get; set; }

    /// <summary>
    /// status power speed up
    /// </summary>
    public int? StatPowerSpeedUp { get; set; }

    /// <summary>
    /// status roll speed
    /// </summary>
    public int? StatRollSpeed { get; set; }

    /// <summary>
    /// status speed up
    /// </summary>
    public int? StatSpeedUp { get; set; }

    /// <summary>
    /// status thick head
    /// </summary>
    public int? StatThickHead { get; set; }

    /// <summary>
    /// status thick head
    /// </summary>
    public int? StatThickTail { get; set; }

    /// <summary>
    /// status thread speed
    /// </summary>
    public int? StatThreadSpeed { get; set; }

    /// <summary>
    /// thick head: no=0, yes=1
    /// </summary>
    public int? ThickHead { get; set; }

    /// <summary>
    /// thick tail: no=0, yes=1
    /// </summary>
    public int? ThickTail { get; set; }

    /// <summary>
    /// Unit[m/s] max speed for threading in coiler (strip speed exit fm LIMIT MAX)
    /// </summary>
    public double? ThreadSpeed { get; set; }

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
