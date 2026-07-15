using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StatLppass
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
    /// bending force, if pc_mode is off then will be taken for setup
    /// </summary>
    public short? BendingForce { get; set; }

    /// <summary>
    /// profile actuators, position CVC shifting, if pc_mode is off then will be taken for setup
    /// </summary>
    public short? CVcshifting { get; set; }

    /// <summary>
    /// circum speed correction
    /// </summary>
    public short? CircumSpeedCorrection { get; set; }

    /// <summary>
    /// description field
    /// </summary>
    public short? Description { get; set; }

    /// <summary>
    /// setpoint force when in Edger ForceMode
    /// </summary>
    public short? EdgerForce { get; set; }

    /// <summary>
    /// 0: Edger SideGuideMode;  1: Edger ForceMode  2: Edger Inactive 
    /// </summary>
    public short? EdgerMode { get; set; }

    /// <summary>
    /// loading type defined in scDef.h
    /// </summary>
    public short? LoadingType { get; set; }

    /// <summary>
    /// loading value
    /// </summary>
    public short? LoadingValue { get; set; }

    /// <summary>
    /// loading value correction
    /// </summary>
    public short? LoadingValueCorrection { get; set; }

    /// <summary>
    /// loading value maximum epsilon
    /// </summary>
    public short? LoadingValueMaximumEps { get; set; }

    /// <summary>
    /// loading value maximum roll force
    /// </summary>
    public short? LoadingValueMaximumRollForce { get; set; }

    /// <summary>
    /// loading value minimum epsilon
    /// </summary>
    public short? LoadingValueMinimumEps { get; set; }

    /// <summary>
    /// loading value minimum roll force
    /// </summary>
    public short? LoadingValueMinimumRollForce { get; set; }

    /// <summary>
    /// factor min. width after edging
    /// </summary>
    public short? MinWidthEdgFactor { get; set; }

    /// <summary>
    /// flattness correction
    /// </summary>
    public short? ObservedFlat { get; set; }

    /// <summary>
    /// l p number
    /// </summary>
    public short? PlanNo { get; set; }

    /// <summary>
    /// maximum width reduction for pass with edger stand
    /// </summary>
    public short? WidthReductionMax { get; set; }

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
