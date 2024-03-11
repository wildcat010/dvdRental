using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class PlantLimit
{
    /// <summary>
    /// Unit[Unit] name of the value
    /// </summary>
    public string LimitName { get; set; }

    /// <summary>
    /// plant type:  HRM, HFM
    /// </summary>
    public string PlantType { get; set; }

    /// <summary>
    /// Unit[Unit] type of the value
    /// </summary>
    public string CType { get; set; }

    /// <summary>
    /// Unit[Unit] description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Unit[Unit] lower limit of the value
    /// </summary>
    public float? LowerLimit { get; set; }

    /// <summary>
    /// Unit[Unit] description of modification
    /// </summary>
    public string Moddescr { get; set; }

    /// <summary>
    /// Unit[Unit] sort order
    /// </summary>
    public string SortOrder { get; set; }

    /// <summary>
    /// Unit[Unit] unit of the value
    /// </summary>
    public string Unit { get; set; }

    /// <summary>
    /// Unit[Unit] upper limit of the value
    /// </summary>
    public float? UpperLimit { get; set; }

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
