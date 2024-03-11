using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class L2l3millStatus
{
    /// <summary>
    /// unique communication ID
    /// </summary>
    public int Id { get; set; }

    public int? SlabStatus { get; set; }

    public DateTime? StatusTime { get; set; }

    public string L3SlabId { get; set; }

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
