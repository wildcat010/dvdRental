using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CasMillPreRolling
{
    /// <summary>
    /// unique communication ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 1=prepare to roll
    /// </summary>
    public int? PrepareRolling { get; set; }

    /// <summary>
    /// sequence id of heat
    /// </summary>
    public string SequenceId { get; set; }

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
