using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Standard strategy Table for APS plan
/// </summary>
public partial class StdCsEdgeMasking
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
    /// description field 2
    /// </summary>
    public string Description2 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd00 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd01 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd02 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd03 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd04 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd05 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd06 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd07 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd08 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd09 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd10 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd11 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd12 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd13 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd14 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd15 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd16 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd17 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd18 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd19 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd20 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd21 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd22 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd23 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd24 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd25 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd26 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd27 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd28 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd29 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd30 { get; set; }

    /// <summary>
    /// Unit[mm] width setpoint for each edgeMaskingDevice as symmetric overlap with strip
    /// </summary>
    public short? EdgeMaskingWidthInd31 { get; set; }

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
