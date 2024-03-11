using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class IntCcmHeatReport
{
    /// <summary>
    /// (PK) Unique id (from INT_SEND)
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Unit[m/s] Average casting speed
    /// </summary>
    public float? AvgCastSpeed { get; set; }

    public int? BurnOpen { get; set; }

    /// <summary>
    /// Heat end in the mould
    /// </summary>
    public DateTime? CastEndTime { get; set; }

    /// <summary>
    /// Heat start in the mould
    /// </summary>
    public DateTime? CastStartTime { get; set; }

    /// <summary>
    /// Unit[mm] 
    /// </summary>
    public float? CastThick { get; set; }

    /// <summary>
    /// Unit[mm] 
    /// </summary>
    public float? CastWidth { get; set; }

    public string CoolPractice { get; set; }

    public string DynagapPractice { get; set; }

    /// <summary>
    /// Position of heat in casting sequence
    /// </summary>
    public int? HeatCounterCast { get; set; }

    /// <summary>
    /// Heat number
    /// </summary>
    public string HeatNumber { get; set; }

    /// <summary>
    /// Treatment number at aggregate
    /// </summary>
    public int? HeatTreatment { get; set; }

    public float? InsulationPowderAmount { get; set; }

    public float? InsulationPowderType { get; set; }

    /// <summary>
    /// Arrival (loading) time on turret
    /// </summary>
    public DateTime? LadleArriveTime { get; set; }

    /// <summary>
    /// Unit[kg] Ladle gross weight at arrival at turret (total weight)
    /// </summary>
    public int? LadleArriveWeight { get; set; }

    /// <summary>
    /// Final ladle close time
    /// </summary>
    public DateTime? LadleCloseTime { get; set; }

    /// <summary>
    /// Depart (unloading) on turret
    /// </summary>
    public DateTime? LadleDepartTime { get; set; }

    /// <summary>
    /// Unit[kg] Ladle gross weight departure from turret (total weight)
    /// </summary>
    public int? LadleDepartWeight { get; set; }

    public int? LadleNumber { get; set; }

    /// <summary>
    /// First ladle opened time
    /// </summary>
    public DateTime? LadleOpenTime { get; set; }

    public int? LadleTempArrival { get; set; }

    /// <summary>
    /// Unit[C] 
    /// </summary>
    public int? LiquidusTemp { get; set; }

    public int? MoldNumber { get; set; }

    /// <summary>
    /// Casting powder type
    /// </summary>
    public int? MoldPowderType { get; set; }

    /// <summary>
    /// Operator comment
    /// </summary>
    public string Note { get; set; }

    /// <summary>
    /// CCM Number
    /// </summary>
    public int? PlantNumber { get; set; }

    public int? RemainLadleNetWeight { get; set; }

    public int? RemainTundWeight { get; set; }

    /// <summary>
    /// Submerged entry nozzle type at start
    /// </summary>
    public int? SenType { get; set; }

    /// <summary>
    /// sequence identification (plan number)
    /// </summary>
    public string SequenceId { get; set; }

    public string ShiftForeman { get; set; }

    public string ShiftTeam { get; set; }

    /// <summary>
    /// Ladle shroud type at start
    /// </summary>
    public int? ShroudType { get; set; }

    public float? SlagPowderAmount { get; set; }

    public int? SlagPowderType { get; set; }

    public int? StarterPowderType { get; set; }

    public string SteelGrade { get; set; }

    /// <summary>
    /// Unit[C] 
    /// </summary>
    public int? SuperHeat { get; set; }

    public string TundishNr { get; set; }

    public int? TundishTemp { get; set; }

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
