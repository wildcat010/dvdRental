using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class SpOrdEnt
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
    /// owner
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// thick head flag ( in HSM = 0)
    /// </summary>
    public short ThickHead { get; set; }

    /// <summary>
    /// amount of bindings circumferential
    /// </summary>
    public short? AmountBindings { get; set; }

    /// <summary>
    /// only for HMI: technological material key
    /// </summary>
    public string ApsKey { get; set; }

    /// <summary>
    /// no. of dilatometer curve to be applied
    /// </summary>
    public short? DilatometerCurve { get; set; }

    /// <summary>
    /// Flag for plate production:  0 = strip production, 1 = plate production
    /// </summary>
    public int? FlagPlateProd { get; set; }

    /// <summary>
    /// for marking
    /// </summary>
    public float? HExitCus { get; set; }

    /// <summary>
    /// Unit[m] strip thickness - tolerance - (delta)
    /// </summary>
    public float? HExitM { get; set; }

    /// <summary>
    /// Unit[m] strip thickness - tolerance + (delta)
    /// </summary>
    public float? HExitP { get; set; }

    /// <summary>
    /// Unit[m] planned finished strip thickness from L3
    /// </summary>
    public float? HExitSetp { get; set; }

    /// <summary>
    /// Row Order identifier from L3
    /// </summary>
    public int? IdRiga { get; set; }

    /// <summary>
    /// Sequence identifier from L3
    /// </summary>
    public int? IdSeq { get; set; }

    /// <summary>
    /// Sampling/inspection code
    /// </summary>
    public short? InspectionCode { get; set; }

    /// <summary>
    /// Unit[m] length of order
    /// </summary>
    public float? LengthOrder { get; set; }

    /// <summary>
    /// Marking data for disc line
    /// </summary>
    public string MarkingDataDiscLine { get; set; }

    /// <summary>
    /// material identifier for measurement devices (from table ThickMatId)
    /// </summary>
    public int? MatId { get; set; }

    /// <summary>
    /// dilatometercurve number
    /// </summary>
    public short? NoDil { get; set; }

    /// <summary>
    /// Unit[m] strip profile upper tolerance
    /// </summary>
    public float? ProfileMax { get; set; }

    /// <summary>
    /// Unit[m] strip profile lower tolerance
    /// </summary>
    public float? ProfileMin { get; set; }

    /// <summary>
    /// Flag: 1=setpoints from Ed are o.k.
    /// </summary>
    public short? SetpointsEdOk { get; set; }

    /// <summary>
    /// for marking
    /// </summary>
    public string SteelCus { get; set; }

    /// <summary>
    /// Unit[_C] tension reel/coiler: coiling temperature
    /// </summary>
    public float? TCoiler { get; set; }

    /// <summary>
    /// Unit[_C] planned exit temperature from L3
    /// </summary>
    public float? TExitSetp { get; set; }

    /// <summary>
    /// Unit[m] strip wedge - positive tolerance limit
    /// </summary>
    public float? WedgeMax { get; set; }

    /// <summary>
    /// Unit[m] strip wedge - negative tolerance limit
    /// </summary>
    public float? WedgeMin { get; set; }

    /// <summary>
    /// for marking
    /// </summary>
    public float? WidthExitCus { get; set; }

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

    /// <summary>
    /// amount of bindings radial
    /// </summary>
    public short? AmountBindingsR { get; set; }

    public virtual Me1 Me1 { get; set; }
}
