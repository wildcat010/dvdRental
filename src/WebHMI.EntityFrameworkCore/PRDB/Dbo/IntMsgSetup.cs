using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class IntMsgSetup
{
    /// <summary>
    /// unique ID
    /// </summary>
    public int MsgId { get; set; }

    /// <summary>
    /// description of message
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// receiver
    /// </summary>
    public string Destination { get; set; }

    /// <summary>
    /// Unit[sec] duration how long a message shall be stored in database
    /// </summary>
    public int KeepHistory { get; set; }

    /// <summary>
    /// Unit[sec] duration how long a message remains useable. NULL means forever
    /// </summary>
    public int? LifeTime { get; set; }

    /// <summary>
    /// internal message name
    /// </summary>
    public string MsgName { get; set; }

    /// <summary>
    /// table name holding the master data for the message. NULL defines a message without any data.
    /// </summary>
    public string MsgTableName { get; set; }

    /// <summary>
    /// 0=no, 1=yes, defines that only the last instance of this message shall be read. the sender ignores this flag.
    /// </summary>
    public short SingleInstance { get; set; }

    /// <summary>
    /// sender
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// 0=no, 1=yes, the sender does not store messages flagged as not used. the receiver does not read messages flagged as not used.
    /// </summary>
    public short Used { get; set; }

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
