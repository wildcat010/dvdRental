using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class PrHrm
{
    public int SequenceNo { get; set; }

    public float? AimCastSpeed { get; set; }

    public string AimHeatId { get; set; }

    public float? AimSlabThickness { get; set; }

    public float? AimSlabWeight { get; set; }

    public float? AimSlabWidthHead { get; set; }

    public float? AlloyCompensation { get; set; }

    public float? AmountBindingsC { get; set; }

    public int? BatchRolling { get; set; }

    public float? CastSpeedAvg { get; set; }

    public float? CastSpeedMax { get; set; }

    public float? CastSpeedMin { get; set; }

    public float? CastSpeedSigma { get; set; }

    public float? CenterLineDev { get; set; }

    public float? CoilLengthX { get; set; }

    public float? CoolRateBot { get; set; }

    public float? CoolRateTop { get; set; }

    public float? CoolingMode { get; set; }

    public float? CrownClasMax { get; set; }

    public float? DescEpresAvg { get; set; }

    public float? DescEpresMax { get; set; }

    public float? DescEpresMin { get; set; }

    public float? DescEpresSigma { get; set; }

    public float? DescXpresAvg { get; set; }

    public float? DescXpresMax { get; set; }

    public float? DescXpresMin { get; set; }

    public float? DescXpresSigma { get; set; }

    public float? DilatometerCurve { get; set; }

    public float? DualPhase { get; set; }

    public DateTime? EndCoiling { get; set; }

    public float? ExitHeadLength { get; set; }

    public float? ExitHeadStartPos { get; set; }

    public float? FirstValveSwitchLo { get; set; }

    public float? FirstValveSwitchUp { get; set; }

    public float? FlatAsymClasMax { get; set; }

    public float? FlatSymClasMax { get; set; }

    public float? FromBasket { get; set; }

    public float? HClasMax { get; set; }

    public float? HClasMin { get; set; }

    public float? HEntryHrm { get; set; }

    public float? HEntryHrmmax { get; set; }

    public float? HEntryHrmmin { get; set; }

    public float? HExitCustomer { get; set; }

    public float? HExitHrm { get; set; }

    public float? HExitHrmaver { get; set; }

    public float? HExitHrmmax { get; set; }

    public float? HExitHrmmin { get; set; }

    public float? HExitHrmsigma { get; set; }

    public float? HExitHeadAver { get; set; }

    public float? HExitHeadSigma { get; set; }

    public string HeatId1 { get; set; }

    public string HeatId2 { get; set; }

    public float? HeatTreatmentNo1 { get; set; }

    public float? HeatTreatmentNo2 { get; set; }

    public float? HoldTemperature { get; set; }

    public float? HoldTime { get; set; }

    public int? IdRiga { get; set; }

    public int? IdSeq { get; set; }

    public string L3CoilId { get; set; }

    public float? LengthUncooledHead { get; set; }

    public float? LengthUncooledTail { get; set; }

    public float? MaxSlabWeight { get; set; }

    public float? MinSlabWeight { get; set; }

    public int? NoOrder { get; set; }

    public float? OrderLengthX { get; set; }

    public float? PercentHeat1 { get; set; }

    public float? PercentHeat2 { get; set; }

    public float? ProdEnd { get; set; }

    public float? ProdStart { get; set; }

    public int? ProdTime { get; set; }

    public float? ProfEntryHrm { get; set; }

    public float? ProfEntryHrmmax { get; set; }

    public float? ProfEntryHrmmin { get; set; }

    public float? ProfXheadAvg { get; set; }

    public float? ProfXheadSigma { get; set; }

    public float? ProfXsigma { get; set; }

    public string SeqId { get; set; }

    public string SequenceId { get; set; }

    public string SlabId { get; set; }

    public DateTime? StartCoiling { get; set; }

    public string SteelCustomer { get; set; }

    public string SteelGrade { get; set; }

    public float? T2ExitHrmaver { get; set; }

    public float? T2ExitHrmsigma { get; set; }

    public float? TClasMax { get; set; }

    public float? TClasMin { get; set; }

    public float? TCoolMax { get; set; }

    public float? TCoolMin { get; set; }

    public float? TEhrmscan { get; set; }

    public float? TEhrmscanMax { get; set; }

    public float? TEhrmscanMin { get; set; }

    public float? TEntryHrmscan { get; set; }

    public float? TEntryRm { get; set; }

    public float? TExitHrm { get; set; }

    public float? TExitHrmaver { get; set; }

    public float? TExitHrmsigma { get; set; }

    public int? Type { get; set; }

    public float? WExitHrm { get; set; }

    public float? WExitRmaver { get; set; }

    public float? WExitRmsigna { get; set; }

    public float? WedgeClasMax { get; set; }

    public float? WedgeEndPos { get; set; }

    public float? WedgeStartPos { get; set; }

    public float? Weight { get; set; }

    public float? WidthChange { get; set; }

    public float? WidthChangeFlag { get; set; }

    public float? WidthClasMax { get; set; }

    public float? WidthClasMin { get; set; }

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
