using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class IntTableSetup
{
    /// <summary>
    /// table name storing message data. all data tables must be specified here.
    /// </summary>
    public string MsgTableName { get; set; }

    /// <summary>
    /// description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// column names defining the unique key for the message data. the column names are specified as a semicolon separated string. NULL for messages without any data tables.
    /// </summary>
    public string MsgTableKey { get; set; }

    /// <summary>
    /// defines the parent table. only applicable for detail tables. for master tables the value is NULL.
    /// </summary>
    public string MsgTableParent { get; set; }

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
