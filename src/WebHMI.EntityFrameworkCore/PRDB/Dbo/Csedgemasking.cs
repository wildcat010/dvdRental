using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Material specific strategy Table with Effective (E), Manual (M) and original (X) lines for each material
/// </summary>
public partial class CsEdgeMasking
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

    public string Description { get; set; }

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
    /// manual intervention in plan
    /// </summary>
    public short? ManInt { get; set; }

    /// <summary>
    /// Unit[0...999] plan number
    /// </summary>
    public int? PlanNo { get; set; }

    /// <summary>
    /// External material ID
    /// </summary>
    public string ToExtId { get; set; }

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
