using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class HmiMessage
{
    /// <summary>
    /// language
    /// </summary>
    public string Lang { get; set; }

    /// <summary>
    /// Number
    /// </summary>
    public int No { get; set; }

    /// <summary>
    /// Name of lfe/screen
    /// </summary>
    public string ScreenLfe { get; set; }

    /// <summary>
    /// message text
    /// </summary>
    public string Text { get; set; }

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
