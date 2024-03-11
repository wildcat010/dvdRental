using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CsRolledStrip
{
    /// <summary>
    /// material identification
    /// </summary>
    public int MeId { get; set; }

    public double? AlloyContent { get; set; }

    public double? AnalysisAluminium { get; set; }

    public double? AnalysisAntimony { get; set; }

    public double? AnalysisArsenic { get; set; }

    public double? AnalysisBoron { get; set; }

    public double? AnalysisCalcium { get; set; }

    public double? AnalysisCarbon { get; set; }

    public double? AnalysisCerum { get; set; }

    public double? AnalysisChromium { get; set; }

    public double? AnalysisCobalt { get; set; }

    public double? AnalysisCopper { get; set; }

    public double? AnalysisLead { get; set; }

    public double? AnalysisManganese { get; set; }

    public double? AnalysisMolybdenum { get; set; }

    public double? AnalysisNickel { get; set; }

    public double? AnalysisNiobium { get; set; }

    public double? AnalysisNitrogen { get; set; }

    public double? AnalysisPhosphorus { get; set; }

    public double? AnalysisSilicon { get; set; }

    public double? AnalysisSulfur { get; set; }

    public double? AnalysisTin { get; set; }

    public double? AnalysisTitanium { get; set; }

    public double? AnalysisTungsten { get; set; }

    public double? AnalysisVanadium { get; set; }

    public double? AnalysisZirkonium { get; set; }

    public double? F4tSp { get; set; }

    public double? Mct1DcSeg1 { get; set; }

    public double? Mct2DcSeg1 { get; set; }

    public double? MfmtSeg1 { get; set; }

    public double? MfmtSeg2 { get; set; }

    public double? PrecCofaH { get; set; }

    public double? PrecCofaP { get; set; }

    public double? PrecCofaT { get; set; }

    public double? SpCoilerTemp { get; set; }

    public double? SpFinishingTemp { get; set; }

    public double? SpThickness { get; set; }

    public double? SpWidth { get; set; }

    public double? Sg0spd1Seg1 { get; set; }

    public double? Sg1spd1Seg2 { get; set; }

    public string AlloyCode { get; set; }

    public string AlloyName { get; set; }

    public double? CofaHSeg1 { get; set; }

    public double? CofaHSeg2 { get; set; }

    public double? CofaPSeg1 { get; set; }

    public double? CofaPSeg2 { get; set; }

    public double? CofaTSeg1 { get; set; }

    public double? CofaTSeg2 { get; set; }

    public double? F4tSeg1 { get; set; }

    public double? F4tSeg2 { get; set; }

    public double? F4tspSeg1 { get; set; }

    public double? F4tspSeg2 { get; set; }

    public short? InheritanceFlag { get; set; }

    public double? MctDcSeg2 { get; set; }

    public double? Measpd1Seg1 { get; set; }

    public double? Measpd1Seg2 { get; set; }

    public string ProductId { get; set; }

    public string RollSequenceNumber { get; set; }

    public double? RollingLength { get; set; }

    public double? S1Spd2Seg1 { get; set; }

    public double? S1Spd2Seg2 { get; set; }

    public double? S2Spd2Seg1 { get; set; }

    public double? S2Spd2Seg2 { get; set; }

    public string SlabPosNumber { get; set; }

    public double? TSpur1Seg1Ht { get; set; }

    public double? TSpur1Seg1Wet { get; set; }

    public double? TSpur1Seg2Ht { get; set; }

    public double? TSpur1Seg2Wet { get; set; }

    public double? TSpur2Seg1Ht { get; set; }

    public double? TSpur2Seg1Wet { get; set; }

    public double? TSpur2Seg2Ht { get; set; }

    public double? TSpur2Seg2Wet { get; set; }

    public double? TSpur3Seg1Ht { get; set; }

    public double? TSpur3Seg1Wet { get; set; }

    public double? TSpur3Seg2Ht { get; set; }

    public double? TSpur3Seg2Wet { get; set; }

    public double? TSpur4Seg1Ht { get; set; }

    public double? TSpur4Seg2Ht { get; set; }

    public double? TSpur5Seg1Ht { get; set; }

    public double? TSpur5Seg2Ht { get; set; }

    public double? TSpur6Seg1Ht { get; set; }

    public double? TSpur6Seg2Ht { get; set; }

    public double? TSpur7Seg1Ht { get; set; }

    public double? TSpur7Seg2Ht { get; set; }

    public double? TSpur8Seg1Ht { get; set; }

    public double? TSpur8Seg2Ht { get; set; }

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
