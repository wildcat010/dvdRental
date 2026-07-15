using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// Standard anti-peeling and anti-oxidation plan pass
/// </summary>
public partial class StdAoppass
{
    /// <summary>
    /// active flag
    /// </summary>
    public int ActiveFlag { get; set; }

    /// <summary>
    /// passw number
    /// </summary>
    public int PassNo { get; set; }

    /// <summary>
    /// Unit[0...999] anti-peeling and anti-oxidation plan number
    /// </summary>
    public int PlanNo { get; set; }

    /// <summary>
    /// Unit[0/1] anti-oxidation entry pass state: 0-AUTO, 1-MANUAL
    /// </summary>
    public int? AntiOxStateEntry { get; set; }

    /// <summary>
    /// Unit[0/1] anti-oxidation exit pass state: 0-AUTO, 1-MANUAL
    /// </summary>
    public int? AntiOxStateExit { get; set; }

    /// <summary>
    /// anti-oxidation entry
    /// </summary>
    public double? AntiOxidationEntry { get; set; }

    /// <summary>
    /// anti-oxidation exit
    /// </summary>
    public double? AntiOxidationExit { get; set; }

    /// <summary>
    /// anti-peeling
    /// </summary>
    public double? AntiPeeling { get; set; }

    /// <summary>
    /// Unit[0/1] anti-peeling pass state: 0-AUTO, 1-MANUAL
    /// </summary>
    public int? AntiPeelingState { get; set; }

    /// <summary>
    /// description field
    /// </summary>
    public string Description { get; set; }

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
