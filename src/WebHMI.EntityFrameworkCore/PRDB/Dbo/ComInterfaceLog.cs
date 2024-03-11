using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class ComInterfaceLog
{
    public int Lognb { get; set; }

    public string Logtext { get; set; }

    public DateTime? Logtime { get; set; }

    public int? Severity { get; set; }

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
