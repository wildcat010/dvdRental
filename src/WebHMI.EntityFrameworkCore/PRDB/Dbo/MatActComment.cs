using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class MatActComment
{
    /// <summary>
    /// kind of action 1 = take out material, 2 = acknowledge material, 3 = lock material 4 = material break
    /// </summary>
    public int Action { get; set; }

    /// <summary>
    /// Material owner
    /// </summary>
    public string MeCreator { get; set; }

    /// <summary>
    /// Material idendification number
    /// </summary>
    public int MeId { get; set; }

    /// <summary>
    /// Line status
    /// </summary>
    public short MesId { get; set; }

    /// <summary>
    /// date and time of action
    /// </summary>
    public DateTime? DateTime { get; set; }

    /// <summary>
    /// additional information (manual input)
    /// </summary>
    public string InfoInd0 { get; set; }

    /// <summary>
    /// additional information (manual input)
    /// </summary>
    public string InfoInd1 { get; set; }

    /// <summary>
    /// additional information (manual input)
    /// </summary>
    public string InfoInd2 { get; set; }

    /// <summary>
    /// location of coil send from MTR
    /// </summary>
    public int? Location { get; set; }

    /// <summary>
    /// classification for locking (manual input)
    /// </summary>
    public string LockClass { get; set; }

    /// <summary>
    /// next line code (manual input)
    /// </summary>
    public string NextLineInd0 { get; set; }

    /// <summary>
    /// next line code (manual input)
    /// </summary>
    public string NextLineInd1 { get; set; }

    /// <summary>
    /// next line code (manual input)
    /// </summary>
    public string NextLineInd2 { get; set; }

    /// <summary>
    /// reason or comment to this action
    /// </summary>
    public string Reason { get; set; }

    /// <summary>
    /// reason code
    /// </summary>
    public string ReasonCode { get; set; }

    /// <summary>
    /// additional remarks for coil locking (manual input)
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

    public virtual Me1 Me1 { get; set; }
}
