using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class ThickMatId
{
    /// <summary>
    /// material alloy code
    /// </summary>
    public string AlloyCode { get; set; }

    /// <summary>
    /// matId for the thickness measuring device
    /// </summary>
    public short? MatId { get; set; }

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
