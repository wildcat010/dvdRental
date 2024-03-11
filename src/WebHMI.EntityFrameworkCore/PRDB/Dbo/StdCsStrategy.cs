using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Standard strategy Table for APS plan
/// </summary>
public partial class StdCsStrategy
{
    /// <summary>
    /// active flag
    /// </summary>
    public int ActiveFlag { get; set; }

    /// <summary>
    /// key for the compensation plan
    /// </summary>
    public int PlanNo { get; set; }

    /// <summary>
    /// Used in case of valid input of TempGrad for first phase
    /// </summary>
    public float? ValveRatio { get; set; }

    /// <summary>
    /// FM in bar adaption on (1), off (2)
    /// </summary>
    public float? Aft { get; set; }

    /// <summary>
    /// cooling strategy, as defined in enum CoolingStrategy of CS_CoolingCourse.h
    /// </summary>
    public int? CoolingStrategy { get; set; }

    /// <summary>
    /// dynamic control in bar adaption on (1), off (2)
    /// </summary>
    public short? DcAdaptationInd0 { get; set; }

    /// <summary>
    /// dynamic control in bar adaption on (1), off (2)
    /// </summary>
    public short? DcAdaptationInd1 { get; set; }

    /// <summary>
    /// dynamic control in bar adaption on (1), off (2)
    /// </summary>
    public short? DcAdaptationInd2 { get; set; }

    /// <summary>
    /// dynamic control in bar adaption on (1), off (2)
    /// </summary>
    public short? DcAdaptationInd3 { get; set; }

    /// <summary>
    /// Unit[degC] dynamic control auto spline transition temperature
    /// </summary>
    public float? DcAutoSplineTempTransition { get; set; }

    /// <summary>
    /// dynamic control auto spline low value (cool rate) bottom valves
    /// </summary>
    public float? DcAutoSplineValueLowBot { get; set; }

    /// <summary>
    /// dynamic control auto spline low value (cool rate) top valves
    /// </summary>
    public float? DcAutoSplineValueLowTop { get; set; }

    /// <summary>
    /// dynamic control cool rate(s) bot
    /// </summary>
    public float? DcCoolRateBotInd0 { get; set; }

    /// <summary>
    /// dynamic control cool rate(s) bot
    /// </summary>
    public float? DcCoolRateBotInd1 { get; set; }

    /// <summary>
    /// dynamic control cool rate(s) bot
    /// </summary>
    public float? DcCoolRateBotInd2 { get; set; }

    /// <summary>
    /// dynamic control cool rate(s) bot
    /// </summary>
    public float? DcCoolRateBotInd3 { get; set; }

    /// <summary>
    /// dynamic control cool rate(s) top
    /// </summary>
    public float? DcCoolRateTopInd0 { get; set; }

    /// <summary>
    /// dynamic control cool rate(s) top
    /// </summary>
    public float? DcCoolRateTopInd1 { get; set; }

    /// <summary>
    /// dynamic control cool rate(s) top
    /// </summary>
    public float? DcCoolRateTopInd2 { get; set; }

    /// <summary>
    /// dynamic control cool rate(s) top
    /// </summary>
    public float? DcCoolRateTopInd3 { get; set; }

    /// <summary>
    /// Unit[s] dynamic control hold time(s)
    /// </summary>
    public float? DcHoldTimeInd0 { get; set; }

    /// <summary>
    /// Unit[s] dynamic control hold time(s)
    /// </summary>
    public float? DcHoldTimeInd1 { get; set; }

    /// <summary>
    /// Unit[s] dynamic control hold time(s)
    /// </summary>
    public float? DcHoldTimeInd2 { get; set; }

    /// <summary>
    /// Unit[idx] dynamic control leading pyrometers indexe(s)
    /// </summary>
    public short? DcLeadingPyroInd0 { get; set; }

    /// <summary>
    /// Unit[idx] dynamic control leading pyrometers indexe(s)
    /// </summary>
    public short? DcLeadingPyroInd1 { get; set; }

    /// <summary>
    /// Unit[idx] dynamic control leading pyrometers indexe(s)
    /// </summary>
    public short? DcLeadingPyroInd2 { get; set; }

