using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class PlantRefsProcessArea
{
    /// <summary>
    /// process area
    /// </summary>
    public string ProcessArea { get; set; }

    /// <summary>
    /// record Id of PlantRefs
    /// </summary>
    public int RecId { get; set; }

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
