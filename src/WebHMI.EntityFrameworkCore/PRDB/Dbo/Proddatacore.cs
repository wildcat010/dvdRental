using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Core post-production dataset
/// </summary>
public partial class ProdDataCore
{
    /// <summary>
    /// basic automation id
    /// </summary>
    public int BasId { get; set; }

    /// <summary>
    /// coil id, ext id
    /// </summary>
    public string CoilId { get; set; }

    /// <summary>
    /// lev 2 id
    /// </summary>
    public int MeId { get; set; }

    /// <summary>
    /// aim for casting speed
    /// </summary>
    public double? AimCastSpeed { get; set; }

    /// <summary>
    /// Planned thickness at entry of HRM
    /// </summary>
    public double? AimSlabThickness { get; set; }

    /// <summary>
    /// Planned weight
    /// </summary>
    public double? AimSlabWeight { get; set; }

    /// <summary>
    /// Planned width
    /// </summary>
    public double? AimSlabWidthHead { get; set; }

    /// <summary>
    /// Alloy compensation for thickness measurement device
    /// </summary>
    public double? AlloyCompensation { get; set; }

    /// <summary>
    /// Amount of bindings circumferential
    /// </summary>
    public int? AmountBindingsC { get; set; }

    /// <summary>
    /// 0: endless rolling in FM, 1: batch rolling in FM, (possibility for flexible decision, if thickness can be done in both modes)
    /// </summary>
    public int? BatchRolling { get; set; }

    /// <summary>
    /// bending mode in FM
    /// </summary>
    public int? BendFmflag { get; set; }

    /// <summary>
    /// Casting Speed meas. average value
    /// </summary>
    public double? CastSpeedAvg { get; set; }

    /// <summary>
    /// Casting Speed meas. max value
    /// </summary>
    public double? CastSpeedMax { get; set; }

    /// <summary>
    /// Casting Speed meas. min value
    /// </summary>
    public double? CastSpeedMin { get; set; }

    /// <summary>
    /// Casting Speed meas. standard deviation
    /// </summary>
    public double? CastSpeedSigma { get; set; }

    /// <summary>
    /// Center of line deviation (L3)
    /// </summary>
    public double? CenterLineDev { get; set; }

    /// <summary>
    /// Center of line deviation max
    /// </summary>
    public double? CenterLineMax { get; set; }

    /// <summary>
    /// Center of line deviation min
    /// </summary>
    public double? CenterLineMin { get; set; }

    /// <summary>
    /// FM coil inner diameter (meas Value)
    /// </summary>
    public double? CoilInDiaX { get; set; }

    /// <summary>
    /// strip length of the whole exit-coil
    /// </summary>
    public double? CoilLengthX { get; set; }

    /// <summary>
    /// number of used coiler
    /// </summary>
    public short? CoilNo { get; set; }

    /// <summary>
    /// FM coil outer diameter (meas Value)
    /// </summary>
    public double? CoilOutDiaX { get; set; }

    /// <summary>
    /// Cooling intensity bottom (laminar cooling), possible values: 0, 0.25, 0.5, 0.75, 1
    /// </summary>
    public double? CoolRateBot { get; set; }

    /// <summary>
    /// Cooling intensity  top (laminar cooling), possible values: 0, 0.25, 0.5, 0.75, 1
    /// </summary>
    public double? CoolRateTop { get; set; }

    /// <summary>
    /// 0=Use directives  from Look up table deposited in the L2, 1=Use directives of the PDI  (L3)
    /// </summary>
    public int? CoolingMode { get; set; }

    /// <summary>
    /// Classif. maximal strip crown delta from aim C40
    /// </summary>
    public double? CrownClasMax { get; set; }

    /// <summary>
    /// descaler before FM pressure entry side average
    /// </summary>
    public double? DescEpresAvgFm { get; set; }

    /// <summary>
    /// descaler before HRM pressure entry side average
    /// </summary>
    public double? DescEpresAvgHrm { get; set; }

    /// <summary>
    /// descaler before FM pressure entry side maximum
    /// </summary>
    public double? DescEpresMaxFm { get; set; }

    /// <summary>
    /// descaler before HRM pressure entry side maximum
    /// </summary>
    public double? DescEpresMaxHrm { get; set; }

    /// <summary>
    /// descaler before FM pressure entry side minimum
    /// </summary>
    public double? DescEpresMinFm { get; set; }

    /// <summary>
    /// descaler before HRM pressure entry side minimum
    /// </summary>
    public double? DescEpresMinHrm { get; set; }

    /// <summary>
    /// descaler before FM pressure entry side sigma
    /// </summary>
    public double? DescEpresSigmaFm { get; set; }

    /// <summary>
    /// descaler before HRM pressure entry side sigma
    /// </summary>
    public double? DescEpresSigmaHrm { get; set; }

    /// <summary>
    /// descaler before FM pressure exit side average
    /// </summary>
    public double? DescXpresAvgFm { get; set; }

    /// <summary>
    /// descaler before HRM pressure exit side average
    /// </summary>
    public double? DescXpresAvgHrm { get; set; }

    /// <summary>
    /// descaler before FM pressure exit side minimum
    /// </summary>
    public double? DescXpresMaxFm { get; set; }

    /// <summary>
    /// descaler before HRM pressure exit side minimum
    /// </summary>
    public double? DescXpresMaxHrm { get; set; }

    /// <summary>
    /// descaler before FM pressure exit side minimum
    /// </summary>
    public double? DescXpresMinFm { get; set; }

    /// <summary>
    /// descaler before HRM pressure exit side minimum
    /// </summary>
    public double? DescXpresMinHrm { get; set; }

