using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class PapRcvTelegram
{
    /// <summary>
    /// Counter as additional key (1-9999)
    /// </summary>
    public short Counter { get; set; }

    /// <summary>
    /// date and time of sending (oracle standard YYYYMMDDHH24MISS)
    /// </summary>
    public DateTime SysTime { get; set; }

    /// <summary>
    /// transfer table name
    /// </summary>
    public string TableName { get; set; }

    /// <summary>
    /// for forced ordering of the received telegrams
    /// </summary>
    public float? ForceTel { get; set; }

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
