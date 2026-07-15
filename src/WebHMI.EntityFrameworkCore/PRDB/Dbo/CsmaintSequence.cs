using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CsMaintSequence
{
    /// <summary>
    /// sequence identifier
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// maintenance identifier
    /// </summary>
    public int MId { get; set; }

    /// <summary>
    /// Number of total valves used
    /// </summary>
    public short? NoValves { get; set; }

    /// <summary>
    /// Sequence type: 1 - max flow,2 - valve characteristic,3 - total flow
    /// </summary>
    public short? SeqType { get; set; }

    /// <summary>
    /// Status of the sequence: 0 - in progress, 1 - successfully finished, 2 - failed finished,3 - cancelled by operator
    /// </summary>
    public short? Status { get; set; }

    /// <summary>
    /// Last used valve
    /// </summary>
    public short? ValveEnd { get; set; }

    /// <summary>
    /// Valve group: IC top, IC bottom, LC Top, LC bottom...
    /// </summary>
    public short? ValveGroup { get; set; }

    /// <summary>
    /// First used valve
    /// </summary>
    public short? ValveStart { get; set; }

    /// <summary>
    /// Valve type: 1 - switchable valve, 2 - continuous valve, 3 - drain valve
    /// </summary>
    public short? ValveType { get; set; }

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
