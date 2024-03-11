using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class MosPqe
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
    /// maximum acceleration value (either positive or negativ)
    /// </summary>
    public float? Acceleration { get; set; }

    /// <summary>
    /// neural network material hardness relation factor
    /// </summary>
    public float? Alpha { get; set; }

    /// <summary>
    /// counter for changes of the chemistry
    /// </summary>
    public short? ChemistryChange { get; set; }

    /// <summary>
    /// ???????
    /// </summary>
    public short? ContourPreCondition { get; set; }

    /// <summary>
    /// maximum cooling water un CS is reached (1 =upper limit, 2 = lower limit)
    /// </summary>
    public int? CoolWaterLim { get; set; }

    /// <summary>
    /// difference exit temperature FM and CS bigger 400~C or less 100~C  = 1
    /// </summary>
    public short? CsTargDiff { get; set; }

    /// <summary>
    /// Defective valve on while cooling
    /// </summary>
    public short? DefectiveValveOn { get; set; }

    /// <summary>
    /// force limit has been detected (stand no)
    /// </summary>
    public int? ForceLimit { get; set; }

    /// <summary>
    /// prc is active
    /// </summary>
    public short? HrmPrcActive { get; set; }

    /// <summary>
    /// 2 = Auto, 1 = Manual
    /// </summary>
    public short? IsBendingAuto { get; set; }

    public int? IsFlyingGauge { get; set; }

    /// <summary>
    /// 2 = Auto, 1 = Manual
    /// </summary>
    public short? IsShiftingAuto { get; set; }

    public float? LengthWedge { get; set; }

    /// <summary>
    /// L1 measured wedge length for material
    /// </summary>
    public float? LengthWedgeMeas { get; set; }

    /// <summary>
    /// Manual intervention in the laminar cooling section
    /// </summary>
    public short? ManualInterventionCs { get; set; }

    /// <summary>
    /// Manual intervention due to flatness
    /// </summary>
    public short? MiVsFlatness { get; set; }

    /// <summary>
    /// Manual intervention due to profile
    /// </summary>
    public short? MiVsProfile { get; set; }

    /// <summary>
    /// manual entered speed from operator
    /// </summary>
    public float? OpSpeed { get; set; }

    /// <summary>
    /// roll property id for indicating hss, hcr rolls
    /// </summary>
    public short? RollPropIdInd0 { get; set; }

    /// <summary>
    /// roll property id for indicating hss, hcr rolls
    /// </summary>
    public short? RollPropIdInd1 { get; set; }

    /// <summary>
    /// roll property id for indicating hss, hcr rolls
    /// </summary>
    public short? RollPropIdInd2 { get; set; }

    /// <summary>
    /// roll property id for indicating hss, hcr rolls
    /// </summary>
    public short? RollPropIdInd3 { get; set; }

    /// <summary>
    /// roll property id for indicating hss, hcr rolls
    /// </summary>
    public short? RollPropIdInd4 { get; set; }

    /// <summary>
    /// roll property id for indicating hss, hcr rolls
    /// </summary>
    public short? RollPropIdInd5 { get; set; }

    /// <summary>
    /// roll property id for indicating hss, hcr rolls
    /// </summary>
    public short? RollPropIdInd6 { get; set; }

    /// <summary>
    /// roll property id for indicating hss, hcr rolls
    /// </summary>
    public short? RollPropIdInd7 { get; set; }

    public short? RollingMode { get; set; }

    /// <summary>
    /// first strip of a sequence = 1, last strip of a sequence = 2
    /// </summary>
    public short? SeqFstLst { get; set; }

    /// <summary>
    /// Shear ID for head cut
    /// </summary>
    public short? ShearIdForHeadCut { get; set; }

    /// <summary>
    /// Shear ID for tail cut
    /// </summary>
    public short? ShearIdForTailCut { get; set; }

    /// <summary>
    /// speed Limit is reached (1 = due to speed limitation, 2 =due to torque limit 3 =due to power limit))
    /// </summary>
    public int? SpeedLimitReached { get; set; }

    /// <summary>
    /// slab with a width or thickness taper = 1, otherwise = 0
    /// </summary>
    public short? TaperedSlab { get; set; }

    /// <summary>
    /// casting speed
    /// </summary>
    public float? VCast { get; set; }

    /// <summary>
    /// Calculated yield stress for Stand F1
    /// </summary>
    public float? YieldStress { get; set; }

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
