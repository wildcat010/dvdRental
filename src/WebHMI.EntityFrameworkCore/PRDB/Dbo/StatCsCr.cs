using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Material specific strategy Table with Effective (E), Manual (M) and original (X) lines for each material
/// </summary>
public partial class StatCsCr
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

    public short? CrsInd0 { get; set; }

    public short? CrsInd1 { get; set; }

    public short? CrsInd10 { get; set; }

    public short? CrsInd11 { get; set; }

    public short? CrsInd12 { get; set; }

    public short? CrsInd13 { get; set; }

    public short? CrsInd14 { get; set; }

    public short? CrsInd15 { get; set; }

    public short? CrsInd16 { get; set; }

    public short? CrsInd17 { get; set; }

    public short? CrsInd18 { get; set; }

    public short? CrsInd19 { get; set; }

    public short? CrsInd2 { get; set; }

    public short? CrsInd20 { get; set; }

    public short? CrsInd21 { get; set; }

    public short? CrsInd22 { get; set; }

    public short? CrsInd23 { get; set; }

    public short? CrsInd24 { get; set; }

    public short? CrsInd25 { get; set; }

    public short? CrsInd26 { get; set; }

    public short? CrsInd27 { get; set; }

    public short? CrsInd28 { get; set; }

    public short? CrsInd29 { get; set; }

    public short? CrsInd3 { get; set; }

    public short? CrsInd30 { get; set; }

    public short? CrsInd31 { get; set; }

    public short? CrsInd32 { get; set; }

    public short? CrsInd33 { get; set; }

    public short? CrsInd34 { get; set; }

    public short? CrsInd35 { get; set; }

    public short? CrsInd36 { get; set; }

    public short? CrsInd37 { get; set; }

    public short? CrsInd38 { get; set; }

    public short? CrsInd39 { get; set; }

    public short? CrsInd4 { get; set; }

    public short? CrsInd5 { get; set; }

    public short? CrsInd6 { get; set; }

    public short? CrsInd7 { get; set; }

    public short? CrsInd8 { get; set; }

    public short? CrsInd9 { get; set; }

    public short? Delaylength { get; set; }

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
