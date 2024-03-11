using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StdSrp
{
    /// <summary>
    /// active flag
    /// </summary>
    public int ActiveFlag { get; set; }

    /// <summary>
    /// Unit[0...999] shifting model plan number
    /// </summary>
    public int PlanNo { get; set; }

    /// <summary>
    /// Unit[m] dummy for mosDm
    /// </summary>
    public float? Dummy { get; set; }

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
