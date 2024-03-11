using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class LocationActionDesc
{
    /// <summary>
    /// sequence action id
    /// </summary>
    public short ActId { get; set; }

    /// <summary>
    /// kind of action  1 = do calculation, 2 = do Action
    /// </summary>
    public short? Action { get; set; }

    /// <summary>
    /// action description text
    /// </summary>
    public string ActionDesc { get; set; }

    /// <summary>
    /// kind of action,  describes the kind of action 1 = enter the point  2 = exit the point
    /// </summary>
    public short? ActionStart { get; set; }

    /// <summary>
    /// addistioanl action information e.g doAction ID
    /// </summary>
    public short? AddActionInfo { get; set; }

    /// <summary>
    /// area id
    /// </summary>
    public short? Area { get; set; }

    /// <summary>
    /// location ID
    /// </summary>
    public short? LocationId { get; set; }

    /// <summary>
    /// Unit[m] position of the action
    /// </summary>
    public float? Position { get; set; }

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
