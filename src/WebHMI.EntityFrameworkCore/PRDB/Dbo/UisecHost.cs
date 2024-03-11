using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// configuration of the hosts
/// </summary>
public partial class UisecHost
{
    /// <summary>
    /// name of host (in capital letters!)
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// used if privileges only valid upto a certain date
    /// </summary>
    public DateTime? ExpiredDate { get; set; }

    /// <summary>
    /// name of host for display purpose
    /// </summary>
    public string FullName { get; set; }

    /// <summary>
    /// 0 = UISec_Right.denyPriv evaluated, 1 = UISec_Right.denyPriv ignored
    /// </summary>
    public bool? GrantPrivileges { get; set; }

    /// <summary>
    /// location of host (for detailed explanation)
    /// </summary>
    public string Location { get; set; }

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

    public virtual ICollection<UisecHostInHostGroup> UisecHostInHostGroups { get; set; } = new List<UisecHostInHostGroup>();
}
