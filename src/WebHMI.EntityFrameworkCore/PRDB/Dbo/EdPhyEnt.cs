using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class EdPhyEnt
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
    /// Unit[m] planned slab thickness
    /// </summary>
    public double? AimSlabThickness { get; set; }

    /// <summary>
    /// Unit[m] planned slab thickness head
    /// </summary>
    public double? AimSlabThicknessHead { get; set; }

    /// <summary>
    /// Unit[m] planned slab thickness tail
    /// </summary>
    public double? AimSlabThicknessTail { get; set; }

    /// <summary>
    /// (not used forArvedi) 1=caster 1, 2=caster2
    /// </summary>
    public short? CasterLine { get; set; }

    /// <summary>
    /// Caster slab flag (1= width tapered slab, 2 = thickness tapered flag, 3=both)
    /// </summary>
    public int? FlagCaster { get; set; }

    /// <summary>
    /// 1= coil is transition coil
    /// </summary>
    public int? FlagTransition { get; set; }

    /// <summary>
    /// Unit[m] Slab thickness - setpoint
    /// </summary>
    public double? HEntry { get; set; }

    /// <summary>
    /// Unit[m] Entry thickness FM
    /// </summary>
    public double? HEntryFm { get; set; }

    /// <summary>
    /// unique heat identificationn
    /// </summary>
    public string HeatId { get; set; }

    /// <summary>
    /// current heat name (planned name from L3, real name from SMP)
    /// </summary>
    public string HeatName { get; set; }

    /// <summary>
    /// position of heat in Sequence
    /// </summary>
    public int? HeatPosInSeq { get; set; }

    /// <summary>
    /// Entry length FM
    /// </summary>
    public double? LEntryFm { get; set; }

    /// <summary>
    /// position of coil in heat
    /// </summary>
    public int? MatPosInHeat { get; set; }

    /// <summary>
    /// Unit[m] maximum slab length (used as cutting limit)
    /// </summary>
    public double? MaxSlabLength { get; set; }

    /// <summary>
    /// maximum slab weight
    /// </summary>
    public double? MaxSlabWeight { get; set; }

    /// <summary>
    /// Unit[m] minimum slab length (used as cutting limit)
    /// </summary>
    public double? MinSlabLength { get; set; }

    /// <summary>
    /// minimum salb weight
    /// </summary>
    public double? MinSlabWeight { get; set; }

    /// <summary>
    /// Reason for okAll not ok: e.g. apsKey
    /// </summary>
    public string NOkAllReason { get; set; }

    /// <summary>
    /// identification, material data OK = 1
    /// </summary>
    public int? Ok { get; set; }

    /// <summary>
    /// identification, all material data OK = 1
    /// </summary>
    public int? OkAll { get; set; }

    /// <summary>
    /// operation flag from L3
    /// </summary>
    public int? OperationFlag { get; set; }

    /// <summary>
    /// 0 : coil 1: plate production
    /// </summary>
    public int? PlateProduction { get; set; }

    /// <summary>
    /// sequence identification
    /// </summary>
    public string SequenceId { get; set; }

    /// <summary>
    /// 0: real slab 1: PD for ghost rolling
    /// </summary>
    public int? SimMat { get; set; }

    /// <summary>
    /// Unit[m] Slab length calculated
    /// </summary>
    public double? SlabLength { get; set; }

    /// <summary>
    /// Unit[m] (not used for Arvedi) planned position where thickness change ends in the slab
    /// </summary>
    public double? SlabPosThickChangeEnd { get; set; }

    /// <summary>
    /// Unit[m] (not used for Arvedi) planned position where thickness change start in the slab
    /// </summary>
    public double? SlabPosThickChangeStart { get; set; }

    /// <summary>
    /// Unit[m] planned position where width change ends in the slab
    /// </summary>
    public double? SlabPosWidthChangeEnd { get; set; }

    /// <summary>
    /// Unit[m] planned position where width change starts in the slab
    /// </summary>
    public double? SlabPosWidthChangeStart { get; set; }

    /// <summary>
    /// Unit[kg] slab weight from caster
    /// </summary>
    public double? SlabWeight { get; set; }

    /// <summary>
    /// Unit[m] Slab width setpoint
    /// </summary>
    public double? SlabWidth { get; set; }

    /// <summary>
    /// Unit[m] planned width at the head
    /// </summary>
    public double? SlabWidthHead { get; set; }

    /// <summary>
    /// Unit[m] planned width at the tail
    /// </summary>
    public double? SlabWidthTail { get; set; }

    /// <summary>
    /// Unit[_C] Slab furnace entry temperature setpoint
    /// </summary>
    public double? TEntry { get; set; }

    /// <summary>
    /// Unit[_C] Transfer bar temperature set point
    /// </summary>
    public double? TEntryFm { get; set; }

    /// <summary>
    /// Type of transition: 0=grade, 1=thickness, 2=width
    /// </summary>
    public int? TransitionType { get; set; }

    /// <summary>
    /// Unit[kg/m3] specific weight of material
    /// </summary>
    public double? WeightSpecific { get; set; }

    /// <summary>
    /// Unit[m] delta width change
    /// </summary>
    public double? WidthChange { get; set; }

    /// <summary>
    /// width change over entire coil
    /// </summary>
    public int? WidthChangeFlag { get; set; }

    /// <summary>
    /// Unit[0, 1] 1 - width change telegram sent to Caster
    /// </summary>
    public short? WidthChangeSent { get; set; }

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
