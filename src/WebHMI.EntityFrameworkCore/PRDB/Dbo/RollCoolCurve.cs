using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class RollCoolCurve
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

    /// <summary>
    /// owner
    /// </summary>
    public string Source { get; set; }

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
    /// number roll cool curve
    /// </summary>
    public int? CurveNo { get; set; }

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

    public virtual Me1 Me1 { get; set; }
}
