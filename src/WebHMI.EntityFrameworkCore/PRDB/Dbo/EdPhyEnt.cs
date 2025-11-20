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
    public float? AimSlabThickness { get; set; }

    /// <summary>
    /// Unit[m] planned slab thickness head
    /// </summary>
    public float? AimSlabThicknessHead { get; set; }

    /// <summary>
    /// Unit[m] planned slab thickness tail
    /// </summary>
    public float? AimSlabThicknessTail { get; set; }

    /// <summary>
    /// bend mode flag from mos
    /// </summary>
    public int? BendModeFlag { get; set; }

    /// <summary>
    /// (not used forArvedi) 1=caster 1, 2=caster2
    /// </summary>
    public short? CasterLine { get; set; }

    /// <summary>
    /// Unit[m] length of coil
    /// </summary>
    public float? CoilLength { get; set; }

    /// <summary>
    /// Caster slab flag (1= width tapered slab, 2 = thickness tapered flag, 3=both)
    /// </summary>
    public int? FlagCaster { get; set; }

    /// <summary>
    /// (not used for Arvedi) Flag 1=mixed slab
    /// </summary>
    public int? FlagMixed { get; set; }

    /// <summary>
    /// (Arvedi not available)  Furnace Number
    /// </summary>
    public int? FurnaceNo { get; set; }

    /// <summary>
    /// Unit[m] Slab thickness - setpoint
    /// </summary>
    public float? HEntry { get; set; }

    /// <summary>
    /// Unit[m] Entry thickness FM
    /// </summary>
    public float? HEntryFm { get; set; }

    /// <summary>
    /// Only for HMI: status entry thickness FM
    /// </summary>
    public int? HEntryFmstat { get; set; }

    /// <summary>
    /// exit thickness ordered by customer
    /// </summary>
    public float? HExitCustomer { get; set; }

    /// <summary>
    /// heat identification
    /// </summary>
    public string HeatId { get; set; }

    /// <summary>
    /// Entry length FM
    /// </summary>
    public float? LEntryFm { get; set; }

    /// <summary>
    /// Unit[m] maximum slab length (used as cutting limit)
    /// </summary>
    public float? MaxSlabLength { get; set; }

    /// <summary>
    /// maximum slab weight
    /// </summary>
    public float? MaxSlabWeight { get; set; }

    /// <summary>
    /// Unit[m] minimum slab length (used as cutting limit)
    /// </summary>
    public float? MinSlabLength { get; set; }

    /// <summary>
    /// minimum salb weight
    /// </summary>
    public float? MinSlabWeight { get; set; }

    /// <summary>
    /// identification, material data OK = 1
    /// </summary>
    public int? Ok { get; set; }

    /// <summary>
    /// identification, all material data OK = 1
    /// </summary>
    public int? OkAll { get; set; }

    /// <summary>
    /// plan identification
    /// </summary>
    public string PlanId { get; set; }

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
    public float? SlabLength { get; set; }

    /// <summary>
    /// Unit[m] (not used for Arvedi) planned position where thickness change ends in the slab
    /// </summary>
    public float? SlabPosThickChangeEnd { get; set; }

    /// <summary>
    /// Unit[m] (not used for Arvedi) planned position where thickness change start in the slab
    /// </summary>
    public float? SlabPosThickChangeStart { get; set; }

    /// <summary>
    /// Unit[m] planned position where width change ends in the slab
    /// </summary>
    public float? SlabPosWidthChangeEnd { get; set; }

    /// <summary>
    /// Unit[m] planned position where width change starts in the slab
    /// </summary>
    public float? SlabPosWidthChangeStart { get; set; }

    /// <summary>
    /// Unit[kg] slab weight from caster
    /// </summary>
    public float? SlabWeight { get; set; }

    /// <summary>
    /// Unit[m] Slab width setpoint
    /// </summary>
    public float? SlabWidth { get; set; }

    /// <summary>
    /// Unit[m] planned width at the head
    /// </summary>
    public float? SlabWidthHead { get; set; }

    /// <summary>
    /// Unit[m] planned width at the tail
    /// </summary>
    public float? SlabWidthTail { get; set; }

    /// <summary>
    /// customer steel grade
    /// </summary>
    public string SteelCustomer { get; set; }

    /// <summary>
    /// Unit[_C] Slab furnace entry temperature setpoint
    /// </summary>
    public float? TEntry { get; set; }

    /// <summary>
    /// Unit[_C] Transfer bar temperature set point
    /// </summary>
    public float? TEntryFm { get; set; }

    /// <summary>
    /// Unit[kg/m3] specific weight of material
    /// </summary>
    public float? WeightSpecific { get; set; }

    /// <summary>
    /// Unit[m] delta width change
    /// </summary>
    public float? WidthChange { get; set; }

    /// <summary>
    /// width change over entire coil
    /// </summary>
    public int? WidthChangeFlag { get; set; }

    /// <summary>
    /// Unit[m] width exit orderd by customer
    /// </summary>
    public float? WidthExitCustomer { get; set; }

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

    /// <summary>
    /// Unit[0, 1] 1 - width change telegram sent to Caster
    /// </summary>
    public short? WidthChangeSent { get; set; }

    /// <summary>
    /// heat plan identification from L3
    /// </summary>
    public string HeatPlanId { get; set; }

    /// <summary>
    /// heat identification assigned by L3
    /// </summary>
    public string HeatIdL3 { get; set; }

    /// <summary>
    /// operation flag from L3
    /// </summary>
    public int? OperationFlag { get; set; }

    /// <summary>
    /// Sequence identifier from L3
    /// </summary>
    public int? HeatPos { get; set; }

    /// <summary>
    /// Row order identifier from L3
    /// </summary>
    public int? MatPos { get; set; }

    public virtual Me1 Me1 { get; set; }
}
