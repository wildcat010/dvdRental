using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class DeadTime
{
    /// <summary>
    /// Valve number counting separately from 0 for each sort
    /// </summary>
    public int No { get; set; }

    /// <summary>
    /// Valve Type: 0= top, 1=bot, 2=cross, 3= rtc
    /// </summary>
    public int Type { get; set; }

    /// <summary>
    /// Version
    /// </summary>
    public int Version { get; set; }

    /// <summary>
    /// measured delay-on time
    /// </summary>
    public float DelayOff { get; set; }

    /// <summary>
    /// measured delay-on time
    /// </summary>
    public float DelayOn { get; set; }

    /// <summary>
    /// last measurement entered by operator, last Measurement has value 1 all others NULL
    /// </summary>
    public int? LastMeasurement { get; set; }

    /// <summary>
    /// Date of measurement
    /// </summary>
    public DateTime VersionDate { get; set; }

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
