using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CalInfo
{
    /// <summary>
    /// plant type (HRM, HFM, ...)
    /// </summary>
    public string PlantType { get; set; }

    /// <summary>
    /// [0|1|2|3|4] physical stand number
    /// </summary>
    public int StandNo { get; set; }

    /// <summary>
    /// calibration flag, calibration with (=true) or without (=false) strip
    /// </summary>
    public int? BmCalib { get; set; }

    /// <summary>
    /// Unit[m] roll deformation cal point
    /// </summary>
    public double? CalDsb { get; set; }

    /// <summary>
    /// Unit[m] stand spring cal point
    /// </summary>
    public double? CalDss { get; set; }

    /// <summary>
    /// Unit[m] calibration point stand modulus
    /// </summary>
    public double? CalGcg { get; set; }

    /// <summary>
    /// Unit[m] calibration zero point
    /// </summary>
    public double? CalGs0 { get; set; }

    /// <summary>
    /// Unit[m] calibration zero point cor. Special plate
    /// </summary>
    public double? CalGs0k { get; set; }

    /// <summary>
    /// Unit[m] screw down after calibration
    /// </summary>
    public double? CalSdcor { get; set; }

    /// <summary>
    /// Unit[m] screw down position BA
    /// </summary>
    public double? CalSd { get; set; }

    /// <summary>
    /// Unit[N] roll force at calibration
    /// </summary>
    public double? FrCal { get; set; }

    /// <summary>
    /// Unit[m/s] speed at calibration
    /// </summary>
    public double? SpeedCal { get; set; }

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
