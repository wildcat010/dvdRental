using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Defect
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
    /// sequence ID (record no.)
    /// </summary>
    public int Sid { get; set; }

    /// <summary>
    /// owner
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// action which should be carried out in the case of this defect (0=ignore, 1=low speed1, 2=low speed2, 3=stop)
    /// </summary>
    public int? Action { get; set; }

    /// <summary>
    /// defect class
    /// </summary>
    public short? DefClass { get; set; }

    /// <summary>
    /// creator of defect
    /// </summary>
    public string DefCreator { get; set; }

    /// <summary>
    /// Unit[m] defect end position
    /// </summary>
    public float? DefEnd { get; set; }

    /// <summary>
    /// Defect locked for further modifications
    /// </summary>
    public short? DefLock { get; set; }

    /// <summary>
    /// material side upper/lower
    /// </summary>
    public string DefSide { get; set; }

    /// <summary>
    /// Unit[m] defect start position
    /// </summary>
    public float? DefStart { get; set; }

    /// <summary>
    /// type of defect
    /// </summary>
    public string DefType { get; set; }

    /// <summary>
    /// defect discription
    /// </summary>
    public string DefectText { get; set; }

    /// <summary>
    /// defect intensity
    /// </summary>
    public string Intensity { get; set; }

    /// <summary>
    /// value of defect intensity
    /// </summary>
    public float? IntensityVal { get; set; }

    /// <summary>
    /// identification, if this defect results in a material locking   Y/N
    /// </summary>
    public string MatLock { get; set; }

    /// <summary>
    /// inspection track
    /// </summary>
    public int? Track { get; set; }

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
