using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class OperTime
{
    /// <summary>
    /// Material owner
    /// </summary>
    public string MeCreator { get; set; }

    /// <summary>
    /// Material idendification number
    /// </summary>
    public int MeId { get; set; }

    /// <summary>
    /// Line status
    /// </summary>
    public short MesId { get; set; }

    /// <summary>
    /// operation status  0= planed, 1= inline (entry), 2=production start, 3 = produced, 4finish prod., 5 = outline
    /// </summary>
    public short Status { get; set; }

    /// <summary>
    /// timestamp of status begin
    /// </summary>
    public DateTime DateTime { get; set; }

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

    public virtual Me1 Me1 { get; set; }
}
