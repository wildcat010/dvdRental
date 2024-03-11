using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Material related strategy value: cyclic shifting pass
/// </summary>
public partial class StatDirFmPfcCycShiftPpass
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
    /// pass number
    /// </summary>
    public int PassNo { get; set; }

    /// <summary>
    /// owner
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// cyclic shifting: maximum shifting position
    /// </summary>
    public short? CSmaxLimit { get; set; }

    /// <summary>
    /// cyclic shifting: minimum shifting position
    /// </summary>
    public short? CSminLimit { get; set; }

    /// <summary>
    /// cyclic shifting mode: 0 - no shifting, 1- CVC-shifting, 2 - cyclic shifting TWM-mode, 3 - cyclic shifting TWM and fix step width, 4 - fix cyclic shifting
    /// </summary>
    public short? CSmode { get; set; }

    /// <summary>
    /// shifting direction -1 - negative, 1- positiv
    /// </summary>
    public short? CSshiftDir { get; set; }

    /// <summary>
    /// cyclic shifting step range
    /// </summary>
    public short? CSshiftStep1 { get; set; }

    /// <summary>
    /// cyclic shifting step range
    /// </summary>
    public short? CSshiftStep2 { get; set; }

    /// <summary>
    /// cyclic shifting step range
    /// </summary>
    public short? CSshiftStep3 { get; set; }

    /// <summary>
    /// cyclic shifting: start position
    /// </summary>
    public short? CSstartPos { get; set; }

    /// <summary>
    /// description field
    /// </summary>
    public short? Description { get; set; }

    /// <summary>
    /// manual intervention in plan
    /// </summary>
    public short? ManInt { get; set; }

    /// <summary>
    /// cyclic shift plan number
    /// </summary>
    public short? PlanNo { get; set; }

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
