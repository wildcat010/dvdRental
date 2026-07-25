using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Aoppass
{
    /// <summary>
    /// Material owner
    /// </summary>
    public string MeCreator { get; set; }

    /// <summary>
    /// Material idendification number
    /// </summary>
    public int MeId { get; set; }

    /// <summary>
    /// Line status
    /// </summary>
    public short MesId { get; set; }

    /// <summary>
    /// pass number
    /// </summary>
    public int PassNo { get; set; }

    /// <summary>
    /// owner
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// Unit[0/1] anti-oxidation entry pass state: 0-AUTO, 1-MANUAL
    /// </summary>
    public int? AntiOxStateEntry { get; set; }

    /// <summary>
    /// Unit[0/1] anti-oxidation exit pass state: 0-AUTO, 1-MANUAL
    /// </summary>
    public int? AntiOxStateExit { get; set; }

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
    /// Unit[0...999] palan number
    /// </summary>
    public int? PlanNo { get; set; }

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

    public double? AntiOxidationEntryInd0 { get; set; }

    public double? AntiOxidationEntryInd1 { get; set; }

    public double? AntiOxidationExitInd0 { get; set; }

    public double? AntiOxidationExitInd1 { get; set; }

    public virtual Me1 Me1 { get; set; }
}
