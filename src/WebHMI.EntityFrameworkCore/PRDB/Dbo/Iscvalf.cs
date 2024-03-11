using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Stand related ISC valve type definitions CS writes, FM reads
/// </summary>
public partial class Iscvalf
{
    /// <summary>
    /// stand index to which the described valves belong
    /// </summary>
    public int StandIdx { get; set; }

    /// <summary>
    /// type index 0 - top entry 1 - top exit 2 - bottom entry 3 - bottom exit
    /// </summary>
    public int? ValveTypeInd0 { get; set; }

    /// <summary>
    /// type index 0 - top entry 1 - top exit 2 - bottom entry 3 - bottom exit
    /// </summary>
    public int? ValveTypeInd1 { get; set; }

    /// <summary>
    /// type index 0 - top entry 1 - top exit 2 - bottom entry 3 - bottom exit
    /// </summary>
    public int? ValveTypeInd2 { get; set; }

    /// <summary>
    /// type index 0 - top entry 1 - top exit 2 - bottom entry 3 - bottom exit
    /// </summary>
    public int? ValveTypeInd3 { get; set; }

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
