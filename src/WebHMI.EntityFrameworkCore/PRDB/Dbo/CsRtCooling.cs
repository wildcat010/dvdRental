using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Material specific strategy Table with Effective (E), Manual (M) and original (X) lines for each material
/// </summary>
public partial class CsRtCooling
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
    public string Description { get; set; }

    /// <summary>
    /// manual intervention in plan
    /// </summary>
    public short? ManInt { get; set; }

    /// <summary>
    /// Unit[0...999] plan number
    /// </summary>
    public int? PlanNo { get; set; }

    /// <summary>
    /// delay time to switch off
    /// </summary>
    public int? RtcCoolDownTime { get; set; }

    /// <summary>
    /// roller tables on durring production (0,1)
    /// </summary>
    public int? RtcStrategyInd0 { get; set; }

    /// <summary>
    /// roller tables on durring production (0,1)
    /// </summary>
    public int? RtcStrategyInd1 { get; set; }

    /// <summary>
    /// roller tables on durring production (0,1)
    /// </summary>
    public int? RtcStrategyInd10 { get; set; }

    /// <summary>
    /// roller tables on durring production (0,1)
    /// </summary>
    public int? RtcStrategyInd11 { get; set; }

    /// <summary>
    /// roller tables on durring production (0,1)
    /// </summary>
    public int? RtcStrategyInd12 { get; set; }

    /// <summary>
    /// roller tables on durring production (0,1)
    /// </summary>
    public int? RtcStrategyInd13 { get; set; }

    /// <summary>
    /// roller tables on durring production (0,1)
    /// </summary>
    public int? RtcStrategyInd14 { get; set; }

    /// <summary>
    /// roller tables on durring production (0,1)
    /// </summary>
    public int? RtcStrategyInd15 { get; set; }

    /// <summary>
    /// roller tables on durring production (0,1)
    /// </summary>
    public int? RtcStrategyInd2 { get; set; }

    /// <summary>
    /// roller tables on durring production (0,1)
    /// </summary>
    public int? RtcStrategyInd3 { get; set; }

    /// <summary>
    /// roller tables on durring production (0,1)
    /// </summary>
    public int? RtcStrategyInd4 { get; set; }

    /// <summary>
    /// roller tables on durring production (0,1)
    /// </summary>
    public int? RtcStrategyInd5 { get; set; }

    /// <summary>
    /// roller tables on durring production (0,1)
    /// </summary>
    public int? RtcStrategyInd6 { get; set; }

    /// <summary>
    /// roller tables on durring production (0,1)
    /// </summary>
    public int? RtcStrategyInd7 { get; set; }

    /// <summary>
    /// roller tables on durring production (0,1)
    /// </summary>
    public int? RtcStrategyInd8 { get; set; }

    /// <summary>
    /// roller tables on durring production (0,1)
    /// </summary>
    public int? RtcStrategyInd9 { get; set; }

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
