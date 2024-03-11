using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CsMaintSession
{
    /// <summary>
    /// maintenance identifier
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// status: 0 - session in progress,  - session finished,
    /// </summary>
    public short? Status { get; set; }

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