    /// <summary>
    /// descaler before FM pressure exit side sigma
    /// </summary>
    public double? DescXpresSigmaFm { get; set; }

    /// <summary>
    /// descaler before HRM pressure exit side sigma
    /// </summary>
    public double? DescXpresSigmaHrm { get; set; }

    /// <summary>
    /// No. of dilatometer curve to be applied
    /// </summary>
    public int? DilatometerCurve { get; set; }

    /// <summary>
    /// 0=no dual phase steel, 1=dual phase steel
    /// </summary>
    public int? DualPhase { get; set; }

    /// <summary>
    /// head length for strip (L3)
    /// </summary>
    public double? ExitHeadLength { get; set; }

    /// <summary>
    /// start position of the head,measured values in front of this point are not used (L3)
    /// </summary>
    public double? ExitHeadStartPos { get; set; }

    /// <summary>
    /// First valve to be switched lower side,(laminar cooling section) (NULL -&gt; use L2 strategy)
    /// </summary>
    public int? FirstValveSwitchLo { get; set; }

    /// <summary>
    /// First valve to be switched upper side (laminar cooling section) (NULL -&gt; use L2 strategy)
    /// </summary>
    public int? FirstValveSwitchUp { get; set; }

    /// <summary>
    /// strip flatness unsymetric (mean value)
    /// </summary>
    public double? FlatAsym { get; set; }

    /// <summary>
    /// strip flatness measured values average
    /// </summary>
    public double? FlatAsymAver { get; set; }

    /// <summary>
    /// Classif. max. asymmetric strip flatness delta from 0
    /// </summary>
    public double? FlatAsymClasMax { get; set; }

    /// <summary>
    /// strip unsymetric flatness
    /// </summary>
    public double? FlatAsymClassInd0 { get; set; }

    /// <summary>
    /// strip unsymetric flatness
    /// </summary>
    public double? FlatAsymClassInd1 { get; set; }

    /// <summary>
    /// strip unsymetric flatness
    /// </summary>
    public double? FlatAsymClassInd2 { get; set; }

    /// <summary>
    /// strip unsymetric flatness
    /// </summary>
    public double? FlatAsymClassInd3 { get; set; }

    /// <summary>
    /// strip flatness unsymetric (max. value)
    /// </summary>
    public double? FlatAsymMax { get; set; }

    /// <summary>
    /// strip flatness unsymetric (min. value)
    /// </summary>
    public double? FlatAsymMin { get; set; }

    /// <summary>
    /// strip flatness: length out of classification range
    /// </summary>
    public double? FlatAsymOut { get; set; }

    /// <summary>
    /// strip flatness symmetric (mean value)
    /// </summary>
    public double? FlatSym { get; set; }

    /// <summary>
    /// strip flatness symmetric meas. values average
    /// </summary>
    public double? FlatSymAver { get; set; }

    /// <summary>
    /// Classif. max. symmetric strip flatness delta from 0
    /// </summary>
    public double? FlatSymClasMax { get; set; }

    /// <summary>
    /// strip flatness symmetric
    /// </summary>
    public double? FlatSymClassInd0 { get; set; }

    /// <summary>
    /// strip flatness symmetric
    /// </summary>
    public double? FlatSymClassInd1 { get; set; }

    /// <summary>
    /// strip flatness symmetric
    /// </summary>
    public double? FlatSymClassInd2 { get; set; }

    /// <summary>
    /// strip flatness symmetric
    /// </summary>
    public double? FlatSymClassInd3 { get; set; }

    /// <summary>
    /// strip flatness symmetric  (max. value)
    /// </summary>
    public double? FlatSymMax { get; set; }

    /// <summary>
    /// strip flatness symmetric  (min. value)
    /// </summary>
    public double? FlatSymMin { get; set; }

    /// <summary>
    /// strip flatness symetric: length out of classification range
    /// </summary>
    public double? FlatSymOut { get; set; }

    /// <summary>
    /// max.strip thickness delta from aim for classification purpose
    /// </summary>
    public double? HClasMax { get; set; }

    /// <summary>
    /// min.strip thickness delta from aim for classification purpose
    /// </summary>
    public double? HClasMin { get; set; }

    /// <summary>
    /// HRM entry thickness mean value
    /// </summary>
    public double? HEntryHrm { get; set; }

    /// <summary>
    /// HRM entry thickness max value
    /// </summary>
    public double? HEntryHrmmax { get; set; }

    /// <summary>
    /// HRM entry thickness min value
    /// </summary>
    public double? HEntryHrmmin { get; set; }

    /// <summary>
    /// FM strip thickness (mean value)
    /// </summary>
    public double? HExit { get; set; }

    /// <summary>
    /// strip/slab thickness meas.values average
    /// </summary>
    public double? HExitAver { get; set; }

    /// <summary>
    /// FM strip thickness (classification)
    /// </summary>
    public double? HExitClassInd0 { get; set; }

    /// <summary>
    /// FM strip thickness (classification)
    /// </summary>
    public double? HExitClassInd1 { get; set; }

    /// <summary>
    /// FM strip thickness (classification)
    /// </summary>
    public double? HExitClassInd2 { get; set; }

    /// <summary>
    /// FM strip thickness (classification)
    /// </summary>
    public double? HExitClassInd3 { get; set; }

    /// <summary>
    /// FM strip thickness (classification)
    /// </summary>
    public double? HExitClassInd4 { get; set; }

    /// <summary>
    /// FM strip thickness (classification)
    /// </summary>
    public double? HExitClassInd5 { get; set; }

