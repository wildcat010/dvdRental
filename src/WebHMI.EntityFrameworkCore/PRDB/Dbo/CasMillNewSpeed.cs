using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CasMillNewSpeed
{
    /// <summary>
    /// unique communication ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Unit[m] maximum required position for the speed change: 0 - immediate speed change, &gt;0 - short term scheduled speed change
    /// </summary>
    public float? MaxPosition { get; set; }

    /// <summary>
    /// Unit[m/s] new target speed
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
