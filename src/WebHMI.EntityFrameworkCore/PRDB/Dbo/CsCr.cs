using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Material specific strategy Table with Effective (E), Manual (M) and original (X) lines for each material
/// </summary>
public partial class CsCr
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

    public int? CrsInd00 { get; set; }

    public int? CrsInd01 { get; set; }

    public int? CrsInd02 { get; set; }

    public int? CrsInd03 { get; set; }

    public int? CrsInd04 { get; set; }

    public int? CrsInd05 { get; set; }

    public int? CrsInd06 { get; set; }

    public int? CrsInd07 { get; set; }

    public int? CrsInd08 { get; set; }

    public int? CrsInd09 { get; set; }

    public int? CrsInd10 { get; set; }

    public int? CrsInd11 { get; set; }

    public int? CrsInd12 { get; set; }

    public int? CrsInd13 { get; set; }

    public int? CrsInd14 { get; set; }

    public int? CrsInd15 { get; set; }

    public int? CrsInd16 { get; set; }

    public int? CrsInd17 { get; set; }

    public int? CrsInd18 { get; set; }

    public int? CrsInd19 { get; set; }

    public int? CrsInd20 { get; set; }

    public int? CrsInd21 { get; set; }

    public int? CrsInd22 { get; set; }

    public int? CrsInd23 { get; set; }

    public int? CrsInd24 { get; set; }

    public int? CrsInd25 { get; set; }

    public int? CrsInd26 { get; set; }

    public int? CrsInd27 { get; set; }

    public int? CrsInd28 { get; set; }

    public int? CrsInd29 { get; set; }

    public int? CrsInd30 { get; set; }

    public int? CrsInd31 { get; set; }

    public int? CrsInd32 { get; set; }

    public int? CrsInd33 { get; set; }

    public int? CrsInd34 { get; set; }

    public int? CrsInd35 { get; set; }

    public int? CrsInd36 { get; set; }

    public int? CrsInd37 { get; set; }

    public int? CrsInd38 { get; set; }

    public int? CrsInd39 { get; set; }

    public int? Delaylength { get; set; }

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