    /// <summary>
    /// FM strip thickness (classification)
    /// </summary>
    public double? HExitClassInd6 { get; set; }

    /// <summary>
    /// FM strip thickness (classification)
    /// </summary>
    public double? HExitClassInd7 { get; set; }

    /// <summary>
    /// FM strip thickness (classification)
    /// </summary>
    public double? HExitClassInd8 { get; set; }

    /// <summary>
    /// FM strip thickness (classification)
    /// </summary>
    public double? HExitClassInd9 { get; set; }

    /// <summary>
    /// exit  thickness customer
    /// </summary>
    public double? HExitCustomer { get; set; }

    /// <summary>
    /// exit thickness HRM setpoint(L3)
    /// </summary>
    public double? HExitHrm { get; set; }

    /// <summary>
    /// HRM thickness measurement values average
    /// </summary>
    public double? HExitHrmaver { get; set; }

    /// <summary>
    /// HRM thickness standard deviation
    /// </summary>
    public double? HExitHrmsigma { get; set; }

    /// <summary>
    /// Strip/slab head measurement value average
    /// </summary>
    public double? HExitHeadAver { get; set; }

    /// <summary>
    /// thickness : Strip/slab standard head deviation
    /// </summary>
    public double? HExitHeadSigma { get; set; }

    /// <summary>
    /// N/A
    /// </summary>
    public double? HExitIn100Minus { get; set; }

    /// <summary>
    /// thickness deviation within +/- 100 microns
    /// </summary>
    public double? HExitIn100Plus { get; set; }

    /// <summary>
    /// N/A
    /// </summary>
    public double? HExitIn150Minus { get; set; }

    /// <summary>
    /// thickness deviation within +/- 150 microns
    /// </summary>
    public double? HExitIn150Plus { get; set; }

    /// <summary>
    /// N/A
    /// </summary>
    public double? HExitIn200Minus { get; set; }

    /// <summary>
    /// thickness deviation within +/- 200 microns
    /// </summary>
    public double? HExitIn200Plus { get; set; }

    /// <summary>
    /// N/A
    /// </summary>
    public double? HExitIn50Minus { get; set; }

    /// <summary>
    /// thickness deviation within +/- 50 microns
    /// </summary>
    public double? HExitIn50Plus { get; set; }

    /// <summary>
    /// FM strip thickness (max value)
    /// </summary>
    public double? HExitMax { get; set; }

    /// <summary>
    /// FM strip thickness (min value)
    /// </summary>
    public double? HExitMin { get; set; }

    /// <summary>
    /// Thickness: length out of classification
    /// </summary>
    public double? HExitOut { get; set; }

    /// <summary>
    /// strip/slab thickness standard deviation
    /// </summary>
    public double? HExitSigma { get; set; }

    /// <summary>
    /// entry max thickness from caster
    /// </summary>
    public double? HHeadMax { get; set; }

    /// <summary>
    /// entry min thickness from caster
    /// </summary>
    public double? HHeadMin { get; set; }

    /// <summary>
    /// heat id first heat
    /// </summary>
    public string HeatId1 { get; set; }

    /// <summary>
    /// current heat name (planned name from L3, real name from SMP)
    /// </summary>
    public string HeatName { get; set; }

    /// <summary>
    /// heat treatment no from caster
    /// </summary>
    public short? HeatTreatmentNo1 { get; set; }

    /// <summary>
    /// heat treatment no from caster
    /// </summary>
    public short? HeatTreatmentNo2 { get; set; }

    /// <summary>
    /// heat id second heat
    /// </summary>
    public string Heatid2 { get; set; }

    /// <summary>
    /// dual phase steel: hold temperature
    /// </summary>
    public double? HoldTemperature { get; set; }

    /// <summary>
    /// dual phase steel: hold time
    /// </summary>
    public double? HoldTime { get; set; }

    /// <summary>
    /// Row order identifier from L3
    /// </summary>
    public int? IdRiga { get; set; }

    /// <summary>
    /// Sequence identifier from L3
    /// </summary>
    public int? IdSeq { get; set; }

    /// <summary>
    /// coil id for level 3
    /// </summary>
    public string L3CoilId { get; set; }

    /// <summary>
    /// Length of uncooled head (NULL -&gt; use L2 strategy)
    /// </summary>
    public double? LengthUncooledHead { get; set; }

    /// <summary>
    /// Length of uncooled tail (NULL -&gt; use L2 strategy)
    /// </summary>
    public double? LengthUncooledTail { get; set; }

    /// <summary>
    /// maximum slab weight (used as cutting limit for the strip, in case of same sequence ID)
    /// </summary>
    public double? MaxSlabWeight { get; set; }

    /// <summary>
    /// minimum slab weight (used as cutting limit for the strip, in case of same sequence ID)
    /// </summary>
    public double? MinSlabWeight { get; set; }

    /// <summary>
    /// number of orders
    /// </summary>
    public short? NoOrder { get; set; }

    /// <summary>
    /// oder length of the material
    /// </summary>
    public double? OrderLengthX { get; set; }

    /// <summary>
    /// ED.orderNo, from PDI
    /// </summary>
    public string OrderNo { get; set; }

    /// <summary>
    /// percent from first heat ID
    /// </summary>
    public double? PercentHeat1 { get; set; }

    /// <summary>
    /// percent from second heat ID
    /// </summary>
    public double? PercentHeat2 { get; set; }

    /// <summary>
    /// IH1 power
    /// </summary>
    public double? PowerIh1 { get; set; }

    /// <summary>
    /// IH10 power
    /// </summary>
    public double? PowerIh10 { get; set; }

    /// <summary>
    /// IH11 power
    /// </summary>
    public double? PowerIh11 { get; set; }

