using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class ProgParameter
{
    /// <summary>
    /// Unit[Unit] Comment
    /// </summary>
    public string Param { get; set; }

    /// <summary>
    /// Unit[Unit] Comment
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Unit[Unit] Comment
    /// </summary>
    public string ParamChar { get; set; }

    /// <summary>
    /// Unit[Unit] Comment
    /// </summary>
    public double? ParamNum { get; set; }

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
