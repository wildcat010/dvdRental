using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Material specific strategy Table with Effective (E), Manual (M) and original (X) lines for each material
/// </summary>
public partial class StatCsPerf
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
    /// Line status
    /// </summary>
    public short MesId { get; set; }

    public string Source { get; set; }

    public short? Description { get; set; }

    /// <summary>
    /// manual intervention in plan
    /// </summary>
    public short? ManInt { get; set; }

    /// <summary>
    /// multiply any performator correction with this value
    /// </summary>
    public short? PerformatorControlRatio { get; set; }

    /// <summary>
    /// apply performator to first x meters of strip, -1 applies to whole strip
    /// </summary>
    public short? PerformatorDistanceToApply { get; set; }

    /// <summary>
    /// 1: allow performator to apply spline on coil temperature target, 0: do not allow
    /// </summary>
    public short? PerformatorEnable { get; set; }

    /// <summary>
    /// 1: enable performator also if f4t cooling is applied, 0: do not enable
    /// </summary>
    public short? PerformatorEnableForF4tCooling { get; set; }

    /// <summary>
    /// spline number for using a fix performator spline
    /// </summary>
    public short? PerformatorManualNo { get; set; }

    /// <summary>
    /// maximum allowed offset to CT target
    /// </summary>
    public short? PerformatorMaxLimit { get; set; }

    /// <summary>
    /// minimum allowed offset to CT target
    /// </summary>
    public short? PerformatorMinLimit { get; set; }

    /// <summary>
    /// plan number
    /// </summary>
    public short? PlanNo { get; set; }

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
