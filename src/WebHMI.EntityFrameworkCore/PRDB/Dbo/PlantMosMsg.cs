using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class PlantMosMsg
{
    /// <summary>
    /// MOS error number (calcError%MAX_ERR_NO)
    /// </summary>
    public int ErrNo { get; set; }

    /// <summary>
    /// active flag
    /// </summary>
    public int? ActiveFlag { get; set; }

    /// <summary>
    /// error description (to support updates of the table; not displayed on HMI)
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// HMI message number (!= 0)
    /// </summary>
    public int? MsgNo { get; set; }

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
