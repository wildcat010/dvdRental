using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Tppass
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
    /// Unit[deg] looper angle
    /// </summary>
    public double? LooperAngle { get; set; }

    /// <summary>
    /// Unit[0 ...x] looper mode: 0=constant torque, 1=constant tension
    /// </summary>
    public int? LooperMode { get; set; }

    /// <summary>
    /// Unit[m] looper strip len
    /// </summary>
    public double? LooperStripLen { get; set; }

    /// <summary>
    /// Unit[0...999] t p number
    /// </summary>
    public int? PlanNo { get; set; }

    /// <summary>
    /// Unit[N/m2] specific forward tension
    /// </summary>
    public double? SpecifFoTension { get; set; }

    /// <summary>
    /// status specific forward tension
    /// </summary>
    public int? StatSpecifFoTension { get; set; }

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

    /// <summary>
    /// description field
    /// </summary>
    public string Description { get; set; }

    public virtual Me1 Me1 { get; set; }
}
