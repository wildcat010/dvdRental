using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CsValveChar
{
    /// <summary>
    /// Valve amplitude step
    /// </summary>
    public short Step { get; set; }

    /// <summary>
    /// Valve group
    /// </summary>
    public short ValveGroup { get; set; }

    /// <summary>
    /// Valve number
    /// </summary>
    public short ValveNo { get; set; }

    /// <summary>
    /// Valve amplitude
    /// </summary>
    public short? AmplDes { get; set; }

    /// <summary>
    /// used flow (currently stored in process memory)
    /// </summary>
    public float? FlowUsed { get; set; }

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
