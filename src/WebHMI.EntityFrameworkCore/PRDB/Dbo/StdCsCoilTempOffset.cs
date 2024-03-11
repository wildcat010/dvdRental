using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StdCsCoilTempOffset
{
    /// <summary>
    /// active flag
    /// </summary>
    public int ActiveFlag { get; set; }

    /// <summary>
    /// Unit[] key for the compensation plan
    /// </summary>
    public int PlanNo { get; set; }

    public string Description { get; set; }

    /// <summary>
    /// Unit[m] reference strip length
    /// </summary>
    public int? SplineId { get; set; }

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
