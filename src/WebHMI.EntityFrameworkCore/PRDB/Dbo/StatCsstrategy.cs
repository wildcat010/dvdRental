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
    /// FM in bar adaption on (1), off (2)
    /// </summary>
    public short? AdaptationFm { get; set; }

    /// <summary>
    /// dynamic control in bar adaption on (1), off (2)
    /// </summary>
    public short? AdaptationInd0 { get; set; }

    /// <summary>
    /// dynamic control in bar adaption on (1), off (2)
    /// </summary>
    public short? AdaptationInd1 { get; set; }

    /// <summary>
    /// dynamic control auto spline transition temperature
    /// </summary>
    public short? AutoSplineTempTransition { get; set; }

    /// <summary>
    /// dynamic control auto spline low value (cool rate) bottom valves; in HMI in [%]
    /// </summary>
    public short? AutoSplineValueLowBot { get; set; }

    /// <summary>
    /// dynamic control auto spline low value (cool rate) top valves; in HMI in [%]
    /// </summary>
    public short? AutoSplineValueLowTop { get; set; }

    /// <summary>
    /// dynamic control cool rate(s) bot
    /// </summary>
    public short? CoolRateBotInd0 { get; set; }

    /// <summary>
    /// dynamic control cool rate(s) bot
    /// </summary>
    public short? CoolRateBotInd1 { get; set; }

    /// <summary>
    /// dynamic control cool rate(s) top
    /// </summary>
    public short? CoolRateTopInd0 { get; set; }

    /// <summary>
    /// dynamic control cool rate(s) top
    /// </summary>
    public short? CoolRateTopInd1 { get; set; }

    /// <summary>
    /// cooling strategy, as defined in enum CoolingStrategy of CS_CoolingCourse.h
    /// </summary>
    public short? CoolingStrategy { get; set; }

    /// <summary>
    /// Common data of CsStrategy and StdCsStrategy
    /// </summary>
    public short? Description { get; set; }

    /// <summary>
    /// fine tuning zone; in HMI in [%]
    /// </summary>
    public short? FtzLoad { get; set; }

    /// <summary>
    /// dynamic control hold time(s)
    /// </summary>
    public short? HoldTime { get; set; }

    /// <summary>
    /// dynamic control leading pyrometers indexe(s); also in HMI the undexe(s) are displayed
    /// </summary>
    public short? LeadingPyroIndexInd0 { get; set; }

    /// <summary>
    /// dynamic control leading pyrometers indexe(s); also in HMI the undexe(s) are displayed
    /// </summary>
    public short? LeadingPyroIndexInd1 { get; set; }

    /// <summary>
    /// manual intervention in plan
    /// </summary>
    public short? ManInt { get; set; }

    /// <summary>
    /// plan number
    /// </summary>
    public short? PlanNo { get; set; }

    /// <summary>
    /// dynamic control bot start valve(s) number of controller(s); also in HMI the first valve has number 1
    /// </summary>
    public short? StartValveNumberBotInd0 { get; set; }

    /// <summary>
    /// dynamic control bot start valve(s) number of controller(s); also in HMI the first valve has number 1
    /// </summary>
    public short? StartValveNumberBotInd1 { get; set; }

    /// <summary>
    /// dynamic control top start valve(s) number of controller(s); also in HMI the first valve has number 1
    /// </summary>
    public short? StartValveNumberTopInd0 { get; set; }

    /// <summary>
    /// dynamic control top start valve(s) number of controller(s); also in HMI the first valve has number 1
    /// </summary>
    public short? StartValveNumberTopInd1 { get; set; }

    /// <summary>
    /// dynamic control target F4T(s); in HMI in [%]
    /// </summary>
    public short? TargetF4tInd0 { get; set; }

    /// <summary>
    /// dynamic control target F4T(s); in HMI in [%]
    /// </summary>
    public short? TargetF4tInd1 { get; set; }

    /// <summary>
    /// dynamic control target temperature(s)
    /// </summary>
    public short? TargetTempInd0 { get; set; }

    /// <summary>
    /// dynamic control target temperature(s)
    /// </summary>
    public short? TargetTempInd1 { get; set; }

    /// <summary>
    /// temperature gradient for first phase
    /// </summary>
    public short? TempGradInd0 { get; set; }

    /// <summary>
    /// temperature gradient for first phase
    /// </summary>
    public short? TempGradInd1 { get; set; }

    /// <summary>
    /// dynamic control target temperature offset(s) A (head)
    /// </summary>
    public short? TempOffsetAInd0 { get; set; }

    /// <summary>
    /// dynamic control target temperature offset(s) A (head)
    /// </summary>
    public short? TempOffsetAInd1 { get; set; }

    /// <summary>
    /// dynamic control target temperature offset(s) B (tail)
    /// </summary>
    public short? TempOffsetBInd0 { get; set; }

    /// <summary>
    /// dynamic control target temperature offset(s) B (tail)
    /// </summary>
    public short? TempOffsetBInd1 { get; set; }

    /// <summary>
    /// FM target temperature offset(s) A (head)
    /// </summary>
    public short? TempOffsetFmA { get; set; }

    /// <summary>
    /// FM target temperature offset(s) B (tail)
    /// </summary>
    public short? TempOffsetFmB { get; set; }

    /// <summary>
    /// External material ID
    /// </summary>
    public string ToExtId { get; set; }

    /// <summary>
    /// NULL: tempGrad part invisible, 0: use coolrate (tempGrad calculated from coolrate for reference), 1: use tempGrad (coolRate is calculated from desired tempGrad at strip head and gets read only)
    /// </summary>
    public short? UseTempGradSelectionInd0 { get; set; }

    /// <summary>
    /// NULL: tempGrad part invisible, 0: use coolrate (tempGrad calculated from coolrate for reference), 1: use tempGrad (coolRate is calculated from desired tempGrad at strip head and gets read only)
    /// </summary>
    public short? UseTempGradSelectionInd1 { get; set; }

    /// <summary>
    /// Example: behaves like 2 to 3 (top to bottom)
    /// </summary>
    public short? ValveRatioBotInd0 { get; set; }

    /// <summary>
    /// Example: behaves like 2 to 3 (top to bottom)
    /// </summary>
    public short? ValveRatioBotInd1 { get; set; }

    /// <summary>
    /// Example: behaves like 2 to 3 (top to bottom)
    /// </summary>
    public short? ValveRatioTopInd0 { get; set; }

    /// <summary>
    /// Example: behaves like 2 to 3 (top to bottom)
    /// </summary>
    public short? ValveRatioTopInd1 { get; set; }

    /// <summary>
    /// [0..x] valveSequence index for direct reference of a customer specific ValveSequenceClusterDcCus_xx (optional)
    /// </summary>
    public short? ValveSequenceIndexCus { get; set; }

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
