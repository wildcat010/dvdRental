using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class AdOrd2PcStand
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
    /// owner
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// stand number
    /// </summary>
    public short StandId { get; set; }

    /// <summary>
    /// thick head flag
    /// </summary>
    public short ThickHead { get; set; }

    /// <summary>
    /// Unit[m] absolute profile
    /// </summary>
    public double? AbsProfile { get; set; }

    /// <summary>
    /// Unit[N] bending force
    /// </summary>
    public double? Fb { get; set; }

    /// <summary>
    /// Unit[N] roll force
    /// </summary>
    public double? Fr { get; set; }

    /// <summary>
    /// Unit[Nm] rolling torque
    /// </summary>
    public double? Ms { get; set; }

    /// <summary>
    /// Unit[m] work roll shifting position
    /// </summary>
    public double? PositionWrs { get; set; }

    /// <summary>
    /// Unit[W] Rolling power
    /// </summary>
    public double? RPower { get; set; }

    /// <summary>
    /// Unit[%] relative profile
    /// </summary>
    public double? RelProfile { get; set; }

    /// <summary>
    /// Unit[m] screw down
    /// </summary>
    public double? Sd { get; set; }

    /// <summary>
    /// Unit[__C] exit temperature
    /// </summary>
    public double? Texit { get; set; }

    /// <summary>
    /// Unit[m/s] circumferential speed
    /// </summary>
    public double? VCircum { get; set; }

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
