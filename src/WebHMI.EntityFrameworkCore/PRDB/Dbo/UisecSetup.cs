using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// general rules for security management
/// </summary>
public partial class UisecSetup
{
    /// <summary>
    /// application name (must be 
    /// </summary>
    public string ApplName { get; set; }

    /// <summary>
    /// (e.g. 
    /// </summary>
    public string GroupPrefix { get; set; }

    public string PasswordEncryption { get; set; }

    /// <summary>
    /// (stronger than normal rights)
    /// </summary>
    public bool? UseHostRights { get; set; }

    /// <summary>
    /// combination of user rights and host rights (stronger than user rights)
    /// </summary>
    public bool? UseSuperRights { get; set; }

    /// <summary>
    /// (stronger than host rights)
    /// </summary>
    public bool? UseUserRights { get; set; }

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
