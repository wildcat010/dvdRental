using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Standard plan cyclic shifting pass
/// </summary>
public partial class StdDirFmPfcCycShiftPpass
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
    /// cyclic shift plan number
    /// </summary>
    public int PlanNo { get; set; }

    /// <summary>
    /// Unit[m] cyclic shifting: maximum shifting position
    /// </summary>
    public double? CSmaxLimit { get; set; }

    /// <summary>
    /// Unit[m] cyclic shifting: minimum shifting position
    /// </summary>
    public double? CSminLimit { get; set; }

    /// <summary>
    /// cyclic shifting mode: 0 - no shifting, 1- CVC-shifting, 2 - cyclic shifting TWM-mode, 3 - cyclic shifting TWM and fix step width, 4 - fix cyclic shifting
    /// </summary>
    public int? CSmode { get; set; }

    /// <summary>
    /// shifting direction -1 - negative, 1- positiv
    /// </summary>
    public int? CSshiftDir { get; set; }

    /// <summary>
    /// Unit[m] cyclic shifting step range
    /// </summary>
    public double? CSshiftStep1 { get; set; }

    /// <summary>
    /// Unit[m] cyclic shifting step range
    /// </summary>
    public double? CSshiftStep2 { get; set; }

    /// <summary>
    /// Unit[m] cyclic shifting step range
    /// </summary>
    public double? CSshiftStep3 { get; set; }

    /// <summary>
    /// Unit[m] cyclic shifting: start position
    /// </summary>
    public double? CSstartPos { get; set; }

    /// <summary>
    /// description field
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// manual intervention in plan
    /// </summary>
    public short? ManInt { get; set; }

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
