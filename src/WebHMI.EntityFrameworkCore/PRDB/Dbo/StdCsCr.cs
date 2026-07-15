using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Standard strategy Table for APS plan
/// </summary>
public partial class StdCsCr
{
    /// <summary>
    /// active flag
    /// </summary>
    public int ActiveFlag { get; set; }

    /// <summary>
    /// key for the compensation plan
    /// </summary>
    public int PlanNo { get; set; }

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
    /// description field 2
    /// </summary>
    public string Description2 { get; set; }

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