    /// <summary>
    /// IH12 power
    /// </summary>
    public double? PowerIh12 { get; set; }

    /// <summary>
    /// IH13 power
    /// </summary>
    public double? PowerIh13 { get; set; }

    /// <summary>
    /// IH14 power
    /// </summary>
    public double? PowerIh14 { get; set; }

    /// <summary>
    /// IH2 power
    /// </summary>
    public double? PowerIh2 { get; set; }

    /// <summary>
    /// IH3 power
    /// </summary>
    public double? PowerIh3 { get; set; }

    /// <summary>
    /// IH4 power
    /// </summary>
    public double? PowerIh4 { get; set; }

    /// <summary>
    /// IH5 power
    /// </summary>
    public double? PowerIh5 { get; set; }

    /// <summary>
    /// IH6 power
    /// </summary>
    public double? PowerIh6 { get; set; }

    /// <summary>
    /// IH7 power
    /// </summary>
    public double? PowerIh7 { get; set; }

    /// <summary>
    /// IH8 power
    /// </summary>
    public double? PowerIh8 { get; set; }

    /// <summary>
    /// IH9 power
    /// </summary>
    public double? PowerIh9 { get; set; }

    /// <summary>
    /// production end time
    /// </summary>
    public DateTime? ProdEnd { get; set; }

    /// <summary>
    /// production start time
    /// </summary>
    public DateTime? ProdStart { get; set; }

    /// <summary>
    /// Coil production time
    /// </summary>
    public int? ProdTime { get; set; }

    /// <summary>
    /// HRM profile entry mean value
    /// </summary>
    public double? ProfEntryHrm { get; set; }

    /// <summary>
    /// HRM entry profile max value
    /// </summary>
    public double? ProfEntryHrmmax { get; set; }

    /// <summary>
    /// HRM entry profile min value
    /// </summary>
    public double? ProfEntryHrmmin { get; set; }

    /// <summary>
    /// strip profile(crown) head standard deviation
    /// </summary>
    public double? ProfXheadAvg { get; set; }

    /// <summary>
    /// FM exit profile head standard deviation
    /// </summary>
    public double? ProfXheadSigma { get; set; }

    /// <summary>
    /// strip profile(crown) satndard deviation
    /// </summary>
    public double? ProfXsigma { get; set; }

    /// <summary>
    /// strip profile (mean value)
    /// </summary>
    public double? Profile { get; set; }

    /// <summary>
    /// strip profile (classification)
    /// </summary>
    public double? ProfileClassInd0 { get; set; }

    /// <summary>
    /// strip profile (classification)
    /// </summary>
    public double? ProfileClassInd1 { get; set; }

    /// <summary>
    /// strip profile (classification)
    /// </summary>
    public double? ProfileClassInd2 { get; set; }

    /// <summary>
    /// strip profile (classification)
    /// </summary>
    public double? ProfileClassInd3 { get; set; }

    /// <summary>
    /// strip profile(crown)average
    /// </summary>
    public double? ProfileExitAver { get; set; }

    /// <summary>
    /// profile(crown) length out of classification
    /// </summary>
    public double? ProfileExitOut { get; set; }

    /// <summary>
    /// strip profile (max. value)
    /// </summary>
    public double? ProfileMax { get; set; }

    /// <summary>
    /// strip profile (min. value)
    /// </summary>
    public double? ProfileMin { get; set; }

    /// <summary>
    /// sequence of cast
    /// </summary>
    public string SeqId { get; set; }

    /// <summary>
    /// sequence identification
    /// </summary>
    public string SequenceId { get; set; }

    /// <summary>
    /// shift identification
    /// </summary>
    public string Shift { get; set; }

    /// <summary>
    /// slab id from level3
    /// </summary>
    public string SlabId { get; set; }

    /// <summary>
    /// Status of transmision
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// steelgrade customer
    /// </summary>
    public string SteelCustomer { get; set; }

    /// <summary>
    /// steel grade
    /// </summary>
    public string SteelGrade { get; set; }

    /// <summary>
    /// FM entry temperature (mean value)
    /// </summary>
    public double? T1EntryFm { get; set; }

    /// <summary>
    /// FM entry temperature (max value)
    /// </summary>
    public double? T1EntryFmmax { get; set; }

    /// <summary>
    /// FM entry temperature (min value)
    /// </summary>
    public double? T1EntryFmmin { get; set; }

    /// <summary>
    /// FM entry temperature pyrometer 2 mean value
    /// </summary>
    public double? T2EntryFm { get; set; }

    /// <summary>
    /// FM entry temperature pyrometer 2 max value
    /// </summary>
    public double? T2EntryFmmax { get; set; }

    /// <summary>
    /// FM entry temperature pyrometer 2 min value
    /// </summary>
    public double? T2EntryFmmin { get; set; }

    /// <summary>
    /// HRM exit temperature pyro 2
    /// </summary>
    public double? T2ExitHrmaver { get; set; }

    /// <summary>
    /// HRM exit temperature sigma pyro2
    /// </summary>
    public double? T2ExitHrmsigma { get; set; }

    /// <summary>
    /// temperature at active coiler
    /// </summary>
    public double? TActCoilerAvg { get; set; }

    /// <summary>
    /// temperature at active coiler max
    /// </summary>
    public double? TActCoilerMax { get; set; }

    /// <summary>
    /// temperature at active coiler min
    /// </summary>
    public double? TActCoilerMin { get; set; }

    /// <summary>
    /// temperature at active coiler sigma
    /// </summary>
    public double? TActCoilerSig { get; set; }

