using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class IntSend
{
    /// <summary>
    /// unique communication ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// time stamp when the receiver processed the message
    /// </summary>
    public DateTime? ConfirmTime { get; set; }

    /// <summary>
    /// message identification
    /// </summary>
    public int MsgId { get; set; }

    /// <summary>
    /// semicolon separated string of key values in the sequence as defined in INT_TABLE_SETUP.msg_table_key, NULL for messages witout any data tables
    /// </summary>
    public string MsgKey { get; set; }

    /// <summary>
    /// 0 ... lowest priority
    /// </summary>
    public short? Priority { get; set; }

    /// <summary>
    /// the field is maintained by the receiver and indicates how many attempts where made to process the message. the field is used to handle the read retry in case of receiver problems during processing the message.
    /// </summary>
    public short ReadCount { get; set; }

    /// <summary>
    /// time stamp when message was written
    /// </summary>
    public DateTime SendTime { get; set; }

    /// <summary>
    /// 0=not in simulation mode, 1=in simulation mode, the information is provided by the sender. the receiver decides how simulation data are handled(e.g. receive and drop)
    /// </summary>
    public short Simulation { get; set; }

    /// <summary>
    /// message confirmation status, 0=pending(new message), 1=processed with success, 2-n=processed with error
    /// </summary>
    public short Status { get; set; }

    /// <summary>
    /// status text in case of processing error, NULL=no error, not NULL=error description
    /// </summary>
    public string StatusText { get; set; }

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
