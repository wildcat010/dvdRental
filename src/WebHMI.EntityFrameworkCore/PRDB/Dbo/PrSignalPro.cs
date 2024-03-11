using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Record any cut to material
/// </summary>
public partial class PrSignalPro
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
    /// time of cut
    /// </summary>
    public string NameRef { get; set; }

    /// <summary>
    /// data source
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// target value
    /// </summary>
    public double? Target { get; set; }

    /// <summary>
    /// External material ID
    /// </summary>
    public string ToExtId { get; set; }

    /// <summary>
    /// upper tolerance
    /// </summary>
    public double? TolMax { get; set; }

    /// <summary>
    /// lower tolerance
    /// </summary>
    public double? TolMin { get; set; }

    /// <summary>
    /// measured/calculated value
    /// </summary>
    public double? ValueInd0 { get; set; }

    /// <summary>
    /// measured/calculated value
    /// </summary>
    public double? ValueInd1 { get; set; }

    /// <summary>
    /// measured/calculated value
    /// </summary>
    public double? ValueInd2 { get; set; }

    /// <summary>
    /// measured/calculated value
    /// </summary>
    public double? ValueInd3 { get; set; }

    /// <summary>
    /// measured/calculated value
    /// </summary>
    public double? ValueInd4 { get; set; }

    /// <summary>
    /// measured/calculated value
    /// </summary>
    public double? ValueInd5 { get; set; }

    /// <summary>
    /// measured/calculated value
    /// </summary>
    public double? ValueInd6 { get; set; }

    /// <summary>
    /// measured/calculated value
    /// </summary>
    public double? ValueInd7 { get; set; }

    /// <summary>
    /// measured/calculated value
    /// </summary>
    public double? ValueInd8 { get; set; }

    /// <summary>
    /// measured/calculated value
    /// </summary>
    public double? ValueInd9 { get; set; }

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