    /// <summary>
    /// Ft1bCS temperature after FM average   Pyro 2
    /// </summary>
    public double? TCs12aver { get; set; }

    /// <summary>
    /// Ft1bCS temperature after FM maximum   Pyro 2
    /// </summary>
    public double? TCs12max { get; set; }

    /// <summary>
    /// Ft1bCS temperature after FM minimum    Pyro 2
    /// </summary>
    public double? TCs12min { get; set; }

    /// <summary>
    /// Ft1bCS temperature after FM sigma  Pyro 2
    /// </summary>
    public double? TCs12sigma { get; set; }

    /// <summary>
    /// CS exit temperature pyrometer 1  meas.values average
    /// </summary>
    public double? TCs1aver { get; set; }

    /// <summary>
    /// CS exit temperature pyrometer 1  max value
    /// </summary>
    public double? TCs1max { get; set; }

    /// <summary>
    /// CS exit temperature pyrometer 1 min value
    /// </summary>
    public double? TCs1min { get; set; }

    /// <summary>
    /// CS exit temperature pyrometer 1 standard deviation
    /// </summary>
    public double? TCs1sigma { get; set; }

    /// <summary>
    /// Ft2bCS temperature after FM average  Pyro 2
    /// </summary>
    public double? TCs22aver { get; set; }

    /// <summary>
    /// Ft2bCS temperature after FM maximum  Pyro 2
    /// </summary>
    public double? TCs22max { get; set; }

    /// <summary>
    /// Ft2bCS temperature after FM minimum   Pyro 2
    /// </summary>
    public double? TCs22min { get; set; }

    /// <summary>
    /// Ft2bCS temperature after FM sigma  Pyro 2
    /// </summary>
    public double? TCs22sigma { get; set; }

    /// <summary>
    /// CS exit temperature pyrometer 2  meas.values average
    /// </summary>
    public double? TCs2aver { get; set; }

    /// <summary>
    /// CS exit temperature pyrometer 2  max value
    /// </summary>
    public double? TCs2max { get; set; }

    /// <summary>
    /// CS exit temperature pyrometer 2 min value
    /// </summary>
    public double? TCs2min { get; set; }

    /// <summary>
    /// CS exit temperature pyrometer 2 standard deviation
    /// </summary>
    public double? TCs2sigma { get; set; }

    /// <summary>
    /// Ft3bCS temperature after FM average   Pyro 2
    /// </summary>
    public double? TCs32aver { get; set; }

    /// <summary>
    /// Ft3bCS temperature after FM maximum   Pyro 2
    /// </summary>
    public double? TCs32max { get; set; }

    /// <summary>
    /// Ft3bCS temperature after FM minimumPyro 2
    /// </summary>
    public double? TCs32min { get; set; }

    /// <summary>
    /// CS exit temperature pyrometer 2  meas.values sigma
    /// </summary>
    public double? TCs32sigma { get; set; }

    /// <summary>
    /// CS exit temperature pyrometer 3  meas.values average
    /// </summary>
    public double? TCs3aver { get; set; }

    /// <summary>
    /// CS exit temperature pyrometer 3  max value
    /// </summary>
    public double? TCs3max { get; set; }

    /// <summary>
    /// CS exit temperature pyrometer 3 min value
    /// </summary>
    public double? TCs3min { get; set; }

    /// <summary>
    /// CS exit temperature pyrometer 3 standard deviation
    /// </summary>
    public double? TCs3sigma { get; set; }

    /// <summary>
    /// Ft4bCS temperature after FM average  Pyro 2
    /// </summary>
    public double? TCs42aver { get; set; }

    /// <summary>
    /// Ft4bCS temperature after FM maximum Pyro 2
    /// </summary>
    public double? TCs42max { get; set; }

    /// <summary>
    /// Ft4bCS temperature after FM minimum  Pyro 2
    /// </summary>
    public double? TCs42min { get; set; }

    /// <summary>
    /// Ft4bCS temperature after FM sigma  Pyro 2
    /// </summary>
    public double? TCs42sigma { get; set; }

    /// <summary>
    /// Ft5bCS temperature after FM average  Pyro 2
    /// </summary>
    public double? TCs52aver { get; set; }

    /// <summary>
    /// Ft5bCS temperature after FM maximum Pyro 2
    /// </summary>
    public double? TCs52max { get; set; }

    /// <summary>
    /// Ft5bCS temperature after FM minimum Pyro 2
    /// </summary>
    public double? TCs52min { get; set; }

    /// <summary>
    /// Ft5bCS temperature after FM sigmaPyro 2
    /// </summary>
    public double? TCs52sigma { get; set; }

    /// <summary>
    /// Classif. max. strip temperature delta
    /// </summary>
    public double? TClasMax { get; set; }

    /// <summary>
    /// Classif. min. strip temperature delta
    /// </summary>
    public double? TClasMin { get; set; }

    /// <summary>
    /// date/time when slabs enters the coiler
    /// </summary>
    public DateTime? TCoLoad { get; set; }

    /// <summary>
    /// date/time when slab leaves the coiler
    /// </summary>
    public DateTime? TCoUnload { get; set; }

    /// <summary>
    /// Max. cooling section exit strip temperature delta
    /// </summary>
    public double? TCoolMax { get; set; }

    /// <summary>
    /// Min. cooling section exit strip temperature delta
    /// </summary>
    public double? TCoolMin { get; set; }

    /// <summary>
    /// HRM entry temperatur max value
    /// </summary>
    public double? TEhrmscanMax { get; set; }

    /// <summary>
    /// HRM entry temperatur min value
    /// </summary>
    public double? TEhrmscanMin { get; set; }

