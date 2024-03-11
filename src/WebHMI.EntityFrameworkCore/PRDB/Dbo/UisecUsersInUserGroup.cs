using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// assignment of users to use
/// </summary>
public partial class UisecUsersInUserGroup
{
    /// <summary>
    /// user group (FK UISec_UserGroup)
    /// </summary>
    public string UserGroupName { get; set; }

    /// <summary>
    /// user name (FK UISec_User)
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

    public virtual UisecUserGroup UserGroupNameNavigation { get; set; }

    public virtual UisecUser UserNameNavigation { get; set; }
}
