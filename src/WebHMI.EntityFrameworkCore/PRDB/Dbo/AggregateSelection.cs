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
    public double? AlloyValueAlFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Al  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueAlTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil As  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueAsFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil As  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueAsTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil B  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueBfrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil B  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueBto { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil C  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueCfrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil C  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueCto { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Co  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueCoFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Co  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueCoTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Cr  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueCrFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Cr  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueCrTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Cu  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueCuFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Cu  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueCuTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Mg  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueMgFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Mg  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueMgTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Mn  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueMnFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Mn  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueMnTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Mo  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueMoFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Mo  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueMoTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil N  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueNfrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil N  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueNto { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Nb  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueNbFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Nb  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueNbTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Ni  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueNiFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Ni  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueNiTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil P  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValuePfrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil P  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValuePto { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Pb  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValuePbFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Pb  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValuePbTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil S  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueSfrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil S  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueSto { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Si  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueSiFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Si  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueSiTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Sn  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueSnFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Sn  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueSnTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Ti  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueTiFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Ti  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueTiTo { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil V  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueVfrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil V  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueVto { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Zn  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueZnFrom { get; set; }

    /// <summary>
    /// Unit[%] Analysenanteil Zn  || NC, Mos, MosCS  ||
    /// </summary>
    public double? AlloyValueZnTo { get; set; }

    /// <summary>
    /// Material
    /// </summary>
    public string ApsKey { get; set; }

    /// <summary>
    /// checker height from
    /// </summary>
    public double? CheckerHeightFrom { get; set; }

    /// <summary>
    /// checker height to
    /// </summary>
    public double? CheckerHeightTo { get; set; }

    /// <summary>
    /// Unit[m] Classif. max. strip crown delta from aim C40
    /// </summary>
    public double? ClassMaxCrownDeltaFrom { get; set; }

    /// <summary>
    /// Unit[m] Classif. max. strip crown delta from aim C40
    /// </summary>
    public double? ClassMaxCrownDeltaTo { get; set; }

    /// <summary>
    /// Unit[m] Classif. min. strip crown delta from aim C40
    /// </summary>
    public double? ClassMinCrownDeltaFrom { get; set; }

    /// <summary>
    /// Unit[m] Classif. min. strip crown delta from aim C40
    /// </summary>
    public double? ClassMinCrownDeltaTo { get; set; }

    /// <summary>
    /// Unit[_C] Cooling Section: Coil target temperature for body of strip
    /// </summary>
    public double? CoilTempFrom { get; set; }

    /// <summary>
    /// Unit[_C] Cooling Section: Coil target temperature for body of strip
    /// </summary>
    public double? CoilTempTo { get; set; }

    /// <summary>
    /// cooling section cooling plan number
    /// </summary>
    public short? CoolPlanNo { get; set; }

    /// <summary>
    /// Unit[m] wExit-wEntry
    /// </summary>
    public double? DeltaWidthFrom { get; set; }

    /// <summary>
    /// Unit[m] wExit-wEntry
    /// </summary>
    public double? DeltaWidthTo { get; set; }

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
    public double? HEntryFmfrom { get; set; }

    /// <summary>
    /// Unit[_C] Entry thickness finishing mill
    /// </summary>
    public double? HEntryFmto { get; set; }

    /// <summary>
    /// Unit[m] Slab thickness   || NC, Mos  ||
    /// </summary>
    public double? HEntryFrom { get; set; }

    /// <summary>
    /// Eintrittsdicke PreRoller
    /// </summary>
    public double? HEntryPreFrom { get; set; }

    /// <summary>
    /// Unit[m] Eintrittsdicke PreRoller
    /// </summary>
    public double? HEntryPreTo { get; set; }

    /// <summary>
    /// Unit[m] Slab thickness   || NC, Mos  ||
    /// </summary>
    public double? HEntryTo { get; set; }

    /// <summary>
    /// Unit[m] Finished strip thickness  || NC, Mos, MosCS  ||
    /// </summary>
    public double? HExitFrom { get; set; }

    /// <summary>
    /// Unit[m] Finished strip thickness  || NC, Mos, MosCS  ||
    /// </summary>
    public double? HExitTo { get; set; }

    /// <summary>
    /// Unit[m] Vorbrammenl_nge bei Keil
    /// </summary>
    public double? LEntryWedgeFrom { get; set; }

    /// <summary>
    /// Unit[m] Vorbrammenl_nge bei Keil
    /// </summary>
    public double? LEntryWedgeTo { get; set; }

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
    public double? SetpointsInd0 { get; set; }

    /// <summary>
    /// setpoints for 
    /// </summary>
    public double? SetpointsInd1 { get; set; }

    /// <summary>
    /// setpoints for 
    /// </summary>
    public double? SetpointsInd2 { get; set; }

    /// <summary>
    /// setpoints for 
    /// </summary>
    public double? SetpointsInd3 { get; set; }

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
    /// spare equal character 01
    /// </summary>
    public string SpareEqChar01 { get; set; }

    /// <summary>
    /// spare float 01 from
    /// </summary>
    public double? SpareFloat01From { get; set; }

    /// <summary>
    /// spare float 01 to
    /// </summary>
    public double? SpareFloat01To { get; set; }

    /// <summary>
    /// spare float 02 from
    /// </summary>
    public double? SpareFloat02From { get; set; }

    /// <summary>
    /// spare float 02 to
    /// </summary>
    public double? SpareFloat02To { get; set; }

    /// <summary>
    /// spare float 03 from
    /// </summary>
    public double? SpareFloat03From { get; set; }

    /// <summary>
    /// spare float 03 to
    /// </summary>
    public double? SpareFloat03To { get; set; }

    /// <summary>
    /// spare float 04 from
    /// </summary>
    public double? SpareFloat04From { get; set; }

    /// <summary>
    /// spare float 04 to
    /// </summary>
    public double? SpareFloat04To { get; set; }

    /// <summary>
    /// spare float 01 from
    /// </summary>
    public double? SpareFloat05From { get; set; }

    /// <summary>
    /// spare float 01 to
    /// </summary>
    public double? SpareFloat05To { get; set; }

    /// <summary>
    /// spare float 02 from
    /// </summary>
    public double? SpareFloat06From { get; set; }

    /// <summary>
    /// spare float 02 to
    /// </summary>
    public double? SpareFloat06To { get; set; }

    /// <summary>
    /// spare float 03 from
    /// </summary>
    public double? SpareFloat07From { get; set; }

    /// <summary>
    /// spare float 03 to
    /// </summary>
    public double? SpareFloat07To { get; set; }

    /// <summary>
    /// spare float 04 from
    /// </summary>
    public double? SpareFloat08From { get; set; }

    /// <summary>
    /// spare float 04 to
    /// </summary>
    public double? SpareFloat08To { get; set; }

    /// <summary>
    /// Unit[_C] Transfer bar temperature set point
    /// </summary>
    public double? TEntryFmfrom { get; set; }

    /// <summary>
    /// Unit[_C] Transfer bar temperature set point
    /// </summary>
    public double? TEntryFmto { get; set; }

    /// <summary>
    /// Unit[_C] Slab furnace exit  temperature setpoint    || NC, Mos ||
    /// </summary>
    public double? TEntryFrom { get; set; }

    /// <summary>
    /// Unit[_C] Slab furnace exit  temperature setpoint    || NC, Mos ||
    /// </summary>
    public double? TEntryTo { get; set; }

    /// <summary>
    /// Unit[_C] Finished strip temperature  || NC, Mos, MosCS  ||
    /// </summary>
    public double? TExitFrom { get; set; }

    /// <summary>
    /// Unit[_C] Finished strip temperature  || NC, Mos, MosCS  ||
    /// </summary>
    public double? TExitTo { get; set; }

    /// <summary>
    /// Unit[m] Slab width || NC, Mos ||
    /// </summary>
    public double? WEntryFrom { get; set; }

    /// <summary>
    /// Unit[m] Slab width || NC, Mos ||
    /// </summary>
    public double? WEntryTo { get; set; }

    /// <summary>
    /// Unit[m] Finished strip width   || NC, Mos ||
    /// </summary>
    public double? WExitFrom { get; set; }

    /// <summary>
    /// Unit[m] Finished strip width   || NC, Mos ||
    /// </summary>
    public double? WExitTo { get; set; }

    /// <summary>
    /// Unit[kg] slab weight
    /// </summary>
    public double? WeightEntryFrom { get; set; }

    /// <summary>
    /// Unit[kg] slab weight
    /// </summary>
    public double? WeightEntryTo { get; set; }

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
