using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class PapSndTelegram
{
    /// <summary>
    /// counter as additonal key (1-9999)
    /// </summary>
    public short Counter { get; set; }

    /// <summary>
    /// for forced ordering of the received telegrams
    /// </summary>
    public float ForceTel { get; set; }

    /// <summary>
    /// date and time in Oracle format: YYYYMMDDHH24MMISS
    /// </summary>
    public DateTime SysTime { get; set; }

    /// <summary>
    /// transfer table name
    /// </summary>
    public string TableName { get; set; }

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
