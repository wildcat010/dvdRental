using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class MillOccupation
{
    /// <summary>
    /// record number
    /// </summary>
    public int RecNo { get; set; }

    /// <summary>
    /// external identification
    /// </summary>
    public string ExtId { get; set; }

    /// <summary>
    /// material identification
    /// </summary>
    public int? MeId { get; set; }

    /// <summary>
    /// head position according to MIP Telegramm
    /// </summary>
    public int? PositionHead { get; set; }

    /// <summary>
    /// name of the head position
    /// </summary>
    public string PositionNameHead { get; set; }

    /// <summary>
    /// name of the tail position
    /// </summary>
    public string PositionNameTail { get; set; }

    /// <summary>
    /// tail position according to MIP Telegramm
    /// </summary>
    public int? PositionTail { get; set; }

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
