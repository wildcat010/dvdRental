using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class IntRhHeatReport
{
    /// <summary>
    /// (PK) Unique id (from INT_SEND)
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Unit[min] Bubbling lift gas flow duration of last treatment (Gas flow &gt; limit)
    /// </summary>
    public int? BubLiftGasFlowDur { get; set; }

    /// <summary>
    /// Unit[Nm3] Bubbling lift gas volume of last treatment (Gas flow &gt; limit)
    /// </summary>
    public int? BubLiftGasVolume { get; set; }

    /// <summary>
    /// Unit[min] Bubbling soft circulation after last addition - Any addition Al, alloys or scrap; gas flow&lt;=limit
    /// </summary>
    public int? BubSoftCircAftLast { get; set; }

    /// <summary>
    /// Unit[min] Bubbling soft circulation total of the last treatment (Gas flow &lt;= limit)
    /// </summary>
    public int? BubSoftCircTotal { get; set; }

    /// <summary>
    /// Unit[Nm3] Bubbling soft circulation total of the last treatment (Gas flow &lt;= limit)
    /// </summary>
    public int? BubSoftCircVol { get; set; }

    /// <summary>
    /// Unit[min] O2 flow duration
    /// </summary>
    public int? FlowDuration { get; set; }

    /// <summary>
    /// Heat number
    /// </summary>
    public string HeatNumber { get; set; }

    /// <summary>
    /// Unit[ppm] Hydrogen at end
    /// </summary>
    public int? HydrogenAtEnd { get; set; }

    /// <summary>
    /// Unit[ppm] Hydrogen at start
    /// </summary>
    public int? HydrogenAtStart { get; set; }

    /// <summary>
    /// Unit[ppm] Oxygen at end
    /// </summary>
    public int? OxygenAtEnd { get; set; }

    /// <summary>
    /// Unit[ppm] Oxygen at start
    /// </summary>
    public int? OxygenAtStart { get; set; }

    /// <summary>
    /// RH Number
    /// </summary>
    public int? PlantNumber { get; set; }

    /// <summary>
    /// sequence identification (plan number)
    /// </summary>
    public string SequenceId { get; set; }

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
    /// Treatment counter - how many RH treatments occurred in total
    /// </summary>
    public int? TreatmentCounter { get; set; }

    /// <summary>
    /// Unit[min] Total treatment duration
    /// </summary>
    public int? TreatmentDuration { get; set; }

    /// <summary>
    /// Time when ladle has left station
    /// </summary>
    public DateTime? TreatmentEndTime { get; set; }

    /// <summary>
    /// Unit[min] Vacuum duration total
    /// </summary>
    public int? VacuumDuration { get; set; }

    /// <summary>
    /// Unit[mbar] Final vacuum pressure avg
    /// </summary>
    public int? VacPressAvg { get; set; }

    /// <summary>
    /// Unit[mbar] Final vacuum pressure min - minimum pressure reached
    /// </summary>
    public int? VacPressMin { get; set; }

    /// <summary>
    /// Unit[Nm3] O2 volume
    /// </summary>
    public int? Volume { get; set; }

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
