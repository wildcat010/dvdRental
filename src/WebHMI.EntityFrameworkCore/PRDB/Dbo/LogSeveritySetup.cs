using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class LogSeveritySetup
{
    /// <summary>
    /// language (short name)
    /// </summary>
    public string Lang { get; set; }

    /// <summary>
    /// severity (message type)
    /// </summary>
    public short Severity { get; set; }

    /// <summary>
    /// description of severity
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

    public virtual LogLanguageSetup LangNavigation { get; set; }

    public virtual LogColour SeverityNavigation { get; set; }
}
