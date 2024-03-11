using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class L3casheatevent
{
    /// <summary>
    /// PK unique ID from INT_SEND
    /// </summary>
    public int Id { get; set; }

    public DateTime? Dtevent { get; set; }

    public string Eventcode { get; set; }

    public string Heatid { get; set; }

    public string Heatplanid { get; set; }

    public string Lineid { get; set; }

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
