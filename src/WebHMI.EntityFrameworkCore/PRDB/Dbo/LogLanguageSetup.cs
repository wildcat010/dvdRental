using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// list of languages known by msg server
/// </summary>
public partial class LogLanguageSetup
{
    /// <summary>
    /// language (short name)
    /// </summary>
    public string Lang { get; set; }

    /// <summary>
    /// description of language
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

    public virtual ICollection<LogAreaSetup> LogAreaSetups { get; set; } = new List<LogAreaSetup>();

    public virtual ICollection<LogFormat> LogFormats { get; set; } = new List<LogFormat>();

    public virtual ICollection<LogSeveritySetup> LogSeveritySetups { get; set; } = new List<LogSeveritySetup>();
}
