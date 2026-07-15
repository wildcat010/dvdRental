using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Material specific strategy Table with Effective (E), Manual (M) and original (X) lines for each material
/// </summary>
public partial class StatCsRtCooling
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

    public string Source { get; set; }

    /// <summary>
    /// description field
    /// </summary>
    public short? Description { get; set; }

    /// <summary>
    /// manual intervention in plan
    /// </summary>
    public short? ManInt { get; set; }

    /// <summary>
    /// plan number
    /// </summary>
    public short? PlanNo { get; set; }

    /// <summary>
    /// delay time to switch off
    /// </summary>
    public short? RtcCoolDownTime { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public short? RtcStrategyInd00 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public short? RtcStrategyInd01 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public short? RtcStrategyInd02 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public short? RtcStrategyInd03 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public short? RtcStrategyInd04 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public short? RtcStrategyInd05 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public short? RtcStrategyInd06 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public short? RtcStrategyInd07 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public short? RtcStrategyInd08 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public short? RtcStrategyInd09 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public short? RtcStrategyInd10 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public short? RtcStrategyInd11 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public short? RtcStrategyInd12 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public short? RtcStrategyInd13 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public short? RtcStrategyInd14 { get; set; }

    /// <summary>
    /// roller tables on during production (0,1)
    /// </summary>
    public short? RtcStrategyInd15 { get; set; }

    /// <summary>
    /// External material ID
    /// </summary>
    public string ToExtId { get; set; }

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
