using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Rglppass
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
    /// pass number
    /// </summary>
    public int PassNo { get; set; }

    /// <summary>
    /// owner
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// Unit[0...999] r g l p number
    /// </summary>
    public int? PlanNo { get; set; }

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

    /// <summary>
    /// description field
    /// </summary>
    public string Description { get; set; }

    public virtual Me1 Me1 { get; set; }
}
