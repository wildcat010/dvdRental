using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class MatExtId
{
    public int KeyT { get; set; }

    public int? ExtId { get; set; }

    public int? Counter { get; set; }

    public string HeatId { get; set; }

    public int? SimuExtId { get; set; }

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
