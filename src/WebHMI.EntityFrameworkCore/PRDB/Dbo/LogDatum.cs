using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// table which contains all logs/alarms stored by msg server
/// </summary>
public partial class LogDatum
{
    /// <summary>
    /// id of entry (id of individual event)
    /// </summary>
    public int EntryId { get; set; }

    /// <summary>
    /// language (short name)
    /// </summary>
    public string Lang { get; set; }

    /// <summary>
    /// timestamp of log
    /// </summary>
    public DateTime Clock { get; set; }

    /// <summary>
    /// timestamp of log confirmation
    /// </summary>
    public DateTime? ConfirmedAt { get; set; }

    /// <summary>
    /// name of client, who confirmed alarm
    /// </summary>
    public string ConfirmedBy { get; set; }

    /// <summary>
    /// id of log
    /// </summary>
    public short Id { get; set; }

    /// <summary>
    /// group of log/alarm
    /// </summary>
    public string LogGroup { get; set; }

    /// <summary>
    /// name of client, who logged alarm (LFE, hostname, CORBA servername)
    /// </summary>
    public string LogOrigin { get; set; }

    /// <summary>
    /// log text (i. e. formatted message)
    /// </summary>
    public string LogText { get; set; }

    /// <summary>
    /// timestamp of status end
    /// </summary>
    public DateTime? StatusEndAt { get; set; }

    /// <summary>
    /// additional user data: area
    /// </summary>
    public string UserData1 { get; set; }

    /// <summary>
    /// additional user data: materialID
    /// </summary>
    public string UserData2 { get; set; }

    /// <summary>
    /// additional user data: processValues
    /// </summary>
    public string UserData3 { get; set; }

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

    public virtual LogIndex IdNavigation { get; set; }
}
