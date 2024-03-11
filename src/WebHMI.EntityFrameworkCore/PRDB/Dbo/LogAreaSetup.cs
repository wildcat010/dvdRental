using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// list of message areas known by msg server
/// </summary>
public partial class LogAreaSetup
{
    /// <summary>
    /// message area (short name)
    /// </summary>
    public string Area { get; set; }

    /// <summary>
    /// language (short name)
    /// </summary>
    public string Lang { get; set; }

    /// <summary>
    /// description of message area
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
}
