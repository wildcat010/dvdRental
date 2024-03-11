using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class L2l3coilWeight
{
    /// <summary>
    /// unique primay key
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// coil weight
    /// </summary>
    public float? CoilWeight { get; set; }

    /// <summary>
    /// coil ID
    /// </summary>
    public string ProductId { get; set; }

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
