using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class MorgOilFloatAct
{
    /// <summary>
    /// plant type
    /// </summary>
    public string PlantType { get; set; }

    /// <summary>
    /// stand number
    /// </summary>
    public int StandNo { get; set; }

    /// <summary>
    /// calculate parameter A
    /// </summary>
    public double? ParameterA { get; set; }

    /// <summary>
    /// calculate parameter B
    /// </summary>
    public double? ParameterB { get; set; }

    /// <summary>
    /// calculate parameter C
    /// </summary>
    public double? ParameterC { get; set; }

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