    /// <summary>
    /// HRM entry temperatur mean value
    /// </summary>
    public double? TEntryHrmscan { get; set; }

    /// <summary>
    /// Induction heater  entry temperatur 1 average
    /// </summary>
    public double? TEntryIh1aver { get; set; }

    /// <summary>
    /// Induction heater entry temperatur 1 sigma
    /// </summary>
    public double? TEntryIh1sigma { get; set; }

    /// <summary>
    /// Induction heater entry temperatur 2 average
    /// </summary>
    public double? TEntryIh2aver { get; set; }

    /// <summary>
    /// Induction heater entry  temperatur 2 sigma
    /// </summary>
    public double? TEntryIh2sigma { get; set; }

    /// <summary>
    /// RM entry temperature after descaler (mean value)
    /// </summary>
    public double? TEntryRm { get; set; }

    /// <summary>
    /// FM exit temperature (mean value)
    /// </summary>
    public double? TExit { get; set; }

    /// <summary>
    /// FM exit temperature  measured values average
    /// </summary>
    public double? TExitAver { get; set; }

    /// <summary>
    /// CS exit temperature (mean value)
    /// </summary>
    public double? TExitCs { get; set; }

    /// <summary>
    /// FM exit temperature (classification)
    /// </summary>
    public double? TExitClassInd0 { get; set; }

    /// <summary>
    /// FM exit temperature (classification)
    /// </summary>
    public double? TExitClassInd1 { get; set; }

    /// <summary>
    /// FM exit temperature (classification)
    /// </summary>
    public double? TExitClassInd2 { get; set; }

    /// <summary>
    /// FM exit temperature (classification)
    /// </summary>
    public double? TExitClassInd3 { get; set; }

    /// <summary>
    /// CS exit temperatur meas average
    /// </summary>
    public double? TExitCsAver { get; set; }

    /// <summary>
    /// CS exit temperature (classification)
    /// </summary>
    public double? TExitCsClassInd0 { get; set; }

    /// <summary>
    /// CS exit temperature (classification)
    /// </summary>
    public double? TExitCsClassInd1 { get; set; }

    /// <summary>
    /// CS exit temperature (classification)
    /// </summary>
    public double? TExitCsClassInd2 { get; set; }

    /// <summary>
    /// CS exit temperature (classification)
    /// </summary>
    public double? TExitCsClassInd3 { get; set; }

    /// <summary>
    /// CS exit temperature (max value)
    /// </summary>
    public double? TExitCsMax { get; set; }

    /// <summary>
    /// CS exit temperature (min value)
    /// </summary>
    public double? TExitCsMin { get; set; }

    /// <summary>
    /// CS exit temperatur : length out of classification range
    /// </summary>
    public double? TExitCsOut { get; set; }

    /// <summary>
    /// CS exit temperatur  standard deviation
    /// </summary>
    public double? TExitCsSigma { get; set; }

    /// <summary>
    /// Temperature HRM Exit Setpoint (L3)
    /// </summary>
    public double? TExitHrm { get; set; }

    /// <summary>
    /// HRM exit temperature pyrometer 1 average
    /// </summary>
    public double? TExitHrmaver { get; set; }

    /// <summary>
    /// HRM exit temperature pyrometer 1  standard deviation
    /// </summary>
    public double? TExitHrmsigma { get; set; }

    /// <summary>
    /// Induction heater exit temperatur average
    /// </summary>
    public double? TExitIhaver { get; set; }

    /// <summary>
    /// Induction heater exit temperatur sigma
    /// </summary>
    public double? TExitIhsigma { get; set; }

    /// <summary>
    /// FM exit temperature (max value)
    /// </summary>
    public double? TExitMax { get; set; }

    /// <summary>
    /// FM exit temperature (min value)
    /// </summary>
    public double? TExitMin { get; set; }

    /// <summary>
    /// FM exit  temperature : length out of classification range
    /// </summary>
    public double? TExitOut { get; set; }

    /// <summary>
    /// FM exit temperature standard deviation
    /// </summary>
    public double? TExitSigma { get; set; }

    /// <summary>
    /// date/time when slab enters first stand (F1)
    /// </summary>
    public DateTime? TF1load { get; set; }

    /// <summary>
    /// date/time when slab leaves  first stand ( F1)
    /// </summary>
    public DateTime? TF1unload { get; set; }

    /// <summary>
    /// date/time when slab enters last stand (F5)
    /// </summary>
    public DateTime? TF5load { get; set; }

    /// <summary>
    /// date/time when slab leaves last stand (F5)
    /// </summary>
    public DateTime? TF5unload { get; set; }

    /// <summary>
    /// date/time when slab enters R3 for last pass
    /// </summary>
    public DateTime? TR2load { get; set; }

    /// <summary>
    /// date/time when slab leaves R3 after last pass
    /// </summary>
    public DateTime? TR2unload { get; set; }

    /// <summary>
    /// date/time when slab enters RM (either R1 or R2)
    /// </summary>
    public DateTime? TRmload { get; set; }

    /// <summary>
    /// Rotary Shear RTS temperatur 1 average
    /// </summary>
    public double? TRts1aver { get; set; }

    /// <summary>
    /// Rotary Shear RTS temperatur 1 sigma
    /// </summary>
    public double? TRts1sigma { get; set; }

    /// <summary>
    /// Rotary Shear RTS temperatur 2 average
    /// </summary>
    public double? TRts2aver { get; set; }

    /// <summary>
    /// Rotary Shear RTS temperatur 2 sigma
    /// </summary>
    public double? TRts2sigma { get; set; }

