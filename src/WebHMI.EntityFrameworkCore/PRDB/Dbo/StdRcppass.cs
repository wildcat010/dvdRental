using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Standard roll cooling plan pass
/// </summary>
public partial class StdRcppass
{
    /// <summary>
    /// active flag
    /// </summary>
    public int ActiveFlag { get; set; }

    /// <summary>
    /// pass number
    /// </summary>
    public int PassNo { get; set; }

    /// <summary>
    /// Unit[0...999] r c p number
    /// </summary>
    public int PlanNo { get; set; }

    /// <summary>
    /// Unit[%] multizone cooling: amplitude for parabolic cooling curve
    /// </summary>
    public double? Mzcamplitude { get; set; }

    /// <summary>
    /// multizone cooling: cascade order
    /// </summary>
    public int? MzccascadeInd0 { get; set; }

    /// <summary>
    /// multizone cooling: cascade order
    /// </summary>
    public int? MzccascadeInd1 { get; set; }

    /// <summary>
    /// multizone cooling: cascade order
    /// </summary>
    public int? MzccascadeInd2 { get; set; }

    /// <summary>
    /// Unit[0..1] multizone cooling: flow rate
    /// </summary>
    public double? MzcflowRate { get; set; }

    /// <summary>
    /// Unit[0..1] multizone cooling: flow rate at the edges
    /// </summary>
    public double? MzcflowRateEdge { get; set; }

    /// <summary>
    /// multizone cooling: number of valves to add or reduce from strip width
    /// </summary>
    public int? MzcnozzelIndex { get; set; }

    /// <summary>
    /// Unit[s] delay time for roll cooling
    /// </summary>
    public double? DelayTime { get; set; }

    /// <summary>
    /// description field
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Unit[0..1] area back up roll, factor flow back up roll cooling idle
    /// </summary>
    public double? FlowBrIdleInd0 { get; set; }

    /// <summary>
    /// Unit[0..1] area back up roll, factor flow back up roll cooling idle
    /// </summary>
    public double? FlowBrIdleInd1 { get; set; }

    /// <summary>
    /// Unit[0..1] area back up roll, factor flow back up roll cooling idle
    /// </summary>
    public double? FlowBrIdleInd2 { get; set; }

    /// <summary>
    /// Unit[0..1] factor flow back up roll cooling stand loaded
    /// </summary>
    public double? FlowBrLoadedInd0 { get; set; }

    /// <summary>
    /// Unit[0..1] factor flow back up roll cooling stand loaded
    /// </summary>
    public double? FlowBrLoadedInd1 { get; set; }

    /// <summary>
    /// Unit[0..1] factor flow back up roll cooling stand loaded
    /// </summary>
    public double? FlowBrLoadedInd2 { get; set; }

    /// <summary>
    /// Unit[0..1] area work roll, factor flow work roll cooling idle
    /// </summary>
    public double? FlowWrIdleInd0 { get; set; }

    /// <summary>
    /// Unit[0..1] area work roll, factor flow work roll cooling idle
    /// </summary>
    public double? FlowWrIdleInd1 { get; set; }

    /// <summary>
    /// Unit[0..1] area work roll, factor flow work roll cooling idle
    /// </summary>
    public double? FlowWrIdleInd2 { get; set; }

    /// <summary>
    /// Unit[0..1] area work roll, factor flow work roll cooling idle
    /// </summary>
    public double? FlowWrIdleInd3 { get; set; }

    /// <summary>
    /// Unit[0..1] area work roll, factor flow work roll cooling idle
    /// </summary>
    public double? FlowWrIdleInd4 { get; set; }

    /// <summary>
    /// Unit[0..1] area work roll, factor flow work roll cooling idle
    /// </summary>
    public double? FlowWrIdleInd5 { get; set; }

    /// <summary>
    /// Unit[0..1] factor flow work roll cooling loaded
    /// </summary>
    public double? FlowWrLoadedInd0 { get; set; }

    /// <summary>
    /// Unit[0..1] factor flow work roll cooling loaded
    /// </summary>
    public double? FlowWrLoadedInd1 { get; set; }

    /// <summary>
    /// Unit[0..1] factor flow work roll cooling loaded
    /// </summary>
    public double? FlowWrLoadedInd2 { get; set; }

    /// <summary>
    /// Unit[0..1] factor flow work roll cooling loaded
    /// </summary>
    public double? FlowWrLoadedInd3 { get; set; }

    /// <summary>
    /// Unit[0..1] factor flow work roll cooling loaded
    /// </summary>
    public double? FlowWrLoadedInd4 { get; set; }

    /// <summary>
    /// Unit[0..1] factor flow work roll cooling loaded
    /// </summary>
    public double? FlowWrLoadedInd5 { get; set; }

    /// <summary>
    /// number of roll cooling curve for segmented cooling
    /// </summary>
    public int? RollCoolCurve { get; set; }

    /// <summary>
    /// Unit[0 / 1] roll cooling pass state: 0=AUTO, 1=MAN
    /// </summary>
    public int? RollCoolState { get; set; }

    /// <summary>
    /// work roll cooling angle RTC
    /// </summary>
    public int? WrcAngle { get; set; }

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
