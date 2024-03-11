using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class MipResult
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
    /// 1=data can be used for adaption, 0=data can not be used for adaption
    /// </summary>
    public string Adaptable { get; set; }

    /// <summary>
    /// Unit[s] adaption offset used for calculated runtime from head at controlpoint i
    /// </summary>
    public float? AdptRtHeadCpInd0 { get; set; }

    /// <summary>
    /// Unit[s] adaption offset used for calculated runtime from head at controlpoint i
    /// </summary>
    public float? AdptRtHeadCpInd1 { get; set; }

    /// <summary>
    /// Unit[s] adaption offset used for calculated runtime from head at controlpoint i
    /// </summary>
    public float? AdptRtHeadCpInd2 { get; set; }

    /// <summary>
    /// Unit[s] adaption offset used for calculated runtime from head at controlpoint i
    /// </summary>
    public float? AdptRtHeadCpInd3 { get; set; }

    /// <summary>
    /// Unit[s] adaption offset used for calculated runtime from head at controlpoint i
    /// </summary>
    public float? AdptRtHeadCpInd4 { get; set; }

    /// <summary>
    /// Unit[s] adaption offset used for calculated runtime
    /// </summary>
    public float? AdptRtHeadFurn { get; set; }

    /// <summary>
    /// Unit[s] adaption offset used for calculated runtime from head at controlpoint i
    /// </summary>
    public float? AdptRtTailCpInd0 { get; set; }

    /// <summary>
    /// Unit[s] adaption offset used for calculated runtime from head at controlpoint i
    /// </summary>
    public float? AdptRtTailCpInd1 { get; set; }

    /// <summary>
    /// Unit[s] adaption offset used for calculated runtime from head at controlpoint i
    /// </summary>
    public float? AdptRtTailCpInd2 { get; set; }

    /// <summary>
    /// Unit[s] adaption offset used for calculated runtime from head at controlpoint i
    /// </summary>
    public float? AdptRtTailCpInd3 { get; set; }

    /// <summary>
    /// Unit[s] adaption offset used for calculated runtime from head at controlpoint i
    /// </summary>
    public float? AdptRtTailCpInd4 { get; set; }

    public int? Bottleneck { get; set; }

    /// <summary>
    /// Unit[s] calculated runtime from head at controlpoint i
    /// </summary>
    public float? CalcRtHeadCpInd0 { get; set; }

    /// <summary>
    /// Unit[s] calculated runtime from head at controlpoint i
    /// </summary>
    public float? CalcRtHeadCpInd1 { get; set; }

    /// <summary>
    /// Unit[s] calculated runtime from head at controlpoint i
    /// </summary>
    public float? CalcRtHeadCpInd2 { get; set; }

    /// <summary>
    /// Unit[s] calculated runtime from head at controlpoint i
    /// </summary>
    public float? CalcRtHeadCpInd3 { get; set; }

    /// <summary>
    /// Unit[s] calculated runtime from head at controlpoint i
    /// </summary>
    public float? CalcRtHeadCpInd4 { get; set; }

    /// <summary>
    /// Unit[s] calculated runtime from furnace to first synchronisation point
    /// </summary>
    public float? CalcRtHeadFurn { get; set; }

    /// <summary>
    /// Unit[s] calculated runtime from tail at controlpoint i
    /// </summary>
    public float? CalcRtTailCpInd0 { get; set; }

    /// <summary>
    /// Unit[s] calculated runtime from tail at controlpoint i
    /// </summary>
    public float? CalcRtTailCpInd1 { get; set; }

    /// <summary>
    /// Unit[s] calculated runtime from tail at controlpoint i
    /// </summary>
    public float? CalcRtTailCpInd2 { get; set; }

    /// <summary>
    /// Unit[s] calculated runtime from tail at controlpoint i
    /// </summary>
    public float? CalcRtTailCpInd3 { get; set; }

    /// <summary>
    /// Unit[s] calculated runtime from tail at controlpoint i
    /// </summary>
    public float? CalcRtTailCpInd4 { get; set; }

    /// <summary>
    /// Unit[s] used distance time for controlpoint i
    /// </summary>
    public float? DistTimeCpInd0 { get; set; }

    /// <summary>
    /// Unit[s] used distance time for controlpoint i
    /// </summary>
    public float? DistTimeCpInd1 { get; set; }

    /// <summary>
    /// Unit[s] used distance time for controlpoint i
    /// </summary>
    public float? DistTimeCpInd2 { get; set; }

    /// <summary>
    /// Unit[s] used distance time for controlpoint i
    /// </summary>
    public float? DistTimeCpInd3 { get; set; }

    /// <summary>
    /// Unit[s] used distance time for controlpoint i
    /// </summary>
    public float? DistTimeCpInd4 { get; set; }

    /// <summary>
    /// Unit[s] used distance time offset for controlpoint i
    /// </summary>
    public float? DistTimeOffsetCpInd0 { get; set; }

    /// <summary>
    /// Unit[s] used distance time offset for controlpoint i
    /// </summary>
    public float? DistTimeOffsetCpInd1 { get; set; }

    /// <summary>
    /// Unit[s] used distance time offset for controlpoint i
    /// </summary>
    public float? DistTimeOffsetCpInd2 { get; set; }

    /// <summary>
    /// Unit[s] used distance time offset for controlpoint i
    /// </summary>
    public float? DistTimeOffsetCpInd3 { get; set; }

    /// <summary>
    /// Unit[s] used distance time offset for controlpoint i
    /// </summary>
    public float? DistTimeOffsetCpInd4 { get; set; }

    /// <summary>
    /// 1=disturbance (e.g. manual speed intervention) during production, 0=no disturbance
    /// </summary>
    public string Disturbance { get; set; }

    /// <summary>
    /// 1=manual strip mode, 0=automatic strip mode
    /// </summary>
    public string ManualStripMode { get; set; }

    /// <summary>
    /// Unit[s] measured runtime from head at controlpoint i
    /// </summary>
    public float? MeasRtHeadCpInd0 { get; set; }

    /// <summary>
    /// Unit[s] measured runtime from head at controlpoint i
    /// </summary>
    public float? MeasRtHeadCpInd1 { get; set; }

    /// <summary>
    /// Unit[s] measured runtime from head at controlpoint i
    /// </summary>
    public float? MeasRtHeadCpInd2 { get; set; }

    /// <summary>
    /// Unit[s] measured runtime from head at controlpoint i
    /// </summary>
    public float? MeasRtHeadCpInd3 { get; set; }

    /// <summary>
    /// Unit[s] measured runtime from head at controlpoint i
    /// </summary>
    public float? MeasRtHeadCpInd4 { get; set; }

    /// <summary>
    /// Unit[s] runtime from furnace to first synchronisation point
    /// </summary>
    public float? MeasRtHeadFurn { get; set; }

    /// <summary>
    /// Unit[s] measured runtime from tail at controlpoint i
    /// </summary>
    public float? MeasRtTailCpInd0 { get; set; }

    /// <summary>
    /// Unit[s] measured runtime from tail at controlpoint i
    /// </summary>
    public float? MeasRtTailCpInd1 { get; set; }

    /// <summary>
    /// Unit[s] measured runtime from tail at controlpoint i
    /// </summary>
    public float? MeasRtTailCpInd2 { get; set; }

    /// <summary>
    /// Unit[s] measured runtime from tail at controlpoint i
    /// </summary>
    public float? MeasRtTailCpInd3 { get; set; }

    /// <summary>
    /// Unit[s] measured runtime from tail at controlpoint i
    /// </summary>
    public float? MeasRtTailCpInd4 { get; set; }

    /// <summary>
    /// 1=oscillation during production, 0=no oscillation
    /// </summary>
    public string Oscillation { get; set; }

    /// <summary>
    /// starttime of strip (head at first synchronisation point)
    /// </summary>
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// Unit[ms] milliseconds to startTime
    /// </summary>
    public int? StartTimeMs { get; set; }

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
