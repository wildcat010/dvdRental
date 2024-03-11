using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Definitions of ISC header types
/// </summary>
public partial class IscvalveHeadType
{
    /// <summary>
    /// Header type index
    /// </summary>
    public int ValveHeadTypeIndex { get; set; }

    /// <summary>
    /// Unit[0 - top, 1 - bottom] top or bottom header
    /// </summary>
    public int? HeadSide { get; set; }

    /// <summary>
    /// Unit[m3/s or 0..1.0 - relative flow] maximum flow per header, if value is &lt;= 1.0 then it is treated as relative flow of the maxFlow of the whole valve (defined in the other table ISCValveTypes)
    /// </summary>
    public double? MaxFlow { get; set; }

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
