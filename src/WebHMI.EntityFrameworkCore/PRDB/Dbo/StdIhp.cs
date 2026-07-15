using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StdIhp
{
    /// <summary>
    /// active flag
    /// </summary>
    public int ActiveFlag { get; set; }

    /// <summary>
    /// Unit[0...999] ih p number
    /// </summary>
    public int PlanNo { get; set; }

    /// <summary>
    /// description field
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Unit[m] target temperature to IH
    /// </summary>
    public double? Temperature { get; set; }

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
