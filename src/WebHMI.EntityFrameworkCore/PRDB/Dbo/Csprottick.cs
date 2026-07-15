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

    public double? CoefInd0 { get; set; }

    public double? CoefInd1 { get; set; }

    public double? CoefInd2 { get; set; }

    /// <summary>
    /// coil temperature SP
    /// </summary>
    public double? CoilTempSp { get; set; }

    /// <summary>
    /// adaptation temperature offset
    /// </summary>
    public double? DcTempOffsetInd0 { get; set; }

    /// <summary>
    /// adaptation temperature offset
    /// </summary>
    public double? DcTempOffsetInd1 { get; set; }

    /// <summary>
    /// adaptation temperature offset
    /// </summary>
    public double? DcTempOffsetInd2 { get; set; }

    /// <summary>
    /// adaptation temperature offset
    /// </summary>
    public double? DcTempOffsetInd3 { get; set; }

    public int? FmVsetpCnt { get; set; }

    public int? FmVstatesCnt { get; set; }

    /// <summary>
    /// Performator offset
    /// </summary>
    public double? PerformatorOffset { get; set; }

    /// <summary>
    /// ril possition
    /// </summary>
    public double? Ril { get; set; }

    public double? Slope { get; set; }

    public double? Speed { get; set; }

    public double? Speed5DiagDiff { get; set; }

    /// <summary>
    /// time difference
    /// </summary>
    public double? Tdiff { get; set; }

    /// <summary>
    /// Temperature after CS
    /// </summary>
    public double? TempCs { get; set; }

    public double? TempCsdiff { get; set; }

    /// <summary>
    /// Temperature after FM
    /// </summary>
    public double? TempFm { get; set; }

    /// <summary>
    /// Temperature after RM
    /// </summary>
    public double? TempRm { get; set; }

    /// <summary>
    /// Temperature after TBC
    /// </summary>
    public double? TempTbc { get; set; }

    public double? TemperatureDeviation { get; set; }

    public double? Thickness { get; set; }

    public int? TopVsetpCnt { get; set; }

    public int? TopVstatesCnt { get; set; }

    public double? TotalCalcWaterFlow { get; set; }

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
