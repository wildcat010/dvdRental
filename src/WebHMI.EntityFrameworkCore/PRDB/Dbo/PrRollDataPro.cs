using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class PrRollDataPro
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
    /// roll ID
    /// </summary>
    public string RollId { get; set; }

    /// <summary>
    /// roll position (u=upper, l= lower)
    /// </summary>
    public string RollPos { get; set; }

    /// <summary>
    /// Unit[s] rolled time
    /// </summary>
    public float? RollTime { get; set; }

    /// <summary>
    /// Unit[kg] rolled tons
    /// </summary>
    public float? RollTons { get; set; }

    /// <summary>
    /// type of roll (BUR; IMR; WKR)
    /// </summary>
    public string RollType { get; set; }

    /// <summary>
    /// Unit[m] rolled length
    /// </summary>
    public float? RollenLength { get; set; }

    /// <summary>
    /// stand number
    /// </summary>
    public int? StandId { get; set; }

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
