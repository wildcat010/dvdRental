using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// assignment of hosts to host groups
/// </summary>
public partial class UisecHostInHostGroup
{
    /// <summary>
    /// host group (FK UISec_HostGroup)
    /// </summary>
    public string HostGroupName { get; set; }

    /// <summary>
    /// host name (FK UISec_Host)
    /// </summary>
    public string HostName { get; set; }

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

    public virtual UisecHost HostNameNavigation { get; set; }
}
