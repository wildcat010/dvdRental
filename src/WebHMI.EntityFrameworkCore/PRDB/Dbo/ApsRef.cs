using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class ApsRef
{
    /// <summary>
    /// Unit[Unit] Comment
    /// </summary>
    public string KeyName { get; set; }

    /// <summary>
    /// Unit[Unit] Comment
    /// </summary>
    public string KeyType { get; set; }

    /// <summary>
    /// Unit[Unit] Comment
    /// </summary>
    public string ApsKey { get; set; }

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

    /// <summary>
    /// description field
    /// </summary>
    public string Description { get; set; }
}
