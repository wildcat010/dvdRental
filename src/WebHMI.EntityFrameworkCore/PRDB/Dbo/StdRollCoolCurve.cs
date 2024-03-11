using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Standard roll cool curves
/// </summary>
public partial class StdRollCoolCurve
{
    /// <summary>
    /// active flag
    /// </summary>
    public int ActiveFlag { get; set; }

    /// <summary>
    /// number roll cool curve
    /// </summary>
    public int PlanNo { get; set; }

    /// <summary>
    /// curve for no rolling: curveCoef[10]
    /// </summary>
    public float? CurveCoefIdleInd0 { get; set; }

    /// <summary>
    /// curve for no rolling: curveCoef[10]
    /// </summary>
    public float? CurveCoefIdleInd1 { get; set; }

    /// <summary>
    /// curve for no rolling: curveCoef[10]
    /// </summary>
    public float? CurveCoefIdleInd2 { get; set; }

    /// <summary>
    /// curve for no rolling: curveCoef[10]
    /// </summary>
    public float? CurveCoefIdleInd3 { get; set; }

    /// <summary>
    /// curve for no rolling: curveCoef[10]
    /// </summary>
    public float? CurveCoefIdleInd4 { get; set; }

    /// <summary>
    /// curve for no rolling: curveCoef[10]
    /// </summary>
    public float? CurveCoefIdleInd5 { get; set; }

    /// <summary>
    /// curve for no rolling: curveCoef[10]
    /// </summary>
    public float? CurveCoefIdleInd6 { get; set; }

    /// <summary>
    /// curve for no rolling: curveCoef[10]
    /// </summary>
    public float? CurveCoefIdleInd7 { get; set; }

    /// <summary>
    /// curve for no rolling: curveCoef[10]
    /// </summary>
    public float? CurveCoefIdleInd8 { get; set; }

    /// <summary>
    /// curve for no rolling: curveCoef[10]
    /// </summary>
    public float? CurveCoefIdleInd9 { get; set; }

    /// <summary>
    /// curveCoef[10]
    /// </summary>
    public float? CurveCoefInd0 { get; set; }

    /// <summary>
    /// curveCoef[10]
    /// </summary>
    public float? CurveCoefInd1 { get; set; }

    /// <summary>
    /// curveCoef[10]
    /// </summary>
    public float? CurveCoefInd2 { get; set; }

    /// <summary>
    /// curveCoef[10]
    /// </summary>
    public float? CurveCoefInd3 { get; set; }

    /// <summary>
    /// curveCoef[10]
    /// </summary>
    public float? CurveCoefInd4 { get; set; }

    /// <summary>
    /// curveCoef[10]
    /// </summary>
    public float? CurveCoefInd5 { get; set; }

    /// <summary>
    /// curveCoef[10]
    /// </summary>
    public float? CurveCoefInd6 { get; set; }

    /// <summary>
    /// curveCoef[10]
    /// </summary>
    public float? CurveCoefInd7 { get; set; }

    /// <summary>
    /// curveCoef[10]
    /// </summary>
    public float? CurveCoefInd8 { get; set; }

    /// <summary>
    /// curveCoef[10]
    /// </summary>
    public float? CurveCoefInd9 { get; set; }

    /// <summary>
    /// description field
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Unit[%/m/s] delta speed to delta flow
    /// </summary>
    public float? DvDflow { get; set; }

    /// <summary>
    /// Unit[%] maximum cooling flow for whole stand
    /// </summary>
    public float? MaxFlow { get; set; }

    /// <summary>
    /// Unit[%] minimum cooling flow for whole stand
    /// </summary>
    public float? MinFlow { get; set; }

    /// <summary>
    /// Switch main cooling bar: exit bar = 0, entry bar = 1
    /// </summary>
    public short? SwitchCoolBar { get; set; }

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
