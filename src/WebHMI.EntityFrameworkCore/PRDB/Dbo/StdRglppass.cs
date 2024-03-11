using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Standard roll gap lubrication plan pass
/// </summary>
public partial class StdRglppass
{
    /// <summary>
    /// active flag
    /// </summary>
    public int ActiveFlag { get; set; }

    /// <summary>
    /// pass number
    /// </summary>
    public int PassNo { get; set; }

    /// <summary>
    /// Unit[0...999] r g l p number
    /// </summary>
    public int PlanNo { get; set; }

    /// <summary>
    /// Unit[0...1] factor volumen flow oil bot work roll
    /// </summary>
    public double? RollGapLubOilFlowBot { get; set; }

    /// <summary>
    /// Unit[0...1] factor volumen flow oil top work roll
    /// </summary>
    public double? RollGapLubOilFlowTop { get; set; }

    /// <summary>
    /// Unit[s] ramp time for switch on
    /// </summary>
    public double? RollGapLubRampTimeStart { get; set; }

    /// <summary>
    /// Unit[s] ramp time for switch off
    /// </summary>
    public double? RollGapLubRampTimeStop { get; set; }

    /// <summary>
    /// SF-sensitivity - todo units
    /// </summary>
    public double? RollGapLubSensitivity { get; set; }

    /// <summary>
    /// Unit[0....X] state roll gap lubrication: 0=OFF, 1=BEF_STAND_LOADED, 2=NEXT_STAND_LOADED, 3=AFT_TIME
    /// </summary>
    public int? RollGapLubState { get; set; }

    /// <summary>
    /// Unit[-x...x] head distance switch on
    /// </summary>
    public double? RollGapLubSwitchLength { get; set; }

    /// <summary>
    /// Unit[m] tail distance for switch off
    /// </summary>
    public double? RollGapLubSwitchLengthTail { get; set; }

    /// <summary>
    /// Unit[0...1] factor volumen flow water
    /// </summary>
    public double? RollGapLubWaterFlow { get; set; }

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
