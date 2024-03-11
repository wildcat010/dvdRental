using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// each log/alarm belongs to one or more log groups
/// </summary>
public partial class LogGroup
{
    /// <summary>
    /// id of log
    /// </summary>
    public short Id { get; set; }

    /// <summary>
    /// log group (short name)
    /// </summary>
    public string LogGroup1 { get; set; }

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

    public virtual LogIndex IdNavigation { get; set; }

    public virtual LogGroupSetup LogGroup1Navigation { get; set; }
}
