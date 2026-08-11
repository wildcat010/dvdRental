using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StatEdPhyEnt
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
    /// planned slab thickness
    /// </summary>
    public short? AimSlabThickness { get; set; }

    /// <summary>
    /// planned slab thickness head
    /// </summary>
    public short? AimSlabThicknessHead { get; set; }

    /// <summary>
    /// planned slab thickness tail
    /// </summary>
    public short? AimSlabThicknessTail { get; set; }

    /// <summary>
    /// (not used forArvedi) 1=caster 1, 2=caster2
    /// </summary>
    public short? CasterLine { get; set; }

    /// <summary>
    /// Caster slab flag (1= width tapered slab, 2 = thickness tapered flag, 3=both)
    /// </summary>
    public short? FlagCaster { get; set; }

    /// <summary>
    /// 1= coil is transition coil
    /// </summary>
    public short? FlagTransition { get; set; }

    /// <summary>
    /// Slab thickness - setpoint
    /// </summary>
    public short? HEntry { get; set; }

    /// <summary>
    /// Entry thickness FM
    /// </summary>
    public short? HEntryFm { get; set; }

    /// <summary>
    /// unique heat identificationn
    /// </summary>
    public short? HeatId { get; set; }

    /// <summary>
    /// current heat name (planned name from L3, real name from SMP)
    /// </summary>
    public short? HeatName { get; set; }

    /// <summary>
    /// position of heat in Sequence
    /// </summary>
    public short? HeatPosInSeq { get; set; }

    /// <summary>
    /// Entry length FM
    /// </summary>
    public short? LEntryFm { get; set; }

    /// <summary>
    /// position of coil in heat
    /// </summary>
    public short? MatPosInHeat { get; set; }

    /// <summary>
    /// maximum slab length (used as cutting limit)
    /// </summary>
    public short? MaxSlabLength { get; set; }

    /// <summary>
    /// maximum slab weight
    /// </summary>
    public short? MaxSlabWeight { get; set; }

    /// <summary>
    /// minimum slab length (used as cutting limit)
    /// </summary>
    public short? MinSlabLength { get; set; }

    /// <summary>
    /// minimum salb weight
    /// </summary>
    public short? MinSlabWeight { get; set; }

    /// <summary>
    /// Reason for okAll not ok: e.g. apsKey
    /// </summary>
    public short? NOkAllReason { get; set; }

    /// <summary>
    /// identification, material data OK = 1
    /// </summary>
    public short? Ok { get; set; }

    /// <summary>
    /// identification, all material data OK = 1
    /// </summary>
    public short? OkAll { get; set; }

    /// <summary>
    /// operation flag from L3
    /// </summary>
    public short? OperationFlag { get; set; }

    /// <summary>
    /// 0 : coil 1: plate production
    /// </summary>
    public short? PlateProduction { get; set; }

    /// <summary>
    /// sequence identification
    /// </summary>
    public short? SequenceId { get; set; }

    /// <summary>
    /// 0: real slab 1: PD for ghost rolling
    /// </summary>
    public short? SimMat { get; set; }

    /// <summary>
    /// Slab length calculated
    /// </summary>
    public short? SlabLength { get; set; }

    /// <summary>
    /// (not used for Arvedi) planned position where thickness change ends in the slab
    /// </summary>
    public short? SlabPosThickChangeEnd { get; set; }

    /// <summary>
    /// (not used for Arvedi) planned position where thickness change start in the slab
    /// </summary>
    public short? SlabPosThickChangeStart { get; set; }

    /// <summary>
    /// planned position where width change ends in the slab
    /// </summary>
    public short? SlabPosWidthChangeEnd { get; set; }

    /// <summary>
    /// planned position where width change starts in the slab
    /// </summary>
    public short? SlabPosWidthChangeStart { get; set; }

    /// <summary>
    /// slab weight from caster
    /// </summary>
    public short? SlabWeight { get; set; }

    /// <summary>
    /// Slab width setpoint
    /// </summary>
    public short? SlabWidth { get; set; }

    /// <summary>
    /// planned width at the head
    /// </summary>
    public short? SlabWidthHead { get; set; }

    /// <summary>
    /// planned width at the tail
    /// </summary>
    public short? SlabWidthTail { get; set; }

    /// <summary>
    /// Slab furnace entry temperature setpoint
    /// </summary>
    public short? TEntry { get; set; }

    /// <summary>
    /// Transfer bar temperature set point
    /// </summary>
    public short? TEntryFm { get; set; }

    /// <summary>
    /// Type of transition: 0=grade, 1=thickness, 2=width
    /// </summary>
    public short? TransitionType { get; set; }

    /// <summary>
    /// specific weight of material
    /// </summary>
    public short? WeightSpecific { get; set; }

    /// <summary>
    /// delta width change
    /// </summary>
    public short? WidthChange { get; set; }

    /// <summary>
    /// width change over entire coil
    /// </summary>
    public short? WidthChangeFlag { get; set; }

    /// <summary>
    /// 1 - width change telegram sent to Caster
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
