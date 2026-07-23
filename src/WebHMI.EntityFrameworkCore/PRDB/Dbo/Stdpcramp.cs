using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Standard PowerCooling Plan Ramp
/// </summary>
public partial class StdPcramp
{
    /// <summary>
    /// active flag
    /// </summary>
    public int ActiveFlag { get; set; }

    /// <summary>
    /// Unit[0...999] pc p number
    /// </summary>
    public int PlanNo { get; set; }

    /// <summary>
    /// ramp number
    /// </summary>
    public int RampNo { get; set; }

    /// <summary>
    /// description field
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Unit[0 / 1] ramp auto mode: AUTO=0, MAN=1
    /// </summary>
    public int? PcRampAuto { get; set; }

    /// <summary>
    /// Unit[0 / 1] ramp state: ON=1, OFF=0
    /// </summary>
    public int? PcRampState { get; set; }

    /// <summary>
    /// Unit[0...n] priority: -1: do not switch, 0,1,2,3,.....: lowest number is switched on first and switched off last
    /// </summary>
    public int? PrioPowerC { get; set; }

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
    /// Unit[0 / 1] ramp volume flow factor from max flow
    /// </summary>
    public double? PcRampVolumeInd0 { get; set; }

    /// <summary>
    /// Unit[0 / 1] ramp volume flow factor from max flow
    /// </summary>
    public double? PcRampVolumeInd1 { get; set; }
}
