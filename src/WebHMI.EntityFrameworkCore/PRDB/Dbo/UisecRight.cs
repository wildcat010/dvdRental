using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// assignment of privileges to user and host groups
/// </summary>
public partial class UisecRight
{
    /// <summary>
    /// 0 = privilege added, 1 = privilege removed
    /// </summary>
    public bool DenyPriv { get; set; }

    /// <summary>
    /// aggregate name in user interface configuration
    /// </summary>
    public string Facility { get; set; }

    /// <summary>
    /// host group (FK UISec_HostGroup)
    /// </summary>
    public string HostGroupName { get; set; }

    /// <summary>
    /// privilege (FK UISec_Privilege)
    /// </summary>
    public string Privilege { get; set; }

    /// <summary>
    /// user group (FK UISec_UserGroup)
    /// </summary>
    public string UserGroupName { get; set; }

    /// <summary>
    /// must be greater than 0
    /// </summary>
    public int AccessLevel { get; set; }

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

    public virtual UisecHostGroup HostGroupNameNavigation { get; set; }

    public virtual UisecPrivilege PrivilegeNavigation { get; set; }

    public virtual UisecUserGroup UserGroupNameNavigation { get; set; }
}
