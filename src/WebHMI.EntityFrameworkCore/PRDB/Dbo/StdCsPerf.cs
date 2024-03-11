using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Standard strategy Table for APS plan
/// </summary>
public partial class StdCsPerf
{
    /// <summary>
    /// active flag
    /// </summary>
    public int ActiveFlag { get; set; }

    /// <summary>
    /// key for the compensation plan
    /// </summary>
    public int PlanNo { get; set; }

    public string Description { get; set; }

    /// <summary>
    /// multiply any performator correction with this value
    /// </summary>
    public float? PerformatorControlRatio { get; set; }

    /// <summary>
    /// apply performator to first x meters of strip, -1 applies to whole strip
    /// </summary>
    public float? PerformatorDistanceToApply { get; set; }

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
    public float? PerformatorMaxLimit { get; set; }

    /// <summary>
    /// minimum allowed offset to CT target
    /// </summary>
    public float? PerformatorMinLimit { get; set; }

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