    /// <summary>
    /// IH10  temperature
    /// </summary>
    public double? TempIh10 { get; set; }

    /// <summary>
    /// IH12  temperature
    /// </summary>
    public double? TempIh12 { get; set; }

    /// <summary>
    /// IH14  temperature
    /// </summary>
    public double? TempIh14 { get; set; }

    /// <summary>
    /// IH2  temperature
    /// </summary>
    public double? TempIh2 { get; set; }

    /// <summary>
    /// IH4  temperature
    /// </summary>
    public double? TempIh4 { get; set; }

    /// <summary>
    /// IH6  temperature
    /// </summary>
    public double? TempIh6 { get; set; }

    /// <summary>
    /// IH8  temperature
    /// </summary>
    public double? TempIh8 { get; set; }

    /// <summary>
    /// type of product(0-coil  1- plate  2- passby RM plate)
    /// </summary>
    public int? Type { get; set; }

    /// <summary>
    /// rougher circumferential speed
    /// </summary>
    public double? VCircumRmInd00 { get; set; }

    /// <summary>
    /// rougher circumferential speed
    /// </summary>
    public double? VCircumRmInd01 { get; set; }

    /// <summary>
    /// rougher circumferential speed
    /// </summary>
    public double? VCircumRmInd02 { get; set; }

    /// <summary>
    /// rougher circumferential speed
    /// </summary>
    public double? VCircumRmInd03 { get; set; }

    /// <summary>
    /// rougher circumferential speed
    /// </summary>
    public double? VCircumRmInd04 { get; set; }

    /// <summary>
    /// rougher circumferential speed
    /// </summary>
    public double? VCircumRmInd05 { get; set; }

    /// <summary>
    /// rougher circumferential speed
    /// </summary>
    public double? VCircumRmInd06 { get; set; }

    /// <summary>
    /// rougher circumferential speed
    /// </summary>
    public double? VCircumRmInd07 { get; set; }

    /// <summary>
    /// rougher circumferential speed
    /// </summary>
    public double? VCircumRmInd08 { get; set; }

    /// <summary>
    /// rougher circumferential speed
    /// </summary>
    public double? VCircumRmInd09 { get; set; }

    /// <summary>
    /// rougher circumferential speed
    /// </summary>
    public double? VCircumRmInd10 { get; set; }

    /// <summary>
    /// rougher circumferential speed
    /// </summary>
    public double? VCircumRmInd11 { get; set; }

    /// <summary>
    /// rougher circumferential speed
    /// </summary>
    public double? VCircumRmInd12 { get; set; }

    /// <summary>
    /// rougher circumferential speed
    /// </summary>
    public double? VCircumRmInd13 { get; set; }

    /// <summary>
    /// rougher circumferential speed
    /// </summary>
    public double? VCircumRmInd14 { get; set; }

    /// <summary>
    /// rougher circumferential speed
    /// </summary>
    public double? VCircumRmInd15 { get; set; }

    /// <summary>
    /// rougher circumferential speed
    /// </summary>
    public double? VCircumRmInd16 { get; set; }

    /// <summary>
    /// rougher circumferential speed
    /// </summary>
    public double? VCircumRmInd17 { get; set; }

    /// <summary>
    /// rougher circumferential speed
    /// </summary>
    public double? VCircumRmInd18 { get; set; }

    /// <summary>
    /// rougher circumferential speed
    /// </summary>
    public double? VCircumRmInd19 { get; set; }

    /// <summary>
    /// rougher circumferential speed
    /// </summary>
    public double? VCircumRmInd20 { get; set; }

    /// <summary>
    /// rougher circumferential speed
    /// </summary>
    public double? VCircumRmInd21 { get; set; }

    /// <summary>
    /// FM exit strip speed (mean value)
    /// </summary>
    public double? VExit { get; set; }

    /// <summary>
    /// FM exit strip speed(max value)
    /// </summary>
    public double? VExitMax { get; set; }

    /// <summary>
    /// FM Exit strip speed(min value)
    /// </summary>
    public double? VExitMin { get; set; }

    /// <summary>
    /// HRM entry width
    /// </summary>
    public double? WEntryHrmAver { get; set; }

    /// <summary>
    /// FM strip width exit (mean value)
    /// </summary>
    public double? WExit { get; set; }

    /// <summary>
    /// strip/slab width measured values average
    /// </summary>
    public double? WExitAver { get; set; }

    /// <summary>
    /// FM strip width exit (classification)
    /// </summary>
    public double? WExitClassInd0 { get; set; }

    /// <summary>
    /// FM strip width exit (classification)
    /// </summary>
    public double? WExitClassInd1 { get; set; }

    /// <summary>
    /// FM strip width exit (classification)
    /// </summary>
    public double? WExitClassInd2 { get; set; }

    /// <summary>
    /// FM strip width exit (classification)
    /// </summary>
    public double? WExitClassInd3 { get; set; }

    /// <summary>
    /// exit width HRM setpoint(L3)
    /// </summary>
    public double? WExitHrm { get; set; }

    /// <summary>
    /// HRM width measured values average
    /// </summary>
    public double? WExitHrmaver { get; set; }

    /// <summary>
    /// HRM width standard deviation
    /// </summary>
    public double? WExitHrmsigma { get; set; }

    /// <summary>
    /// strip/slab width measured values average
    /// </summary>
    public double? WExitHeadAver { get; set; }

    /// <summary>
    /// Strip/slab standard head deviation
    /// </summary>
    public double? WExitHeadSigma { get; set; }

    /// <summary>
    /// FM strip width exit (max value)
    /// </summary>
    public double? WExitMax { get; set; }

