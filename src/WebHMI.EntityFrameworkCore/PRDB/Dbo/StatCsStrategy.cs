using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Material specific strategy Table with Effective (E), Manual (M) and original (X) lines for each material
/// </summary>
public partial class StatCsStrategy
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
    /// L: L3 PDI, E Effective, M Manual
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// Used in case of valid input of TempGrad for first phase
    /// </summary>
    public short? ValveRatio { get; set; }

    /// <summary>
    /// FM in bar adaption on (1), off (2)
    /// </summary>
    public short? Aft { get; set; }

    /// <summary>
    /// cooling strategy, as defined in enum CoolingStrategy of CS_CoolingCourse.h
    /// </summary>
    public short? CoolingStrategy { get; set; }

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
    /// dynamic control auto spline transition temperature
    /// </summary>
    public short? DcAutoSplineTempTransition { get; set; }

    /// <summary>
    /// dynamic control auto spline low value (cool rate) bottom valves
    /// </summary>
    public short? DcAutoSplineValueLowBot { get; set; }

    /// <summary>
    /// dynamic control auto spline low value (cool rate) top valves
    /// </summary>
    public short? DcAutoSplineValueLowTop { get; set; }

    /// <summary>
    /// dynamic control cool rate(s) bot
    /// </summary>
    public short? DcCoolRateBotInd0 { get; set; }

    /// <summary>
    /// dynamic control cool rate(s) bot
    /// </summary>
    public short? DcCoolRateBotInd1 { get; set; }

    /// <summary>
    /// dynamic control cool rate(s) bot
    /// </summary>
    public short? DcCoolRateBotInd2 { get; set; }

    /// <summary>
    /// dynamic control cool rate(s) bot
    /// </summary>
    public short? DcCoolRateBotInd3 { get; set; }

    /// <summary>
    /// dynamic control cool rate(s) top
    /// </summary>
    public short? DcCoolRateTopInd0 { get; set; }

    /// <summary>
    /// dynamic control cool rate(s) top
    /// </summary>
    public short? DcCoolRateTopInd1 { get; set; }

    /// <summary>
    /// dynamic control cool rate(s) top
    /// </summary>
    public short? DcCoolRateTopInd2 { get; set; }

    /// <summary>
    /// dynamic control cool rate(s) top
    /// </summary>
    public short? DcCoolRateTopInd3 { get; set; }

    /// <summary>
    /// dynamic control hold time(s)
    /// </summary>
    public short? DcHoldTimeInd0 { get; set; }

    /// <summary>
    /// dynamic control hold time(s)
    /// </summary>
    public short? DcHoldTimeInd1 { get; set; }

    /// <summary>
    /// dynamic control hold time(s)
    /// </summary>
    public short? DcHoldTimeInd2 { get; set; }

    /// <summary>
    /// dynamic control leading pyrometers indexe(s)
    /// </summary>
    public short? DcLeadingPyroInd0 { get; set; }

    /// <summary>
    /// dynamic control leading pyrometers indexe(s)
    /// </summary>
    public short? DcLeadingPyroInd1 { get; set; }

    /// <summary>
    /// dynamic control leading pyrometers indexe(s)
    /// </summary>
    public short? DcLeadingPyroInd2 { get; set; }

    /// <summary>
    /// dynamic control leading pyrometers indexe(s)
    /// </summary>
    public short? DcLeadingPyroInd3 { get; set; }

    /// <summary>
    /// dynamic control cool mode (for single phase only), target is on intermerdiate place (0) or coiler (1)
    /// </summary>
    public short? DcMode { get; set; }

    /// <summary>
    /// dynamic control start valve(s) of controller(s)
    /// </summary>
    public short? DcStartPosInd0 { get; set; }

    /// <summary>
    /// dynamic control start valve(s) of controller(s)
    /// </summary>
    public short? DcStartPosInd1 { get; set; }

    /// <summary>
    /// dynamic control start valve(s) of controller(s)
    /// </summary>
    public short? DcStartPosInd2 { get; set; }

    /// <summary>
    /// dynamic control start valve(s) of controller(s)
    /// </summary>
    public short? DcStartPosInd3 { get; set; }

    /// <summary>
    /// dynamic control target F4T(s)
    /// </summary>
    public short? DcTargetF4tInd0 { get; set; }

    /// <summary>
    /// dynamic control target F4T(s)
    /// </summary>
    public short? DcTargetF4tInd1 { get; set; }

    /// <summary>
    /// dynamic control target F4T(s)
    /// </summary>
    public short? DcTargetF4tInd2 { get; set; }

    /// <summary>
    /// dynamic control target F4T(s)
    /// </summary>
    public short? DcTargetF4tInd3 { get; set; }

    /// <summary>
    /// dynamic control target temperature(s)
    /// </summary>
    public short? DcTargetTempInd0 { get; set; }

    /// <summary>
    /// dynamic control target temperature(s)
    /// </summary>
    public short? DcTargetTempInd1 { get; set; }

    /// <summary>
    /// dynamic control target temperature(s)
    /// </summary>
    public short? DcTargetTempInd2 { get; set; }

    /// <summary>
    /// dynamic control target temperature(s)
    /// </summary>
    public short? DcTargetTempInd3 { get; set; }

    /// <summary>
    /// dynamic control target temperature offset(s) B (tail)
    /// </summary>
    public short? DcTempOffsetBInd0 { get; set; }

    /// <summary>
    /// dynamic control target temperature offset(s) B (tail)
    /// </summary>
    public short? DcTempOffsetBInd1 { get; set; }

    /// <summary>
    /// dynamic control target temperature offset(s) B (tail)
    /// </summary>
    public short? DcTempOffsetBInd2 { get; set; }

    /// <summary>
    /// dynamic control target temperature offset(s) B (tail)
    /// </summary>
    public short? DcTempOffsetBInd3 { get; set; }

    /// <summary>
    /// FM target temperature offset(s) A (head)
    /// </summary>
    public short? DcTempOffsetFm { get; set; }

    /// <summary>
    /// FM target temperature offset(s) B (tail)
    /// </summary>
    public short? DcTempOffsetFmB { get; set; }

    /// <summary>
    /// dynamic control target temperature offset(s) A (head)
    /// </summary>
    public short? DcTempOffsetInd0 { get; set; }

    /// <summary>
    /// dynamic control target temperature offset(s) A (head)
    /// </summary>
    public short? DcTempOffsetInd1 { get; set; }

    /// <summary>
    /// dynamic control target temperature offset(s) A (head)
    /// </summary>
    public short? DcTempOffsetInd2 { get; set; }

    /// <summary>
    /// dynamic control target temperature offset(s) A (head)
    /// </summary>
    public short? DcTempOffsetInd3 { get; set; }

    /// <summary>
    /// Cool rate bot for first phase water amount [0..1]
    /// </summary>
    public short? Description { get; set; }

    /// <summary>
    /// fine tuning zone
    /// </summary>
    public short? FtzLoad { get; set; }

    /// <summary>
    /// Furnace no
    /// </summary>
    public short? FurnaceNo { get; set; }

    /// <summary>
    /// manual intervention in plan
    /// </summary>
    public short? ManInt { get; set; }

    /// <summary>
    /// plan number
    /// </summary>
    public short? PlanNo { get; set; }

    /// <summary>
    /// temperature gradient for first phase
    /// </summary>
    public short? TempGrad { get; set; }

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
