using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class DefectValf
{
    /// <summary>
    /// Valve number, first the top, then bottom, then cross sprays then roll table cooling
    /// </summary>
    public int No { get; set; }

    /// <summary>
    /// Valve Type: 0= top, 1=bot, 2=cross, 3= rtc
    /// </summary>
    public int Type { get; set; }

    /// <summary>
    /// Version Number
    /// </summary>
    public int Version { get; set; }

    /// <summary>
    /// Defect Valve State: 0= ok, 1=defective-on, 2=defective-off
    /// </summary>
    public int State { get; set; }

    /// <summary>
    /// Date of setting valve ok/not ok.
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
