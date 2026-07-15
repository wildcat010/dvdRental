using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class PlantParam
{
    /// <summary>
    /// Unit[Unit] name of the parameter
    /// </summary>
    public string ParamName { get; set; }

    /// <summary>
    /// plant type:  HRM, HFM
    /// </summary>
    public string PlantType { get; set; }

    /// <summary>
    /// Unit[Unit] type of the value
    /// </summary>
    public string CType { get; set; }

    /// <summary>
    /// Unit[Unit] character value
    /// </summary>
    public string CurValC { get; set; }

    /// <summary>
    /// Unit[Unit] numeric value
    /// </summary>
    public double? CurValN { get; set; }

    /// <summary>
    /// Unit[Unit] description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Unit[Unit] name of the lower limit value
    /// </summary>
    public string LimitNameLl { get; set; }

    /// <summary>
    /// Unit[Unit] name of the upper limit value
    /// </summary>
    public string LimitNameUl { get; set; }

    /// <summary>
    /// Unit[Unit] description of the modification
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
