using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CsProtDatum
{
    /// <summary>
    /// material identification
    /// </summary>
    public int MeId { get; set; }

    public double? AnalysisAluminium { get; set; }

    public double? AnalysisAntimony { get; set; }

    public double? AnalysisArsenic { get; set; }

    public double? AnalysisBoron { get; set; }

    public double? AnalysisCalcium { get; set; }

    public double? AnalysisCarbon { get; set; }

    public double? AnalysisCerum { get; set; }

    public double? AnalysisChromium { get; set; }

    public double? AnalysisCircon { get; set; }

    public double? AnalysisCobalt { get; set; }

    public double? AnalysisCopper { get; set; }

    public double? AnalysisLead { get; set; }

    public double? AnalysisManganese { get; set; }

    public double? AnalysisManganium { get; set; }

    public double? AnalysisMolybdenum { get; set; }

    public double? AnalysisNickel { get; set; }

    public double? AnalysisNiobium { get; set; }

    public double? AnalysisNitrogen { get; set; }

    public double? AnalysisOxygen { get; set; }

    public double? AnalysisPhosphorus { get; set; }

    public double? AnalysisSilicon { get; set; }

    public double? AnalysisSulfur { get; set; }

    public double? AnalysisTin { get; set; }

    public double? AnalysisTitanium { get; set; }

    public double? AnalysisTungsten { get; set; }

    public double? AnalysisVanadium { get; set; }

    public double? AnalysisZirkonium { get; set; }

    /// <summary>
    /// only applicable for ISC strategy = auto: this value decides, how much percentage of the temperature error will be compensated by switching water
    /// </summary>
    public float? ControlRatioIsc { get; set; }

    /// <summary>
    /// strategy: OFF, FIXEDWATER, AUTO
    /// </summary>
    public int? CoolingStrategyIsc { get; set; }

    /// <summary>
    /// length [m] where no water will be appied on head
    /// </summary>
    public float? IscUncooledHeadLen { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMaxInd0 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMaxInd1 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMaxInd10 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMaxInd11 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMaxInd12 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMaxInd13 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMaxInd14 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMaxInd15 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMaxInd16 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMaxInd17 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMaxInd18 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMaxInd19 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMaxInd2 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMaxInd20 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMaxInd21 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMaxInd22 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMaxInd23 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMaxInd24 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMaxInd25 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMaxInd3 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMaxInd4 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMaxInd5 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMaxInd6 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMaxInd7 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMaxInd8 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMaxInd9 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMinInd0 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMinInd1 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMinInd10 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMinInd11 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMinInd12 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMinInd13 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMinInd14 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMinInd15 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMinInd16 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMinInd17 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMinInd18 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMinInd19 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMinInd2 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMinInd20 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMinInd21 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMinInd22 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMinInd23 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMinInd24 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMinInd25 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMinInd3 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMinInd4 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMinInd5 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMinInd6 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMinInd7 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMinInd8 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public float? IscWaterAmountMinInd9 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public float? IscWaterAmountInd0 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public float? IscWaterAmountInd1 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public float? IscWaterAmountInd10 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public float? IscWaterAmountInd11 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public float? IscWaterAmountInd12 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public float? IscWaterAmountInd13 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public float? IscWaterAmountInd14 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public float? IscWaterAmountInd15 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public float? IscWaterAmountInd16 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public float? IscWaterAmountInd17 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public float? IscWaterAmountInd18 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public float? IscWaterAmountInd19 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public float? IscWaterAmountInd2 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public float? IscWaterAmountInd20 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public float? IscWaterAmountInd21 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public float? IscWaterAmountInd22 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public float? IscWaterAmountInd23 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public float? IscWaterAmountInd24 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public float? IscWaterAmountInd25 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public float? IscWaterAmountInd3 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public float? IscWaterAmountInd4 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public float? IscWaterAmountInd5 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public float? IscWaterAmountInd6 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public float? IscWaterAmountInd7 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public float? IscWaterAmountInd8 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public float? IscWaterAmountInd9 { get; set; }

    /// <summary>
    /// strategy: EARLY, LATE, DISTRIBUTED
    /// </summary>
    public int? ValveSwitchingStrategyIsc { get; set; }

    public int? ValveSwitchingStrategyIndex { get; set; }

    /// <summary>
    /// water over length: relative strip length
    /// </summary>
    public float? WaterOverLengthRelLengthInd0 { get; set; }

    /// <summary>
    /// water over length: relative strip length
    /// </summary>
    public float? WaterOverLengthRelLengthInd1 { get; set; }

    /// <summary>
    /// water over length: relative strip length
    /// </summary>
    public float? WaterOverLengthRelLengthInd2 { get; set; }

    /// <summary>
    /// water over length: relative strip length
    /// </summary>
    public float? WaterOverLengthRelLengthInd3 { get; set; }

    /// <summary>
    /// water over length: relative strip length
    /// </summary>
    public float? WaterOverLengthRelLengthInd4 { get; set; }

    /// <summary>
    /// water over length: relative strip length
    /// </summary>
    public float? WaterOverLengthRelLengthInd5 { get; set; }

    /// <summary>
    /// water over length: water amount
    /// </summary>
    public float? WaterOverLengthRelWaterInd0 { get; set; }

    /// <summary>
    /// water over length: water amount
    /// </summary>
    public float? WaterOverLengthRelWaterInd1 { get; set; }

    /// <summary>
    /// water over length: water amount
    /// </summary>
    public float? WaterOverLengthRelWaterInd2 { get; set; }

    /// <summary>
    /// water over length: water amount
    /// </summary>
    public float? WaterOverLengthRelWaterInd3 { get; set; }

    /// <summary>
    /// water over length: water amount
    /// </summary>
    public float? WaterOverLengthRelWaterInd4 { get; set; }

    /// <summary>
    /// water over length: water amount
    /// </summary>
    public float? WaterOverLengthRelWaterInd5 { get; set; }

    public int? AirCoolingLimitation { get; set; }

    public string AlloyCode { get; set; }

    public int? AmountSimilartStripsCs { get; set; }

    public int? AmountSimilartStripsFm { get; set; }

    public int? AmountVerySimilartStripsCs { get; set; }

    /// <summary>
    /// from: 3.Similar strip
    /// </summary>
    public float? Cofa1Heat { get; set; }

    /// <summary>
    /// from: 3.Similar strip
    /// </summary>
    public float? Cofa1Phase { get; set; }

    /// <summary>
    /// from: 3.Similar strip
    /// </summary>
    public float? Cofa1RefSpeed { get; set; }

    /// <summary>
    /// from: 3.Similar strip
    /// </summary>
    public float? Cofa2Heat { get; set; }

    /// <summary>
    /// from: 3.Similar strip
    /// </summary>
    public float? Cofa2Phase { get; set; }

    /// <summary>
    /// from: 3.Similar strip
    /// </summary>
    public float? Cofa2RefSpeed { get; set; }

    public int? CoilerNo { get; set; }

    public double? CoilerTempSp { get; set; }

    /// <summary>
    /// 0: drive vRef (no CTC control), 1: full CTC control, 0 &lt; x &lt; 1: v = x*vDesiredCTC + (1-x)*vRef
    /// </summary>
    public float? ControlRatioCtc { get; set; }

    public int? CoolRateBot { get; set; }

    public int? CoolRateBotIc { get; set; }

    public int? CoolRateTop { get; set; }

    public int? CoolRateTopIc { get; set; }

    public int? CoolingStrategy { get; set; }

    /// <summary>
    /// maximum allowed technological deceleration rate which can be realized by BA, when strip is already coiling
    /// </summary>
    public float? CsTechnAccMaxCoiling { get; set; }

    /// <summary>
    /// maximum allowed technological deceleration rate which can be realized by BA, from strip head at last active stand till strip head at coiler
    /// </summary>
    public float? CsTechnAccMaxStart { get; set; }

    /// <summary>
    /// minimum allowed technological deceleration rate which can be realized by BA, when strip is already coiling
    /// </summary>
    public float? CsTechnAccMinCoiling { get; set; }

    /// <summary>
    /// minimum allowed technological deceleration rate which can be realized by BA, from strip head at last active stand till strip head at coiler
    /// </summary>
    public float? CsTechnAccMinStart { get; set; }

    /// <summary>
    /// 0: don#t care, 1: CTC has control, 2: TC has control
    /// </summary>
    public short? CtcActivePlan { get; set; }

    public int? DcAdaptationInd0 { get; set; }

    public int? DcAdaptationInd1 { get; set; }

    public int? DcAdaptationInd2 { get; set; }

    public int? DcAdaptationInd3 { get; set; }

    public int? DcCoolRateBotInd0 { get; set; }

    public int? DcCoolRateBotInd1 { get; set; }

    public int? DcCoolRateBotInd2 { get; set; }

    public int? DcCoolRateBotInd3 { get; set; }

    public int? DcCoolRateTopInd0 { get; set; }

    public int? DcCoolRateTopInd1 { get; set; }

    public int? DcCoolRateTopInd2 { get; set; }

    public int? DcCoolRateTopInd3 { get; set; }

    public double? DcHoldTimeInd0 { get; set; }

    public double? DcHoldTimeInd1 { get; set; }

    public double? DcHoldTimeInd2 { get; set; }

    public int? DcLeadingPyroIdxInd0 { get; set; }

    public int? DcLeadingPyroIdxInd1 { get; set; }

    public int? DcLeadingPyroIdxInd2 { get; set; }

    public int? DcLeadingPyroIdxInd3 { get; set; }

    public int? DcSplineBot { get; set; }

    public int? DcSplineTop { get; set; }

    public int? DcStartValveInd0 { get; set; }

    public int? DcStartValveInd1 { get; set; }

    public int? DcStartValveInd2 { get; set; }

    public int? DcStartValveInd3 { get; set; }

    public double? DcTargetF4tInd0 { get; set; }

    public double? DcTargetF4tInd1 { get; set; }

    public double? DcTargetF4tInd2 { get; set; }

    public double? DcTargetF4tInd3 { get; set; }

    public double? DcTargetTempInd0 { get; set; }

    public double? DcTargetTempInd1 { get; set; }

    public double? DcTargetTempInd2 { get; set; }

    public double? DcTargetTempInd3 { get; set; }

    public double? DcTempOffsetAInd0 { get; set; }

    public double? DcTempOffsetAInd1 { get; set; }

    public double? DcTempOffsetAInd2 { get; set; }

    public double? DcTempOffsetAInd3 { get; set; }

    public double? DcTempOffsetBInd0 { get; set; }

    public double? DcTempOffsetBInd1 { get; set; }

    public double? DcTempOffsetBInd2 { get; set; }

    public double? DcTempOffsetBInd3 { get; set; }

    /// <summary>
    /// maximum speed difference between actual speed desired by CTC and speed resulting from given speed up
    /// </summary>
    public float? DeltaSpeedEnvelope { get; set; }

    public float? F4tReachedSeg1 { get; set; }

    public float? F4tReachedSeg2 { get; set; }

    public double? F4tSp { get; set; }

    public double? FinishingTempSp { get; set; }

    public int? Flag { get; set; }

    public int? FurnaceNo { get; set; }

    public int? LeadingPyroIdx { get; set; }

    /// <summary>
    /// from: 1. History
    /// </summary>
    public string OpMode { get; set; }

    public string ProductId { get; set; }

    public double? RoughingTempSp { get; set; }

    public int? StartValveBot { get; set; }

    public int? StartValveTop { get; set; }

    public int? Status { get; set; }

    public float? StripLength { get; set; }

    public double? ThicknessSp { get; set; }

    /// <summary>
    /// false: use setpoint FM target temperature from PDI, 1: use FM target temperature calculated by MOS
    /// </summary>
    public short? UseCalcFmTempSp { get; set; }

    /// <summary>
    /// Defect valves on bottom
    /// </summary>
    public string VDefectBot { get; set; }

    /// <summary>
    /// Defect valves on top
    /// </summary>
    public string VDefectTop { get; set; }

    /// <summary>
    /// Precalculated valves on bottom
    /// </summary>
    public string VPrecalcBot { get; set; }

    /// <summary>
    /// Precalculated valves on top
    /// </summary>
    public string VPrecalcTop { get; set; }

    /// <summary>
    /// if NULL: speed from SpeedThicknessDiagram, otherwise: constant speed
    /// </summary>
    public float? VRef { get; set; }

    public double? WidthSp { get; set; }

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
