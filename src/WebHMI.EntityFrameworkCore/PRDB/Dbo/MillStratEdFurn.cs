using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class MillStratEdFurn
{
    /// <summary>
    /// plant type (HRM, HFM, SPM, TCM, ....)
    /// </summary>
    public string PlantType { get; set; }

    /// <summary>
    /// record number = furnace number
    /// </summary>
    public int RecordNo { get; set; }

    /// <summary>
    /// owner
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// Unit[_C] Cooling Section: Coil target temperature for body of strip
    /// </summary>
    public float? CoilTemp { get; set; }

    /// <summary>
    /// Cooling strategy: 1 early cooling, 2 = early separate cooling, 3 = later cooling, 4 = later separate cooling, 5 = no cooling
    /// </summary>
    public int? CoolStrategy { get; set; }

    /// <summary>
    /// Cooling Section: 0 = use directives from look up table deposited in the L2, 1 = use directives of the PDI
    /// </summary>
    public short? CoolingStrategyModeSelection { get; set; }

    /// <summary>
    /// Unit[m] Finished strip crown C40  || NC, Mos  ||
    /// </summary>
    public float? ExitCrownC40 { get; set; }

    /// <summary>
    /// Unit[m] Slab thickness   || NC, Mos  ||
    /// </summary>
    public float? HEntry { get; set; }

    /// <summary>
    /// Unit[m] Entry thickness FM transfer bar thickness setpoint
    /// </summary>
    public float? HEntryFm { get; set; }

    /// <summary>
    /// Unit[m] Finished strip thickness  || NC, Mos, MosCS  ||
    /// </summary>
    public float? HExit { get; set; }

    /// <summary>
    /// Unit[m] Slab length calculated
    /// </summary>
    public float? LEntry { get; set; }

    /// <summary>
    /// Unit[m] Cooling Section: Length of uncooled head
    /// </summary>
    public float? LengthUncooledHead { get; set; }

    /// <summary>
    /// Unit[m] Cooling Section: Length of uncooled tail
    /// </summary>
    public float? LengthUncooledTail { get; set; }

    /// <summary>
    /// Cooling Section: First valve to be switched lower side (laminar cooling section)
    /// </summary>
    public short? StartValveBot { get; set; }

    /// <summary>
    /// Cooling Section: First valve to be switched upper side (laminar cooling section)
    /// </summary>
    public float? StartValveTop { get; set; }

    /// <summary>
    /// Unit[_C] Slab furnace exit  temperature setpoint    || NC, Mos ||
    /// </summary>
    public float? TEntry { get; set; }

    /// <summary>
    /// Unit[_C] Transfer bar temperature set point
    /// </summary>
    public float? TEntryFm { get; set; }

    /// <summary>
    /// Unit[_C] Finished strip temperature  || NC, Mos, MosCS  ||
    /// </summary>
    public float? TExit { get; set; }

    /// <summary>
    /// Unit[IU] Finished strip target flatness
    /// </summary>
    public float? TargetFlatness { get; set; }

    /// <summary>
    /// Unit[m] Slab width || NC, Mos ||
    /// </summary>
    public float? WEntry { get; set; }

    /// <summary>
    /// Unit[m] transfer bar width (setpoint set)
    /// </summary>
    public float? WEntryFm { get; set; }

    /// <summary>
    /// Unit[m] Finished strip width   || NC, Mos ||
    /// </summary>
    public float? WExit { get; set; }

    /// <summary>
    /// Unit[kg] slab weight
    /// </summary>
    public float? WeightEntry { get; set; }

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
