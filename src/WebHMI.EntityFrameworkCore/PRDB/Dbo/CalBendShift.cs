using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CalBendShift
{
    /// <summary>
    /// plant type (HRM, HFM, ...)
    /// </summary>
    public string PlantType { get; set; }

    /// <summary>
    /// roll number
    /// </summary>
    public int RollNumber { get; set; }

    /// <summary>
    /// [0|1|2|3|4] physical stand number
    /// </summary>
    public int StandNo { get; set; }

    /// <summary>
    /// Unit[N] bending force of calibration
    /// </summary>
    public double? FbCal { get; set; }

    /// <summary>
    /// Unit[m] shifting position of calibration
    /// </summary>
    public double? SrCal { get; set; }

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
