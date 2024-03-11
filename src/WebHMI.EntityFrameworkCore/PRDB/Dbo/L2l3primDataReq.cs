using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class L2l3primDataReq
{
    /// <summary>
    /// unique communication ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Slab ID for which PDI are requested. If slab ID is empty (all blanks) L3 returns the PDI of the next 10 slabs to be rolled
    /// </summary>
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
