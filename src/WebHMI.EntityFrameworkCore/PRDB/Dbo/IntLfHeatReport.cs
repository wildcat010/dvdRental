using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class IntLfHeatReport
{
    /// <summary>
    /// (PK) Unique id (from INT_SEND)
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Unit[min] Bubbling duration of the last treatment (gas flow &gt; limit)
    /// </summary>
    public int? BubDuration { get; set; }

    /// <summary>
    /// Unit[Nm3] Bubbling gas volume of the last treatment (gas flow &gt; limit
    /// </summary>
    public int? BubGasVol { get; set; }

    /// <summary>
    /// Unit[min] Rinsing duration of the last treatment (gas flow &lt;= limit)
    /// </summary>
    public int? BubRinsingDuration { get; set; }

    /// <summary>
    /// Unit[min] Rinsing duration after last addition of last treatment (any addition Al, alloys or scrap; gas flow &lt;= limit)
    /// </summary>
    public int? BubRinsingDurLast { get; set; }

    /// <summary>
    /// Unit[Nm3] Rinsing gas volume of the last treatment (gas flow &lt;= limit)
    /// </summary>
    public int? BubRinsingGasVol { get; set; }

    /// <summary>
    /// Unit[kg] Steel weight in at treatment end
    /// </summary>
    public int? EndWeight { get; set; }

    /// <summary>
    /// Unit[min] Heating duration
    /// </summary>
    public int? HeatDuration { get; set; }

    /// <summary>
    /// Unit[kWh] Heating energy
    /// </summary>
    public int? HeatEnergy { get; set; }

    /// <summary>
    /// Heat number
    /// </summary>
    public string HeatNumber { get; set; }

    public int? LadleNumber { get; set; }

    /// <summary>
    /// Unit[ppm] Oxygen at end
    /// </summary>
    public int? OxygenEnd { get; set; }

    /// <summary>
    /// Unit[ppm] Oxygen at start
    /// </summary>
    public int? OxygenStart { get; set; }

    /// <summary>
    /// LF Number
    /// </summary>
    public int? PlantNumber { get; set; }

    /// <summary>
    /// sequence identification (plan number)
    /// </summary>
    public string SequenceId { get; set; }

    /// <summary>
    /// Analysis ID
    /// </summary>
    public string SteelGrade { get; set; }

    /// <summary>
    /// Unit[_C] Temperature at end
    /// </summary>
    public int? TempAtEnd { get; set; }

    /// <summary>
    /// Unit[_C] Temperature at start
    /// </summary>
    public int? TempAtStart { get; set; }

    /// <summary>
    /// Time when ladle left station
    /// </summary>
    public DateTime? TreatmentEndTime { get; set; }

    /// <summary>
    /// Treatment counter - How many LF treatments occurred in total
    /// </summary>
    public int? TreatCounter { get; set; }

    /// <summary>
    /// Unit[min] Treatment total duration
    /// </summary>
    public int? TreatDuration { get; set; }

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
