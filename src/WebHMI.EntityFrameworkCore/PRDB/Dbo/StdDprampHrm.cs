using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Standard descaler plan ramp HRM
/// </summary>
public partial class StdDprampHrm
{
    /// <summary>
    /// active flag
    /// </summary>
    public int ActiveFlag { get; set; }

    /// <summary>
    /// Unit[0...999] d p number
    /// </summary>
    public int PlanNo { get; set; }

    /// <summary>
    /// ramp number
    /// </summary>
    public int RampNo { get; set; }

    /// <summary>
    /// Unit[0 / 1] descaler ramp auto mode: AUTO=0, MAN=1
    /// </summary>
    public int? DescRampAuto { get; set; }

    /// <summary>
    /// Unit[0 / 1] descaler ramp state: ON=1, OFF=0
    /// </summary>
    public int? DescRampState { get; set; }

    /// <summary>
    /// Unit[0...1] descaler ramp volume flow factor from max flow
    /// </summary>
    public double? DescRampVolume { get; set; }

    /// <summary>
    /// Unit[0...n] priority: -1: do not switch, 0,1,2,3,.....: lowest number is switched on first and switched off last
    /// </summary>
    public int? PrioDescaler { get; set; }

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
