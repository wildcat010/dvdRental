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
    /// Alloy compensation for thickness
    /// </summary>
    public float? AlloyCompensation { get; set; }

    /// <summary>
    /// Amount of bindings circumferential
    /// </summary>
    public short? AmountBindings { get; set; }

    /// <summary>
    /// Amount of bindings radial
    /// </summary>
    public short? AmountBindingsR { get; set; }

    /// <summary>
    /// Unit[m/s] casting speed
    /// </summary>
    public float? CastSpeed { get; set; }

    /// <summary>
    /// Unit[m/s] minimun casting speed to roll product
    /// </summary>
    public float? CastSpeedMin { get; set; }

    /// <summary>
    /// 0 = normal strip or plate,   1 = checker strip or plate
    /// </summary>
    public int? CheckerFlag { get; set; }

    /// <summary>
    /// Unit[m] Checker height
    /// </summary>
    public float? CheckerHeight { get; set; }

    /// <summary>
    /// Unit[m] Classif. max. strip crown delta from aim C40
    /// </summary>
    public float? ClassMaxCrownDelta { get; set; }

    /// <summary>
    /// Unit[I-unit] Classif. max. strip flatness delta for asymetric flatness
    /// </summary>
    public float? ClassMaxFlatDeltaAsym { get; set; }

    /// <summary>
    /// Unit[I-unit] Classif. max. strip flatness delta for symetric flatness
    /// </summary>
    public float? ClassMaxFlatDeltaSym { get; set; }

    /// <summary>
    /// Unit[m] Classif. max strip wedge delta from 0
    /// </summary>
    public float? ClassMaxWedgeDelta { get; set; }

    /// <summary>
    /// Unit[m] Classif. min. strip crown delta from aim C40
    /// </summary>
    public float? ClassMinCrownDelta { get; set; }

    /// <summary>
    /// Unit[I-unit] Classif. min. strip flatness delta for symetric flatness
    /// </summary>
    public float? ClassMinFlatDeltaSym { get; set; }

    /// <summary>
    /// Unit[m] Classif. min strip wedge delta from 0
    /// </summary>
    public float? ClassMinWedgeDelta { get; set; }

    /// <summary>
    /// Unit[_C] Cooling Section: Coil target temperature for body of strip
    /// </summary>
    public float? CoilTemp { get; set; }

    /// <summary>
    /// Unit[_C] CoolingSection: Max cooling section exit strip temperature delta
    /// </summary>
    public float? CoilTempMaxTol { get; set; }

    /// <summary>
    /// Unit[_C] CoolingSection: Min cooling section exit strip temperature delta
    /// </summary>
    public float? CoilTempMinTol { get; set; }

    /// <summary>
    /// Unit[_C] CoolingSection: (not used for Arvedi) Coil profile temperature head
    /// </summary>
    public float? CoilTempProfileHead { get; set; }

    /// <summary>
    /// Unit[_C] CoolingSection: (not used for Arvedi) Coil profile temperature tail
    /// </summary>
    public float? CoilTempProfileTail { get; set; }

    /// <summary>
    /// CoolingSection:  (not used for Arvedi) when strips pass different numbers of valves on the way to the coiler
    /// </summary>
    public short? CoilerLocationSelection { get; set; }

    /// <summary>
    /// Unit[%] CS exit temperature fraction for transition (for carbon steel grades)
    /// </summary>
    public float? CoolExitF4t { get; set; }

    /// <summary>
    /// Unit[%] Load of fine cooling zone (for early and late cooling strategy)
    /// </summary>
    public int? CoolFineCzoneLoad { get; set; }

    /// <summary>
    /// Unit[0, 1] Cooling Section: Cooling rate  bottom (laminar cooling): 25%, 50%, 75%, 100% or coolRateBotIC for MPC
    /// </summary>
    public float? CoolRateBot { get; set; }

    /// <summary>
    /// Unit[0, 1] Cooling Section: Cooling rate  bottom 2nd phase (laminar cooling): 25%, 50%, 75%, 100%  or coolRateBotIC for MPC
    /// </summary>
    public float? CoolRateBot2 { get; set; }

    /// <summary>
    /// Unit[0, 1] Cooling Section: Cooling rate bottom 3rd phase (laminar cooling): 25%, 50%, 75%, 100%
    /// </summary>
    public float? CoolRateBot3 { get; set; }

    /// <summary>
    /// Unit[0, 1] Cooling Section: Cooling rate  top (laminar cooling): 25%, 50%, 75%, 100% or coolRateTopIC for MPC
    /// </summary>
    public float? CoolRateTop { get; set; }

    /// <summary>
    /// Unit[0, 1] Cooling Section: Cooling rate  top 2nd phase (laminar cooling): 25%, 50%, 75%, 100% or coolRateTop for MPC
    /// </summary>
    public float? CoolRateTop2 { get; set; }

    /// <summary>
    /// Unit[0, 1] Cooling Section: Cooling rate  top 3rd phase (laminar cooling): 25%, 50%, 75%, 100%
    /// </summary>
    public float? CoolRateTop3 { get; set; }

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
    public float? CsCoolRateRedHighBot { get; set; }

    /// <summary>
    /// Unit[0, 1] top coolrate reduction for areas above the transition temp
    /// </summary>
    public float? CsCoolRateRedHighTop { get; set; }

    /// <summary>
    /// Unit[0, 1] bottom coolrate reduction for areas below the transition temp
    /// </summary>
    public float? CsCoolRateRedLowBot { get; set; }

    /// <summary>
    /// Unit[0, 1] top coolrate reduction for areas below the transition temp
    /// </summary>
    public float? CsCoolRateRedLowTop { get; set; }

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
    public float? CsTransitionTemp { get; set; }

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
    /// Unit[s] time of slab in furnace (if available)
    /// </summary>
    public float? Duration { get; set; }

    /// <summary>
    /// Unit[m] Finished strip crown C25
    /// </summary>
    public float? ExitCrownC25 { get; set; }

    /// <summary>
    /// ( 0 for Arvedi) 0=no ferritic transformation in FM, 2=ferritic transformation between F2 and F3 is required, 3=ferritic transformation between F3 and F4 is required
    /// </summary>
    public short? FerriticRollingMode { get; set; }

    /// <summary>
    /// whether slab is first in heat
    /// </summary>
    public int? FirstInHeat { get; set; }

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
    /// (Arvedi not available)  stainless steel
    /// </summary>
    public int? FlagStainless { get; set; }

    /// <summary>
    /// CoolingSection: fraction for transition: desired fraction of non-austenitic material at coiler for high carbon steels
    /// </summary>
    public float? FractionForTransition { get; set; }

    /// <summary>
    /// Unit[m] Classif. max. strip alternative thickness delta from aim
    /// </summary>
    public float? HClassMaxAltDelta { get; set; }

    /// <summary>
    /// Unit[m] Classif. max. strip thickness delta from aim
    /// </summary>
    public float? HClassMaxDelta { get; set; }

    /// <summary>
    /// Unit[m] Classif. min strip alternative thickness delta from aim
    /// </summary>
    public float? HClassMinAltDelta { get; set; }

    /// <summary>
    /// Unit[m] Classif. min. strip thickness delta from aim
    /// </summary>
    public float? HClassMinDelta { get; set; }

    /// <summary>
    /// Unit[m] Finished strip thickness
    /// </summary>
    public float? HExit { get; set; }

    /// <summary>
    /// Unit[m] Finished strip alternative thickness
    /// </summary>
    public float? HExitAlt { get; set; }

    /// <summary>
    /// Finishing strip thickness(only for marking
    /// </summary>
    public float? HExitCus { get; set; }

    /// <summary>
    /// Only for HMI: status exit thickness FM
    /// </summary>
    public int? HExitStat { get; set; }

    /// <summary>
    /// thickness after HRM (plate)
    /// </summary>
    public float? HIntermediate { get; set; }

    /// <summary>
    /// Unit[m] alternativ plate thickness
    /// </summary>
    public float? HPlateAlt { get; set; }

    /// <summary>
    /// Unit[_C] Cooling Section: Dual/Triple phase steel: hold temperature after first phase
    /// </summary>
    public float? HoldTemp { get; set; }

    /// <summary>
    /// Unit[_C] Cooling Section: Triple phase steel: hold temperature after second phase
    /// </summary>
    public float? HoldTemp2 { get; set; }

    /// <summary>
    /// Unit[s] Cooling Section: Dual/Triple phase steel: hold time after first phase
    /// </summary>
    public float? HoldTime { get; set; }

    /// <summary>
    /// Unit[s] Cooling Section: Triple phase steel: hold time after second phase
    /// </summary>
    public float? HoldTime2 { get; set; }

    /// <summary>
    /// Row order identifier from L3
    /// </summary>
    public int? IdRiga { get; set; }

    /// <summary>
    /// Sequence identifier from L3
    /// </summary>
    public int? IdSeq { get; set; }

    /// <summary>
    /// 0: no inspection 1: inspection required
    /// </summary>
    public int? IncspectionFlag { get; set; }

    /// <summary>
    /// Sampling/inspection code
    /// </summary>
    public int? InspectionCode { get; set; }

    /// <summary>
    /// Unit[m] Slab length setpoint
    /// </summary>
    public float? LengthOrder { get; set; }

    /// <summary>
    /// Unit[m] CoolingSection: (not used for Arvedi) Length coil profile temperature head
    /// </summary>
    public float? LengthProfileHead { get; set; }

    /// <summary>
    /// Unit[m] CoolingSection: (not used for Arvedi) Length coil profile temperature tail
    /// </summary>
    public float? LengthProfileTail { get; set; }

    /// <summary>
    /// Unit[m] CoolingSection: Length of uncooled head
    /// </summary>
    public float? LengthUncooledHead { get; set; }

    /// <summary>
    /// Unit[m] CoolingSection: Length of uncooled tail
    /// </summary>
    public float? LengthUncooledTail { get; set; }

    /// <summary>
    /// identification, material data OK = 1
    /// </summary>
    public int? Ok { get; set; }

    /// <summary>
    /// (Arvedi not available)  parent actual material creator (before divide)
    /// </summary>
    public string ParentActMeCreator { get; set; }

    /// <summary>
    /// (Arvedi not available)  parent actual material identification (before divide)
    /// </summary>
    public int? ParentActMeId { get; set; }

    /// <summary>
    /// (Arvedi not available) parent actual material workstep (before divide)
    /// </summary>
    public short? ParentActMesId { get; set; }

    /// <summary>
    /// (Arvedi not available) parent basis id (before divide)
    /// </summary>
    public short? ParentBasId { get; set; }

    /// <summary>
    /// (Arvedi not available)parent external material identification (before divide)
    /// </summary>
    public string ParentExtId { get; set; }

    /// <summary>
    /// (Arvedi not available)parent material typ (before divide)
    /// </summary>
    public string ParentMeTyp { get; set; }

    /// <summary>
    /// (Arvedi not available)parent original material creator (before divide)
    /// </summary>
    public string ParentOriMeCreator { get; set; }

    /// <summary>
    /// (Arvedi not available)parent original material identification (before divide)
    /// </summary>
    public int? ParentOriMeId { get; set; }

    /// <summary>
    /// (Arvedi not available)parent original workstep (before divide)
    /// </summary>
    public short? ParentOriMesId { get; set; }

    /// <summary>
    /// Unit[%] (Arvedi not available)percent of slab length planned for the first strip
    /// </summary>
    public float? PlannedDivision { get; set; }

    /// <summary>
    /// target profile for HRM exit, 1 = 1prz
    /// </summary>
    public float? RMtargProfile { get; set; }

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
    /// Steel grade customer (only for marking
    /// </summary>
    public string SteelCus { get; set; }

    /// <summary>
    /// Unit[_C] Classif. max. strip temperature delta
    /// </summary>
    public float? TClassMaxDelta { get; set; }

    /// <summary>
    /// Unit[_C] Classif. min. strip temperature delta
    /// </summary>
    public float? TClassMinDelta { get; set; }

    /// <summary>
    /// Unit[_C] average slab core temperature calculated
    /// </summary>
    public float? TCore { get; set; }

    /// <summary>
    /// Unit[0, 1] Cooling Section: Hold fraction for transition after first cooling phase (for dual/triple phase cooling strategy)
    /// </summary>
    public float? TCsHoldF4t { get; set; }

    /// <summary>
    /// Unit[0, 1] Cooling Section: Hold fraction for transition after second cooling phase (for triple phase cooling strategy)
    /// </summary>
    public float? TCsHoldF4t2 { get; set; }

    /// <summary>
    /// Unit[_C] Finished strip temperature
    /// </summary>
    public float? TExit { get; set; }

    /// <summary>
    /// Unit[_C] Slab casting hand over temperature setpoint
    /// </summary>
    public float? TExitCaster { get; set; }

    /// <summary>
    /// Unit[_C] calculated head temperature at position X
    /// </summary>
    public float? THeadXInd0 { get; set; }

    /// <summary>
    /// Unit[_C] calculated head temperature at position X
    /// </summary>
    public float? THeadXInd1 { get; set; }

    /// <summary>
    /// Unit[_C] calculated head temperature at position X
    /// </summary>
    public float? THeadXInd10 { get; set; }

    /// <summary>
    /// Unit[_C] calculated head temperature at position X
    /// </summary>
    public float? THeadXInd11 { get; set; }

    /// <summary>
    /// Unit[_C] calculated head temperature at position X
    /// </summary>
    public float? THeadXInd12 { get; set; }

    /// <summary>
    /// Unit[_C] calculated head temperature at position X
    /// </summary>
    public float? THeadXInd13 { get; set; }

    /// <summary>
    /// Unit[_C] calculated head temperature at position X
    /// </summary>
    public float? THeadXInd14 { get; set; }

    /// <summary>
    /// Unit[_C] calculated head temperature at position X
    /// </summary>
    public float? THeadXInd15 { get; set; }

    /// <summary>
    /// Unit[_C] calculated head temperature at position X
    /// </summary>
    public float? THeadXInd16 { get; set; }

    /// <summary>
    /// Unit[_C] calculated head temperature at position X
    /// </summary>
    public float? THeadXInd17 { get; set; }

    /// <summary>
    /// Unit[_C] calculated head temperature at position X
    /// </summary>
    public float? THeadXInd18 { get; set; }

    /// <summary>
    /// Unit[_C] calculated head temperature at position X
    /// </summary>
    public float? THeadXInd19 { get; set; }

    /// <summary>
    /// Unit[_C] calculated head temperature at position X
    /// </summary>
    public float? THeadXInd2 { get; set; }

    /// <summary>
    /// Unit[_C] calculated head temperature at position X
    /// </summary>
    public float? THeadXInd20 { get; set; }

    /// <summary>
    /// Unit[_C] calculated head temperature at position X
    /// </summary>
    public float? THeadXInd3 { get; set; }

    /// <summary>
    /// Unit[_C] calculated head temperature at position X
    /// </summary>
    public float? THeadXInd4 { get; set; }

    /// <summary>
    /// Unit[_C] calculated head temperature at position X
    /// </summary>
    public float? THeadXInd5 { get; set; }

    /// <summary>
    /// Unit[_C] calculated head temperature at position X
    /// </summary>
    public float? THeadXInd6 { get; set; }

    /// <summary>
    /// Unit[_C] calculated head temperature at position X
    /// </summary>
    public float? THeadXInd7 { get; set; }

    /// <summary>
    /// Unit[_C] calculated head temperature at position X
    /// </summary>
    public float? THeadXInd8 { get; set; }

    /// <summary>
    /// Unit[_C] calculated head temperature at position X
    /// </summary>
    public float? THeadXInd9 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate (Head) for tHeadX
    /// </summary>
    public float? TPosHeadXInd0 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate (Head) for tHeadX
    /// </summary>
    public float? TPosHeadXInd1 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate (Head) for tHeadX
    /// </summary>
    public float? TPosHeadXInd10 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate (Head) for tHeadX
    /// </summary>
    public float? TPosHeadXInd11 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate (Head) for tHeadX
    /// </summary>
    public float? TPosHeadXInd12 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate (Head) for tHeadX
    /// </summary>
    public float? TPosHeadXInd13 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate (Head) for tHeadX
    /// </summary>
    public float? TPosHeadXInd14 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate (Head) for tHeadX
    /// </summary>
    public float? TPosHeadXInd15 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate (Head) for tHeadX
    /// </summary>
    public float? TPosHeadXInd16 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate (Head) for tHeadX
    /// </summary>
    public float? TPosHeadXInd17 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate (Head) for tHeadX
    /// </summary>
    public float? TPosHeadXInd18 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate (Head) for tHeadX
    /// </summary>
    public float? TPosHeadXInd19 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate (Head) for tHeadX
    /// </summary>
    public float? TPosHeadXInd2 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate (Head) for tHeadX
    /// </summary>
    public float? TPosHeadXInd20 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate (Head) for tHeadX
    /// </summary>
    public float? TPosHeadXInd3 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate (Head) for tHeadX
    /// </summary>
    public float? TPosHeadXInd4 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate (Head) for tHeadX
    /// </summary>
    public float? TPosHeadXInd5 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate (Head) for tHeadX
    /// </summary>
    public float? TPosHeadXInd6 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate (Head) for tHeadX
    /// </summary>
    public float? TPosHeadXInd7 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate (Head) for tHeadX
    /// </summary>
    public float? TPosHeadXInd8 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate (Head) for tHeadX
    /// </summary>
    public float? TPosHeadXInd9 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate for tX (starting with 0 for top  surfac e temperature, ending with 100 for bottom surface temperature)
    /// </summary>
    public float? TPosXInd0 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate for tX (starting with 0 for top  surfac e temperature, ending with 100 for bottom surface temperature)
    /// </summary>
    public float? TPosXInd1 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate for tX (starting with 0 for top  surfac e temperature, ending with 100 for bottom surface temperature)
    /// </summary>
    public float? TPosXInd10 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate for tX (starting with 0 for top  surfac e temperature, ending with 100 for bottom surface temperature)
    /// </summary>
    public float? TPosXInd11 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate for tX (starting with 0 for top  surfac e temperature, ending with 100 for bottom surface temperature)
    /// </summary>
    public float? TPosXInd12 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate for tX (starting with 0 for top  surfac e temperature, ending with 100 for bottom surface temperature)
    /// </summary>
    public float? TPosXInd13 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate for tX (starting with 0 for top  surfac e temperature, ending with 100 for bottom surface temperature)
    /// </summary>
    public float? TPosXInd14 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate for tX (starting with 0 for top  surfac e temperature, ending with 100 for bottom surface temperature)
    /// </summary>
    public float? TPosXInd15 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate for tX (starting with 0 for top  surfac e temperature, ending with 100 for bottom surface temperature)
    /// </summary>
    public float? TPosXInd16 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate for tX (starting with 0 for top  surfac e temperature, ending with 100 for bottom surface temperature)
    /// </summary>
    public float? TPosXInd17 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate for tX (starting with 0 for top  surfac e temperature, ending with 100 for bottom surface temperature)
    /// </summary>
    public float? TPosXInd18 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate for tX (starting with 0 for top  surfac e temperature, ending with 100 for bottom surface temperature)
    /// </summary>
    public float? TPosXInd19 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate for tX (starting with 0 for top  surfac e temperature, ending with 100 for bottom surface temperature)
    /// </summary>
    public float? TPosXInd2 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate for tX (starting with 0 for top  surfac e temperature, ending with 100 for bottom surface temperature)
    /// </summary>
    public float? TPosXInd20 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate for tX (starting with 0 for top  surfac e temperature, ending with 100 for bottom surface temperature)
    /// </summary>
    public float? TPosXInd3 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate for tX (starting with 0 for top  surfac e temperature, ending with 100 for bottom surface temperature)
    /// </summary>
    public float? TPosXInd4 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate for tX (starting with 0 for top  surfac e temperature, ending with 100 for bottom surface temperature)
    /// </summary>
    public float? TPosXInd5 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate for tX (starting with 0 for top  surfac e temperature, ending with 100 for bottom surface temperature)
    /// </summary>
    public float? TPosXInd6 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate for tX (starting with 0 for top  surfac e temperature, ending with 100 for bottom surface temperature)
    /// </summary>
    public float? TPosXInd7 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate for tX (starting with 0 for top  surfac e temperature, ending with 100 for bottom surface temperature)
    /// </summary>
    public float? TPosXInd8 { get; set; }

    /// <summary>
    /// Unit[%] Thickness coordinate for tX (starting with 0 for top  surfac e temperature, ending with 100 for bottom surface temperature)
    /// </summary>
    public float? TPosXInd9 { get; set; }

    /// <summary>
    /// Unit[_C] measured slab temperature
    /// </summary>
    public float? TSlab { get; set; }

    /// <summary>
    /// Unit[_C] ( not used for Arvedi) target temperature where the conversion ends
    /// </summary>
    public float? TTemperatureFeEnd { get; set; }

    /// <summary>
    /// Unit[_C] ( not used for Arvedi) target temperature where the conversion starts ferritic rolling
    /// </summary>
    public float? TTemperatureFeStart { get; set; }

    /// <summary>
    /// Unit[_C] calculated temperature at position X
    /// </summary>
    public float? TXInd0 { get; set; }

    /// <summary>
    /// Unit[_C] calculated temperature at position X
    /// </summary>
    public float? TXInd1 { get; set; }

    /// <summary>
    /// Unit[_C] calculated temperature at position X
    /// </summary>
    public float? TXInd10 { get; set; }

    /// <summary>
    /// Unit[_C] calculated temperature at position X
    /// </summary>
    public float? TXInd11 { get; set; }

    /// <summary>
    /// Unit[_C] calculated temperature at position X
    /// </summary>
    public float? TXInd12 { get; set; }

    /// <summary>
    /// Unit[_C] calculated temperature at position X
    /// </summary>
    public float? TXInd13 { get; set; }

    /// <summary>
    /// Unit[_C] calculated temperature at position X
    /// </summary>
    public float? TXInd14 { get; set; }

    /// <summary>
    /// Unit[_C] calculated temperature at position X
    /// </summary>
    public float? TXInd15 { get; set; }

    /// <summary>
    /// Unit[_C] calculated temperature at position X
    /// </summary>
    public float? TXInd16 { get; set; }

    /// <summary>
    /// Unit[_C] calculated temperature at position X
    /// </summary>
    public float? TXInd17 { get; set; }

    /// <summary>
    /// Unit[_C] calculated temperature at position X
    /// </summary>
    public float? TXInd18 { get; set; }

    /// <summary>
    /// Unit[_C] calculated temperature at position X
    /// </summary>
    public float? TXInd19 { get; set; }

    /// <summary>
    /// Unit[_C] calculated temperature at position X
    /// </summary>
    public float? TXInd2 { get; set; }

    /// <summary>
    /// Unit[_C] calculated temperature at position X
    /// </summary>
    public float? TXInd20 { get; set; }

    /// <summary>
    /// Unit[_C] calculated temperature at position X
    /// </summary>
    public float? TXInd3 { get; set; }

    /// <summary>
    /// Unit[_C] calculated temperature at position X
    /// </summary>
    public float? TXInd4 { get; set; }

    /// <summary>
    /// Unit[_C] calculated temperature at position X
    /// </summary>
    public float? TXInd5 { get; set; }

    /// <summary>
    /// Unit[_C] calculated temperature at position X
    /// </summary>
    public float? TXInd6 { get; set; }

    /// <summary>
    /// Unit[_C] calculated temperature at position X
    /// </summary>
    public float? TXInd7 { get; set; }

    /// <summary>
    /// Unit[_C] calculated temperature at position X
    /// </summary>
    public float? TXInd8 { get; set; }

    /// <summary>
    /// Unit[_C] calculated temperature at position X
    /// </summary>
    public float? TXInd9 { get; set; }

    /// <summary>
    /// finished strip target flatness
    /// </summary>
    public float? TargetFlatness { get; set; }

    /// <summary>
    /// Unit[_C] Cooling Section: (not used for Arvedi) temperature behind the compact cooling section
    /// </summary>
    public float? TempBehindCompCool { get; set; }

    /// <summary>
    /// Unit[_C] CoolingSection: (not used for Arvedi) temperature Gradient
    /// </summary>
    public float? TempCrit { get; set; }

    /// <summary>
    /// Unit[_C/s] CoolingSection: (not used for Arvedi) critical temperature
    /// </summary>
    public float? TempGrad { get; set; }

    /// <summary>
    /// Unit[m] Classif. max. strip width delta from aim
    /// </summary>
    public float? WClassMaxDelta { get; set; }

    /// <summary>
    /// Unit[m] Classif. min. strip width delta from aim
    /// </summary>
    public float? WClassMinDelta { get; set; }

    /// <summary>
    /// Unit[m] transfer bar width
    /// </summary>
    public float? WidthEntryFm { get; set; }

    /// <summary>
    /// Unit[m] Finished strip width
    /// </summary>
    public float? WidthExit { get; set; }

    /// <summary>
    /// Finishing strip width (only for marking device)
    /// </summary>
    public float? WidthExitCus { get; set; }

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

    public string OrderNo { get; set; }

    public virtual Me1 Me1 { get; set; }
}
