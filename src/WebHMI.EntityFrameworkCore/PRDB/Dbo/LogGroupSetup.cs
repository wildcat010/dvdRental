using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// list of log/alarm groups known by msg server
/// </summary>
public partial class LogGroupSetup
{
    /// <summary>
    /// log group (short name)
    /// </summary>
    public string LogGroup { get; set; }

    /// <summary>
    /// description of log group
    /// </summary>
    public string Descr { get; set; }

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

    public virtual ICollection<LogGroup> LogGroups { get; set; } = new List<LogGroup>();
}
