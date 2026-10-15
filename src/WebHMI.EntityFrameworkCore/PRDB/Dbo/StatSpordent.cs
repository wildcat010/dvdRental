using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StatSpOrdEnt
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
    /// amount of bindings radial
    /// </summary>
    public short? AmountBindingsR { get; set; }

    /// <summary>
    /// only for HMI: technological material key
    /// </summary>
    public short? ApsKey { get; set; }

    /// <summary>
    /// Coil Yard Destination
    /// </summary>
    public short? CoilYard { get; set; }

    /// <summary>
    /// strip crown - maximum tolerance from aim C40
    /// </summary>
    public short? CrownMax { get; set; }

    /// <summary>
    /// strip crown - minimum tolerance from aim C40
    /// </summary>
    public short? CrownMin { get; set; }

    /// <summary>
    /// no. of dilatometer curve to be applied
    /// </summary>
    public short? DilatometerCurve { get; set; }

    /// <summary>
    /// Flag for plate production:  0 = strip production, 1 = plate production
    /// </summary>
    public short? FlagPlateProd { get; set; }

    /// <summary>
    /// strip flatness - maximum tolerance for asymetric flatness
    /// </summary>
    public short? FlatAsymMax { get; set; }

    /// <summary>
    /// strip flatness - maximum tolerance for symetric flatness
    /// </summary>
    public short? FlatSymMax { get; set; }

    /// <summary>
    /// strip flatness - minimum tolerance for symetric flatness
    /// </summary>
    public short? FlatSymMin { get; set; }

    /// <summary>
    /// for marking
    /// </summary>
    public short? HExitCus { get; set; }

    /// <summary>
    /// strip thickness - tolerance - (delta)
    /// </summary>
    public short? HExitM { get; set; }

    /// <summary>
    /// strip thickness - tolerance + (delta)
    /// </summary>
    public short? HExitP { get; set; }

    /// <summary>
    /// planned finished strip thickness from L3
    /// </summary>
    public short? HExitSetp { get; set; }

    /// <summary>
    /// Row Order identifier from L3
    /// </summary>
    public short? IdRiga { get; set; }

    /// <summary>
    /// Sequence identifier from L3
    /// </summary>
    public short? IdSeq { get; set; }

    /// <summary>
    /// Sampling/inspection code
    /// </summary>
    public short? InspectionCode { get; set; }

    /// <summary>
    /// length of order
    /// </summary>
    public short? LengthOrder { get; set; }

    /// <summary>
    /// Marking data for disc line
    /// </summary>
    public short? MarkingDataDiscLine { get; set; }

    /// <summary>
    /// material identifier for measurement devices (from table ThickMatId)
    /// </summary>
    public short? MatId { get; set; }

    /// <summary>
    /// dilatometercurve number
    /// </summary>
    public short? NoDil { get; set; }

    /// <summary>
    /// Flag: 1=setpoints from Ed are o.k.
    /// </summary>
    public short? SetpointsEdOk { get; set; }

    /// <summary>
    /// for marking
    /// </summary>
    public short? SteelCus { get; set; }

    /// <summary>
    /// tension reel/coiler: coiling temperature
    /// </summary>
    public short? TCoiler { get; set; }

    /// <summary>
    /// planned exit temperature from L3
    /// </summary>
    public short? TExitSetp { get; set; }

    /// <summary>
    /// finished strip target flatness
    /// </summary>
    public short? TargetFlatness { get; set; }

    /// <summary>
    /// strip wedge - positive tolerance limit
    /// </summary>
    public short? WedgeMax { get; set; }

    /// <summary>
    /// strip wedge - negative tolerance limit
    /// </summary>
    public short? WedgeMin { get; set; }

    /// <summary>
    /// for marking
    /// </summary>
    public short? WidthExitCus { get; set; }

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
