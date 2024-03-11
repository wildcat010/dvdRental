using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CsProtTick
{
    /// <summary>
    /// material ID
    /// </summary>
    public int MeId { get; set; }

    /// <summary>
    /// tick number
    /// </summary>
    public int Seg { get; set; }

    /// <summary>
    /// strip is in CS area
    /// </summary>
    public short? OccCs { get; set; }

    /// <summary>
    /// strip is in FM area
    /// </summary>
    public short? OccFm { get; set; }

    /// <summary>
    /// strip is in TBC area
    /// </summary>
    public short? OccTbc { get; set; }

    public int? BotVsetpCnt { get; set; }

    public int? BotVstatesCnt { get; set; }

    public float? CoefInd0 { get; set; }

    public float? CoefInd1 { get; set; }

    public float? CoefInd2 { get; set; }

    /// <summary>
    /// coil temperature SP
    /// </summary>
    public float? CoilTempSp { get; set; }

    /// <summary>
    /// adaptation temperature offset
    /// </summary>
    public float? DcTempOffsetInd0 { get; set; }

    /// <summary>
    /// adaptation temperature offset
    /// </summary>
    public float? DcTempOffsetInd1 { get; set; }

    /// <summary>
    /// adaptation temperature offset
    /// </summary>
    public float? DcTempOffsetInd2 { get; set; }

    /// <summary>
    /// adaptation temperature offset
    /// </summary>
    public float? DcTempOffsetInd3 { get; set; }

    public int? FmVsetpCnt { get; set; }

    public int? FmVstatesCnt { get; set; }

    /// <summary>
    /// Performator offset
    /// </summary>
    public float? PerformatorOffset { get; set; }

    /// <summary>
    /// ril possition
    /// </summary>
    public float? Ril { get; set; }

    public float? Slope { get; set; }

    public float? Speed { get; set; }

    public float? Speed5DiagDiff { get; set; }

    /// <summary>
    /// time difference
    /// </summary>
    public float? Tdiff { get; set; }

    /// <summary>
    /// Temperature after CS
    /// </summary>
    public float? TempCs { get; set; }

    public float? TempCsdiff { get; set; }

    /// <summary>
    /// Temperature after FM
    /// </summary>
    public float? TempFm { get; set; }

    /// <summary>
    /// Temperature after RM
    /// </summary>
    public float? TempRm { get; set; }

    /// <summary>
    /// Temperature after TBC
    /// </summary>
    public float? TempTbc { get; set; }

    public float? TemperatureDeviation { get; set; }

    public float? Thickness { get; set; }

    public int? TopVsetpCnt { get; set; }

    public int? TopVstatesCnt { get; set; }

    public float? TotalCalcWaterFlow { get; set; }

    public string ValveSetpBot { get; set; }

    public string ValveSetpFm { get; set; }

    public string ValveSetpTop { get; set; }

    public string ValveStateBot { get; set; }

    public string ValveStateFm { get; set; }

    public string ValveStateTop { get; set; }

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
