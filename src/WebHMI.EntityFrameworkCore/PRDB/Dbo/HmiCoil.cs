using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Information for hmi where a coil is
/// </summary>
public partial class HmiCoil
{
    /// <summary>
    /// Name of spceial Strip
    /// </summary>
    public string Param { get; set; }

    /// <summary>
    /// extid of spcial Strip
    /// </summary>
    public string Id { get; set; }

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
