using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// language specific texts for privileges
/// </summary>
public partial class UisecPrivilegeText
{
    /// <summary>
    /// language
    /// </summary>
    public string Lang { get; set; }

    /// <summary>
    /// name of privilege (FK UISec_Privilege)
    /// </summary>
    public string Privilege { get; set; }

    /// <summary>
    /// name of privilege in this language
    /// </summary>
    public string LongText { get; set; }

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

    public virtual UisecPrivilege PrivilegeNavigation { get; set; }
}
