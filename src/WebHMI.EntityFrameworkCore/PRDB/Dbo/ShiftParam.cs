using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class ShiftParam
{
    /// <summary>
    /// shift number
    /// </summary>
    public short No { get; set; }

    /// <summary>
    /// level 3 code
    /// </summary>
    public string L3code { get; set; }

    /// <summary>
    /// 1 = actual shift   0 = others
    /// </summary>
    public short? Actual { get; set; }

    /// <summary>
    /// shift at short text
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Unit[s] duration of shift
    /// </summary>
    public int Duration { get; set; }

    /// <summary>
    /// next shift number
    /// </summary>
    public short NextNo { get; set; }

    /// <summary>
    /// Unit[s] shift offset (No of seconds since 00:00 actual day)
    /// </summary>
    public int Offset { get; set; }

    /// <summary>
    /// shift as long text
    /// </summary>
    public string Remark { get; set; }

    /// <summary>
    /// 0 = for actual day 1 = for next day
    /// </summary>
    public short? ShiftDayFlag { get; set; }

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
