using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// list of format definitions
/// </summary>
public partial class LogFormat
{
    /// <summary>
    /// id of log
    /// </summary>
    public short Id { get; set; }

    /// <summary>
    /// language (short name)
    /// </summary>
    public string Lang { get; set; }

    /// <summary>
    /// format specification of log
    /// </summary>
    public string Format { get; set; }

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
