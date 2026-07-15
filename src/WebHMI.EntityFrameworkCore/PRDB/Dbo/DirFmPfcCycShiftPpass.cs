using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Material related strategy value: cyclic shifting pass
/// </summary>
public partial class DirFmPfcCycShiftPpass
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
    /// Unit[m] cyclic shifting: maximum shifting position
    /// </summary>
    public double? CSmaxLimit { get; set; }

    /// <summary>
    /// Unit[m] wear shifting: maximum shifting position
    /// </summary>
    public double? CSmaxLimitParabolicInd0 { get; set; }

    /// <summary>
    /// Unit[m] wear shifting: maximum shifting position
    /// </summary>
    public double? CSmaxLimitParabolicInd1 { get; set; }

    /// <summary>
    /// Unit[m] wear shifting: maximum shifting position
    /// </summary>
    public double? CSmaxLimitParabolicInd2 { get; set; }

    /// <summary>
    /// Unit[m] cyclic shifting: minimum shifting position
    /// </summary>
    public double? CSminLimit { get; set; }

    /// <summary>
    /// Unit[m] wear shifting: minimum shifting position
    /// </summary>
    public double? CSminLimitParabolicInd0 { get; set; }

    /// <summary>
    /// Unit[m] wear shifting: minimum shifting position
    /// </summary>
    public double? CSminLimitParabolicInd1 { get; set; }

    /// <summary>
    /// Unit[m] wear shifting: minimum shifting position
    /// </summary>
    public double? CSminLimitParabolicInd2 { get; set; }

    /// <summary>
    /// wear shifting on/off: 0 - no shifting, 1 - shifting based on rollshape active
    /// </summary>
    public int? CSmode { get; set; }

    /// <summary>
    /// wear shifting direction: -1: negative, 1: positiv
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
    /// Unit[m] wear shifting: start position
    /// </summary>
    public double? CSstartPos { get; set; }

    /// <summary>
    /// Unit[m] wear shifting step range - parabolic
    /// </summary>
    public double? CSstepParabolicInd0 { get; set; }

    /// <summary>
    /// Unit[m] wear shifting step range - parabolic
    /// </summary>
    public double? CSstepParabolicInd1 { get; set; }

    /// <summary>
    /// Unit[m] wear shifting step range - parabolic
    /// </summary>
    public double? CSstepParabolicInd2 { get; set; }

    /// <summary>
    /// Unit[m] wear shifting step range - SmartCrown / CVC
    /// </summary>
    public double? CSstepSmartCrownInd0 { get; set; }

    /// <summary>
    /// Unit[m] wear shifting step range - SmartCrown / CVC
    /// </summary>
    public double? CSstepSmartCrownInd1 { get; set; }

    /// <summary>
    /// Unit[m] wear shifting step range - SmartCrown / CVC
    /// </summary>
    public double? CSstepSmartCrownInd2 { get; set; }

    /// <summary>
    /// description field
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// manual intervention in plan
    /// </summary>
    public short? ManInt { get; set; }

    /// <summary>
    /// cyclic shift plan number
    /// </summary>
    public int? PlanNo { get; set; }

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
