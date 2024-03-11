using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// definition of privileges
/// </summary>
public partial class UisecPrivilege
{
    /// <summary>
    /// name of privilege (attention: used in user interfaces =&gt; programs must be modified, too!)
    /// </summary>
    public string Privilege { get; set; }

    /// <summary>
    /// note
    /// </summary>
    public string Remark { get; set; }

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

    public virtual ICollection<UisecPrivilegeText> UisecPrivilegeTexts { get; set; } = new List<UisecPrivilegeText>();

    public virtual ICollection<UisecRight> UisecRights { get; set; } = new List<UisecRight>();
}
