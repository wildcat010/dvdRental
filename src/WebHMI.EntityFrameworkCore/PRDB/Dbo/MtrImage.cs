using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class MtrImage
{
    /// <summary>
    /// material tracking section identifikation (defined by MTR)
    /// </summary>
    public short Section { get; set; }

    /// <summary>
    /// material image
    /// </summary>
    public byte[] Image { get; set; }

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
