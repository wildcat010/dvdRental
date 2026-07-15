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
    public int? DbgSwitchFInd00 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd01 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd02 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd03 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd04 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd05 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd06 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd07 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd08 { get; set; }

    /// <summary>
    /// debug switches for future use
    /// </summary>
    public int? DbgSwitchFInd09 { get; set; }

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
    /// FM: 1 = prio is profile  0 = prio is flatness
    /// </summary>
    public int? StrFirstPrioProfile { get; set; }

    /// <summary>
    /// wear optimized shifting on/off for each stand
    /// </summary>
    public int? StrPfcWearShiftAllowedInd0 { get; set; }

    /// <summary>
    /// wear optimized shifting on/off for each stand
    /// </summary>
    public int? StrPfcWearShiftAllowedInd1 { get; set; }

    /// <summary>
    /// wear optimized shifting on/off for each stand
    /// </summary>
    public int? StrPfcWearShiftAllowedInd2 { get; set; }

    /// <summary>
    /// wear optimized shifting on/off for each stand
    /// </summary>
    public int? StrPfcWearShiftAllowedInd3 { get; set; }

    /// <summary>
    /// wear optimized shifting on/off for each stand
    /// </summary>
    public int? StrPfcWearShiftAllowedInd4 { get; set; }

    /// <summary>
    /// wear optimized shifting on/off for each stand
    /// </summary>
    public int? StrPfcWearShiftAllowedInd5 { get; set; }

    /// <summary>
    /// wear optimized shifting on/off for each stand
    /// </summary>
    public int? StrPfcWearShiftAllowedInd6 { get; set; }

    /// <summary>
    /// wear optimized shifting on/off for each stand
    /// </summary>
    public int? StrPfcWearShiftAllowedInd7 { get; set; }

    /// <summary>
    /// wear optimized shifting on/off for each stand
    /// </summary>
    public int? StrPfcWearShiftAllowedInd8 { get; set; }

    /// <summary>
    /// automatic roll cooling on/off for each stand
    /// </summary>
    public int? StrRccAllowedInd0 { get; set; }

    /// <summary>
    /// automatic roll cooling on/off for each stand
    /// </summary>
    public int? StrRccAllowedInd1 { get; set; }

    /// <summary>
    /// automatic roll cooling on/off for each stand
    /// </summary>
    public int? StrRccAllowedInd2 { get; set; }

    /// <summary>
    /// automatic roll cooling on/off for each stand
    /// </summary>
    public int? StrRccAllowedInd3 { get; set; }

    /// <summary>
    /// automatic roll cooling on/off for each stand
    /// </summary>
    public int? StrRccAllowedInd4 { get; set; }

    /// <summary>
    /// automatic roll cooling on/off for each stand
    /// </summary>
    public int? StrRccAllowedInd5 { get; set; }

    /// <summary>
    /// automatic roll cooling on/off for each stand
    /// </summary>
    public int? StrRccAllowedInd6 { get; set; }

    /// <summary>
    /// automatic roll cooling on/off for each stand
    /// </summary>
    public int? StrRccAllowedInd7 { get; set; }

    /// <summary>
    /// automatic roll cooling on/off for each stand
    /// </summary>
    public int? StrRccAllowedInd8 { get; set; }

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
    public int? StrSwitchesInd00 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd01 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd02 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd03 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd04 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd05 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd06 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd07 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd08 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd09 { get; set; }

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
    public int? StrSwitchesInd40 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd41 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd42 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd43 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd44 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd45 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd46 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd47 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd48 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd49 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd50 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd51 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd52 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd53 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd54 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd55 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd56 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd57 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd58 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd59 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd60 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd61 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd62 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd63 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd64 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd65 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd66 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd67 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd68 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd69 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd70 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd71 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd72 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd73 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd74 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd75 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd76 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd77 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd78 { get; set; }

    /// <summary>
    /// strategy switches for future use
    /// </summary>
    public int? StrSwitchesInd79 { get; set; }

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
