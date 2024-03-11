using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// assign a colour to a configured log/alarm
/// </summary>
public partial class LogColour
{
    /// <summary>
    /// id of log
    /// </summary>
    public short Id { get; set; }

    /// <summary>
    /// name of colour
    /// </summary>
    public string Colour { get; set; }

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

    public virtual SetupColour ColourNavigation { get; set; }

    public virtual ICollection<LogIndex> LogIndices { get; set; } = new List<LogIndex>();

    public virtual ICollection<LogSeveritySetup> LogSeveritySetups { get; set; } = new List<LogSeveritySetup>();
}
