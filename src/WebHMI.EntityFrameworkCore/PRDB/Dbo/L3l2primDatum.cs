using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class L3l2primDatum
{
    /// <summary>
    /// unique communication ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Heat order
    /// </summary>
    public string HeatPlanId { get; set; }

    /// <summary>
    /// Unit[mm/min] aim for casting speed
    /// </summary>
    public float? AimCastSpeed { get; set; }

    /// <summary>
    /// planned heat identification
    /// </summary>
    public string AimHeatId { get; set; }

    /// <summary>
    /// Unit[ym] Planned thickness at entry of HRM slab
    /// </summary>
    public float? AimSlabThickness { get; set; }

    /// <summary>
    /// Unit[kg] Planned weight coil
    /// </summary>
    public float? AimSlabWeight { get; set; }

    /// <summary>
    /// Unit[1/10 mm] Planned width slab
    /// </summary>
    public float? AimSlabWidthHead { get; set; }

    /// <summary>
    /// Unit[1/10] Alloy compensation for thickness measurement device
    /// </summary>
    public float? AlloyCompensation { get; set; }

    /// <summary>
    /// Amount of bindings circumferential
    /// </summary>
    public int? AmountBindingsC { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Aluminium (total)
    /// </summary>
    public float? AnalysisAl { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Aluminium (soluble)
    /// </summary>
    public float? AnalysisAls { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Arsenic
    /// </summary>
    public float? AnalysisAs { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Boron
    /// </summary>
    public float? AnalysisB { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Bismuth
    /// </summary>
    public float? AnalysisBi { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Carbon
    /// </summary>
    public float? AnalysisC { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Calcium
    /// </summary>
    public float? AnalysisCa { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Cerum
    /// </summary>
    public float? AnalysisCe { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Cobalt
    /// </summary>
    public float? AnalysisCo { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Chrome
    /// </summary>
    public float? AnalysisCr { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Copper
    /// </summary>
    public float? AnalysisCu { get; set; }

    /// <summary>
    /// Analysis flag ( 0=default analysis for the steel grade, 1=melt shop analysis, 2=caster analysis)
    /// </summary>
    public int? AnalysisFlag { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Hydrogen
    /// </summary>
    public float? AnalysisH { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Magnesium
    /// </summary>
    public float? AnalysisMg { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Manganese
    /// </summary>
    public float? AnalysisMn { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Molybdaen
    /// </summary>
    public float? AnalysisMo { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Nitrogen
    /// </summary>
    public float? AnalysisN { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Niob
    /// </summary>
    public float? AnalysisNb { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Nickel
    /// </summary>
    public float? AnalysisNi { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Oxygen
    /// </summary>
    public float? AnalysisO { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Phosphor
    /// </summary>
    public float? AnalysisP { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Lead
    /// </summary>
    public float? AnalysisPb { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Sulfur
    /// </summary>
    public float? AnalysisS { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Antimon
    /// </summary>
    public float? AnalysisSb { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Silicon
    /// </summary>
    public float? AnalysisSi { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Tin
    /// </summary>
    public float? AnalysisSn { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Reserve
    /// </summary>
    public float? AnalysisSpare1 { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Reserve
    /// </summary>
    public float? AnalysisSpare10 { get; set; }

    /// <summary>
    /// Unit[%] 
    /// </summary>
    public float? AnalysisSpare11 { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Reserve
    /// </summary>
    public float? AnalysisSpare2 { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Reserve
    /// </summary>
    public float? AnalysisSpare3 { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Reserve
    /// </summary>
    public float? AnalysisSpare4 { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Reserve
    /// </summary>
    public float? AnalysisSpare5 { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Reserve
    /// </summary>
    public float? AnalysisSpare6 { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Reserve
    /// </summary>
    public float? AnalysisSpare7 { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Reserve
    /// </summary>
    public float? AnalysisSpare8 { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Reserve
    /// </summary>
    public float? AnalysisSpare9 { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Titanium
    /// </summary>
    public float? AnalysisTi { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Vanadium
    /// </summary>
    public float? AnalysisV { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Tungsten
    /// </summary>
    public float? AnalysisW { get; set; }

    /// <summary>
    /// Unit[%] Analysis of Zirkon
    /// </summary>
    public float? AnalysisZr { get; set; }

    /// <summary>
    /// 0: endless rolling in FM, 1: batch rolling in FM, (possibility for flexible decision, if thickness can be done in both modes)
    /// </summary>
    public int? BatchRolling { get; set; }

    public int? CheckerFlag { get; set; }

    /// <summary>
    /// Unit[m] 
    /// </summary>
    public float? CheckerHeight { get; set; }

    /// <summary>
    /// Unit[nm] Classif. maximal strip crown delta from aim C40
    /// </summary>
    public float? CrownClasMax { get; set; }

    /// <summary>
    /// Unit[%] cooling rate bottom for early / late cooling and 1. cooling phase of dual phase strategy (1-100)
    /// </summary>
    public float? CsCoolingRateBot { get; set; }

    /// <summary>
    /// Unit[%] cooling rate bottom for 2. cooling phase of dual phase strategy(1-100)
    /// </summary>
    public int? CsCoolingRateBot2 { get; set; }

    /// <summary>
    /// Unit[%] cooling rate top for early / late cooling and 1. cooling phase of dual phase strategy (1-100)
    /// </summary>
    public float? CsCoolingRateTop { get; set; }

    /// <summary>
    /// Unit[%] cooling rate top for 2. cooling phase of dual phase strategy(1-100)
    /// </summary>
    public int? CsCoolingRateTop2 { get; set; }

    /// <summary>
    /// 1 _ early cooling, 2 _ late cooling, 6 _ dual phase cooling
    /// </summary>
    public int? CsCoolingStrategy { get; set; }

    /// <summary>
    /// 0 = Use directives  from Look up table deposited in the L2, 1= Use directives of the PDI  (L3)
    /// </summary>
    public int? CsDataSourcePriority { get; set; }

    /// <summary>
    /// Unit[%] Load of fine cooling zone (for early and late cooling strategy)
    /// </summary>
    public int? CsFineCoolingZoneLoad { get; set; }

    /// <summary>
    /// spline number for temperature dependent bottom cooling rate (for dual phase cooling)
    /// </summary>
    public int? CsSplineIndexBot { get; set; }

    /// <summary>
    /// spline number for temperature dependent top cooling rate (for dual phase cooling)
    /// </summary>
    public int? CsSplineIndexTop { get; set; }

    /// <summary>
    /// Start valve bottom for first cooling zone
    /// </summary>
    public int? CsStartValveBot { get; set; }

    /// <summary>
    /// Start valve top for first cooling zone
    /// </summary>
    public int? CsStartValveTop { get; set; }

    /// <summary>
    /// Start valve top for second cooling zone (only used for dual phase cooling strategy
    /// </summary>
    public int? CsStartValveTop2 { get; set; }

    /// <summary>
    /// No. of dilatometer curve to be applied
    /// </summary>
    public int? DilatometerCurve { get; set; }

    /// <summary>
    /// Unit[nm] Finished strip crown C40
    /// </summary>
    public float? ExitCrownC25 { get; set; }

    /// <summary>
    /// Flag delivery specification, 0 = Coil Yard, 1= cold rolling mill, 2 = Shipping client 1, only for operator information
    /// </summary>
    public int? FlagDelivery { get; set; }

    /// <summary>
    /// Unit[I-Unit] Classif. max. asymmetric strip flatness delta from 0
    /// </summary>
    public float? FlatAsymClasMax { get; set; }

    /// <summary>
    /// Unit[I-Unit] Classif. max. symmetric strip flatness delta from 0
    /// </summary>
    public float? FlatSymclasMax { get; set; }

    /// <summary>
    /// 0: real slab (sent by L3), 1: PD for ghost rolling (used for simulation)
    /// </summary>
    public int? GhostSlab { get; set; }

    /// <summary>
    /// Unit[ym] max.strip thickness delta from aim for classification purpose coil
    /// </summary>
    public float? HClasMax { get; set; }

    /// <summary>
    /// Unit[ym] min.strip thickness delta from aim for classification purpose coil
    /// </summary>
    public float? HClasMin { get; set; }

    /// <summary>
    /// Unit[ym] Finished strip/plate thickness coil
    /// </summary>
    public float? HExit { get; set; }

    /// <summary>
    /// Unit[ym] Finishing strip  thickness(only for marking device )
    /// </summary>
    public float? HExitCustomer { get; set; }

    /// <summary>
    /// Unit[ym] thickness at exit of HRM ( if NULL L2 decides automatically)
    /// </summary>
    public float? HIntermediate { get; set; }

    /// <summary>
    /// row order identifier from L3 and for L3 only
    /// </summary>
    public int? IdRiga { get; set; }

    /// <summary>
    /// sequence identifier from L3 and for L3 only
    /// </summary>
    public int? IdSeq { get; set; }

    /// <summary>
    /// Sampling/inspection code
    /// </summary>
    public int? InspectionCode { get; set; }

    /// <summary>
    /// 0: no inspection, 1: inspection required
    /// </summary>
    public int? InspectionFlag { get; set; }

    /// <summary>
    /// Virtual slab identification
    /// </summary>
    public string L3SlabId { get; set; }

    /// <summary>
    /// Unit[kg] maximum slab weight (used as cutting limit for the strip, in case of same sequence ID)
    /// </summary>
    public float? MaxSlabWeight { get; set; }

    /// <summary>
    /// Unit[mm/min] minimum casting speed to roll this material
    /// </summary>
    public float? MinCastSpeed { get; set; }

    /// <summary>
    /// Unit[kg] minimum slab weight (used as cutting limit for the strip, in case of same sequence ID)
    /// </summary>
    public float? MinSlabWeight { get; set; }

    /// <summary>
    /// 0: strip, 1: plate
    /// </summary>
    public int? PlateProduction { get; set; }

    /// <summary>
    /// sequence identification
    /// </summary>
    public string SequenceId { get; set; }

    /// <summary>
    /// steel type ordered by customer (for marking device only)
    /// </summary>
    public string SteelCustomer { get; set; }

    /// <summary>
    /// Steel grade
    /// </summary>
    public string SteelGrade { get; set; }

    /// <summary>
    /// Unit[_C] Classif. max. strip temperature delta
    /// </summary>
    public float? TClasMax { get; set; }

    /// <summary>
    /// Unit[_C] Classif. min. strip temperature delta
    /// </summary>
    public float? TClasMin { get; set; }

    /// <summary>
    /// Unit[_C] Cooling section exit strip temperature
    /// </summary>
    public float? TCsExit { get; set; }

    /// <summary>
    /// Unit[%] CS exit temperature fraction for transition (for carbon steel grades)
    /// </summary>
    public float? TCsExitF4t { get; set; }

    /// <summary>
    /// Unit[m] strip head profile length
    /// </summary>
    public float? TCsExitProfileHeadLength { get; set; }

    /// <summary>
    /// Unit[_C] strip head profile temperature
    /// </summary>
    public float? TCsExitProfileHeadTemp { get; set; }

    /// <summary>
    /// Unit[m] strip tail profile length
    /// </summary>
    public float? TCsExitProfileTailLength { get; set; }

    /// <summary>
    /// Unit[_C] strip tail profile temperature
    /// </summary>
    public float? TCsExitProfileTailTemp { get; set; }

    /// <summary>
    /// Unit[_C] Min. cooling section exit strip temperature delta
    /// </summary>
    public float? TCsExitTolNeg { get; set; }

    /// <summary>
    /// Unit[_C] Max. cooling section exit strip temperature delta
    /// </summary>
    public float? TCsExitTolPos { get; set; }

    /// <summary>
    /// Unit[mm] Length of uncooled head
    /// </summary>
    public float? TCsExitUncooledHeadLength { get; set; }

    /// <summary>
    /// Unit[mm] Length of uncooled tail
    /// </summary>
    public float? TCsExitUncooledTailLength { get; set; }

    /// <summary>
    /// Unit[%] dual phase steel hold fraction for transition
    /// </summary>
    public float? TCsHoldF4t { get; set; }

    /// <summary>
    /// Unit[_C] dual phase steel: hold temperature
    /// </summary>
    public float? TCsHoldTemperature { get; set; }

    /// <summary>
    /// Unit[s] dual phase steel: hold time
    /// </summary>
    public float? TCsHoldTime { get; set; }

    /// <summary>
    /// Unit[_C] Finished strip temperature
    /// </summary>
    public float? TExit { get; set; }

    /// <summary>
    /// Unit[nm] Classif. max. strip wedge delta from 0
    /// </summary>
    public float? WedgeClasMax { get; set; }

    /// <summary>
    /// Unit[1/10 mm] Planned width change
    /// </summary>
    public float? WidthChange { get; set; }

    /// <summary>
    /// 0=width change at the end of the coil, 1=width change at the head of the coil, 2=width change over entire coil
    /// </summary>
    public int? WidthChangeFlag { get; set; }

    /// <summary>
    /// Unit[1/10 mm] maximal strip width delta from aim for classification purpose coil
    /// </summary>
    public float? WidthClasMax { get; set; }

    /// <summary>
    /// Unit[1/10 mm] minimal strip width delta from aim for classification purpose coil
    /// </summary>
    public float? WidthClasMin { get; set; }

    /// <summary>
    /// Unit[1/10 mm] Finished strip customer width coil
    /// </summary>
    public float? WidthExit { get; set; }

    /// <summary>
    /// Unit[1/10 mm] Finishing strip width (only for marking device )
    /// </summary>
    public float? WidthExitCustomer { get; set; }

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
