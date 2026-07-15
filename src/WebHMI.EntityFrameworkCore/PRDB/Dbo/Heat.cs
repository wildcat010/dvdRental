using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Heat
{
    /// <summary>
    /// unique heat identification from telegram CASMILLNEWHEAT
    /// </summary>
    public string HeatId { get; set; }

    /// <summary>
    /// 1 - heat start  0 - heat end
    /// </summary>
    public int HeatStart { get; set; }

    /// <summary>
    /// Unit[m] planed length from caster when heat starts
    /// </summary>
    public double? AimLengthCaster { get; set; }

    /// <summary>
    /// planned length of the heat
    /// </summary>
    public double? AimLengthL3 { get; set; }

    /// <summary>
    /// Unit[m] end position of heat in cast
    /// </summary>
    public double? EndMixedArea { get; set; }

    /// <summary>
    /// traetment no
    /// </summary>
    public short? HeatTreatmentNo { get; set; }

    /// <summary>
    /// Unit[Kg] heat weight when heat is finished cast
    /// </summary>
    public double? HeatWeight { get; set; }

    /// <summary>
    /// Unit[m] measured length from caster when heat ends
    /// </summary>
    public double? MeasLength { get; set; }

    /// <summary>
    /// number of slabs in this heat
    /// </summary>
    public int? NrOfSlabs { get; set; }

    /// <summary>
    /// record time
    /// </summary>
    public DateTime? RecTime { get; set; }

    /// <summary>
    /// sequence identification (planl number)
    /// </summary>
    public string SequenceId { get; set; }

    /// <summary>
    /// Unit[m/min] speed planned for heat
    /// </summary>
    public double? SpeedCas { get; set; }

    /// <summary>
    /// Unit[m] start of mixed alloy area position in the sequence (cast length)
    /// </summary>
    public double? StartMixedArea { get; set; }

    /// <summary>
    /// Unit[m] start position of heat in cast
    /// </summary>
    public double? StartPosHeat { get; set; }

    /// <summary>
    /// status
    /// </summary>
    public double? Status { get; set; }

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
