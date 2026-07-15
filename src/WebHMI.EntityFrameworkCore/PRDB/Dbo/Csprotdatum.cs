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
    public double? ControlRatioIsc { get; set; }

    /// <summary>
    /// strategy: OFF, FIXEDWATER, AUTO
    /// </summary>
    public int? CoolingStrategyIsc { get; set; }

    /// <summary>
    /// length [m] where no water will be appied on head
    /// </summary>
    public double? IscUncooledHeadLen { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMaxInd00 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMaxInd01 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMaxInd02 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMaxInd03 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMaxInd04 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMaxInd05 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMaxInd06 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMaxInd07 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMaxInd08 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMaxInd09 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMaxInd10 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMaxInd11 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMaxInd12 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMaxInd13 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMaxInd14 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMaxInd15 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMaxInd16 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMaxInd17 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMaxInd18 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMaxInd19 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMaxInd20 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMaxInd21 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMaxInd22 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMaxInd23 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMaxInd24 { get; set; }

    /// <summary>
    /// water amount max, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMaxInd25 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMinInd00 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMinInd01 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMinInd02 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMinInd03 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMinInd04 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMinInd05 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMinInd06 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMinInd07 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMinInd08 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMinInd09 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMinInd10 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMinInd11 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMinInd12 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMinInd13 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMinInd14 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMinInd15 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMinInd16 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMinInd17 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMinInd18 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMinInd19 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMinInd20 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMinInd21 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMinInd22 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMinInd23 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMinInd24 { get; set; }

    /// <summary>
    /// water amount min, only applicable for ISC strategy = auto
    /// </summary>
    public double? IscWaterAmountMinInd25 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public double? IscWaterAmountInd00 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public double? IscWaterAmountInd01 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public double? IscWaterAmountInd02 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public double? IscWaterAmountInd03 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public double? IscWaterAmountInd04 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public double? IscWaterAmountInd05 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public double? IscWaterAmountInd06 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public double? IscWaterAmountInd07 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public double? IscWaterAmountInd08 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public double? IscWaterAmountInd09 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public double? IscWaterAmountInd10 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public double? IscWaterAmountInd11 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public double? IscWaterAmountInd12 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public double? IscWaterAmountInd13 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public double? IscWaterAmountInd14 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public double? IscWaterAmountInd15 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public double? IscWaterAmountInd16 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public double? IscWaterAmountInd17 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public double? IscWaterAmountInd18 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public double? IscWaterAmountInd19 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public double? IscWaterAmountInd20 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public double? IscWaterAmountInd21 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public double? IscWaterAmountInd22 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public double? IscWaterAmountInd23 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public double? IscWaterAmountInd24 { get; set; }

    /// <summary>
    /// water amount, only applicable for ISC strategy = fixed water
    /// </summary>
    public double? IscWaterAmountInd25 { get; set; }

    /// <summary>
    /// strategy: EARLY, LATE, DISTRIBUTED
    /// </summary>
    public int? ValveSwitchingStrategyIsc { get; set; }

    public int? ValveSwitchingStrategyIndex { get; set; }

    /// <summary>
    /// water over length: relative strip length
    /// </summary>
    public double? WaterOverLengthRelLengthInd0 { get; set; }

    /// <summary>
    /// water over length: relative strip length
    /// </summary>
    public double? WaterOverLengthRelLengthInd1 { get; set; }

    /// <summary>
    /// water over length: relative strip length
    /// </summary>
    public double? WaterOverLengthRelLengthInd2 { get; set; }

    /// <summary>
    /// water over length: relative strip length
    /// </summary>
    public double? WaterOverLengthRelLengthInd3 { get; set; }

    /// <summary>
    /// water over length: relative strip length
    /// </summary>
    public double? WaterOverLengthRelLengthInd4 { get; set; }

    /// <summary>
    /// water over length: relative strip length
    /// </summary>
    public double? WaterOverLengthRelLengthInd5 { get; set; }

    /// <summary>
    /// water over length: water amount
    /// </summary>
    public double? WaterOverLengthRelWaterInd0 { get; set; }

    /// <summary>
    /// water over length: water amount
    /// </summary>
    public double? WaterOverLengthRelWaterInd1 { get; set; }

    /// <summary>
    /// water over length: water amount
    /// </summary>
    public double? WaterOverLengthRelWaterInd2 { get; set; }

    /// <summary>
    /// water over length: water amount
    /// </summary>
    public double? WaterOverLengthRelWaterInd3 { get; set; }

    /// <summary>
    /// water over length: water amount
    /// </summary>
    public double? WaterOverLengthRelWaterInd4 { get; set; }

    /// <summary>
    /// water over length: water amount
    /// </summary>
    public double? WaterOverLengthRelWaterInd5 { get; set; }

    public int? AirCoolingLimitation { get; set; }

    public string AlloyCode { get; set; }

    public int? AmountSimilartStripsCs { get; set; }

    public int? AmountSimilartStripsFm { get; set; }

    public int? AmountVerySimilartStripsCs { get; set; }

    /// <summary>
    /// from: 3.Similar strip
    /// </summary>
    public double? Cofa1Heat { get; set; }

    /// <summary>
    /// from: 3.Similar strip
    /// </summary>
    public double? Cofa1Phase { get; set; }

    /// <summary>
    /// from: 3.Similar strip
    /// </summary>
    public double? Cofa1RefSpeed { get; set; }

    /// <summary>
    /// from: 3.Similar strip
    /// </summary>
    public double? Cofa2Heat { get; set; }

    /// <summary>
    /// from: 3.Similar strip
    /// </summary>
    public double? Cofa2Phase { get; set; }

    /// <summary>
    /// from: 3.Similar strip
    /// </summary>
    public double? Cofa2RefSpeed { get; set; }

    public int? CoilerNo { get; set; }

    public double? CoilerTempSp { get; set; }

    /// <summary>
    /// 0: drive vRef (no CTC control), 1: full CTC control, 0 &lt; x &lt; 1: v = x*vDesiredCTC + (1-x)*vRef
    /// </summary>
    public double? ControlRatioCtc { get; set; }

    public int? CoolRateBot { get; set; }

    public int? CoolRateBotIc { get; set; }

    public int? CoolRateTop { get; set; }

    public int? CoolRateTopIc { get; set; }

    public int? CoolingStrategy { get; set; }

    /// <summary>
    /// maximum allowed technological deceleration rate which can be realized by BA, when strip is already coiling
    /// </summary>
    public double? CsTechnAccMaxCoiling { get; set; }

    /// <summary>
    /// maximum allowed technological deceleration rate which can be realized by BA, from strip head at last active stand till strip head at coiler
    /// </summary>
    public double? CsTechnAccMaxStart { get; set; }

    /// <summary>
    /// minimum allowed technological deceleration rate which can be realized by BA, when strip is already coiling
    /// </summary>
    public double? CsTechnAccMinCoiling { get; set; }

    /// <summary>
    /// minimum allowed technological deceleration rate which can be realized by BA, from strip head at last active stand till strip head at coiler
    /// </summary>
    public double? CsTechnAccMinStart { get; set; }

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
    public double? DeltaSpeedEnvelope { get; set; }

    public double? F4tReachedSeg1 { get; set; }

    public double? F4tReachedSeg2 { get; set; }

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

    public double? StripLength { get; set; }

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
    public double? VRef { get; set; }

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
