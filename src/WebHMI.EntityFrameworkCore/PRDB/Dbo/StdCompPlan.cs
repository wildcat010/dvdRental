using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Standard compensation plan
/// </summary>
public partial class StdCompPlan
{
    /// <summary>
    /// active flag
    /// </summary>
    public int ActiveFlag { get; set; }

    /// <summary>
    /// key for the compensation plan
    /// </summary>
    public int PlanNo { get; set; }

    public double? KawaInd0 { get; set; }

    public double? KawaInd1 { get; set; }

    public double? KawaInd10 { get; set; }

    public double? KawaInd11 { get; set; }

    public double? KawaInd12 { get; set; }

    public double? KawaInd13 { get; set; }

    public double? KawaInd14 { get; set; }

    public double? KawaInd15 { get; set; }

    public double? KawaInd16 { get; set; }

    public double? KawaInd17 { get; set; }

    public double? KawaInd18 { get; set; }

    public double? KawaInd19 { get; set; }

    public double? KawaInd2 { get; set; }

    public double? KawaInd20 { get; set; }

    public double? KawaInd21 { get; set; }

    public double? KawaInd22 { get; set; }

    public double? KawaInd23 { get; set; }

    public double? KawaInd24 { get; set; }

    public double? KawaInd25 { get; set; }

    public double? KawaInd3 { get; set; }

    public double? KawaInd4 { get; set; }

    public double? KawaInd5 { get; set; }

    public double? KawaInd6 { get; set; }

    public double? KawaInd7 { get; set; }

    public double? KawaInd8 { get; set; }

    public double? KawaInd9 { get; set; }

    public double? KawakInd0 { get; set; }

    public double? KawakInd1 { get; set; }

    public double? KawakInd2 { get; set; }

    public double? KawakInd3 { get; set; }

    public double? KawakInd4 { get; set; }

    public double? TempInd0 { get; set; }

    public double? TempInd1 { get; set; }

    public double? TempInd10 { get; set; }

    public double? TempInd11 { get; set; }

    public double? TempInd12 { get; set; }

    public double? TempInd13 { get; set; }

    public double? TempInd14 { get; set; }

    public double? TempInd15 { get; set; }

    public double? TempInd16 { get; set; }

    public double? TempInd17 { get; set; }

    public double? TempInd18 { get; set; }

    public double? TempInd19 { get; set; }

    public double? TempInd2 { get; set; }

    public double? TempInd20 { get; set; }

    public double? TempInd21 { get; set; }

    public double? TempInd22 { get; set; }

    public double? TempInd23 { get; set; }

    public double? TempInd24 { get; set; }

    public double? TempInd25 { get; set; }

    public double? TempInd3 { get; set; }

    public double? TempInd4 { get; set; }

    public double? TempInd5 { get; set; }

    public double? TempInd6 { get; set; }

    public double? TempInd7 { get; set; }

    public double? TempInd8 { get; set; }

    public double? TempInd9 { get; set; }

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
