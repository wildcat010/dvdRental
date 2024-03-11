using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// configuration of the users
/// </summary>
public partial class UisecUser
{
    /// <summary>
    /// name of user for logon
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// used if privileges only valid upto a certain date
    /// </summary>
    public DateTime? ExpiredDate { get; set; }

    /// <summary>
    /// name of user for display purpose
    /// </summary>
    public string FullName { get; set; }

    /// <summary>
    /// 0 = UISec_Right.denyPriv evaluated, 1 = UISec_Right.denyPriv ignored
    /// </summary>
    public bool? GrantPrivileges { get; set; }

    /// <summary>
    /// password of user for logon
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// note
    /// </summary>
    public string Remark { get; set; }

    /// <summary>
    /// (not used)
    /// </summary>
    public string StartInfo { get; set; }

    /// <summary>
    /// 0 = ignored, 1 = used
    /// </summary>
    public bool? Status { get; set; }

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

    public virtual ICollection<UisecUsersInUserGroup> UisecUsersInUserGroups { get; set; } = new List<UisecUsersInUserGroup>();
}
