using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Friction values
/// </summary>
public partial class MyDatum
{
    /// <summary>
    /// lubrication type
    /// </summary>
    public int Lubrication { get; set; }

    /// <summary>
    /// plant type (HRM, HFM, ...)
    /// </summary>
    public string PlantType { get; set; }

    /// <summary>
    /// roll property class, intern usage for MOS (rollPropRef), related to rolldata
    /// </summary>
    public int RollPropertyClass { get; set; }

    /// <summary>
    /// stand number
    /// </summary>
    public int StandNo { get; set; }

    /// <summary>
    /// parameter values for mydata
    /// </summary>
    public double? ParamInd0 { get; set; }

    /// <summary>
    /// parameter values for mydata
    /// </summary>
    public double? ParamInd1 { get; set; }

    /// <summary>
    /// parameter values for mydata
    /// </summary>
    public double? ParamInd2 { get; set; }

    /// <summary>
    /// parameter values for mydata
    /// </summary>
    public double? ParamInd3 { get; set; }

    /// <summary>
    /// parameter values for mydata
    /// </summary>
    public double? ParamInd4 { get; set; }

    /// <summary>
    /// parameter values for mydata
    /// </summary>
    public double? ParamInd5 { get; set; }

    /// <summary>
    /// parameter values for mydata
    /// </summary>
    public double? ParamInd6 { get; set; }

    /// <summary>
    /// parameter values for mydata
    /// </summary>
    public double? ParamInd7 { get; set; }

    /// <summary>
    /// parameter values for mydata
    /// </summary>
    public double? ParamInd8 { get; set; }

    /// <summary>
    /// parameter values for mydata
    /// </summary>
    public double? ParamInd9 { get; set; }

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
