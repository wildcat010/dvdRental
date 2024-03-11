using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class QemeasSeg
{
    /// <summary>
    /// Material owner
    /// </summary>
    public string MeCreator { get; set; }

    /// <summary>
    /// Material idendification number
    /// </summary>
    public int MeId { get; set; }

    /// <summary>
    /// measured value name like in ADH
    /// </summary>
    public string MeasValueName { get; set; }

    /// <summary>
    /// Line status
    /// </summary>
    public short MesId { get; set; }

    /// <summary>
    /// segment number
    /// </summary>
    public int SegNo { get; set; }

    /// <summary>
    /// Average of measured value
    /// </summary>
    public float? AvgValue { get; set; }

    /// <summary>
    /// elongation measured
    /// </summary>
    public float? ElongMeas { get; set; }

    /// <summary>
    /// elongation according to setpoints
    /// </summary>
    public float? ElongSp { get; set; }

    /// <summary>
    /// Maximum of measured value
    /// </summary>
    public float? MaxValue { get; set; }

    /// <summary>
    /// Minimum of measured value
    /// </summary>
    public float? MinValue { get; set; }

    /// <summary>
    /// Unit[m] position in sequence releated to position of MP
    /// </summary>
    public float? Position { get; set; }

    /// <summary>
    /// Sigma of measured value
    /// </summary>
    public float? SigmaValue { get; set; }

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
