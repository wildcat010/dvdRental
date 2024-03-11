using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// mill specific strategy data set for stand
/// </summary>
public partial class MillStratStand
{
    /// <summary>
    /// plant type (HRM, HFM, TCM, SPM, ....)
    /// </summary>
    public string PlantType { get; set; }

    /// <summary>
    /// record number (always 0)
    /// </summary>
    public int RecordNo { get; set; }

    /// <summary>
    /// owner
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// stand number (0 .... MAX_NO_STANDS-1)
    /// </summary>
    public int Stand { get; set; }

    /// <summary>
    /// Unit[%] correction for model calculated work roll shifting
    /// </summary>
    public double? CorrDeltaWrShiftPos { get; set; }

    /// <summary>
    /// Unit[m] delta work roll shift position
    /// </summary>
    public double? DeltaWrShiftPos { get; set; }

    /// <summary>
    /// Unit[N] bending force (operator input)
    /// </summary>
    public double? Fb { get; set; }

    /// <summary>
    /// Unit[N] bending force lower limit
    /// </summary>
    public double? FbLl { get; set; }

    /// <summary>
    /// Unit[N] bending force upper limit
    /// </summary>
    public double? FbUl { get; set; }

    /// <summary>
    /// flatness correction specific for caster no or furnace no
    /// </summary>
    public double? ObservedFlatInd0 { get; set; }

    /// <summary>
    /// flatness correction specific for caster no or furnace no
    /// </summary>
    public double? ObservedFlatInd1 { get; set; }

    /// <summary>
    /// flatness correction specific for caster no or furnace no
    /// </summary>
    public double? ObservedFlatInd2 { get; set; }

    /// <summary>
    /// flatness correction specific for caster no or furnace no
    /// </summary>
    public double? ObservedFlatInd3 { get; set; }

    /// <summary>
    /// flatness correction specific for caster no or furnace no
    /// </summary>
    public double? ObservedFlatInd4 { get; set; }

    /// <summary>
    /// flatness correction specific for caster no or furnace no
    /// </summary>
    public double? ObservedFlatInd5 { get; set; }

    /// <summary>
    /// flatness correction specific for caster no or furnace no
    /// </summary>
    public double? ObservedFlatInd6 { get; set; }

    /// <summary>
    /// flatness correction specific for caster no or furnace no
    /// </summary>
    public double? ObservedFlatInd7 { get; set; }

    /// <summary>
    /// flatness correction specific for caster no or furnace no
    /// </summary>
    public double? ObservedFlatInd8 { get; set; }

    /// <summary>
    /// flatness correction specific for caster no or furnace no
    /// </summary>
    public double? ObservedFlatInd9 { get; set; }

    /// <summary>
    /// Unit[deg] pair cross angle (operator input)
    /// </summary>
    public double? PcAngle { get; set; }

    /// <summary>
    /// Unit[deg] lower limit of pair cross angle
    /// </summary>
    public double? PcAngleLl { get; set; }

    /// <summary>
    /// Unit[deg] upper limit of pair cross angle
    /// </summary>
    public double? PcAngleUl { get; set; }

    public double? Reserve1 { get; set; }

    public double? Reserve2 { get; set; }

    /// <summary>
    /// Unit[m] work roll shifting position
    /// </summary>
    public double? WrShiftPos { get; set; }

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
