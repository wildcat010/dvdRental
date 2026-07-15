using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Standard strategy Table for APS plan
/// </summary>
public partial class StdCsRtCooling
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
    /// description field
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// delay time to switch off
    /// </summary>
    public int? RtcCoolDownTime { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public int? RtcStrategyInd00 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public int? RtcStrategyInd01 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public int? RtcStrategyInd02 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public int? RtcStrategyInd03 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public int? RtcStrategyInd04 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public int? RtcStrategyInd05 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public int? RtcStrategyInd06 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public int? RtcStrategyInd07 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public int? RtcStrategyInd08 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public int? RtcStrategyInd09 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public int? RtcStrategyInd10 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public int? RtcStrategyInd11 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public int? RtcStrategyInd12 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public int? RtcStrategyInd13 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public int? RtcStrategyInd14 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public int? RtcStrategyInd15 { get; set; }

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