    /// <summary>
    /// FM strip width exit (min value)
    /// </summary>
    public double? WExitMin { get; set; }

    /// <summary>
    /// width: length out of classification range
    /// </summary>
    public double? WExitOut { get; set; }

    /// <summary>
    /// rougher strip exit width
    /// </summary>
    public double? WExitRmInd00 { get; set; }

    /// <summary>
    /// rougher strip exit width
    /// </summary>
    public double? WExitRmInd01 { get; set; }

    /// <summary>
    /// rougher strip exit width
    /// </summary>
    public double? WExitRmInd02 { get; set; }

    /// <summary>
    /// rougher strip exit width
    /// </summary>
    public double? WExitRmInd03 { get; set; }

    /// <summary>
    /// rougher strip exit width
    /// </summary>
    public double? WExitRmInd04 { get; set; }

    /// <summary>
    /// rougher strip exit width
    /// </summary>
    public double? WExitRmInd05 { get; set; }

    /// <summary>
    /// rougher strip exit width
    /// </summary>
    public double? WExitRmInd06 { get; set; }

    /// <summary>
    /// rougher strip exit width
    /// </summary>
    public double? WExitRmInd07 { get; set; }

    /// <summary>
    /// rougher strip exit width
    /// </summary>
    public double? WExitRmInd08 { get; set; }

    /// <summary>
    /// rougher strip exit width
    /// </summary>
    public double? WExitRmInd09 { get; set; }

    /// <summary>
    /// rougher strip exit width
    /// </summary>
    public double? WExitRmInd10 { get; set; }

    /// <summary>
    /// rougher strip exit width
    /// </summary>
    public double? WExitRmInd11 { get; set; }

    /// <summary>
    /// rougher strip exit width
    /// </summary>
    public double? WExitRmInd12 { get; set; }

    /// <summary>
    /// rougher strip exit width
    /// </summary>
    public double? WExitRmInd13 { get; set; }

    /// <summary>
    /// rougher strip exit width
    /// </summary>
    public double? WExitRmInd14 { get; set; }

    /// <summary>
    /// rougher strip exit width
    /// </summary>
    public double? WExitRmInd15 { get; set; }

    /// <summary>
    /// rougher strip exit width
    /// </summary>
    public double? WExitRmInd16 { get; set; }

    /// <summary>
    /// rougher strip exit width
    /// </summary>
    public double? WExitRmInd17 { get; set; }

    /// <summary>
    /// rougher strip exit width
    /// </summary>
    public double? WExitRmInd18 { get; set; }

    /// <summary>
    /// rougher strip exit width
    /// </summary>
    public double? WExitRmInd19 { get; set; }

    /// <summary>
    /// rougher strip exit width
    /// </summary>
    public double? WExitRmInd20 { get; set; }

    /// <summary>
    /// rougher strip exit width
    /// </summary>
    public double? WExitRmInd21 { get; set; }

    /// <summary>
    /// strip/slab width standard deviation
    /// </summary>
    public double? WExitSigma { get; set; }

    /// <summary>
    /// instand cooling water flow after F3
    /// </summary>
    public double? WaterFlowF3 { get; set; }

    /// <summary>
    /// instand cooling water flow after F4
    /// </summary>
    public double? WaterFlowF4 { get; set; }

    /// <summary>
    /// Strip wedge meas. (mean value)
    /// </summary>
    public double? Wedge { get; set; }

    /// <summary>
    /// wedge measured values average
    /// </summary>
    public double? WedgeAver { get; set; }

    /// <summary>
    /// Classif. max. strip wedge delta from 0
    /// </summary>
    public double? WedgeClasMax { get; set; }

    /// <summary>
    /// Strip wedge
    /// </summary>
    public double? WedgeClassInd0 { get; set; }

    /// <summary>
    /// Strip wedge
    /// </summary>
    public double? WedgeClassInd1 { get; set; }

    /// <summary>
    /// Strip wedge
    /// </summary>
    public double? WedgeClassInd2 { get; set; }

    /// <summary>
    /// Strip wedge
    /// </summary>
    public double? WedgeClassInd3 { get; set; }

    /// <summary>
    /// wedge start position in strip
    /// </summary>
    public double? WedgeEndPos { get; set; }

    /// <summary>
    /// Strip wedge meas. (max. value)
    /// </summary>
    public double? WedgeMax { get; set; }

    /// <summary>
    /// Strip wedge meas. (min. value)
    /// </summary>
    public double? WedgeMin { get; set; }

    /// <summary>
    /// wedge : length out of classification range
    /// </summary>
    public double? WedgeOut { get; set; }

    /// <summary>
    /// wedge standard deviation
    /// </summary>
    public double? WedgeSigma { get; set; }

    /// <summary>
    /// wedge end  position in strip
    /// </summary>
    public double? WedgeStartPos { get; set; }

    /// <summary>
    /// product material weight (meas value)
    /// </summary>
    public double? Weight { get; set; }

    /// <summary>
    /// Planned width change
    /// </summary>
    public double? WidthChange { get; set; }

    /// <summary>
    /// 0=width change at the end of the coil, 1=width change cut as plate (scrap), 2=width change over entire coil
    /// </summary>
    public int? WidthChangeFlag { get; set; }

    /// <summary>
    /// maximal strip width delta from aim for classification purpose
    /// </summary>
    public double? WidthClasMax { get; set; }

    /// <summary>
    /// minimal strip width delta from aim for classification purpose
    /// </summary>
    public double? WidthClasMin { get; set; }

    /// <summary>
    /// exit  width customer
    /// </summary>
    public double? WidthExitCustomer { get; set; }

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
