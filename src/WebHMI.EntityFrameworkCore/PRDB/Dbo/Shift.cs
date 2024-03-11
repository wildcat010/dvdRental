using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Shift
{
    /// <summary>
    /// production day and time
    /// </summary>
    public DateTime ProdDay { get; set; }

    /// <summary>
    /// shift number
    /// </summary>
    public short ShiftNo { get; set; }

    /// <summary>
    /// count rolled coils
    /// </summary>
    public int? CntRolledCoil { get; set; }

    /// <summary>
    /// weight coil
    /// </summary>
    public int? CoilWeight { get; set; }

    /// <summary>
    /// consumption description
    /// </summary>
    public string ConsumptionDesc { get; set; }

    /// <summary>
    /// consumption value
    /// </summary>
    public int? ConsumptionVal { get; set; }

    /// <summary>
    /// operating hour stage engine
    /// </summary>
    public int? OperatHourStageEngine { get; set; }

    /// <summary>
    /// operating time
    /// </summary>
    public int? OperatingTime { get; set; }

    /// <summary>
    /// performance factor shift
    /// </summary>
    public float? PerformFactorShift { get; set; }

    /// <summary>
    /// performance factor coil
    /// </summary>
    public float? PerformaFactorCoil { get; set; }

    /// <summary>
    /// plan classification coil
    /// </summary>
    public string PlanClassificCoil { get; set; }

    /// <summary>
    /// production target time
    /// </summary>
    public int? ProdTargetTime { get; set; }

    /// <summary>
    /// production time
    /// </summary>
    public int? ProdTime { get; set; }

    /// <summary>
    /// roll change time
    /// </summary>
    public int? RollChangeT { get; set; }

    /// <summary>
    /// Unit[km] rolled km
    /// </summary>
    public int? RolledKm { get; set; }

    /// <summary>
    /// sum coil weight
    /// </summary>
    public int? SumCoilWeight { get; set; }

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
