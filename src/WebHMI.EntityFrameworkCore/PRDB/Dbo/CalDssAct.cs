using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CalDssAct
{
    /// <summary>
    /// record number
    /// </summary>
    public int DssNumber { get; set; }

    /// <summary>
    /// plant type (HRM, HFM, ...)
    /// </summary>
    public string PlantType { get; set; }

    /// <summary>
    /// [0|1|2|3|4] physical stand number
    /// </summary>
    public int StandNo { get; set; }

    /// <summary>
    /// Unit[m] stand spring only frame
    /// </summary>
    public double? DsFrame { get; set; }

    /// <summary>
    /// Unit[m] stand spring
    /// </summary>
    public double? Dss { get; set; }

    /// <summary>
    /// Unit[N] roll force
    /// </summary>
    public double? Fr { get; set; }

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
