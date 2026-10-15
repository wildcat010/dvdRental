using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StatEdOrdEnt
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
    /// owner
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// Amount of bindings circumferential
    /// </summary>
    public short? AmountBindings { get; set; }

    /// <summary>
    /// Amount of bindings radial
    /// </summary>
    public short? AmountBindingsR { get; set; }

    /// <summary>
    /// bend mode flag from mos
    /// </summary>
    public short? BendModeFlag { get; set; }

    /// <summary>
    /// casting speed
    /// </summary>
    public short? CastSpeed { get; set; }

    /// <summary>
    /// minimun casting speed to roll product
    /// </summary>
    public short? CastSpeedMin { get; set; }

    /// <summary>
    /// 0 = normal strip or plate,   1 = checker strip or plate
    /// </summary>
    public short? CheckerFlag { get; set; }

    /// <summary>
    /// Checker height
    /// </summary>
    public short? CheckerHeight { get; set; }

    /// <summary>
    /// Classif. max. strip crown delta from aim C40
    /// </summary>
    public short? ClassMaxCrownDelta { get; set; }

    /// <summary>
    /// Classif. max. strip flatness delta for asymetric flatness
    /// </summary>
    public short? ClassMaxFlatDeltaAsym { get; set; }

    /// <summary>
    /// Classif. max. strip flatness delta for symetric flatness
    /// </summary>
    public short? ClassMaxFlatDeltaSym { get; set; }

    /// <summary>
    /// Classif. max strip wedge delta from 0
    /// </summary>
    public short? ClassMaxWedgeDelta { get; set; }

    /// <summary>
    /// Classif. min. strip crown delta from aim C40
    /// </summary>
    public short? ClassMinCrownDelta { get; set; }

    /// <summary>
    /// Classif. min. strip flatness delta for symetric flatness
    /// </summary>
    public short? ClassMinFlatDeltaSym { get; set; }

    /// <summary>
    /// Classif. min strip wedge delta from 0
    /// </summary>
    public short? ClassMinWedgeDelta { get; set; }

    /// <summary>
    /// Cooling Section: Coil target temperature for body of strip
    /// </summary>
    public short? CoilTemp { get; set; }

    /// <summary>
    /// Customer limit for maximum coil temp
    /// </summary>
    public short? CoilTempLimitMaxCust { get; set; }

    /// <summary>
    /// Customer limit for minimum coil temp
    /// </summary>
    public short? CoilTempLimitMinCust { get; set; }

    /// <summary>
    /// CoolingSection: Max cooling section exit strip temperature delta
    /// </summary>
    public short? CoilTempMaxTol { get; set; }

    /// <summary>
    /// CoolingSection: Min cooling section exit strip temperature delta
    /// </summary>
    public short? CoilTempMinTol { get; set; }

    /// <summary>
    /// CoolingSection: (not used for Arvedi) Coil profile temperature head
    /// </summary>
    public short? CoilTempProfileHead { get; set; }

    /// <summary>
    /// CoolingSection: (not used for Arvedi) Coil profile temperature tail
    /// </summary>
    public short? CoilTempProfileTail { get; set; }

    /// <summary>
    /// Coil Yard Destination
    /// </summary>
    public short? CoilYard { get; set; }

    /// <summary>
    /// CoolingSection:  (not used for Arvedi) when strips pass different numbers of valves on the way to the coiler
    /// </summary>
    public short? CoilerLocationSelection { get; set; }

    /// <summary>
    /// CS exit temperature fraction for transition (for carbon steel grades)
    /// </summary>
    public short? CoolExitF4t { get; set; }

    /// <summary>
    /// Load of fine cooling zone (for early and late cooling strategy)
    /// </summary>
    public short? CoolFineCzoneLoad { get; set; }

    /// <summary>
    /// Cooling Section: Cooling rate  bottom (laminar cooling): 25%, 50%, 75%, 100% or coolRateBotIC for MPC
    /// </summary>
    public short? CoolRateBot { get; set; }

    /// <summary>
    /// Cooling Section: Cooling rate  bottom 2nd phase (laminar cooling): 25%, 50%, 75%, 100%  or coolRateBotIC for MPC
    /// </summary>
    public short? CoolRateBot2 { get; set; }

    /// <summary>
    /// Cooling Section: Cooling rate bottom 3rd phase (laminar cooling): 25%, 50%, 75%, 100%
    /// </summary>
    public short? CoolRateBot3 { get; set; }

    /// <summary>
    /// Cooling Section: Cooling rate  top (laminar cooling): 25%, 50%, 75%, 100% or coolRateTopIC for MPC
    /// </summary>
    public short? CoolRateTop { get; set; }

    /// <summary>
    /// Cooling Section: Cooling rate  top 2nd phase (laminar cooling): 25%, 50%, 75%, 100% or coolRateTop for MPC
    /// </summary>
    public short? CoolRateTop2 { get; set; }

    /// <summary>
    /// Cooling Section: Cooling rate  top 3rd phase (laminar cooling): 25%, 50%, 75%, 100%
    /// </summary>
    public short? CoolRateTop3 { get; set; }

    /// <summary>
    /// Cooling Section: 0 - no dual phase, 1 - dual phase steel
    /// </summary>
    public short? CoolStrategy { get; set; }

    /// <summary>
    /// Cooling Section: 0 = use directives from look up table deposited in the L2, 1 = use directives of the PDI
    /// </summary>
    public short? CoolingStrategyModeSelection { get; set; }

    /// <summary>
    /// bottom coolrate reduction for areas above the transition temp
    /// </summary>
    public short? CsCoolRateRedHighBot { get; set; }

    /// <summary>
    /// top coolrate reduction for areas above the transition temp
    /// </summary>
    public short? CsCoolRateRedHighTop { get; set; }

    /// <summary>
    /// bottom coolrate reduction for areas below the transition temp
    /// </summary>
    public short? CsCoolRateRedLowBot { get; set; }

    /// <summary>
    /// top coolrate reduction for areas below the transition temp
    /// </summary>
    public short? CsCoolRateRedLowTop { get; set; }

    /// <summary>
    /// Cooling Section: Load of fine cooling zone (for early and late cooling strategy)
    /// </summary>
    public short? CsFineCoolingZoneLoad { get; set; }

    /// <summary>
    /// Cooling Section: Index of pyrometer to be used for final adaptation early/late or first phase adaptation for SP/DP/TP
    /// </summary>
    public short? CsLeadingPyrometerIndex { get; set; }

    /// <summary>
    /// Cooling Section: Index of pyrometer to be used for second phase adaptation for DP/TP
    /// </summary>
    public short? CsLeadingPyrometerIndex2 { get; set; }

    /// <summary>
    /// Cooling Section: Index of pyrometer to be used for third phase adaptation for TP
    /// </summary>
    public short? CsLeadingPyrometerIndex3 { get; set; }

    /// <summary>
    /// spline number for temperature dependent bottom cooling rate (for dual phase cooling)
    /// </summary>
    public short? CsSplineIndexBot { get; set; }

    /// <summary>
    /// spline number for temperature dependent top cooling rate (for dual phase cooling)
    /// </summary>
    public short? CsSplineIndexTop { get; set; }

    /// <summary>
    /// transition temperature for coolrate reduction from high to low
    /// </summary>
    public short? CsTransitionTemp { get; set; }

    /// <summary>
    /// Cooling Section: Index of valve sequence to be used
    /// </summary>
    public short? CsValveSequenceIndex { get; set; }

    /// <summary>
    /// from flagDelivery
    /// </summary>
    public short? Destination { get; set; }

    /// <summary>
    /// no. of dilatometer curve to be applied
    /// </summary>
    public short? DilatometerCurve { get; set; }

    public short? EdgeMask { get; set; }

    /// <summary>
    /// Finished strip crown C40
    /// </summary>
    public short? ExitCrownC40 { get; set; }

    /// <summary>
    /// ( 0 for Arvedi) 0=no ferritic transformation in FM, 2=ferritic transformation between F2 and F3 is required, 3=ferritic transformation between F3 and F4 is required
    /// </summary>
    public short? FerriticRollingMode { get; set; }

    /// <summary>
    /// 1=alternative thickness is used
    /// </summary>
    public short? FlagAltThick { get; set; }

    /// <summary>
    /// 0: semi endless rolling; 1: batch rolling
    /// </summary>
    public short? FlagBatchRolling { get; set; }

    /// <summary>
    /// CoolingSection: (not used for Arvedi)1=compact cooling only, 2=laminar cooling only, 3=combined cooling
    /// </summary>
    public short? FlagCompactCool { get; set; }

    /// <summary>
    /// (Arvedi not available) flag diamond: 0 = normal strip, 1 = diamond strip
    /// </summary>
    public short? FlagDiamond { get; set; }

    /// <summary>
    /// (Arvedi not available) 0 = not divided, 1 = first part, 2 = second part
    /// </summary>
    public short? FlagDivide { get; set; }

    /// <summary>
    /// flag 1 -dual phase
    /// </summary>
    public short? FlagDualPhase { get; set; }

    /// <summary>
    /// 0: strip production, 1: plate production
    /// </summary>
    public short? FlagPlateProd { get; set; }

    /// <summary>
    /// flag speed change requested from caster 0= no , 1=yes
    /// </summary>
    public short? FlagSpeedReqCas { get; set; }

    /// <summary>
    /// Customer limit for maximum fm exit temp
    /// </summary>
    public short? FmTempLimitMaxCust { get; set; }

    /// <summary>
    /// Customer limit for minimum fm exit temp
    /// </summary>
    public short? FmTempLimitMinCust { get; set; }

    /// <summary>
    /// CoolingSection: fraction for transition: desired fraction of non-austenitic material at coiler for high carbon steels
    /// </summary>
    public short? FractionForTransition { get; set; }

    /// <summary>
    /// Classif. max. strip alternative thickness delta from aim
    /// </summary>
    public short? HClassMaxAltDelta { get; set; }

    /// <summary>
    /// Classif. max. strip thickness delta from aim
    /// </summary>
    public short? HClassMaxDelta { get; set; }

    /// <summary>
    /// Classif. min strip alternative thickness delta from aim
    /// </summary>
    public short? HClassMinAltDelta { get; set; }

    /// <summary>
    /// Classif. min. strip thickness delta from aim
    /// </summary>
    public short? HClassMinDelta { get; set; }

    /// <summary>
    /// Finished strip thickness
    /// </summary>
    public short? HExit { get; set; }

    /// <summary>
    /// Finished strip alternative thickness
    /// </summary>
    public short? HExitAlt { get; set; }

    /// <summary>
    /// exit thickness ordered by customer
    /// </summary>
    public short? HExitCustomer { get; set; }

    /// <summary>
    /// thickness after HRM (plate)
    /// </summary>
    public short? HIntermediate { get; set; }

    /// <summary>
    /// alternativ plate thickness
    /// </summary>
    public short? HPlateAlt { get; set; }

    /// <summary>
    /// Cooling Section: Dual/Triple phase steel: hold temperature after first phase
    /// </summary>
    public short? HoldTemp { get; set; }

    /// <summary>
    /// Cooling Section: Triple phase steel: hold temperature after second phase
    /// </summary>
    public short? HoldTemp2 { get; set; }

    /// <summary>
    /// Cooling Section: Dual/Triple phase steel: hold time after first phase
    /// </summary>
    public short? HoldTime { get; set; }

    /// <summary>
    /// Cooling Section: Triple phase steel: hold time after second phase
    /// </summary>
    public short? HoldTime2 { get; set; }

    /// <summary>
    /// Sampling/inspection code
    /// </summary>
    public short? InspectionCode { get; set; }

    /// <summary>
    /// 0: no inspection 1: inspection required
    /// </summary>
    public short? InspectionFlag { get; set; }

    /// <summary>
    /// exit length of coil
    /// </summary>
    public short? LExit { get; set; }

    /// <summary>
    /// Slab length setpoint
    /// </summary>
    public short? LengthOrder { get; set; }

    /// <summary>
    /// CoolingSection: (not used for Arvedi) Length coil profile temperature head
    /// </summary>
    public short? LengthProfileHead { get; set; }

    /// <summary>
    /// CoolingSection: (not used for Arvedi) Length coil profile temperature tail
    /// </summary>
    public short? LengthProfileTail { get; set; }

    /// <summary>
    /// CoolingSection: Length of uncooled head
    /// </summary>
    public short? LengthUncooledHead { get; set; }

    /// <summary>
    /// CoolingSection: Length of uncooled tail
    /// </summary>
    public short? LengthUncooledTail { get; set; }

    /// <summary>
    /// identification, material data OK = 1
    /// </summary>
    public short? Ok { get; set; }

    /// <summary>
    /// Order number for the end customer
    /// </summary>
    public short? OrderNo { get; set; }

    /// <summary>
    /// target profile for HRM exit, 1 = 1prz
    /// </summary>
    public short? RmTargProfile { get; set; }

    /// <summary>
    /// Cooling Section: Valve to be switched lower side (1st cooling phase)
    /// </summary>
    public short? StartValveBot { get; set; }

    /// <summary>
    /// Cooling Section: Valve to be switched lower side (2nd cooling phase)
    /// </summary>
    public short? StartValveBot2 { get; set; }

    /// <summary>
    /// Cooling Section: Valve to be switched lower side (3rd cooling phase)
    /// </summary>
    public short? StartValveBot3 { get; set; }

    /// <summary>
    /// Cooling Section: Valve to be switched upper side (1st cooling phase)
    /// </summary>
    public short? StartValveTop { get; set; }

    /// <summary>
    /// Cooling Section: Valve to be switched upper side (2nd cooling phase)
    /// </summary>
    public short? StartValveTop2 { get; set; }

    /// <summary>
    /// Cooling Section: Valve to be switched upper side (3rd cooling phase)
    /// </summary>
    public short? StartValveTop3 { get; set; }

    /// <summary>
    /// Classif. max. strip temperature delta
    /// </summary>
    public short? TClassMaxDelta { get; set; }

    /// <summary>
    /// Classif. min. strip temperature delta
    /// </summary>
    public short? TClassMinDelta { get; set; }

    /// <summary>
    /// average slab core temperature calculated
    /// </summary>
    public short? TCore { get; set; }

    /// <summary>
    /// Cooling Section: Hold fraction for transition after first cooling phase (for dual/triple phase cooling strategy)
    /// </summary>
    public short? TCsHoldF4t { get; set; }

    /// <summary>
    /// Cooling Section: Hold fraction for transition after second cooling phase (for triple phase cooling strategy)
    /// </summary>
    public short? TCsHoldF4t2 { get; set; }

    /// <summary>
    /// Finished strip temperature
    /// </summary>
    public short? TExit { get; set; }

    /// <summary>
    /// Slab casting hand over temperature setpoint
    /// </summary>
    public short? TExitCaster { get; set; }

    /// <summary>
    /// measured slab temperature
    /// </summary>
    public short? TSlab { get; set; }

    /// <summary>
    /// ( not used for Arvedi) target temperature where the conversion ends
    /// </summary>
    public short? TTemperatureFeEnd { get; set; }

    /// <summary>
    /// ( not used for Arvedi) target temperature where the conversion starts ferritic rolling
    /// </summary>
    public short? TTemperatureFeStart { get; set; }

    /// <summary>
    /// finished strip target flatness
    /// </summary>
    public short? TargetFlatness { get; set; }

    /// <summary>
    /// Cooling Section: (not used for Arvedi) temperature behind the compact cooling section
    /// </summary>
    public short? TempBehindCompCool { get; set; }

    /// <summary>
    /// CoolingSection: (not used for Arvedi) temperature Gradient
    /// </summary>
    public short? TempCrit { get; set; }

    /// <summary>
    /// CoolingSection: (not used for Arvedi) critical temperature
    /// </summary>
    public short? TempGrad { get; set; }

    /// <summary>
    /// Customer limit for maximum thickness
    /// </summary>
    public short? ThickLimitMaxCust { get; set; }

    /// <summary>
    /// Customer limit for minimum thickness
    /// </summary>
    public short? ThickLimitMinCust { get; set; }

    /// <summary>
    /// Classif. max. strip width delta from aim
    /// </summary>
    public short? WClassMaxDelta { get; set; }

    /// <summary>
    /// Classif. min. strip width delta from aim
    /// </summary>
    public short? WClassMinDelta { get; set; }

    /// <summary>
    /// transfer bar width
    /// </summary>
    public short? WidthEntryFm { get; set; }

    /// <summary>
    /// Finished strip width
    /// </summary>
    public short? WidthExit { get; set; }

    /// <summary>
    /// width exit orderd by customer
    /// </summary>
    public short? WidthExitCustomer { get; set; }

    /// <summary>
    /// Customer limit for maximum width
    /// </summary>
    public short? WidthLimitMaxCust { get; set; }

    /// <summary>
    /// Customer limit for minimum width
    /// </summary>
    public short? WidthLimitMinCust { get; set; }

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
