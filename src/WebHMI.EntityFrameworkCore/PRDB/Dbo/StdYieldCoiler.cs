using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StdYieldCoiler
{
    /// <summary>
    /// active flag (0=inactive, 1=active)
    /// </summary>
    public int ActiveFlag { get; set; }

    /// <summary>
    /// record number for the high temperature yield
    /// </summary>
    public int PlanNo { get; set; }

    /// <summary>
    /// Unit[deg C] temperature array value
    /// </summary>
    public float? TempInd0 { get; set; }

    /// <summary>
    /// Unit[deg C] temperature array value
    /// </summary>
    public float? TempInd1 { get; set; }

    /// <summary>
    /// Unit[deg C] temperature array value
    /// </summary>
    public float? TempInd2 { get; set; }

    /// <summary>
    /// Unit[deg C] temperature array value
    /// </summary>
    public float? TempInd3 { get; set; }

    /// <summary>
    /// Unit[deg C] temperature array value
    /// </summary>
    public float? TempInd4 { get; set; }

    /// <summary>
    /// Unit[N/m] 
    /// </summary>
    public float? YieldInd0 { get; set; }

    /// <summary>
    /// Unit[N/m] 
    /// </summary>
    public float? YieldInd1 { get; set; }

    /// <summary>
    /// Unit[N/m] 
    /// </summary>
    public float? YieldInd2 { get; set; }

    /// <summary>
    /// Unit[N/m] 
    /// </summary>
    public float? YieldInd3 { get; set; }

    /// <summary>
    /// Unit[N/m] 
    /// </summary>
    public float? YieldInd4 { get; set; }

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
