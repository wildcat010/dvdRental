using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// list of logs/alarms known by msg server
/// </summary>
public partial class LogIndex
{
    /// <summary>
    /// id of log
    /// </summary>
    public short Id { get; set; }

    /// <summary>
    /// number of days the log should be kept
    /// </summary>
    public short? DbKeep { get; set; }

    /// <summary>
    /// description of log
    /// </summary>
    public string Descr { get; set; }

    /// <summary>
    /// must alarm be confirmed (0: no, 1: yes)
    /// </summary>
    public bool? NeedConfirm { get; set; }

    /// <summary>
    /// severity of log
    /// </summary>
    public short? Severity { get; set; }

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
