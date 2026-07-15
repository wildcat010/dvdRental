using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StdSrppass
{
    /// <summary>
    /// active flag
    /// </summary>
    public int ActiveFlag { get; set; }

    /// <summary>
    /// pass number
    /// </summary>
    public int PassNo { get; set; }

    /// <summary>
    /// Unit[0...999] shifting model plan number
    /// </summary>
    public int PlanNo { get; set; }

    /// <summary>
    /// description field
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// shifting speed value
    /// </summary>
    public double? Model { get; set; }

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
