using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class MatCutInfo
{
    /// <summary>
    /// counter for cuts
    /// </summary>
    public int CounterCuts { get; set; }

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
    /// Unit[m] start position of slab in strand sequence
    /// </summary>
    public float? CastSlabStartPos { get; set; }

    /// <summary>
    /// Unit[m] cutted length
    /// </summary>
    public float? CutLength { get; set; }

    /// <summary>
    /// 0 - head cut 1- product cut 2-scrap cut 3- division
    /// </summary>
    public int? CutPos { get; set; }

    /// <summary>
    /// Unit[m] cut position from head
    /// </summary>
    public float? CutStartPosition { get; set; }

    /// <summary>
    /// heat Id
    /// </summary>
    public string HeatId { get; set; }

    /// <summary>
    /// Unit[m] division of material length head
    /// </summary>
    public float? LengthHead { get; set; }

    /// <summary>
    /// Unit[m] division of material length tail
    /// </summary>
    public float? LengthTail { get; set; }

    /// <summary>
    /// sequence Id
    /// </summary>
    public string SequenceId { get; set; }

    /// <summary>
    /// shear idenfication
    /// </summary>
    public int? ShearId { get; set; }

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

    public virtual Me1 Me1 { get; set; }
}
