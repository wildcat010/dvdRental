using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class MillCasSpeedChange
{
    /// <summary>
    /// unique communication ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Unit[m/s] Aim acceleration, 0 make speed change as fast as possible, #0 try to change the speed with the given acceleration
    /// </summary>
    public float? Acceleration { get; set; }

    /// <summary>
    /// Unit[m] Cast Length when width change should start
    /// </summary>
    public float? CastLength { get; set; }

    /// <summary>
    /// Unit[m] new target speed from request telegram
    /// </summary>
    public float? NewSpeedTarget { get; set; }

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
