using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class L2l3prodDatum
{
    /// <summary>
    /// unique communication ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// first heat in this coil
    /// </summary>
    public string HeatId1 { get; set; }

    /// <summary>
    /// second heat in this coil in case of mixed coil
    /// </summary>
    public string HeatId2 { get; set; }

    /// <summary>
    /// active coiler
    /// </summary>
    public short? ActiveCoiler { get; set; }

    /// <summary>
    /// Unit[m/s] aim for casting speed
    /// </summary>
    public float? AimCastSpeed { get; set; }

    /// <summary>
    /// planned heat identification
    /// </summary>
    public string AimHeatId { get; set; }

    /// <summary>
    /// Unit[m] Planned thickness at entry of HRM
    /// </summary>
    public float? AimSlabThickness { get; set; }

    /// <summary>
    /// Unit[kg] Planned weight
    /// </summary>
    public float? AimSlabWeight { get; set; }

    /// <summary>
    /// Unit[m] Planned width
    /// </summary>
    public float? AimSlabWidthHead { get; set; }

    /// <summary>
    /// Alloy compensation for thickness measurement device
    /// </summary>
    public float? AlloyCompensation { get; set; }

    /// <summary>
    /// Amount of bindings circumferential
    /// </summary>
    public int? AmountBindingsC { get; set; }

    /// <summary>
    /// 0: endless rolling in FM, 1: batch rolling in FM, (possibility for flexible decision, if thickness can be done in both modes)
    /// </summary>
    public int? BatchRolling { get; set; }

    /// <summary>
    /// Unit[m] Bottom backup roll identification
    /// </summary>
    public string BrIdBotInd0 { get; set; }

    /// <summary>
    /// Unit[m] Bottom backup roll identification
    /// </summary>
    public string BrIdBotInd1 { get; set; }

    /// <summary>
    /// Unit[m] Bottom backup roll identification
    /// </summary>
    public string BrIdBotInd2 { get; set; }

    /// <summary>
    /// Unit[m] Bottom backup roll identification
    /// </summary>
    public string BrIdBotInd3 { get; set; }

    /// <summary>
    /// Unit[m] Bottom backup roll identification
    /// </summary>
    public string BrIdBotInd4 { get; set; }

    /// <summary>
    /// Unit[m] Bottom backup roll identification
    /// </summary>
    public string BrIdBotInd5 { get; set; }

    /// <summary>
    /// Unit[m] Bottom backup roll identification
    /// </summary>
    public string BrIdBotInd6 { get; set; }

    /// <summary>
    /// Unit[m] Bottom backup roll identification
    /// </summary>
    public string BrIdBotInd7 { get; set; }

    /// <summary>
    /// Unit[m] Top backup roll identification
    /// </summary>
    public string BrIdTopInd0 { get; set; }

    /// <summary>
    /// Unit[m] Top backup roll identification
    /// </summary>
    public string BrIdTopInd1 { get; set; }

    /// <summary>
    /// Unit[m] Top backup roll identification
    /// </summary>
    public string BrIdTopInd2 { get; set; }

    /// <summary>
    /// Unit[m] Top backup roll identification
    /// </summary>
    public string BrIdTopInd3 { get; set; }

    /// <summary>
    /// Unit[m] Top backup roll identification
    /// </summary>
    public string BrIdTopInd4 { get; set; }

    /// <summary>
    /// Unit[m] Top backup roll identification
    /// </summary>
    public string BrIdTopInd5 { get; set; }

    /// <summary>
    /// Unit[m] Top backup roll identification
    /// </summary>
    public string BrIdTopInd6 { get; set; }

    /// <summary>
    /// Unit[m] Top backup roll identification
    /// </summary>
    public string BrIdTopInd7 { get; set; }

    /// <summary>
    /// Unit[m/s] Casting Speed value meas. average value
    /// </summary>
    public float? CastSpeedAvg { get; set; }

    /// <summary>
    /// Unit[m/s] Casting Speed value meas. max value
    /// </summary>
    public float? CastSpeedMax { get; set; }

    /// <summary>
    /// Unit[m/s] Casting Speed value meas. min value
    /// </summary>
    public float? CastSpeedMin { get; set; }

    /// <summary>
    /// Unit[m/s] Casting Speed value meas. standard deviation
    /// </summary>
    public float? CastSpeedSigma { get; set; }

    /// <summary>
    /// Unit[m] Coil inner diameter
    /// </summary>
    public float? CoilInDia { get; set; }

    /// <summary>
    /// Unit[m] Coil outer diameter
    /// </summary>
    public float? CoilOutDia { get; set; }

    /// <summary>
    /// Unit[kg] Coil weight
    /// </summary>
    public float? CoilWeight { get; set; }

    /// <summary>
    /// Unit[%] Cooling intensity bottom (laminar cooling), possible values: 0, 0.25, 0.5, 0.75, 1
    /// </summary>
    public float? CoolRateBot { get; set; }

    /// <summary>
    /// Unit[%] Cooling intensity  top (laminar cooling), possible values: 0, 0.25, 0.5, 0.75, 1
    /// </summary>
    public float? CoolRateTop { get; set; }

    /// <summary>
    /// 0=Use directives  from Look up table deposited in the L2, 1=Use directives of the PDI  (L3)
    /// </summary>
    public int? CoolingMode { get; set; }

    /// <summary>
    /// Unit[m] Classif. maximal strip crown delta from aim C40
    /// </summary>
    public int? CrownClasMax { get; set; }

    /// <summary>
    /// Unit[m] Strip crown set point
    /// </summary>
    public float? CrownExit { get; set; }

    /// <summary>
    /// Unit[m] Strip/slab crown meas. Value average
    /// </summary>
    public float? CrownExitAver { get; set; }

    /// <summary>
    /// Unit[m] Strip/slab crown head meas. value average
    /// </summary>
    public float? CrownExitHeadAver { get; set; }

    /// <summary>
    /// Unit[m] Strip/slab crown standard head deviaton
    /// </summary>
    public float? CrownExitHeadSigma { get; set; }

    /// <summary>
    /// Unit[m] Strip/slab crown meas.Max. Value
    /// </summary>
    public float? CrownExitMax { get; set; }

    /// <summary>
    /// Unit[m] Strip/slab crown meas.Min. Value
    /// </summary>
    public float? CrownExitMin { get; set; }

    /// <summary>
    /// Unit[m] Crown: length out of classification range
    /// </summary>
    public float? CrownExitOut { get; set; }

    /// <summary>
    /// Unit[m] Strip/slab crown standard deviaton
    /// </summary>
    public float? CrownExitSigma { get; set; }

    /// <summary>
    /// Unit[Pa] descaler in front of FM entry side
    /// </summary>
    public float? DescEntryPresAvg { get; set; }

    /// <summary>
    /// Unit[Pa] descaler in front of FM entry side maximum
    /// </summary>
    public float? DescEntryPresMax { get; set; }

    /// <summary>
    /// Unit[Pa] descaler in front of FM entry side minimum
    /// </summary>
    public float? DescEntryPresMin { get; set; }

    /// <summary>
    /// Unit[Pa] descaler in front of FM entry side sigma
    /// </summary>
    public float? DescEntryPresSigma { get; set; }

    /// <summary>
    /// Unit[Pa] descaler in front of FM exit side
    /// </summary>
    public float? DescExitPresAvg { get; set; }

    /// <summary>
    /// Unit[Pa] descaler in front of FM exit side maximum
    /// </summary>
    public float? DescExitPresMax { get; set; }

    /// <summary>
    /// Unit[Pa] descaler in front of FM exit side minimum
    /// </summary>
    public float? DescExitPresMin { get; set; }

    /// <summary>
    /// Unit[Pa] descaler in front of FM exit side sigma
    /// </summary>
    public float? DescExitPresSigma { get; set; }

    /// <summary>
    /// No. of dilatometer curve to be applied
    /// </summary>
    public int? DilatometerCurve { get; set; }

    /// <summary>
    /// 0=no dual phase steel, 1=dual phase steel
    /// </summary>
    public int? DualPhase { get; set; }

    /// <summary>
    /// end of coiling
    /// </summary>
    public DateTime? EndCoiling { get; set; }

    /// <summary>
    /// Unit[m] Head length for strip
    /// </summary>
    public float? ExitHeadLength { get; set; }

    /// <summary>
    /// Unit[m] start position of the head, measured values in front of this point are not used
    /// </summary>
    public float? ExitHeadStartPos { get; set; }

    /// <summary>
    /// First valve to be switched lower side,(laminar cooling section) (NULL -&gt; use L2 strategy)
    /// </summary>
    public int? FirstValveSwitchLo { get; set; }

    /// <summary>
    /// First valve to be switched upper side (laminar cooling section) (NULL -&gt; use L2 strategy)
    /// </summary>
    public int? FirstValveSwitchUp { get; set; }

    /// <summary>
    /// Unit[I-Unit] Classif. max. asymmetric strip flatness delta from 0
    /// </summary>
    public float? FlatAsymClasMax { get; set; }

    /// <summary>
    /// Unit[I-Unit] Strip flatness meas. max. value
    /// </summary>
    public float? FlatExitAsymMax { get; set; }

    /// <summary>
    /// Unit[I-Unit] Strip flatness meas. min. value
    /// </summary>
    public float? FlatExitAsymMin { get; set; }

    /// <summary>
    /// Unit[m] Flatness: length out of classification range
    /// </summary>
    public float? FlatExitAsymOut { get; set; }

    /// <summary>
    /// Unit[I-Unit] Strip flatness meas. value average
    /// </summary>
    public float? FlatExitAsymAver { get; set; }

    /// <summary>
    /// Unit[I-Unit] Strip flatness (symmetric) meas. value average
    /// </summary>
    public float? FlatExitSymAver { get; set; }

    /// <summary>
    /// Unit[I-Unit] Strip flatness (symmetric) meas. max. value
    /// </summary>
    public float? FlatExitSymMax { get; set; }

    /// <summary>
    /// Unit[I-Unit] Strip flatness (symmetric) meas. min. value
    /// </summary>
    public float? FlatExitSymMin { get; set; }

    /// <summary>
    /// Unit[m] Flatness symmetric: length out of classification range
    /// </summary>
    public float? FlatExitSymOut { get; set; }

    /// <summary>
    /// Unit[I-Unit] Classif. max. symmetric strip flatness delta from 0
    /// </summary>
    public float? FlatSymClasMax { get; set; }

    /// <summary>
    /// from Basket = 1 from PDI = 0
    /// </summary>
    public int? FromBasket { get; set; }

    /// <summary>
    /// Unit[m] max.strip thickness delta from aim for classification purpose
    /// </summary>
    public float? HClasMax { get; set; }

    /// <summary>
    /// Unit[m] min.strip thickness delta from aim for classification purpose
    /// </summary>
    public float? HClasMin { get; set; }

    /// <summary>
    /// Unit[m] Strip/slab thickness set point
    /// </summary>
    public float? HExit { get; set; }

    /// <summary>
    /// Unit[m] Strip/slab thickness meas. Value average
    /// </summary>
    public float? HExitAver { get; set; }

    /// <summary>
    /// Unit[m] exit thickness customer
    /// </summary>
    public float? HExitCustomer { get; set; }

    /// <summary>
    /// Unit[m] HRM thickness set point
    /// </summary>
    public float? HExitHrm { get; set; }

    /// <summary>
    /// Unit[m] HRM thickness meas. Value average
    /// </summary>
    public float? HExitHrmaver { get; set; }

    /// <summary>
    /// Unit[m] HRM thickness standard deviaton
    /// </summary>
    public float? HExitHrmsigma { get; set; }

    /// <summary>
    /// Unit[m] Strip/slab thickness head meas. value average
    /// </summary>
    public float? HExitHeadAver { get; set; }

    /// <summary>
    /// Unit[m] Strip/slab thickness standard head deviaton
    /// </summary>
    public float? HExitHeadSigma { get; set; }

    /// <summary>
    /// Unit[%] Thickness deviation: within classification range of 100_m
    /// </summary>
    public float? HExitIn100 { get; set; }

    /// <summary>
    /// Unit[%] Thickness deviation: within classification range of 150_m
    /// </summary>
    public float? HExitIn150 { get; set; }

    /// <summary>
    /// Unit[%] Thickness deviation: within classification range of 200_m
    /// </summary>
    public float? HExitIn200 { get; set; }

    /// <summary>
    /// Unit[%] Thickness deviation: within classification range of 50_m
    /// </summary>
    public float? HExitIn50 { get; set; }

    /// <summary>
    /// Unit[m] Strip/slab thickness meas.Max. Value
    /// </summary>
    public float? HExitMax { get; set; }

    /// <summary>
    /// Unit[m] Strip/slab thickness meas.Min. Value
    /// </summary>
    public float? HExitMin { get; set; }

    /// <summary>
    /// Unit[m] Thickness: length out of classification range
    /// </summary>
    public float? HExitOut { get; set; }

    /// <summary>
    /// Unit[m] Strip/slab thickness standard deviaton
    /// </summary>
    public float? HExitSigma { get; set; }

    /// <summary>
    /// treatment number of the heat 1
    /// </summary>
    public short? HeatTreatmentNo1 { get; set; }

    /// <summary>
    /// treatment number of the heat 2
    /// </summary>
    public short? HeatTreatmentNo2 { get; set; }

    /// <summary>
    /// Unit[_C] dual phase steel: hold temperature
    /// </summary>
    public float? HoldTemperature { get; set; }

    /// <summary>
    /// Unit[s] dual phase steel: hold time
    /// </summary>
    public float? HoldTime { get; set; }

    /// <summary>
    /// Row order identifier from L3
    /// </summary>
    public int? IdRiga { get; set; }

    /// <summary>
    /// Sequence identifier from L3
    /// </summary>
    public int? IdSeq { get; set; }

    /// <summary>
    /// flag is heat1 fully consumed 0 = no 1 = yes
    /// </summary>
    public short? IsHeat1Consumed { get; set; }

    /// <summary>
    /// flag is heat2 fully consumed 0 = no 1 = yes
    /// </summary>
    public short? IsHeat2Consumed { get; set; }

    /// <summary>
    /// Unit[m] Strip/plate length
    /// </summary>
    public float? Length { get; set; }

    /// <summary>
    /// Unit[m] Length of uncooled head (NULL -&gt; use L2 strategy)
    /// </summary>
    public float? LengthUncooledHead { get; set; }

    /// <summary>
    /// Unit[m] Length of uncooled tail (NULL -&gt; use L2 strategy)
    /// </summary>
    public float? LengthUncooledTail { get; set; }

    /// <summary>
    /// Unit[kg] maximum slab weight (used as cutting limit for the strip, in case of same sequence ID)
    /// </summary>
    public float? MaxSlabWeight { get; set; }

    /// <summary>
    /// Unit[kg] minimum slab weight (used as cutting limit for the strip, in case of same sequence ID)
    /// </summary>
    public float? MinSlabWeight { get; set; }

    /// <summary>
    /// Unit[%] percentage of 1st heat
    /// </summary>
    public float? PercentHeat1 { get; set; }

    /// <summary>
    /// Unit[%] percentage of 2nd heat in case od mixed (0 = not mixed)
    /// </summary>
    public float? PercentHeat2 { get; set; }

    /// <summary>
    /// plate production flag: 0 = coil 1 = plate
    /// </summary>
    public int? Plateproduction { get; set; }

    /// <summary>
    /// Plate ID or coil ID: In case of a coil: Coil ID = Slab ID + 
    /// </summary>
    public string ProductId { get; set; }

    /// <summary>
    /// sequence identification
    /// </summary>
    public string SequenceId { get; set; }

    /// <summary>
    /// related virtual slab ID, if from 2 slabs, choose the first
    /// </summary>
    public string SlabId { get; set; }

    /// <summary>
    /// start of coiling
    /// </summary>
    public DateTime? StartCoiling { get; set; }

    /// <summary>
    /// steel grade customer
    /// </summary>
    public string SteelCustomer { get; set; }

    /// <summary>
    /// Steel grade
    /// </summary>
    public string SteelGrade { get; set; }

    /// <summary>
    /// Unit[_C] temperature active coiler average
    /// </summary>
    public float? TActCoilerAvg { get; set; }

    /// <summary>
    /// Unit[_C] temperature active coiler max
    /// </summary>
    public float? TActCoilerMax { get; set; }

    /// <summary>
    /// Unit[_C] temperature active coiler min
    /// </summary>
    public float? TActCoilerMin { get; set; }

    /// <summary>
    /// Unit[_C] temperature active coiler sigma
    /// </summary>
    public float? TActCoilerSigma { get; set; }

    /// <summary>
    /// Unit[_C] Cooling section pyrometer 1 temperature meas. Value average
    /// </summary>
    public float? TCs1aver { get; set; }

    /// <summary>
    /// Unit[_C] Cooling section pyrometer 1  temperature meas. max. Value
    /// </summary>
    public float? TCs1max { get; set; }

    /// <summary>
    /// Unit[_C] Cooling section pyrometer 1  temperature meas. min. Value
    /// </summary>
    public float? TCs1min { get; set; }

    /// <summary>
    /// Unit[_C] Cooling section pyrometer 1  emperature standard deviaton
    /// </summary>
    public float? TCs1sigma { get; set; }

    /// <summary>
    /// Unit[_C] Cooling section pyrometer 2 temperature meas. Value average
    /// </summary>
    public float? TCs2aver { get; set; }

    /// <summary>
    /// Unit[_C] Cooling section pyrometer 2  temperature meas. max. Value
    /// </summary>
    public float? TCs2max { get; set; }

    /// <summary>
    /// Unit[_C] Cooling section pyrometer 2  temperature meas. min. Value
    /// </summary>
    public float? TCs2min { get; set; }

    /// <summary>
    /// Unit[_C] Cooling section pyrometer 2  emperature standard deviaton
    /// </summary>
    public float? TCs2sigma { get; set; }

    /// <summary>
    /// Unit[_C] Cooling section pyrometer 3 temperature meas. Value average
    /// </summary>
    public float? TCs3aver { get; set; }

    /// <summary>
    /// Unit[_C] Cooling section pyrometer 3  temperature meas. max. Value
    /// </summary>
    public float? TCs3max { get; set; }

    /// <summary>
    /// Unit[_C] Cooling section pyrometer 3  temperature meas. min. Value
    /// </summary>
    public float? TCs3min { get; set; }

    /// <summary>
    /// Unit[_C] Cooling section pyrometer 3  emperature standard deviaton
    /// </summary>
    public float? TCs3sigma { get; set; }

    /// <summary>
    /// Unit[_C] Classif. max. strip temperature delta
    /// </summary>
    public float? TClasMax { get; set; }

    /// <summary>
    /// Unit[_C] Classif. min. strip temperature delta
    /// </summary>
    public float? TClasMin { get; set; }

    /// <summary>
    /// Unit[_C] Max. cooling section exit strip temperature delta
    /// </summary>
    public float? TCoolMax { get; set; }

    /// <summary>
    /// Unit[_C] Min. cooling section exit strip temperature delta
    /// </summary>
    public float? TCoolMin { get; set; }

    /// <summary>
    /// Unit[_C] Strip temperature set point
    /// </summary>
    public float? TExit { get; set; }

    /// <summary>
    /// Unit[_C] Strip/slab temperature meas. Value average
    /// </summary>
    public float? TExitAver { get; set; }

    /// <summary>
    /// Unit[_C] Coiler temperature set point Cooling-Exit
    /// </summary>
    public float? TExitCs { get; set; }

    /// <summary>
    /// Unit[_C] Coiler temperature meas. Value average
    /// </summary>
    public float? TExitCsAver { get; set; }

    /// <summary>
    /// Unit[_C] Coiler temperature meas. max. value
    /// </summary>
    public float? TExitCsMax { get; set; }

    /// <summary>
    /// Unit[_C] Coiler temperature meas. min. value
    /// </summary>
    public float? TExitCsMin { get; set; }

    /// <summary>
    /// Unit[m] Coiler temperature: length out of classification range
    /// </summary>
    public float? TExitCsOut { get; set; }

    /// <summary>
    /// Unit[_C] Coiler temperature standard deviaton
    /// </summary>
    public float? TExitCsSigma { get; set; }

    /// <summary>
    /// Unit[m] HRM temperature set point
    /// </summary>
    public float? TExitHrm { get; set; }

    /// <summary>
    /// Unit[m] HRM temperature meas. Value average
    /// </summary>
    public float? TExitHrmaver { get; set; }

    /// <summary>
    /// Unit[m] HRM temperature standard deviaton
    /// </summary>
    public float? TExitHrmsigma { get; set; }

    /// <summary>
    /// Unit[_C] Strip/slab temperature meas. max. Value
    /// </summary>
    public float? TExitMax { get; set; }

    /// <summary>
    /// Unit[_C] Strip/slab temperature meas. min. Value
    /// </summary>
    public float? TExitMin { get; set; }

    /// <summary>
    /// Unit[m] Strip/slab temperature: length out of classification range
    /// </summary>
    public float? TExitOut { get; set; }

    /// <summary>
    /// Unit[_C] Strip/slab emperature standard deviaton
    /// </summary>
    public float? TExitSigma { get; set; }

    /// <summary>
    /// Unit[m] Strip width set point FM-Exit
    /// </summary>
    public float? WExit { get; set; }

    /// <summary>
    /// Unit[m] Strip width meas. Value average
    /// </summary>
    public float? WExitAver { get; set; }

    /// <summary>
    /// Unit[m] HRM width set point
    /// </summary>
    public float? WExitHrm { get; set; }

    /// <summary>
    /// Unit[m] HRM width meas. Value average
    /// </summary>
    public float? WExitHrmaver { get; set; }

    /// <summary>
    /// Unit[m] HRM width standard deviaton
    /// </summary>
    public float? WExitHrmsigma { get; set; }

    /// <summary>
    /// Unit[m] Strip/slab width head meas. value average
    /// </summary>
    public float? WExitHeadAver { get; set; }

    /// <summary>
    /// Unit[m] Strip/slab width standard head deviaton
    /// </summary>
    public float? WExitHeadSigma { get; set; }

    /// <summary>
    /// Unit[m] Strip width meas.Max. Value
    /// </summary>
    public float? WExitMax { get; set; }

    /// <summary>
    /// Unit[m] Strip width meas.Min. Value
    /// </summary>
    public float? WExitMin { get; set; }

    /// <summary>
    /// Unit[m] Width: length out of classification range
    /// </summary>
    public float? WExitOut { get; set; }

    /// <summary>
    /// Unit[m] Strip/slab width standard deviaton
    /// </summary>
    public float? WExitSigma { get; set; }

    /// <summary>
    /// Unit[m] roll wear gap correction
    /// </summary>
    public float? WearCorrWrInd0 { get; set; }

    /// <summary>
    /// Unit[m] roll wear gap correction
    /// </summary>
    public float? WearCorrWrInd1 { get; set; }

    /// <summary>
    /// Unit[m] roll wear gap correction
    /// </summary>
    public float? WearCorrWrInd2 { get; set; }

    /// <summary>
    /// Unit[m] roll wear gap correction
    /// </summary>
    public float? WearCorrWrInd3 { get; set; }

    /// <summary>
    /// Unit[m] roll wear gap correction
    /// </summary>
    public float? WearCorrWrInd4 { get; set; }

    /// <summary>
    /// Unit[m] roll wear gap correction
    /// </summary>
    public float? WearCorrWrInd5 { get; set; }

    /// <summary>
    /// Unit[m] roll wear gap correction
    /// </summary>
    public float? WearCorrWrInd6 { get; set; }

    /// <summary>
    /// Unit[m] roll wear gap correction
    /// </summary>
    public float? WearCorrWrInd7 { get; set; }

    /// <summary>
    /// Unit[m] Planned width change
    /// </summary>
    public float? WedgeClasMax { get; set; }

    /// <summary>
    /// Unit[m] Strip wedge meas. value average
    /// </summary>
    public float? WedgeExitAver { get; set; }

    /// <summary>
    /// Unit[m] Strip wedge meas. max. value
    /// </summary>
    public float? WedgeExitMax { get; set; }

    /// <summary>
    /// Unit[m] Strip wedge meas. min. value
    /// </summary>
    public float? WedgeExitMin { get; set; }

    /// <summary>
    /// Unit[m] Wedge: length out of classification range
    /// </summary>
    public float? WedgeExitOut { get; set; }

    /// <summary>
    /// Unit[m] Strip/slab wedge standard deviaton
    /// </summary>
    public float? WedgeExitSigma { get; set; }

    /// <summary>
    /// Unit[m] Planned width change
    /// </summary>
    public float? WidthChange { get; set; }

    /// <summary>
    /// 0=width change at the end of the coil, 1=width change cut as plate (scrap), 2=width change over entire coil
    /// </summary>
    public int? WidthChangeFlag { get; set; }

    /// <summary>
    /// Unit[m] maximal strip width delta from aim for classification purpose
    /// </summary>
    public float? WidthClasMax { get; set; }

    /// <summary>
    /// Unit[m] minimal strip width delta from aim for classification purpose
    /// </summary>
    public float? WidthClasMin { get; set; }

    /// <summary>
    /// Unit[m] exit width customer
    /// </summary>
    public float? WidthExitCustomer { get; set; }

    /// <summary>
    /// Unit[m] Bottom work roll identification
    /// </summary>
    public string WrIdBotInd0 { get; set; }

    /// <summary>
    /// Unit[m] Bottom work roll identification
    /// </summary>
    public string WrIdBotInd1 { get; set; }

    /// <summary>
    /// Unit[m] Bottom work roll identification
    /// </summary>
    public string WrIdBotInd2 { get; set; }

    /// <summary>
    /// Unit[m] Bottom work roll identification
    /// </summary>
    public string WrIdBotInd3 { get; set; }

    /// <summary>
    /// Unit[m] Bottom work roll identification
    /// </summary>
    public string WrIdBotInd4 { get; set; }

    /// <summary>
    /// Unit[m] Bottom work roll identification
    /// </summary>
    public string WrIdBotInd5 { get; set; }

    /// <summary>
    /// Unit[m] Bottom work roll identification
    /// </summary>
    public string WrIdBotInd6 { get; set; }

    /// <summary>
    /// Unit[m] Bottom work roll identification
    /// </summary>
    public string WrIdBotInd7 { get; set; }

    /// <summary>
    /// Unit[m] Top work roll identification
    /// </summary>
    public string WrIdTopInd0 { get; set; }

    /// <summary>
    /// Unit[m] Top work roll identification
    /// </summary>
    public string WrIdTopInd1 { get; set; }

    /// <summary>
    /// Unit[m] Top work roll identification
    /// </summary>
    public string WrIdTopInd2 { get; set; }

    /// <summary>
    /// Unit[m] Top work roll identification
    /// </summary>
    public string WrIdTopInd3 { get; set; }

    /// <summary>
    /// Unit[m] Top work roll identification
    /// </summary>
    public string WrIdTopInd4 { get; set; }

    /// <summary>
    /// Unit[m] Top work roll identification
    /// </summary>
    public string WrIdTopInd5 { get; set; }

    /// <summary>
    /// Unit[m] Top work roll identification
    /// </summary>
    public string WrIdTopInd6 { get; set; }

    /// <summary>
    /// Unit[m] Top work roll identification
    /// </summary>
    public string WrIdTopInd7 { get; set; }

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
