using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class RollingSequence
{
    /// <summary>
    /// Unit[]: index number prim key
    /// </summary>
    public short IndNr { get; set; }

    /// <summary>
    /// Unit[]:date and time of the rolling sequence
    /// </summary>
    public DateTime? RecordTime { get; set; }

    /// <summary>
    /// Unit[]:rolling sequence telegram
    /// </summary>
    public byte[] RollSeqTel { get; set; }

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
