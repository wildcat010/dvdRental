using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class PrOrdPro
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
    /// Owner
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// aim for casting speed
    /// </summary>
    public float? AimCastSpeed { get; set; }

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
    /// bending mode in FM
    /// </summary>
    public int? BendFmflag { get; set; }

    /// <summary>
    /// Casting Speed meas. average value
    /// </summary>
    public float? CastSpeedAvg { get; set; }

    /// <summary>
    /// Casting Speed meas. max value
    /// </summary>
    public float? CastSpeedMax { get; set; }

    /// <summary>
    /// Casting Speed meas. min value
    /// </summary>
    public float? CastSpeedMin { get; set; }

    /// <summary>
    /// Casting Speed meas. standard deviation
    /// </summary>
    public float? CastSpeedSigma { get; set; }

    /// <summary>
    /// Unit[mm] Center of line deviation (L3)
    /// </summary>
    public float? CenterLineDev { get; set; }

    /// <summary>
    /// Unit[mm] Center of line deviation max
    /// </summary>
    public float? CenterLineMax { get; set; }

    /// <summary>
    /// Unit[mm] Center of line deviation min
    /// </summary>
    public float? CenterLineMin { get; set; }

    /// <summary>
    /// Cooling intensity bottom (laminar cooling), possible values: 0, 0.25, 0.5, 0.75, 1
    /// </summary>
    public float? CoolRateBot { get; set; }

    /// <summary>
    /// Cooling intensity  top (laminar cooling), possible values: 0, 0.25, 0.5, 0.75, 1
    /// </summary>
    public float? CoolRateTop { get; set; }

    /// <summary>
    /// 0=Use directives  from Look up table deposited in the L2, 1=Use directives of the PDI  (L3)
    /// </summary>
    public int? CoolingMode { get; set; }

    /// <summary>
    /// Classif. maximal strip crown delta from aim C40
    /// </summary>
    public float? CrownClasMax { get; set; }

    /// <summary>
    /// Unit[Pa] descaler before FM pressure entry side average
    /// </summary>
    public float? DescEpresAvgFm { get; set; }

    /// <summary>
    /// Unit[Pa] descaler before HRM pressure entry side average
    /// </summary>
    public float? DescEpresAvgHrm { get; set; }

    /// <summary>
    /// Unit[Pa] descaler before FM pressure entry side maximum
    /// </summary>
    public float? DescEpresMaxFm { get; set; }

    /// <summary>
    /// Unit[Pa] descaler before HRM pressure entry side maximum
    /// </summary>
    public float? DescEpresMaxHrm { get; set; }

    /// <summary>
    /// Unit[Pa] descaler before FM pressure entry side minimum
    /// </summary>
    public float? DescEpresMinFm { get; set; }

    /// <summary>
    /// Unit[Pa] descaler before HRM pressure entry side minimum
    /// </summary>
    public float? DescEpresMinHrm { get; set; }

    /// <summary>
    /// descaler before FM pressure entry side sigma
    /// </summary>
    public float? DescEpresSigmaFm { get; set; }

    /// <summary>
    /// descaler before HRM pressure entry side sigma
    /// </summary>
    public float? DescEpresSigmaHrm { get; set; }

    /// <summary>
    /// Unit[Pa] descaler before FM pressure exit side average
    /// </summary>
    public float? DescXpresAvgFm { get; set; }

    /// <summary>
    /// Unit[Pa] descaler before HRM pressure exit side average
    /// </summary>
    public float? DescXpresAvgHrm { get; set; }

    /// <summary>
    /// Unit[Pa] descaler before FM pressure exit side minimum
    /// </summary>
    public float? DescXpresMaxFm { get; set; }

    /// <summary>
    /// Unit[Pa] descaler before HRM pressure exit side minimum
    /// </summary>
    public float? DescXpresMaxHrm { get; set; }

    /// <summary>
    /// Unit[Pa] descaler before FM pressure exit side minimum
    /// </summary>
    public float? DescXpresMinFm { get; set; }

    /// <summary>
    /// Unit[Pa] descaler before HRM pressure exit side minimum
    /// </summary>
    public float? DescXpresMinHrm { get; set; }

    /// <summary>
    /// descaler before FM pressure exit side sigma
    /// </summary>
    public float? DescXpresSigmaFm { get; set; }

    /// <summary>
    /// descaler before HRM pressure exit side sigma
    /// </summary>
    public float? DescXpresSigmaHrm { get; set; }

    /// <summary>
    /// No. of dilatometer curve to be applied
    /// </summary>
    public int? DilatometerCurve { get; set; }

    /// <summary>
    /// 0=no dual phase steel, 1=dual phase steel
    /// </summary>
    public int? DualPhase { get; set; }

    /// <summary>
    /// Unit[m] head length for strip (L3)
    /// </summary>
    public float? ExitHeadLength { get; set; }

    /// <summary>
    /// start position of the head,measured values in front of this point are not used (L3)
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
    /// Unit[IUnit] strip flatness unsymetric (mean value)
    /// </summary>
    public float? FlatAsym { get; set; }

    /// <summary>
    /// Unit[IUnit] strip flatness measured values average
    /// </summary>
    public float? FlatAsymAver { get; set; }

    /// <summary>
    /// Classif. max. asymmetric strip flatness delta from 0
    /// </summary>
    public float? FlatAsymClasMax { get; set; }

    /// <summary>
    /// Unit[m] strip unsymetric flatness
    /// </summary>
    public float? FlatAsymClassInd0 { get; set; }

    /// <summary>
    /// Unit[m] strip unsymetric flatness
    /// </summary>
    public float? FlatAsymClassInd1 { get; set; }

    /// <summary>
    /// Unit[m] strip unsymetric flatness
    /// </summary>
    public float? FlatAsymClassInd2 { get; set; }

    /// <summary>
    /// Unit[m] strip unsymetric flatness
    /// </summary>
    public float? FlatAsymClassInd3 { get; set; }

    /// <summary>
    /// Unit[IUnit] strip flatness unsymetric (max. value)
    /// </summary>
    public float? FlatAsymMax { get; set; }

    /// <summary>
    /// Unit[IUnit] strip flatness unsymetric (min. value)
    /// </summary>
    public float? FlatAsymMin { get; set; }

    /// <summary>
    /// Unit[m] strip flatness: length out of classification range
    /// </summary>
    public float? FlatAsymOut { get; set; }

    /// <summary>
    /// Unit[IUnit] strip flatness symmetric (mean value)
    /// </summary>
    public float? FlatSym { get; set; }

    /// <summary>
    /// Unit[IUnit] strip flatness symmetric meas. values average
    /// </summary>
    public float? FlatSymAver { get; set; }

    /// <summary>
    /// Classif. max. symmetric strip flatness delta from 0
    /// </summary>
    public float? FlatSymClasMax { get; set; }

    /// <summary>
    /// Unit[m] strip flatness symmetric
    /// </summary>
    public float? FlatSymClassInd0 { get; set; }

    /// <summary>
    /// Unit[m] strip flatness symmetric
    /// </summary>
    public float? FlatSymClassInd1 { get; set; }

    /// <summary>
    /// Unit[m] strip flatness symmetric
    /// </summary>
    public float? FlatSymClassInd2 { get; set; }

    /// <summary>
    /// Unit[m] strip flatness symmetric
    /// </summary>
    public float? FlatSymClassInd3 { get; set; }

    /// <summary>
    /// Unit[IUnit] strip flatness symmetric  (max. value)
    /// </summary>
    public float? FlatSymMax { get; set; }

    /// <summary>
    /// Unit[IUnit] strip flatness symmetric  (min. value)
    /// </summary>
    public float? FlatSymMin { get; set; }

    /// <summary>
    /// Unit[m] strip flatness symetric: length out of classification range
    /// </summary>
    public float? FlatSymOut { get; set; }

    /// <summary>
    /// max.strip thickness delta from aim for classification purpose
    /// </summary>
    public float? HClasMax { get; set; }

    /// <summary>
    /// min.strip thickness delta from aim for classification purpose
    /// </summary>
    public float? HClasMin { get; set; }

    /// <summary>
    /// Unit[m] HRM entry thickness mean value
    /// </summary>
    public float? HEntryHrm { get; set; }

    /// <summary>
    /// Unit[m] HRM entry thickness max value
    /// </summary>
    public float? HEntryHrmmax { get; set; }

    /// <summary>
    /// Unit[m] HRM entry thickness min value
    /// </summary>
    public float? HEntryHrmmin { get; set; }

    /// <summary>
    /// Unit[m] FM strip thickness (mean value)
    /// </summary>
    public float? HExit { get; set; }

    /// <summary>
    /// Unit[m] strip/slab thickness meas.values average
    /// </summary>
    public float? HExitAver { get; set; }

    /// <summary>
    /// Unit[m] FM strip thickness (classification)
    /// </summary>
    public float? HExitClassInd0 { get; set; }

    /// <summary>
    /// Unit[m] FM strip thickness (classification)
    /// </summary>
    public float? HExitClassInd1 { get; set; }

    /// <summary>
    /// Unit[m] FM strip thickness (classification)
    /// </summary>
    public float? HExitClassInd2 { get; set; }

    /// <summary>
    /// Unit[m] FM strip thickness (classification)
    /// </summary>
    public float? HExitClassInd3 { get; set; }

    /// <summary>
    /// Unit[m] FM strip thickness (classification)
    /// </summary>
    public float? HExitClassInd4 { get; set; }

    /// <summary>
    /// Unit[m] FM strip thickness (classification)
    /// </summary>
    public float? HExitClassInd5 { get; set; }

    /// <summary>
    /// Unit[m] FM strip thickness (classification)
    /// </summary>
    public float? HExitClassInd6 { get; set; }

    /// <summary>
    /// Unit[m] FM strip thickness (classification)
    /// </summary>
    public float? HExitClassInd7 { get; set; }

    /// <summary>
    /// Unit[m] FM strip thickness (classification)
    /// </summary>
    public float? HExitClassInd8 { get; set; }

    /// <summary>
    /// Unit[m] FM strip thickness (classification)
    /// </summary>
    public float? HExitClassInd9 { get; set; }

    /// <summary>
    /// exit thickness HRM setpoint(L3)
    /// </summary>
    public float? HExitHrm { get; set; }

    /// <summary>
    /// Unit[m] HRM thickness measurement values average
    /// </summary>
    public float? HExitHrmaver { get; set; }

    /// <summary>
    /// HRM thickness standard deviation
    /// </summary>
    public float? HExitHrmsigma { get; set; }

    /// <summary>
    /// Unit[m] Strip/slab head measurement value average
    /// </summary>
    public float? HExitHeadAver { get; set; }

    /// <summary>
    /// thickness : Strip/slab standard head deviation
    /// </summary>
    public float? HExitHeadSigma { get; set; }

    /// <summary>
    /// N/A
    /// </summary>
    public float? HExitIn100Minus { get; set; }

    /// <summary>
    /// thickness deviation within +/- 100 microns
    /// </summary>
    public float? HExitIn100Plus { get; set; }

    /// <summary>
    /// N/A
    /// </summary>
    public float? HExitIn150Minus { get; set; }

    /// <summary>
    /// thickness deviation within +/- 150 microns
    /// </summary>
    public float? HExitIn150Plus { get; set; }

    /// <summary>
    /// N/A
    /// </summary>
    public float? HExitIn200Minus { get; set; }

    /// <summary>
    /// thickness deviation within +/- 200 microns
    /// </summary>
    public float? HExitIn200Plus { get; set; }

    /// <summary>
    /// N/A
    /// </summary>
    public float? HExitIn50Minus { get; set; }

    /// <summary>
    /// thickness deviation within +/- 50 microns
    /// </summary>
    public float? HExitIn50Plus { get; set; }

    /// <summary>
    /// Unit[m] FM strip thickness (max value)
    /// </summary>
    public float? HExitMax { get; set; }

    /// <summary>
    /// Unit[m] FM strip thickness (min value)
    /// </summary>
    public float? HExitMin { get; set; }

    /// <summary>
    /// Unit[m] Thickness: length out of classification
    /// </summary>
    public float? HExitOut { get; set; }

    /// <summary>
    /// strip/slab thickness standard deviation
    /// </summary>
    public float? HExitSigma { get; set; }

    /// <summary>
    /// entry max thickness from caster
    /// </summary>
    public float? HHeadMax { get; set; }

    /// <summary>
    /// entry min thickness from caster
    /// </summary>
    public float? HHeadMin { get; set; }

    /// <summary>
    /// heat id first heat
    /// </summary>
    public string HeatId1 { get; set; }

    /// <summary>
    /// heat treatment no from caster
    /// </summary>
    public short? HeatTreatmentNo1 { get; set; }

    /// <summary>
    /// heat treatment no from caster
    /// </summary>
    public short? HeatTreatmentNo2 { get; set; }

    /// <summary>
    /// heat id second t heat
    /// </summary>
    public string Heatid2 { get; set; }

    /// <summary>
    /// dual phase steel: hold temperature
    /// </summary>
    public float? HoldTemperature { get; set; }

    /// <summary>
    /// dual phase steel: hold time
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
    /// coil id for level 3
    /// </summary>
    public string L3CoilId { get; set; }

    /// <summary>
    /// Length of uncooled head (NULL -&gt; use L2 strategy)
    /// </summary>
    public float? LengthUncooledHead { get; set; }

    /// <summary>
    /// Length of uncooled tail (NULL -&gt; use L2 strategy)
    /// </summary>
    public float? LengthUncooledTail { get; set; }

    /// <summary>
    /// number of orders
    /// </summary>
    public short? NoOrder { get; set; }

    /// <summary>
    /// Unit[m] oder length of the material
    /// </summary>
    public float? OrderLengthX { get; set; }

    /// <summary>
    /// percent from first heat ID
    /// </summary>
    public float? PercentHeat1 { get; set; }

    /// <summary>
    /// percent from second heat ID
    /// </summary>
    public float? PercentHeat2 { get; set; }

    /// <summary>
    /// IH1 power
    /// </summary>
    public float? PowerIh1 { get; set; }

    /// <summary>
    /// IH10 power
    /// </summary>
    public float? PowerIh10 { get; set; }

    /// <summary>
    /// IH11 power
    /// </summary>
    public float? PowerIh11 { get; set; }

    /// <summary>
    /// IH12 power
    /// </summary>
    public float? PowerIh12 { get; set; }

    /// <summary>
    /// IH13 power
    /// </summary>
    public float? PowerIh13 { get; set; }

    /// <summary>
    /// IH14 power
    /// </summary>
    public float? PowerIh14 { get; set; }

    /// <summary>
    /// IH2 power
    /// </summary>
    public float? PowerIh2 { get; set; }

    /// <summary>
    /// IH3 power
    /// </summary>
    public float? PowerIh3 { get; set; }

    /// <summary>
    /// IH4 power
    /// </summary>
    public float? PowerIh4 { get; set; }

    /// <summary>
    /// IH5 power
    /// </summary>
    public float? PowerIh5 { get; set; }

    /// <summary>
    /// IH6 power
    /// </summary>
    public float? PowerIh6 { get; set; }

    /// <summary>
    /// IH7 power
    /// </summary>
    public float? PowerIh7 { get; set; }

    /// <summary>
    /// IH8 power
    /// </summary>
    public float? PowerIh8 { get; set; }

    /// <summary>
    /// IH9 power
    /// </summary>
    public float? PowerIh9 { get; set; }

    /// <summary>
    /// Unit[m] HRM profile entry mean value
    /// </summary>
    public float? ProfEntryHrm { get; set; }

    /// <summary>
    /// Unit[m] HRM entry profile max value
    /// </summary>
    public float? ProfEntryHrmmax { get; set; }

    /// <summary>
    /// Unit[m] HRM entry profile min value
    /// </summary>
    public float? ProfEntryHrmmin { get; set; }

    /// <summary>
    /// Unit[m] strip profile(crown) head standard deviation
    /// </summary>
    public float? ProfXheadAvg { get; set; }

    /// <summary>
    /// FM exit profile head standard deviation
    /// </summary>
    public float? ProfXheadSigma { get; set; }

    /// <summary>
    /// strip profile(crown) satndard deviation
    /// </summary>
    public float? ProfXsigma { get; set; }

    /// <summary>
    /// Unit[m] strip profile (mean value)
    /// </summary>
    public float? Profile { get; set; }

    /// <summary>
    /// Unit[m] strip profile (classification)
    /// </summary>
    public float? ProfileClassInd0 { get; set; }

    /// <summary>
    /// Unit[m] strip profile (classification)
    /// </summary>
    public float? ProfileClassInd1 { get; set; }

    /// <summary>
    /// Unit[m] strip profile (classification)
    /// </summary>
    public float? ProfileClassInd2 { get; set; }

    /// <summary>
    /// Unit[m] strip profile (classification)
    /// </summary>
    public float? ProfileClassInd3 { get; set; }

    /// <summary>
    /// Unit[m] strip profile(crown)average
    /// </summary>
    public float? ProfileExitAver { get; set; }

    /// <summary>
    /// Unit[m] profile(crown) length out of classification
    /// </summary>
    public float? ProfileExitOut { get; set; }

    /// <summary>
    /// Unit[m] strip profile (max. value)
    /// </summary>
    public float? ProfileMax { get; set; }

    /// <summary>
    /// Unit[m] strip profile (min. value)
    /// </summary>
    public float? ProfileMin { get; set; }

    /// <summary>
    /// sequence of cast
    /// </summary>
    public string SeqId { get; set; }

    /// <summary>
    /// sequence identification
    /// </summary>
    public string SequenceId { get; set; }

    /// <summary>
    /// slab id from level3
    /// </summary>
    public string SlabId { get; set; }

    /// <summary>
    /// steel grade
    /// </summary>
    public string SteelGrade { get; set; }

    /// <summary>
    /// Unit[_C] FM entry temperature (mean value)
    /// </summary>
    public float? T1EntryFm { get; set; }

    /// <summary>
    /// Unit[_C] FM entry temperature (max value)
    /// </summary>
    public float? T1EntryFmmax { get; set; }

    /// <summary>
    /// Unit[_C] FM entry temperature (min value)
    /// </summary>
    public float? T1EntryFmmin { get; set; }

    /// <summary>
    /// Unit[_C] FM entry temperature pyrometer 2 mean value
    /// </summary>
    public float? T2EntryFm { get; set; }

    /// <summary>
    /// Unit[_C] FM entry temperature pyrometer 2 max value
    /// </summary>
    public float? T2EntryFmmax { get; set; }

    /// <summary>
    /// Unit[_C] FM entry temperature pyrometer 2 min value
    /// </summary>
    public float? T2EntryFmmin { get; set; }

    /// <summary>
    /// HRM exit temperature pyro 2
    /// </summary>
    public float? T2ExitHrmaver { get; set; }

    /// <summary>
    /// HRM exit temperature sigma pyro2
    /// </summary>
    public float? T2ExitHrmsigma { get; set; }

    /// <summary>
    /// Unit[_C] temperature at active coiler
    /// </summary>
    public float? TActCoilerAvg { get; set; }

    /// <summary>
    /// Unit[_C] temperature at active coiler max
    /// </summary>
    public float? TActCoilerMax { get; set; }

    /// <summary>
    /// Unit[_C] temperature at active coiler min
    /// </summary>
    public float? TActCoilerMin { get; set; }

    /// <summary>
    /// temperature at active coiler sigma
    /// </summary>
    public float? TActCoilerSig { get; set; }

    /// <summary>
    /// Unit[_C] Ft1bCS temperature after FM average   Pyro 2
    /// </summary>
    public float? TCs12aver { get; set; }

    /// <summary>
    /// Unit[_C] Ft1bCS temperature after FM maximum   Pyro 2
    /// </summary>
    public float? TCs12max { get; set; }

    /// <summary>
    /// Ft1bCS temperature after FM minimum    Pyro 2
    /// </summary>
    public float? TCs12min { get; set; }

    /// <summary>
    /// Ft1bCS temperature after FM sigma  Pyro 2
    /// </summary>
    public float? TCs12sigma { get; set; }

    /// <summary>
    /// Unit[_C] CS exit temperature pyrometer 1  meas.values average
    /// </summary>
    public float? TCs1aver { get; set; }

    /// <summary>
    /// Unit[_C] CS exit temperature pyrometer 1  max value
    /// </summary>
    public float? TCs1max { get; set; }

    /// <summary>
    /// Unit[_C] CS exit temperature pyrometer 1 min value
    /// </summary>
    public float? TCs1min { get; set; }

    /// <summary>
    /// CS exit temperature pyrometer 1 standard deviation
    /// </summary>
    public float? TCs1sigma { get; set; }

    /// <summary>
    /// Ft2bCS temperature after FM average  Pyro 2
    /// </summary>
    public float? TCs22aver { get; set; }

    /// <summary>
    /// Unit[_C] Ft2bCS temperature after FM maximum  Pyro 2
    /// </summary>
    public float? TCs22max { get; set; }

    /// <summary>
    /// Unit[_C] Ft2bCS temperature after FM minimum   Pyro 2
    /// </summary>
    public float? TCs22min { get; set; }

    /// <summary>
    /// Ft2bCS temperature after FM sigma  Pyro 2
    /// </summary>
    public float? TCs22sigma { get; set; }

    /// <summary>
    /// Unit[_C] CS exit temperature pyrometer 2  meas.values average
    /// </summary>
    public float? TCs2aver { get; set; }

    /// <summary>
    /// Unit[_C] CS exit temperature pyrometer 2  max value
    /// </summary>
    public float? TCs2max { get; set; }

    /// <summary>
    /// Unit[_C] CS exit temperature pyrometer 2 min value
    /// </summary>
    public float? TCs2min { get; set; }

    /// <summary>
    /// CS exit temperature pyrometer 2 standard deviation
    /// </summary>
    public float? TCs2sigma { get; set; }

    /// <summary>
    /// Ft3bCS temperature after FM average   Pyro 2
    /// </summary>
    public float? TCs32aver { get; set; }

    /// <summary>
    /// Ft3bCS temperature after FM maximum   Pyro 2
    /// </summary>
    public float? TCs32max { get; set; }

    /// <summary>
    /// Ft3bCS temperature after FM minimumPyro 2
    /// </summary>
    public float? TCs32min { get; set; }

    /// <summary>
    /// CS exit temperature pyrometer 2  meas.values sigma
    /// </summary>
    public float? TCs32sigma { get; set; }

    /// <summary>
    /// Unit[_C] CS exit temperature pyrometer 3  meas.values average
    /// </summary>
    public float? TCs3aver { get; set; }

    /// <summary>
    /// Unit[_C] CS exit temperature pyrometer 3  max value
    /// </summary>
    public float? TCs3max { get; set; }

    /// <summary>
    /// Unit[_C] CS exit temperature pyrometer 3 min value
    /// </summary>
    public float? TCs3min { get; set; }

    /// <summary>
    /// CS exit temperature pyrometer 3 standard deviation
    /// </summary>
    public float? TCs3sigma { get; set; }

    /// <summary>
    /// Ft4bCS temperature after FM average  Pyro 2
    /// </summary>
    public float? TCs42aver { get; set; }

    /// <summary>
    /// Ft4bCS temperature after FM maximum Pyro 2
    /// </summary>
    public float? TCs42max { get; set; }

    /// <summary>
    /// Ft4bCS temperature after FM minimum  Pyro 2
    /// </summary>
    public float? TCs42min { get; set; }

    /// <summary>
    /// Ft4bCS temperature after FM sigma  Pyro 2
    /// </summary>
    public float? TCs42sigma { get; set; }

    /// <summary>
    /// Ft5bCS temperature after FM average  Pyro 2
    /// </summary>
    public float? TCs52aver { get; set; }

    /// <summary>
    /// Ft5bCS temperature after FM maximum Pyro 2
    /// </summary>
    public float? TCs52max { get; set; }

    /// <summary>
    /// Ft5bCS temperature after FM minimum Pyro 2
    /// </summary>
    public float? TCs52min { get; set; }

    /// <summary>
    /// Ft5bCS temperature after FM sigmaPyro 2
    /// </summary>
    public float? TCs52sigma { get; set; }

    /// <summary>
    /// Classif. max. strip temperature delta
    /// </summary>
    public float? TClasMax { get; set; }

    /// <summary>
    /// Classif. min. strip temperature delta
    /// </summary>
    public float? TClasMin { get; set; }

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
    public float? TCoolMax { get; set; }

    /// <summary>
    /// Min. cooling section exit strip temperature delta
    /// </summary>
    public float? TCoolMin { get; set; }

    /// <summary>
    /// HRM entry temperatur max value
    /// </summary>
    public float? TEhrmscanMax { get; set; }

    /// <summary>
    /// HRM entry temperatur min value
    /// </summary>
    public float? TEhrmscanMin { get; set; }

    /// <summary>
    /// HRM entry temperatur mean value
    /// </summary>
    public float? TEntryHrmscan { get; set; }

    /// <summary>
    /// Induction heater  entry temperatur 1 average
    /// </summary>
    public float? TEntryIh1aver { get; set; }

    /// <summary>
    /// Induction heater entry temperatur 1 sigma
    /// </summary>
    public float? TEntryIh1sigma { get; set; }

    /// <summary>
    /// Induction heater entry temperatur 2 average
    /// </summary>
    public float? TEntryIh2aver { get; set; }

    /// <summary>
    /// Induction heater entry  temperatur 2 sigma
    /// </summary>
    public float? TEntryIh2sigma { get; set; }

    /// <summary>
    /// Unit[_C] RM entry temperature after descaler (mean value)
    /// </summary>
    public float? TEntryRm { get; set; }

    /// <summary>
    /// Unit[_C] FM exit temperature (mean value)
    /// </summary>
    public float? TExit { get; set; }

    /// <summary>
    /// Unit[_C] FM exit temperature  measured values average
    /// </summary>
    public float? TExitAver { get; set; }

    /// <summary>
    /// Unit[_C] CS exit temperature (mean value)
    /// </summary>
    public float? TExitCs { get; set; }

    /// <summary>
    /// Unit[m] FM exit temperature (classification)
    /// </summary>
    public float? TExitClassInd0 { get; set; }

    /// <summary>
    /// Unit[m] FM exit temperature (classification)
    /// </summary>
    public float? TExitClassInd1 { get; set; }

    /// <summary>
    /// Unit[m] FM exit temperature (classification)
    /// </summary>
    public float? TExitClassInd2 { get; set; }

    /// <summary>
    /// Unit[m] FM exit temperature (classification)
    /// </summary>
    public float? TExitClassInd3 { get; set; }

    /// <summary>
    /// Unit[_C] CS exit temperatur meas average
    /// </summary>
    public float? TExitCsAver { get; set; }

    /// <summary>
    /// Unit[m] CS exit temperature (classification)
    /// </summary>
    public float? TExitCsClassInd0 { get; set; }

    /// <summary>
    /// Unit[m] CS exit temperature (classification)
    /// </summary>
    public float? TExitCsClassInd1 { get; set; }

    /// <summary>
    /// Unit[m] CS exit temperature (classification)
    /// </summary>
    public float? TExitCsClassInd2 { get; set; }

    /// <summary>
    /// Unit[m] CS exit temperature (classification)
    /// </summary>
    public float? TExitCsClassInd3 { get; set; }

    /// <summary>
    /// Unit[_C] CS exit temperature (max value)
    /// </summary>
    public float? TExitCsMax { get; set; }

    /// <summary>
    /// Unit[_C] CS exit temperature (min value)
    /// </summary>
    public float? TExitCsMin { get; set; }

    /// <summary>
    /// Unit[m] CS exit temperatur : length out of classification range
    /// </summary>
    public float? TExitCsOut { get; set; }

    /// <summary>
    /// CS exit temperatur  standard deviation
    /// </summary>
    public float? TExitCsSigma { get; set; }

    /// <summary>
    /// Unit[_C] Temperature HRM Exit Setpoint (L3)
    /// </summary>
    public float? TExitHrm { get; set; }

    /// <summary>
    /// Unit[_C] HRM exit temperature pyrometer 1 average
    /// </summary>
    public float? TExitHrmaver { get; set; }

    /// <summary>
    /// HRM exit temperature pyrometer 1  standard deviation
    /// </summary>
    public float? TExitHrmsigma { get; set; }

    /// <summary>
    /// Induction heater exit temperatur average
    /// </summary>
    public float? TExitIhaver { get; set; }

    /// <summary>
    /// Induction heater exit temperatur sigma
    /// </summary>
    public float? TExitIhsigma { get; set; }

    /// <summary>
    /// Unit[_C] FM exit temperature (max value)
    /// </summary>
    public float? TExitMax { get; set; }

    /// <summary>
    /// Unit[_C] FM exit temperature (min value)
    /// </summary>
    public float? TExitMin { get; set; }

    /// <summary>
    /// Unit[m] FM exit  temperature : length out of classification range
    /// </summary>
    public float? TExitOut { get; set; }

    /// <summary>
    /// FM exit temperature standard deviation
    /// </summary>
    public float? TExitSigma { get; set; }

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
    public float? TRts1aver { get; set; }

    /// <summary>
    /// Rotary Shear RTS temperatur 1 sigma
    /// </summary>
    public float? TRts1sigma { get; set; }

    /// <summary>
    /// Rotary Shear RTS temperatur 2 average
    /// </summary>
    public float? TRts2aver { get; set; }

    /// <summary>
    /// Rotary Shear RTS temperatur 2 sigma
    /// </summary>
    public float? TRts2sigma { get; set; }

    /// <summary>
    /// IH10  temperature
    /// </summary>
    public float? TempIh10 { get; set; }

    /// <summary>
    /// IH12  temperature
    /// </summary>
    public float? TempIh12 { get; set; }

    /// <summary>
    /// IH14  temperature
    /// </summary>
    public float? TempIh14 { get; set; }

    /// <summary>
    /// IH2  temperature
    /// </summary>
    public float? TempIh2 { get; set; }

    /// <summary>
    /// IH4  temperature
    /// </summary>
    public float? TempIh4 { get; set; }

    /// <summary>
    /// IH6  temperature
    /// </summary>
    public float? TempIh6 { get; set; }

    /// <summary>
    /// IH8  temperature
    /// </summary>
    public float? TempIh8 { get; set; }

    /// <summary>
    /// Unit[m/s] rougher circumferential speed
    /// </summary>
    public float? VCircumRmInd0 { get; set; }

    /// <summary>
    /// Unit[m/s] rougher circumferential speed
    /// </summary>
    public float? VCircumRmInd1 { get; set; }

    /// <summary>
    /// Unit[m/s] rougher circumferential speed
    /// </summary>
    public float? VCircumRmInd10 { get; set; }

    /// <summary>
    /// Unit[m/s] rougher circumferential speed
    /// </summary>
    public float? VCircumRmInd11 { get; set; }

    /// <summary>
    /// Unit[m/s] rougher circumferential speed
    /// </summary>
    public float? VCircumRmInd12 { get; set; }

    /// <summary>
    /// Unit[m/s] rougher circumferential speed
    /// </summary>
    public float? VCircumRmInd13 { get; set; }

    /// <summary>
    /// Unit[m/s] rougher circumferential speed
    /// </summary>
    public float? VCircumRmInd14 { get; set; }

    /// <summary>
    /// Unit[m/s] rougher circumferential speed
    /// </summary>
    public float? VCircumRmInd15 { get; set; }

    /// <summary>
    /// Unit[m/s] rougher circumferential speed
    /// </summary>
    public float? VCircumRmInd16 { get; set; }

    /// <summary>
    /// Unit[m/s] rougher circumferential speed
    /// </summary>
    public float? VCircumRmInd17 { get; set; }

    /// <summary>
    /// Unit[m/s] rougher circumferential speed
    /// </summary>
    public float? VCircumRmInd18 { get; set; }

    /// <summary>
    /// Unit[m/s] rougher circumferential speed
    /// </summary>
    public float? VCircumRmInd19 { get; set; }

    /// <summary>
    /// Unit[m/s] rougher circumferential speed
    /// </summary>
    public float? VCircumRmInd2 { get; set; }

    /// <summary>
    /// Unit[m/s] rougher circumferential speed
    /// </summary>
    public float? VCircumRmInd20 { get; set; }

    /// <summary>
    /// Unit[m/s] rougher circumferential speed
    /// </summary>
    public float? VCircumRmInd21 { get; set; }

    /// <summary>
    /// Unit[m/s] rougher circumferential speed
    /// </summary>
    public float? VCircumRmInd3 { get; set; }

    /// <summary>
    /// Unit[m/s] rougher circumferential speed
    /// </summary>
    public float? VCircumRmInd4 { get; set; }

    /// <summary>
    /// Unit[m/s] rougher circumferential speed
    /// </summary>
    public float? VCircumRmInd5 { get; set; }

    /// <summary>
    /// Unit[m/s] rougher circumferential speed
    /// </summary>
    public float? VCircumRmInd6 { get; set; }

    /// <summary>
    /// Unit[m/s] rougher circumferential speed
    /// </summary>
    public float? VCircumRmInd7 { get; set; }

    /// <summary>
    /// Unit[m/s] rougher circumferential speed
    /// </summary>
    public float? VCircumRmInd8 { get; set; }

    /// <summary>
    /// Unit[m/s] rougher circumferential speed
    /// </summary>
    public float? VCircumRmInd9 { get; set; }

    /// <summary>
    /// Unit[m/s] FM exit strip speed (mean value)
    /// </summary>
    public float? VExit { get; set; }

    /// <summary>
    /// Unit[m/s] FM exit strip speed(max value)
    /// </summary>
    public float? VExitMax { get; set; }

    /// <summary>
    /// Unit[m/s] FM Exit strip speed(min value)
    /// </summary>
    public float? VExitMin { get; set; }

    /// <summary>
    /// HRM entry width
    /// </summary>
    public float? WEntryHrmAver { get; set; }

    /// <summary>
    /// Unit[m] FM strip width exit (mean value)
    /// </summary>
    public float? WExit { get; set; }

    /// <summary>
    /// Unit[m] strip/slab width measured values average
    /// </summary>
    public float? WExitAver { get; set; }

    /// <summary>
    /// Unit[m] FM strip width exit (classification)
    /// </summary>
    public float? WExitClassInd0 { get; set; }

    /// <summary>
    /// Unit[m] FM strip width exit (classification)
    /// </summary>
    public float? WExitClassInd1 { get; set; }

    /// <summary>
    /// Unit[m] FM strip width exit (classification)
    /// </summary>
    public float? WExitClassInd2 { get; set; }

    /// <summary>
    /// Unit[m] FM strip width exit (classification)
    /// </summary>
    public float? WExitClassInd3 { get; set; }

    /// <summary>
    /// Unit[m] exit width HRM setpoint(L3)
    /// </summary>
    public float? WExitHrm { get; set; }

    /// <summary>
    /// Unit[m] HRM width measured values average
    /// </summary>
    public float? WExitHrmaver { get; set; }

    /// <summary>
    /// HRM width standard deviation
    /// </summary>
    public float? WExitHrmsigma { get; set; }

    /// <summary>
    /// Unit[m] strip/slab width measured values average
    /// </summary>
    public float? WExitHeadAver { get; set; }

    /// <summary>
    /// Strip/slab standard head deviation
    /// </summary>
    public float? WExitHeadSigma { get; set; }

    /// <summary>
    /// Unit[m] FM strip width exit (max value)
    /// </summary>
    public float? WExitMax { get; set; }

    /// <summary>
    /// Unit[m] FM strip width exit (min value)
    /// </summary>
    public float? WExitMin { get; set; }

    /// <summary>
    /// Unit[m] width: length out of classification range
    /// </summary>
    public float? WExitOut { get; set; }

    /// <summary>
    /// Unit[m] rougher strip exit width
    /// </summary>
    public float? WExitRmInd0 { get; set; }

    /// <summary>
    /// Unit[m] rougher strip exit width
    /// </summary>
    public float? WExitRmInd1 { get; set; }

    /// <summary>
    /// Unit[m] rougher strip exit width
    /// </summary>
    public float? WExitRmInd10 { get; set; }

    /// <summary>
    /// Unit[m] rougher strip exit width
    /// </summary>
    public float? WExitRmInd11 { get; set; }

    /// <summary>
    /// Unit[m] rougher strip exit width
    /// </summary>
    public float? WExitRmInd12 { get; set; }

    /// <summary>
    /// Unit[m] rougher strip exit width
    /// </summary>
    public float? WExitRmInd13 { get; set; }

    /// <summary>
    /// Unit[m] rougher strip exit width
    /// </summary>
    public float? WExitRmInd14 { get; set; }

    /// <summary>
    /// Unit[m] rougher strip exit width
    /// </summary>
    public float? WExitRmInd15 { get; set; }

    /// <summary>
    /// Unit[m] rougher strip exit width
    /// </summary>
    public float? WExitRmInd16 { get; set; }

    /// <summary>
    /// Unit[m] rougher strip exit width
    /// </summary>
    public float? WExitRmInd17 { get; set; }

    /// <summary>
    /// Unit[m] rougher strip exit width
    /// </summary>
    public float? WExitRmInd18 { get; set; }

    /// <summary>
    /// Unit[m] rougher strip exit width
    /// </summary>
    public float? WExitRmInd19 { get; set; }

    /// <summary>
    /// Unit[m] rougher strip exit width
    /// </summary>
    public float? WExitRmInd2 { get; set; }

    /// <summary>
    /// Unit[m] rougher strip exit width
    /// </summary>
    public float? WExitRmInd20 { get; set; }

    /// <summary>
    /// Unit[m] rougher strip exit width
    /// </summary>
    public float? WExitRmInd21 { get; set; }

    /// <summary>
    /// Unit[m] rougher strip exit width
    /// </summary>
    public float? WExitRmInd3 { get; set; }

    /// <summary>
    /// Unit[m] rougher strip exit width
    /// </summary>
    public float? WExitRmInd4 { get; set; }

    /// <summary>
    /// Unit[m] rougher strip exit width
    /// </summary>
    public float? WExitRmInd5 { get; set; }

    /// <summary>
    /// Unit[m] rougher strip exit width
    /// </summary>
    public float? WExitRmInd6 { get; set; }

    /// <summary>
    /// Unit[m] rougher strip exit width
    /// </summary>
    public float? WExitRmInd7 { get; set; }

    /// <summary>
    /// Unit[m] rougher strip exit width
    /// </summary>
    public float? WExitRmInd8 { get; set; }

    /// <summary>
    /// Unit[m] rougher strip exit width
    /// </summary>
    public float? WExitRmInd9 { get; set; }

    /// <summary>
    /// strip/slab width standard deviation
    /// </summary>
    public float? WExitSigma { get; set; }

    /// <summary>
    /// instand cooling water flow after F3
    /// </summary>
    public float? WaterFlowF3 { get; set; }

    /// <summary>
    /// instand cooling water flow after F4
    /// </summary>
    public float? WaterFlowF4 { get; set; }

    /// <summary>
    /// Unit[m] Strip wedge meas. (mean value)
    /// </summary>
    public float? Wedge { get; set; }

    /// <summary>
    /// Unit[m] wedge measured values average
    /// </summary>
    public float? WedgeAver { get; set; }

    /// <summary>
    /// Classif. max. strip wedge delta from 0
    /// </summary>
    public float? WedgeClasMax { get; set; }

    /// <summary>
    /// Unit[m] Strip wedge
    /// </summary>
    public float? WedgeClassInd0 { get; set; }

    /// <summary>
    /// Unit[m] Strip wedge
    /// </summary>
    public float? WedgeClassInd1 { get; set; }

    /// <summary>
    /// Unit[m] Strip wedge
    /// </summary>
    public float? WedgeClassInd2 { get; set; }

    /// <summary>
    /// Unit[m] Strip wedge
    /// </summary>
    public float? WedgeClassInd3 { get; set; }

    /// <summary>
    /// Unit[m] Strip wedge meas. (max. value)
    /// </summary>
    public float? WedgeMax { get; set; }

    /// <summary>
    /// Unit[m] Strip wedge meas. (min. value)
    /// </summary>
    public float? WedgeMin { get; set; }

    /// <summary>
    /// wedge : length out of classification range
    /// </summary>
    public float? WedgeOut { get; set; }

    /// <summary>
    /// wedge standard deviation
    /// </summary>
    public float? WedgeSigma { get; set; }

    /// <summary>
    /// maximal strip width delta from aim for classification purpose
    /// </summary>
    public float? WidthClasMax { get; set; }

    /// <summary>
    /// minimal strip width delta from aim for classification purpose
    /// </summary>
    public float? WidthClasMin { get; set; }

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
