using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Information for the hmi offer the status off the mill
/// </summary>
public partial class HmiProcessArea
{
    /// <summary>
    /// Name of process area
    /// </summary>
    public string ProcessArea { get; set; }

    public short BitNo { get; set; }

    /// <summary>
    /// description of process area
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// status of process area 0= sending forbidden, 1=sending allowed
    /// </summary>
    public short Status { get; set; }

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
