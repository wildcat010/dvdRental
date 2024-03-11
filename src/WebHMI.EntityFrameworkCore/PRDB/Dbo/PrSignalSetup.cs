using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Production Setup of signals
/// </summary>
public partial class PrSignalSetup
{
    /// <summary>
    /// active flag
    /// </summary>
    public int ActiveFlag { get; set; }

    /// <summary>
    /// reference name of of measured data
    /// </summary>
    public string NameRef { get; set; }

    /// <summary>
    /// description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// filter for targets lower or equal than limit
    /// </summary>
    public double? TargetLimitMax { get; set; }

    /// <summary>
    /// filter for targets bigger than limit
    /// </summary>
    public double? TargetLimitMin { get; set; }

    /// <summary>
    /// processing methods
    /// </summary>
    public string MethodInd0 { get; set; }

    /// <summary>
    /// processing methods
    /// </summary>
    public string MethodInd1 { get; set; }

    /// <summary>
    /// processing methods
    /// </summary>
    public string MethodInd2 { get; set; }

    /// <summary>
    /// processing methods
    /// </summary>
    public string MethodInd3 { get; set; }

    /// <summary>
    /// processing methods
    /// </summary>
    public string MethodInd4 { get; set; }

    /// <summary>
    /// processing methods
    /// </summary>
    public string MethodInd5 { get; set; }

    /// <summary>
    /// processing methods
    /// </summary>
    public string MethodInd6 { get; set; }

    /// <summary>
    /// processing methods
    /// </summary>
    public string MethodInd7 { get; set; }

    /// <summary>
    /// processing methods
    /// </summary>
    public string MethodInd8 { get; set; }

    /// <summary>
    /// processing methods
    /// </summary>
    public string MethodInd9 { get; set; }

    /// <summary>
    /// Unit[m] offset head to skip in calculation
    /// </summary>
    public double? OffsetHead { get; set; }

    /// <summary>
    /// Unit[m] offset tail to skip in calculation
    /// </summary>
    public double? OffsetTail { get; set; }

    /// <summary>
    /// ADH Signal name
    /// </summary>
    public string Signal { get; set; }

    /// <summary>
    /// path to target value (db table.column)
    /// </summary>
    public string TargetSource { get; set; }

    /// <summary>
    /// limit value (path as a text or absolute as value or relative as value with prefix + or -)
    /// </summary>
    public string TolMaxSource { get; set; }

    /// <summary>
    /// limit value (path as a text or absolute as value or relative as value with prefix + or -)
    /// </summary>
    public string TolMinSource { get; set; }

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
