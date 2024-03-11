using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class UserMessage
{
    /// <summary>
    /// RecordNumber
    /// </summary>
    public int No { get; set; }

    /// <summary>
    /// Timestamp of UserInput (UTC)
    /// </summary>
    public DateTime Time { get; set; }

    /// <summary>
    /// Name of  Application (Screenname)
    /// </summary>
    public string Application { get; set; }

    /// <summary>
    /// ClientName
    /// </summary>
    public string Client { get; set; }

    /// <summary>
    /// Command that has been executed (e.g. modified, commit)
    /// </summary>
    public string Command { get; set; }

    /// <summary>
    /// Name of Control (DualEditBox, CheckBox, ...)
    /// </summary>
    public string Control { get; set; }

    /// <summary>
    /// Name of the Database used by Application
    /// </summary>
    public string DatabaseName { get; set; }

    /// <summary>
    /// Name of the DatabaseField used by Control
    /// </summary>
    public string FieldName { get; set; }

    /// <summary>
    /// Key for DatabaseRecord (e.g. extId, rollId)
    /// </summary>
    public string KeyWord { get; set; }

    /// <summary>
    /// InputValue from Operator
    /// </summary>
    public string NewValue { get; set; }

    /// <summary>
    /// Old Value before input from Operator
    /// </summary>
    public string OldValue { get; set; }

    /// <summary>
    /// RowNumber from DatabaseTable
    /// </summary>
    public int? RowNo { get; set; }

    /// <summary>
    /// Name of the DatabaseTable used by Control
    /// </summary>
    public string TableName { get; set; }

    /// <summary>
    /// FieldLabel / MessageText (if e.g. LimitViolation)
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Unit from InputValue
    /// </summary>
    public string Unit { get; set; }

    /// <summary>
    /// Name of HMI Username
    /// </summary>
    public string UserName { get; set; }

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
