using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class MillCasPlanDatum
{
    /// <summary>
    /// unique communication ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 0= new,1 = update,2 = delete
    /// </summary>
    public int? Action { get; set; }

    /// <summary>
    /// Planned heat number
    /// </summary>
    public string AimHeatId { get; set; }

    /// <summary>
    /// Unit[m] Thickness (caster exit thickness) of heat
    /// </summary>
    public float? AimThickness { get; set; }

    /// <summary>
    /// Unit[m] Start width (cold slab width) of heat
    /// </summary>
    public float? AimWidth { get; set; }

    /// <summary>
    /// heat plan id from L3
    /// </summary>
    public string HeatPlanId { get; set; }

    /// <summary>
    /// sequence identification (plan number)
    /// </summary>
    public string SequenceId { get; set; }

    /// <summary>
    /// order of heat within all planned sequences (lowest number will be producerd next)
    /// </summary>
    public float? SequenceOrder { get; set; }

    /// <summary>
    /// Steel grade
    /// </summary>
    public string SteelGrade { get; set; }

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
