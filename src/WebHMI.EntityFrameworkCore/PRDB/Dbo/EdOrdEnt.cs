using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class EdOrdEnt
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
    public int? BendModeFlag { get; set; }

    /// <summary>
    /// Unit[m/s] casting speed
    /// </summary>
    public double? CastSpeed { get; set; }

    /// <summary>
    /// Unit[m/s] minimun casting speed to roll product
    /// </summary>
    public double? CastSpeedMin { get; set; }

    /// <summary>
    /// 0 = normal strip or plate,   1 = checker strip or plate
    /// </summary>
    public int? CheckerFlag { get; set; }

    /// <summary>
    /// Unit[m] Checker height
    /// </summary>
    public double? CheckerHeight { get; set; }

    /// <summary>
    /// Unit[m] Classif. max. strip crown delta from aim C40
    /// </summary>
    public double? ClassMaxCrownDelta { get; set; }

    /// <summary>
    /// Unit[I-unit] Classif. max. strip flatness delta for asymetric flatness
    /// </summary>
    public double? ClassMaxFlatDeltaAsym { get; set; }

    /// <summary>
    /// Unit[I-unit] Classif. max. strip flatness delta for symetric flatness
    /// </summary>
    public double? ClassMaxFlatDeltaSym { get; set; }

    /// <summary>
    /// Unit[m] Classif. max strip wedge delta from 0
    /// </summary>
    public double? ClassMaxWedgeDelta { get; set; }

    /// <summary>
    /// Unit[m] Classif. min. strip crown delta from aim C40
    /// </summary>
    public double? ClassMinCrownDelta { get; set; }

    /// <summary>
    /// Unit[I-unit] Classif. min. strip flatness delta for symetric flatness
    /// </summary>
    public double? ClassMinFlatDeltaSym { get; set; }

    /// <summary>
    /// Unit[m] Classif. min strip wedge delta from 0
    /// </summary>
    public double? ClassMinWedgeDelta { get; set; }

    /// <summary>
    /// Unit[_C] Cooling Section: Coil target temperature for body of strip
    /// </summary>
    public double? CoilTemp { get; set; }

    /// <summary>
    /// Unit[m] Customer limit for maximum coil temp
    /// </summary>
    public double? CoilTempLimitMaxCust { get; set; }

    /// <summary>
    /// Unit[m] Customer limit for minimum coil temp
    /// </summary>
    public double? CoilTempLimitMinCust { get; set; }

    /// <summary>
    /// Unit[_C] CoolingSection: Max cooling section exit strip temperature delta
    /// </summary>
    public double? CoilTempMaxTol { get; set; }

    /// <summary>
    /// Unit[_C] CoolingSection: Min cooling section exit strip temperature delta
    /// </summary>
    public double? CoilTempMinTol { get; set; }

    /// <summary>
    /// Unit[_C] CoolingSection: (not used for Arvedi) Coil profile temperature head
    /// </summary>
    public double? CoilTempProfileHead { get; set; }

    /// <summary>
    /// Unit[_C] CoolingSection: (not used for Arvedi) Coil profile temperature tail
    /// </summary>
    public double? CoilTempProfileTail { get; set; }

    /// <summary>
    /// Coil Yard Destination
    /// </summary>
    public short? CoilYard { get; set; }

    /// <summary>
    /// CoolingSection:  (not used for Arvedi) when strips pass different numbers of valves on the way to the coiler
    /// </summary>
    public short? CoilerLocationSelection { get; set; }

    /// <summary>
    /// Unit[%] CS exit temperature fraction for transition (for carbon steel grades)
    /// </summary>
    public double? CoolExitF4t { get; set; }

    /// <summary>
    /// Unit[%] Load of fine cooling zone (for early and late cooling strategy)
    /// </summary>
    public int? CoolFineCzoneLoad { get; set; }

    /// <summary>
    /// Unit[0, 1] Cooling Section: Cooling rate  bottom (laminar cooling): 25%, 50%, 75%, 100% or coolRateBotIC for MPC
    /// </summary>
    public double? CoolRateBot { get; set; }

    /// <summary>
    /// Unit[0, 1] Cooling Section: Cooling rate  bottom 2nd phase (laminar cooling): 25%, 50%, 75%, 100%  or coolRateBotIC for MPC
    /// </summary>
    public double? CoolRateBot2 { get; set; }

    /// <summary>
    /// Unit[0, 1] Cooling Section: Cooling rate bottom 3rd phase (laminar cooling): 25%, 50%, 75%, 100%
    /// </summary>
    public double? CoolRateBot3 { get; set; }

    /// <summary>
    /// Unit[0, 1] Cooling Section: Cooling rate  top (laminar cooling): 25%, 50%, 75%, 100% or coolRateTopIC for MPC
    /// </summary>
    public double? CoolRateTop { get; set; }

    /// <summary>
    /// Unit[0, 1] Cooling Section: Cooling rate  top 2nd phase (laminar cooling): 25%, 50%, 75%, 100% or coolRateTop for MPC
    /// </summary>
    public double? CoolRateTop2 { get; set; }

    /// <summary>
    /// Unit[0, 1] Cooling Section: Cooling rate  top 3rd phase (laminar cooling): 25%, 50%, 75%, 100%
    /// </summary>
    public double? CoolRateTop3 { get; set; }

    /// <summary>
    /// Cooling Section: 0 - no dual phase, 1 - dual phase steel
    /// </summary>
    public int? CoolStrategy { get; set; }

    /// <summary>
    /// Cooling Section: 0 = use directives from look up table deposited in the L2, 1 = use directives of the PDI
    /// </summary>
    public short? CoolingStrategyModeSelection { get; set; }

    /// <summary>
    /// Unit[0, 1] bottom coolrate reduction for areas above the transition temp
    /// </summary>
    public double? CsCoolRateRedHighBot { get; set; }

    /// <summary>
    /// Unit[0, 1] top coolrate reduction for areas above the transition temp
    /// </summary>
    public double? CsCoolRateRedHighTop { get; set; }

    /// <summary>
    /// Unit[0, 1] bottom coolrate reduction for areas below the transition temp
    /// </summary>
    public double? CsCoolRateRedLowBot { get; set; }

    /// <summary>
    /// Unit[0, 1] top coolrate reduction for areas below the transition temp
    /// </summary>
    public double? CsCoolRateRedLowTop { get; set; }

    /// <summary>
    /// Cooling Section: Load of fine cooling zone (for early and late cooling strategy)
    /// </summary>
    public int? CsFineCoolingZoneLoad { get; set; }

    /// <summary>
    /// Cooling Section: Index of pyrometer to be used for final adaptation early/late or first phase adaptation for SP/DP/TP
    /// </summary>
    public int? CsLeadingPyrometerIndex { get; set; }

    /// <summary>
    /// Cooling Section: Index of pyrometer to be used for second phase adaptation for DP/TP
    /// </summary>
    public int? CsLeadingPyrometerIndex2 { get; set; }

    /// <summary>
    /// Cooling Section: Index of pyrometer to be used for third phase adaptation for TP
    /// </summary>
    public int? CsLeadingPyrometerIndex3 { get; set; }

    /// <summary>
    /// spline number for temperature dependent bottom cooling rate (for dual phase cooling)
    /// </summary>
    public int? CsSplineIndexBot { get; set; }

    /// <summary>
    /// spline number for temperature dependent top cooling rate (for dual phase cooling)
    /// </summary>
    public int? CsSplineIndexTop { get; set; }

    /// <summary>
    /// Unit[_C] transition temperature for coolrate reduction from high to low
    /// </summary>
    public double? CsTransitionTemp { get; set; }

    /// <summary>
    /// Cooling Section: Index of valve sequence to be used
    /// </summary>
    public int? CsValveSequenceIndex { get; set; }

    /// <summary>
    /// from flagDelivery
    /// </summary>
    public int? Destination { get; set; }

    /// <summary>
    /// no. of dilatometer curve to be applied
    /// </summary>
    public int? DilatometerCurve { get; set; }

    /// <summary>
    /// Unit[m] 
    /// </summary>
    public double? EdgeMask { get; set; }

    /// <summary>
    /// Unit[m] Finished strip crown C40
    /// </summary>
    public double? ExitCrownC40 { get; set; }

    /// <summary>
    /// ( 0 for Arvedi) 0=no ferritic transformation in FM, 2=ferritic transformation between F2 and F3 is required, 3=ferritic transformation between F3 and F4 is required
    /// </summary>
    public short? FerriticRollingMode { get; set; }

    /// <summary>
    /// 1=alternative thickness is used
    /// </summary>
    public int? FlagAltThick { get; set; }

    /// <summary>
    /// 0: semi endless rolling; 1: batch rolling
    /// </summary>
    public int? FlagBatchRolling { get; set; }

    /// <summary>
    /// CoolingSection: (not used for Arvedi)1=compact cooling only, 2=laminar cooling only, 3=combined cooling
    /// </summary>
    public short? FlagCompactCool { get; set; }

    /// <summary>
    /// (Arvedi not available) flag diamond: 0 = normal strip, 1 = diamond strip
    /// </summary>
    public int? FlagDiamond { get; set; }

    /// <summary>
    /// (Arvedi not available) 0 = not divided, 1 = first part, 2 = second part
    /// </summary>
    public int? FlagDivide { get; set; }

    /// <summary>
    /// flag 1 -dual phase
    /// </summary>
    public int? FlagDualPhase { get; set; }

    /// <summary>
    /// 0: strip production, 1: plate production
    /// </summary>
    public int? FlagPlateProd { get; set; }

    /// <summary>
    /// flag speed change requested from caster 0= no , 1=yes
    /// </summary>
    public int? FlagSpeedReqCas { get; set; }

    /// <summary>
    /// Unit[m] Customer limit for maximum fm exit temp
    /// </summary>
    public double? FmTempLimitMaxCust { get; set; }

    /// <summary>
    /// Unit[m] Customer limit for minimum fm exit temp
    /// </summary>
    public double? FmTempLimitMinCust { get; set; }

    /// <summary>
    /// CoolingSection: fraction for transition: desired fraction of non-austenitic material at coiler for high carbon steels
    /// </summary>
    public double? FractionForTransition { get; set; }

    /// <summary>
    /// Unit[m] Classif. max. strip alternative thickness delta from aim
    /// </summary>
    public double? HClassMaxAltDelta { get; set; }

    /// <summary>
    /// Unit[m] Classif. max. strip thickness delta from aim
    /// </summary>
    public double? HClassMaxDelta { get; set; }

    /// <summary>
    /// Unit[m] Classif. min strip alternative thickness delta from aim
    /// </summary>
    public double? HClassMinAltDelta { get; set; }

    /// <summary>
    /// Unit[m] Classif. min. strip thickness delta from aim
    /// </summary>
    public double? HClassMinDelta { get; set; }

    /// <summary>
    /// Unit[m] Finished strip thickness
    /// </summary>
    public double? HExit { get; set; }

    /// <summary>
    /// Unit[m] Finished strip alternative thickness
    /// </summary>
    public double? HExitAlt { get; set; }

    /// <summary>
    /// exit thickness ordered by customer
    /// </summary>
    public double? HExitCustomer { get; set; }

    /// <summary>
    /// thickness after HRM (plate)
    /// </summary>
    public double? HIntermediate { get; set; }

    /// <summary>
    /// Unit[m] alternativ plate thickness
    /// </summary>
    public double? HPlateAlt { get; set; }

    /// <summary>
    /// Unit[_C] Cooling Section: Dual/Triple phase steel: hold temperature after first phase
    /// </summary>
    public double? HoldTemp { get; set; }

    /// <summary>
    /// Unit[_C] Cooling Section: Triple phase steel: hold temperature after second phase
    /// </summary>
    public double? HoldTemp2 { get; set; }

    /// <summary>
    /// Unit[s] Cooling Section: Dual/Triple phase steel: hold time after first phase
    /// </summary>
    public double? HoldTime { get; set; }

    /// <summary>
    /// Unit[s] Cooling Section: Triple phase steel: hold time after second phase
    /// </summary>
    public double? HoldTime2 { get; set; }

    /// <summary>
    /// Sampling/inspection code
    /// </summary>
    public int? InspectionCode { get; set; }

    /// <summary>
    /// 0: no inspection 1: inspection required
    /// </summary>
    public int? InspectionFlag { get; set; }

    /// <summary>
    /// Unit[m] exit length of coil
    /// </summary>
    public double? LExit { get; set; }

    /// <summary>
    /// Unit[m] Slab length setpoint
    /// </summary>
    public double? LengthOrder { get; set; }

    /// <summary>
    /// Unit[m] CoolingSection: (not used for Arvedi) Length coil profile temperature head
    /// </summary>
    public double? LengthProfileHead { get; set; }

    /// <summary>
    /// Unit[m] CoolingSection: (not used for Arvedi) Length coil profile temperature tail
    /// </summary>
    public double? LengthProfileTail { get; set; }

    /// <summary>
    /// Unit[m] CoolingSection: Length of uncooled head
    /// </summary>
    public double? LengthUncooledHead { get; set; }

    /// <summary>
    /// Unit[m] CoolingSection: Length of uncooled tail
    /// </summary>
    public double? LengthUncooledTail { get; set; }

    /// <summary>
    /// identification, material data OK = 1
    /// </summary>
    public int? Ok { get; set; }

    /// <summary>
    /// Order number for the end customer
    /// </summary>
    public string OrderNo { get; set; }

    /// <summary>
    /// target profile for HRM exit, 1 = 1prz
    /// </summary>
    public double? RmTargProfile { get; set; }

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
    /// Unit[_C] Classif. max. strip temperature delta
    /// </summary>
    public double? TClassMaxDelta { get; set; }

    /// <summary>
    /// Unit[_C] Classif. min. strip temperature delta
    /// </summary>
    public double? TClassMinDelta { get; set; }

    /// <summary>
    /// Unit[_C] average slab core temperature calculated
    /// </summary>
    public double? TCore { get; set; }

    /// <summary>
    /// Unit[0, 1] Cooling Section: Hold fraction for transition after first cooling phase (for dual/triple phase cooling strategy)
    /// </summary>
    public double? TCsHoldF4t { get; set; }

    /// <summary>
    /// Unit[0, 1] Cooling Section: Hold fraction for transition after second cooling phase (for triple phase cooling strategy)
    /// </summary>
    public double? TCsHoldF4t2 { get; set; }

    /// <summary>
    /// Unit[_C] Finished strip temperature
    /// </summary>
    public double? TExit { get; set; }

    /// <summary>
    /// Unit[_C] Slab casting hand over temperature setpoint
    /// </summary>
    public double? TExitCaster { get; set; }

    /// <summary>
    /// Unit[_C] measured slab temperature
    /// </summary>
    public double? TSlab { get; set; }

    /// <summary>
    /// Unit[_C] ( not used for Arvedi) target temperature where the conversion ends
    /// </summary>
    public double? TTemperatureFeEnd { get; set; }

    /// <summary>
    /// Unit[_C] ( not used for Arvedi) target temperature where the conversion starts ferritic rolling
    /// </summary>
    public double? TTemperatureFeStart { get; set; }

    /// <summary>
    /// finished strip target flatness
    /// </summary>
    public double? TargetFlatness { get; set; }

    /// <summary>
    /// Unit[_C] Cooling Section: (not used for Arvedi) temperature behind the compact cooling section
    /// </summary>
    public double? TempBehindCompCool { get; set; }

    /// <summary>
    /// Unit[_C] CoolingSection: (not used for Arvedi) temperature Gradient
    /// </summary>
    public double? TempCrit { get; set; }

    /// <summary>
    /// Unit[_C/s] CoolingSection: (not used for Arvedi) critical temperature
    /// </summary>
    public double? TempGrad { get; set; }

    /// <summary>
    /// Unit[m] Customer limit for maximum thickness
    /// </summary>
    public double? ThickLimitMaxCust { get; set; }

    /// <summary>
    /// Unit[m] Customer limit for minimum thickness
    /// </summary>
    public double? ThickLimitMinCust { get; set; }

    /// <summary>
    /// Unit[m] Classif. max. strip width delta from aim
    /// </summary>
    public double? WClassMaxDelta { get; set; }

    /// <summary>
    /// Unit[m] Classif. min. strip width delta from aim
    /// </summary>
    public double? WClassMinDelta { get; set; }

    /// <summary>
    /// Unit[m] transfer bar width
    /// </summary>
    public double? WidthEntryFm { get; set; }

    /// <summary>
    /// Unit[m] Finished strip width
    /// </summary>
    public double? WidthExit { get; set; }

    /// <summary>
    /// Unit[m] width exit orderd by customer
    /// </summary>
    public double? WidthExitCustomer { get; set; }

    /// <summary>
    /// Unit[m] Customer limit for maximum width
    /// </summary>
    public double? WidthLimitMaxCust { get; set; }

    /// <summary>
    /// Unit[m] Customer limit for minimum width
    /// </summary>
    public double? WidthLimitMinCust { get; set; }

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
