using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Material related strategy value: flatness pass
/// </summary>
public partial class StatDirFmPfcParaPpass
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
    public short? Description { get; set; }

    /// <summary>
    /// damping factor for dpc sensitivity
    /// </summary>
    public short? FacDfbDfr { get; set; }

    /// <summary>
    /// damping factor for flc sensitivity
    /// </summary>
    public short? FacDfbDiu { get; set; }

    /// <summary>
    /// lower limit bending force
    /// </summary>
    public short? FbLl { get; set; }

    /// <summary>
    /// upper limit bending force
    /// </summary>
    public short? FbUl { get; set; }

    /// <summary>
    /// observed flat
    /// </summary>
    public short? ObservedFlat { get; set; }

    /// <summary>
    /// lower limit paircross
    /// </summary>
    public short? Paircrossll { get; set; }

    /// <summary>
    /// upper limit paircross
    /// </summary>
    public short? Paircrossul { get; set; }

    /// <summary>
    /// plan number
    /// </summary>
    public short? PlanNo { get; set; }

    /// <summary>
    /// plant type
    /// </summary>
    public short? PlantType { get; set; }

    /// <summary>
    /// lower limit of roll shift
    /// </summary>
    public short? SrLl { get; set; }

    /// <summary>
    /// upper limit of roll shift
    /// </summary>
    public short? SrUl { get; set; }

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
