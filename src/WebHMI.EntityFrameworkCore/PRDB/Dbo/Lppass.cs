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
    /// flattness correction
    /// </summary>
    public double? ObservedFlat { get; set; }

    /// <summary>
    /// Unit[0...999] l p number
    /// </summary>
    public int? PlanNo { get; set; }

    /// <summary>
    /// status bending force
    /// </summary>
    public int? StatBendingForce { get; set; }

    /// <summary>
    /// status cvc shifting
    /// </summary>
    public int? StatCvcshifting { get; set; }

    /// <summary>
    /// status loading type
    /// </summary>
    public int? StatLoadingType { get; set; }

    /// <summary>
    /// status loading value, depending on loading type
    /// </summary>
    public int? StatLoadingValue { get; set; }

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
