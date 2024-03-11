using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class AggregateSelection
{
    /// <summary>
    /// is current value active? (0=no, 1=yes)
    /// </summary>
    public int Active { get; set; }

    /// <summary>
    /// key for aggregate selection table
    /// </summary>
    public string Aggregate { get; set; }

    /// <summary>
    /// unique record id
    /// </summary>
    public int RecId { get; set; }

    /// <summary>
    /// Der Text f_r die Stahlmarkennummer (z.B. 05AL)
    /// </summary>
    public string AlloyCode { get; set; }

    /// <summary>
    /// Alloy group code
    /// </summary>
    public string AlloyGroup { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Al  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueAlFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Al  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueAlTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil As  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueAsFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil As  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueAsTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil B  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueBfrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil B  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueBto { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil C  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueCfrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil C  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueCto { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Co  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueCoFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Co  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueCoTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Cr  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueCrFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Cr  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueCrTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Cu  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueCuFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Cu  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueCuTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Mg  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueMgFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Mg  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueMgTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Mn  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueMnFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Mn  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueMnTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Mo  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueMoFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Mo  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueMoTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil N  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueNfrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil N  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueNto { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Nb  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueNbFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Nb  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueNbTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Ni  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueNiFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Ni  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueNiTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil P  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValuePfrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil P  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValuePto { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Pb  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValuePbFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Pb  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValuePbTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil S  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueSfrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil S  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueSto { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Si  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueSiFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Si  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueSiTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Sn  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueSnFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Sn  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueSnTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Ti  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueTiFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Ti  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueTiTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil V  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueVfrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil V  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueVto { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Zn  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueZnFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Zn  || NC, Mos, MosCS  ||
    /// </summary>
    public float? AlloyValueZnTo { get; set; }

    /// <summary>
    /// Material
    /// </summary>
    public string ApsKey { get; set; }

    /// <summary>
    /// checker height from
    /// </summary>
    public float? CheckerHeightFrom { get; set; }

    /// <summary>
    /// checker height to
    /// </summary>
    public float? CheckerHeightTo { get; set; }

    /// <summary>
    /// Unit[m] Classif. max. strip crown delta from aim C40
    /// </summary>
    public float? ClassMaxCrownDeltaFrom { get; set; }

    /// <summary>
    /// Unit[m] Classif. max. strip crown delta from aim C40
    /// </summary>
    public float? ClassMaxCrownDeltaTo { get; set; }

    /// <summary>
    /// Unit[m] Classif. min. strip crown delta from aim C40
    /// </summary>
    public float? ClassMinCrownDeltaFrom { get; set; }

    /// <summary>
    /// Unit[m] Classif. min. strip crown delta from aim C40
    /// </summary>
    public float? ClassMinCrownDeltaTo { get; set; }

    /// <summary>
    /// Unit[_C] Cooling Section: Coil target temperature for body of strip
    /// </summary>
    public float? CoilTempFrom { get; set; }

    /// <summary>
    /// Unit[_C] Sollvorgabe K_hlstrecke: Profiltemperatur Kopf
    /// </summary>
    public float? CoilTempProfileHeadFrom { get; set; }

    /// <summary>
    /// Unit[_C] Sollvorgabe K_hlstrecke: Profiltemperatur Kopf
    /// </summary>
    public float? CoilTempProfileHeadTo { get; set; }

    /// <summary>
    /// Unit[_C] Sollvorgabe K_hlstrecke: Profiltemperatur Fu_
    /// </summary>
    public float? CoilTempProfileTailFrom { get; set; }

    /// <summary>
    /// Unit[_C] Sollvorgabe K_hlstrecke: Profiltemperatur Fu_
    /// </summary>
    public float? CoilTempProfileTailTo { get; set; }

    /// <summary>
    /// Unit[_C] Cooling Section: Coil target temperature for body of strip
    /// </summary>
    public float? CoilTempTo { get; set; }

    /// <summary>
    /// Unit[%] K_hlrate unten: 25%, 50%, 75%, 100%
    /// </summary>
    public float? CoolRateBotFrom { get; set; }

    /// <summary>
    /// Unit[%] K_hlrate unten: 25%, 50%, 75%, 100%
    /// </summary>
    public float? CoolRateBotTo { get; set; }

    /// <summary>
    /// Unit[%] K_hlrate oben: 25%, 50%, 75%, 100%
    /// </summary>
    public float? CoolRateTopFrom { get; set; }

    /// <summary>
    /// Unit[%] K_hlrate oben: 25%, 50%, 75%, 100%
    /// </summary>
    public float? CoolRateTopTo { get; set; }

    /// <summary>
    /// Unit[m] wExit-wEntry
    /// </summary>
    public float? DeltaWidthFrom { get; set; }

    /// <summary>
    /// Unit[m] wExit-wEntry
    /// </summary>
    public float? DeltaWidthTo { get; set; }

    /// <summary>
    /// name of dependence this record belongs to
    /// </summary>
    public string Dependence { get; set; }

    /// <summary>
    /// description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Bramme ehemals Ofenr_ckf_hrung, Kennzeichnung f_r Preroller
    /// </summary>
    public int? FurnaceNoFrom { get; set; }

    /// <summary>
    /// Bramme ehemals Ofenr_ckf_hrung, Kennzeichnung f_r Preroller
    /// </summary>
    public int? FurnaceNoTo { get; set; }

    /// <summary>
    /// Unit[_C] Entry thickness finishing mill
    /// </summary>
    public float? HEntryFmfrom { get; set; }

    /// <summary>
    /// Unit[_C] Entry thickness finishing mill
    /// </summary>
    public float? HEntryFmto { get; set; }

    /// <summary>
    /// Unit[m] Slab thickness   || NC, Mos  ||
    /// </summary>
    public float? HEntryFrom { get; set; }

    /// <summary>
    /// Eintrittsdicke PreRoller
    /// </summary>
    public float? HEntryPreFrom { get; set; }

    /// <summary>
    /// Unit[m] Eintrittsdicke PreRoller
    /// </summary>
    public float? HEntryPreTo { get; set; }

    /// <summary>
    /// Unit[m] Slab thickness   || NC, Mos  ||
    /// </summary>
    public float? HEntryTo { get; set; }

    /// <summary>
    /// Unit[m] Finished strip thickness  || NC, Mos, MosCS  ||
    /// </summary>
    public float? HExitFrom { get; set; }

    /// <summary>
    /// Unit[m] Finished strip thickness  || NC, Mos, MosCS  ||
    /// </summary>
    public float? HExitTo { get; set; }

    /// <summary>
    /// Unit[m] Vorbrammenl_nge bei Keil
    /// </summary>
    public float? LEntryWedgeFrom { get; set; }

    /// <summary>
    /// Unit[m] Vorbrammenl_nge bei Keil
    /// </summary>
    public float? LEntryWedgeTo { get; set; }

    /// <summary>
    /// Unit[m] Sollvorgabe K_hlstrecke: Profill_nge Kopf
    /// </summary>
    public float? LengthProfileHeadFrom { get; set; }

    /// <summary>
    /// Unit[m] Sollvorgabe K_hlstrecke: Profill_nge Kopf
    /// </summary>
    public float? LengthProfileHeadTo { get; set; }

    /// <summary>
    /// Unit[m] Sollvorgabe K_hlstrecke: Profill_nge Fu_
    /// </summary>
    public float? LengthProfileTailFrom { get; set; }

    /// <summary>
    /// Unit[m] Sollvorgabe K_hlstrecke: Profill_nge Fu_
    /// </summary>
    public float? LengthProfileTailTo { get; set; }

    /// <summary>
    /// mode for MSM: 0=optimize to Rm 1=optimize to Re
    /// </summary>
    public short? MsmMode { get; set; }

    /// <summary>
    /// activation for MSM optimizer: off=0, on=1
    /// </summary>
    public string MsmSwitch { get; set; }

    /// <summary>
    /// Unit[_C] HT Stellbereich Obergrenze
    /// </summary>
    public float? MsmTempTolMaxFrom { get; set; }

    /// <summary>
    /// Unit[_C] HT Stellbereich Obergrenze
    /// </summary>
    public float? MsmTempTolMaxTo { get; set; }

    /// <summary>
    /// Unit[_C] HT Stellbereich Untergrenze
    /// </summary>
    public float? MsmTempTolMinFrom { get; set; }

    /// <summary>
    /// Unit[_C] HT Stellbereich Untergrenze
    /// </summary>
    public float? MsmTempTolMinTo { get; set; }

    /// <summary>
    /// auto control level plan number
    /// </summary>
    public int? PlanNoInd0 { get; set; }

    /// <summary>
    /// auto control level plan number
    /// </summary>
    public int? PlanNoInd1 { get; set; }

    /// <summary>
    /// auto control level plan number
    /// </summary>
    public int? PlanNoInd2 { get; set; }

    /// <summary>
    /// auto control level plan number
    /// </summary>
    public int? PlanNoInd3 { get; set; }

    /// <summary>
    /// setpoints for 
    /// </summary>
    public float? SetpointsInd0 { get; set; }

    /// <summary>
    /// setpoints for 
    /// </summary>
    public float? SetpointsInd1 { get; set; }

    /// <summary>
    /// setpoints for 
    /// </summary>
    public float? SetpointsInd2 { get; set; }

    /// <summary>
    /// setpoints for 
    /// </summary>
    public float? SetpointsInd3 { get; set; }

    /// <summary>
    /// Unit[m] Brammenlaengengruppe; 1: 4100 to 5700, 2: 6600 to 8350, 3: 8350 to 9999, 4: 10000 to 11500
    /// </summary>
    public int? SlabLengthGroupFrom { get; set; }

    /// <summary>
    /// Unit[m] Brammenlaengengruppe; 1: 4100 to 5700, 2: 6600 to 8350, 3: 8350 to 9999, 4: 10000 to 11500
    /// </summary>
    public int? SlabLengthGroupTo { get; set; }

    /// <summary>
    /// sorting of records
    /// </summary>
    public int SortId { get; set; }

    /// <summary>
    /// Unit[_C] Transfer bar temperature set point
    /// </summary>
    public float? TEntryFmfrom { get; set; }

    /// <summary>
    /// Unit[_C] Transfer bar temperature set point
    /// </summary>
    public float? TEntryFmto { get; set; }

    /// <summary>
    /// Unit[_C] Slab furnace exit  temperature setpoint    || NC, Mos ||
    /// </summary>
    public float? TEntryFrom { get; set; }

    /// <summary>
    /// Unit[_C] Slab furnace exit  temperature setpoint    || NC, Mos ||
    /// </summary>
    public float? TEntryTo { get; set; }

    /// <summary>
    /// Unit[_C] Finished strip temperature  || NC, Mos, MosCS  ||
    /// </summary>
    public float? TExitFrom { get; set; }

    /// <summary>
    /// Unit[_C] Finished strip temperature  || NC, Mos, MosCS  ||
    /// </summary>
    public float? TExitTo { get; set; }

    /// <summary>
    /// Unit[m] Slab width || NC, Mos ||
    /// </summary>
    public float? WEntryFrom { get; set; }

    /// <summary>
    /// Unit[m] Slab width || NC, Mos ||
    /// </summary>
    public float? WEntryTo { get; set; }

    /// <summary>
    /// Unit[m] Finished strip width   || NC, Mos ||
    /// </summary>
    public float? WExitFrom { get; set; }

    /// <summary>
    /// Unit[m] Finished strip width   || NC, Mos ||
    /// </summary>
    public float? WExitTo { get; set; }

    /// <summary>
    /// Unit[kg] slab weight
    /// </summary>
    public float? WeightEntryFrom { get; set; }

    /// <summary>
    /// Unit[kg] slab weight
    /// </summary>
    public float? WeightEntryTo { get; set; }

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
