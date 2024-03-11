using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class L3l2heatStatus
{
    /// <summary>
    /// unique communication ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Heat number
    /// </summary>
    public string HeatNumber { get; set; }

    /// <summary>
    /// 1= heat at BOF,  2= heat at LF,  3= heat at RH
    /// </summary>
    public int? HeatStatus { get; set; }

    /// <summary>
    /// Treatment number at aggregate
    /// </summary>
    public int? HeatTreatment { get; set; }

    /// <summary>
    /// NULL until tapping at BOF is finished
    /// </summary>
    public int? LadleNumber { get; set; }

    /// <summary>
    /// steel grade
    /// </summary>
    public string SteelGrade { get; set; }

    /// <summary>
    /// Unit[kg] NULL until heat finished at BOF
    /// </summary>
    public int? SteelWeight { get; set; }

    /// <summary>
    /// Unit[_K] Steel temperature, NULL until heat finished at BOF
    /// </summary>
    public int? Temperature { get; set; }

    /// <summary>
    /// Time of temperature measurement.
    /// </summary>
    public DateTime? TemperatureTime { get; set; }

    /// <summary>
    /// Time when the message was sent
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