    /// <summary>
    /// Unit[idx] dynamic control leading pyrometers indexe(s)
    /// </summary>
    public short? DcLeadingPyroInd3 { get; set; }

    /// <summary>
    /// dynamic control cool mode (for single phase only), target is on intermerdiate place (0) or coiler (1)
    /// </summary>
    public short? DcMode { get; set; }

    /// <summary>
    /// Unit[m] dynamic control start valve(s) of controller(s)
    /// </summary>
    public float? DcStartPosInd0 { get; set; }

    /// <summary>
    /// Unit[m] dynamic control start valve(s) of controller(s)
    /// </summary>
    public float? DcStartPosInd1 { get; set; }

    /// <summary>
    /// Unit[m] dynamic control start valve(s) of controller(s)
    /// </summary>
    public float? DcStartPosInd2 { get; set; }

    /// <summary>
    /// Unit[m] dynamic control start valve(s) of controller(s)
    /// </summary>
    public float? DcStartPosInd3 { get; set; }

    /// <summary>
    /// dynamic control target F4T(s)
    /// </summary>
    public float? DcTargetF4tInd0 { get; set; }

    /// <summary>
    /// dynamic control target F4T(s)
    /// </summary>
    public float? DcTargetF4tInd1 { get; set; }

    /// <summary>
    /// dynamic control target F4T(s)
    /// </summary>
    public float? DcTargetF4tInd2 { get; set; }

    /// <summary>
    /// dynamic control target F4T(s)
    /// </summary>
    public float? DcTargetF4tInd3 { get; set; }

    /// <summary>
    /// Unit[degC] dynamic control target temperature(s)
    /// </summary>
    public float? DcTargetTempInd0 { get; set; }

    /// <summary>
    /// Unit[degC] dynamic control target temperature(s)
    /// </summary>
    public float? DcTargetTempInd1 { get; set; }

    /// <summary>
    /// Unit[degC] dynamic control target temperature(s)
    /// </summary>
    public float? DcTargetTempInd2 { get; set; }

    /// <summary>
    /// Unit[degC] dynamic control target temperature(s)
    /// </summary>
    public float? DcTargetTempInd3 { get; set; }

    /// <summary>
    /// Unit[degC] dynamic control target temperature offset(s) B (tail)
    /// </summary>
    public float? DcTempOffsetBInd0 { get; set; }

    /// <summary>
    /// Unit[degC] dynamic control target temperature offset(s) B (tail)
    /// </summary>
    public float? DcTempOffsetBInd1 { get; set; }

    /// <summary>
    /// Unit[degC] dynamic control target temperature offset(s) B (tail)
    /// </summary>
    public float? DcTempOffsetBInd2 { get; set; }

    /// <summary>
    /// Unit[degC] dynamic control target temperature offset(s) B (tail)
    /// </summary>
    public float? DcTempOffsetBInd3 { get; set; }

    /// <summary>
    /// Unit[degC] FM target temperature offset(s) A (head)
    /// </summary>
    public float? DcTempOffsetFm { get; set; }

    /// <summary>
    /// Unit[degC] FM target temperature offset(s) B (tail)
    /// </summary>
    public float? DcTempOffsetFmB { get; set; }

    /// <summary>
    /// Unit[degC] dynamic control target temperature offset(s) A (head)
    /// </summary>
    public float? DcTempOffsetInd0 { get; set; }

    /// <summary>
    /// Unit[degC] dynamic control target temperature offset(s) A (head)
    /// </summary>
    public float? DcTempOffsetInd1 { get; set; }

    /// <summary>
    /// Unit[degC] dynamic control target temperature offset(s) A (head)
    /// </summary>
    public float? DcTempOffsetInd2 { get; set; }

    /// <summary>
    /// Unit[degC] dynamic control target temperature offset(s) A (head)
    /// </summary>
    public float? DcTempOffsetInd3 { get; set; }

    /// <summary>
    /// Cool rate bot for first phase water amount [0..1]
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// fine tuning zone
    /// </summary>
    public float? FtzLoad { get; set; }

    /// <summary>
    /// Furnace no
    /// </summary>
    public short? FurnaceNo { get; set; }

    /// <summary>
    /// temperature gradient for first phase
    /// </summary>
    public float? TempGrad { get; set; }

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
