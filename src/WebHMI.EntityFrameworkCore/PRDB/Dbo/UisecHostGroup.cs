using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// definition of host groups
/// </summary>
public partial class UisecHostGroup
{
    /// <summary>
    /// name of group (e.g. location)
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// name of group for display purpose
    /// </summary>
    public string FullName { get; set; }

    /// <summary>
    /// note
    /// </summary>
    public string Remark { get; set; }

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

    public virtual ICollection<UisecRight> UisecRights { get; set; } = new List<UisecRight>();
}
