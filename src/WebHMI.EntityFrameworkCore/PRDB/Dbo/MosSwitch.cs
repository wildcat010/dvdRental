using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// MOS debug and strategy switches
/// </summary>
public partial class MosSwitch
{
    /// <summary>
    /// plant type (HRM, HFM, ...)
    /// </summary>
    public string PlantType { get; set; }

    /// <summary>
    /// key to the only one MOS switches record: 0
    /// </summary>
    public int RecNo { get; set; }

    /// <summary>
    /// debug mod on/off pfc input file
    /// </summary>
    public int? DbgPfcIncnstr { get; set; }

    /// <summary>
    /// debug mod on/off pfc output file
    /// </summary>
    public int? DbgPfcOutcnstr { get; set; }

    /// <summary>
    /// write pfc result file
    /// </summary>
    public int? DbgPfcResult { get; set; }

    /// <summary>
    /// write psc debug file psc internel
    /// </summary>
    public int? DbgPscDebugFile { get; set; }

    /// <summary>
    /// write psc protokol output from calculation
    /// </summary>
    public int? DbgPscProt { get; set; }

    /// <summary>
    /// dummy debug switch
    /// </summary>
    public int? DbgSwitch1 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd0 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd1 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd10 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd11 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd12 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd13 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd14 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd15 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd16 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd17 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd18 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd19 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd2 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd3 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd4 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd5 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd6 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd7 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd8 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd9 { get; set; }

    /// <summary>
    /// dummy strategy switch
    /// </summary>
    public int? StrSwitch1 { get; set; }

    /// <summary>
    /// dummy strategy switch
    /// </summary>
    public int? StrSwitch2 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd0 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd1 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd10 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd11 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd12 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd13 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd14 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd15 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd16 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd17 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd18 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd19 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd2 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd20 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd21 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd22 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd23 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd24 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd25 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd26 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd27 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd28 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd29 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd3 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd30 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd31 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd32 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd33 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd34 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd35 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd36 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd37 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd38 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd39 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd4 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd5 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd6 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd7 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd8 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd9 { get; set; }

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
