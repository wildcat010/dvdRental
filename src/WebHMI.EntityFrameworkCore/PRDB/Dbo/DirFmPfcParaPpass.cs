using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Material related strategy value: flatness pass
/// </summary>
public partial class DirFmPfcParaPpass
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
    /// plan number
    /// </summary>
    public int? PlanNo { get; set; }

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
