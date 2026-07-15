using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Lppass
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
    /// Unit[N] bending force, if pc_mode is off then will be taken for setup
    /// </summary>
    public double? BendingForce { get; set; }

    /// <summary>
    /// Unit[m] profile actuators, position CVC shifting, if pc_mode is off then will be taken for setup
    /// </summary>
    public double? CVcshifting { get; set; }

    /// <summary>
    /// Unit[-1 ... +1] circum speed correction
    /// </summary>
    public double? CircumSpeedCorrection { get; set; }

    /// <summary>
    /// description field
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Unit[N] setpoint force when in Edger ForceMode
    /// </summary>
    public double? EdgerForce { get; set; }

    /// <summary>
    /// 0: Edger SideGuideMode;  1: Edger ForceMode  2: Edger Inactive 
    /// </summary>
    public short? EdgerMode { get; set; }

    /// <summary>
    /// loading type defined in scDef.h
    /// </summary>
    public int? LoadingType { get; set; }

    /// <summary>
    /// Unit[0 ... 1] loading value
    /// </summary>
    public double? LoadingValue { get; set; }

    /// <summary>
    /// Unit[0 ... 1] loading value correction
    /// </summary>
    public double? LoadingValueCorrection { get; set; }

    /// <summary>
    /// Unit[0 ... 1] loading value maximum epsilon
    /// </summary>
    public double? LoadingValueMaximumEps { get; set; }

    /// <summary>
    /// Unit[N/m] loading value maximum roll force
    /// </summary>
    public double? LoadingValueMaximumRollForce { get; set; }

    /// <summary>
    /// Unit[0 ... 1] loading value minimum epsilon
    /// </summary>
    public double? LoadingValueMinimumEps { get; set; }

    /// <summary>
    /// Unit[N/m] loading value minimum roll force
    /// </summary>
    public double? LoadingValueMinimumRollForce { get; set; }

    /// <summary>
    /// Unit[0..1] factor min. width after edging
    /// </summary>
    public double? MinWidthEdgFactor { get; set; }

    /// <summary>
    /// flattness correction
    /// </summary>
    public double? ObservedFlat { get; set; }

    /// <summary>
    /// Unit[0...999] l p number
    /// </summary>
    public int? PlanNo { get; set; }

    /// <summary>
    /// Unit[m] maximum width reduction for pass with edger stand
    /// </summary>
    public double? WidthReductionMax { get; set; }

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
