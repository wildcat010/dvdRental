using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class LogEmail
{
    public string Email { get; set; }

    public string ReqLogs { get; set; }

    public string Descr { get; set; }

    public short? MinSeverity { get; set; }

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
