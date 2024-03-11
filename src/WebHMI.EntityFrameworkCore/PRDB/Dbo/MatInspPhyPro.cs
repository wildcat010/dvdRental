using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class MatInspPhyPro
{
    /// <summary>
    /// error code (manual input)
    /// </summary>
    public string ErrorCode { get; set; }

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

    public string Source { get; set; }

    /// <summary>
    /// (manual input)
    /// </summary>
    public string AVbs { get; set; }

    /// <summary>
    /// 1 = flag  error occured (manual input)
    /// </summary>
    public string BErrFlag { get; set; }

    /// <summary>
    /// comment regarding the error (selected by error code)
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Unit[m] end of error (manual input)
    /// </summary>
    public float? EndErr { get; set; }

    /// <summary>
    /// 1 = flag  error occured (manual input)
    /// </summary>
    public string HErrFlag { get; set; }

    /// <summary>
    /// 1 = flag  error occured (manual input)
    /// </summary>
    public string LErrFlag { get; set; }

    /// <summary>
    /// (manual input)
    /// </summary>
    public string MS { get; set; }

    /// <summary>
    /// code for next production line(manual input)
    /// </summary>
    public float? NextProcCode { get; set; }

    /// <summary>
    /// (manual input)
    /// </summary>
    public string PR { get; set; }

    /// <summary>
    /// (manual input)
    /// </summary>
    public string Period { get; set; }

    /// <summary>
    /// additional comment for the next production line(manual input)
    /// </summary>
    public string ProcCom { get; set; }

    /// <summary>
    /// 1 = flag  error occured (manual input)
    /// </summary>
    public string SErrFlag { get; set; }

    /// <summary>
    /// Unit[m] beginn of error (manual input)
    /// </summary>
    public float? StartErr { get; set; }

    /// <summary>
    /// additional comment regarding this error (manual input)
    /// </summary>
    public string StripCom { get; set; }

    /// <summary>
    /// 1 = flag  error occured (manual input)
    /// </summary>
    public string TErrFlag { get; set; }

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
