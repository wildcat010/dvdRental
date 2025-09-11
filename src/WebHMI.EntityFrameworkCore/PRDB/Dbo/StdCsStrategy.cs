using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StdCsStrategy
{
    public int ActiveFlag { get; set; }

    public int PlanNo { get; set; }

    public short? AdaptationFm { get; set; }

    public short? AdaptationInd0 { get; set; }

    public short? AdaptationInd1 { get; set; }

    public double? AutoSplineTempTransition { get; set; }

    public double? AutoSplineValueLowBot { get; set; }

    public double? AutoSplineValueLowTop { get; set; }

    public double? CoolRateBotInd0 { get; set; }

    public double? CoolRateBotInd1 { get; set; }

    public double? CoolRateTopInd0 { get; set; }

    public double? CoolRateTopInd1 { get; set; }

    public int? CoolingStrategy { get; set; }

    public string Description { get; set; }

    public string Description2 { get; set; }

    public double? FtzLoad { get; set; }

    public double? HoldTime { get; set; }

    public short? LeadingPyroIndexInd0 { get; set; }

    public short? LeadingPyroIndexInd1 { get; set; }

    public short? StartValveNumberBotInd0 { get; set; }

    public short? StartValveNumberBotInd1 { get; set; }

    public short? StartValveNumberTopInd0 { get; set; }

    public short? StartValveNumberTopInd1 { get; set; }

    public double? TargetF4tInd0 { get; set; }

    public double? TargetF4tInd1 { get; set; }

    public double? TargetTempInd0 { get; set; }

    public double? TargetTempInd1 { get; set; }

    public double? TempGradInd0 { get; set; }

    public double? TempGradInd1 { get; set; }

    public double? TempOffsetAInd0 { get; set; }

    public double? TempOffsetAInd1 { get; set; }

    public double? TempOffsetBInd0 { get; set; }

    public double? TempOffsetBInd1 { get; set; }

    public double? TempOffsetFmA { get; set; }

    public double? TempOffsetFmB { get; set; }

    public short? UseTempGradSelectionInd0 { get; set; }

    public short? UseTempGradSelectionInd1 { get; set; }

    public short? ValveRatioBotInd0 { get; set; }

    public short? ValveRatioBotInd1 { get; set; }

    public short? ValveRatioTopInd0 { get; set; }

    public short? ValveRatioTopInd1 { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
