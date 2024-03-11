using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CasSegInfoTranslate
{
    /// <summary>
    /// parameter description
    /// </summary>
    public string Value { get; set; }

    /// <summary>
    /// parameter name
    /// </summary>
    public string Param { get; set; }

    /// <summary>
    /// key of description
    /// </summary>
    public short ValueKey { get; set; }

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
