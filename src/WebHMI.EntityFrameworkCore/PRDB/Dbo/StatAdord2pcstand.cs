using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StatAdOrd2PcStand
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
    /// absolute profile
    /// </summary>
    public short? AbsProfile { get; set; }

    /// <summary>
    /// bending force
    /// </summary>
    public short? Fb { get; set; }

    /// <summary>
    /// roll force
    /// </summary>
    public short? Fr { get; set; }

    /// <summary>
    /// rolling torque
    /// </summary>
    public short? Ms { get; set; }

    /// <summary>
    /// work roll shifting position
    /// </summary>
    public short? PositionWrs { get; set; }

    /// <summary>
    /// Rolling power
    /// </summary>
    public short? RPower { get; set; }

    /// <summary>
    /// relative profile
    /// </summary>
    public short? RelProfile { get; set; }

    /// <summary>
    /// screw down
    /// </summary>
    public short? Sd { get; set; }

    /// <summary>
    /// exit temperature
    /// </summary>
    public short? Texit { get; set; }

    /// <summary>
    /// circumferential speed
    /// </summary>
    public short? VCircum { get; set; }

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
