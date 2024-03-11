using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class IntCcmHeatStatus
{
    /// <summary>
    /// Unique id (from INT_SEND)
    /// </summary>
    public int Id { get; set; }

    public string HeatNumber { get; set; }

    /// <summary>
    /// CCM Heat Status:1 WAIT (wait on turret)  2  OPEN  (pouring)  3  CAST (strand casting)  4  FIN (opened ladle departed)  5 RETURN (full ladle departed)
    /// </summary>
    public int? HeatStatus { get; set; }

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
    /// Heat status change time
    /// </summary>
    public DateTime? TimeStamp { get; set; }

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
