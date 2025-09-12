using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StdCsPerf
{
    public int ActiveFlag { get; set; }

    public int PlanNo { get; set; }

    public string Description { get; set; }

    public string Description2 { get; set; }

    public double? PerformatorControlRatio { get; set; }

    public double? PerformatorDistanceToApply { get; set; }

    public short? PerformatorEnable { get; set; }

    public short? PerformatorEnableForF4tCooling { get; set; }

    public short? PerformatorManualNo { get; set; }

    public double? PerformatorMaxLimit { get; set; }

    public double? PerformatorMinLimit { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
