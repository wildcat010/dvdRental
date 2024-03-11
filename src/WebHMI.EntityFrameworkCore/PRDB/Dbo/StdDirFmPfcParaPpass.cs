using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Standard flatness plan pass
/// </summary>
public partial class StdDirFmPfcParaPpass
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
    /// plan number
    /// </summary>
    public int PlanNo { get; set; }

    /// <summary>
    /// description field
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// damping factor for dpc sensitivity
    /// </summary>
    public double? FacDfbDfr { get; set; }

    /// <summary>
    /// damping factor for flc sensitivity
    /// </summary>
    public double? FacDfbDiu { get; set; }

    /// <summary>
    /// Unit[N] lower limit bending force
    /// </summary>
    public double? FbLl { get; set; }

    /// <summary>
    /// Unit[N] upper limit bending force
    /// </summary>
    public double? FbUl { get; set; }

    /// <summary>
    /// observed flat
    /// </summary>
    public double? ObservedFlat { get; set; }

    /// <summary>
    /// Unit[deg] lower limit paircross
    /// </summary>
    public double? Paircrossll { get; set; }

    /// <summary>
    /// Unit[deg] upper limit paircross
    /// </summary>
    public double? Paircrossul { get; set; }

    /// <summary>
    /// plant type
    /// </summary>
    public string PlantType { get; set; }

    /// <summary>
    /// Unit[deg] lower limit of roll shift
    /// </summary>
    public double? SrLl { get; set; }

    /// <summary>
    /// Unit[deg] upper limit of roll shift
    /// </summary>
    public double? SrUl { get; set; }

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
