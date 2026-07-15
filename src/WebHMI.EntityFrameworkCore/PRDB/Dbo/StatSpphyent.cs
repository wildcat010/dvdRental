using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StatSpPhyEnt
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
    /// identifaction of material in basic automation
    /// </summary>
    public short? BasisId { get; set; }

    public short? BendModeFlag { get; set; }

    /// <summary>
    /// coil outer diameter (only available for exit, measured value)
    /// </summary>
    public short? CoilOutDia { get; set; }

    /// <summary>
    /// thickness of coil customer
    /// </summary>
    public short? HExitCustomer { get; set; }

    /// <summary>
    /// heat identification
    /// </summary>
    public short? HeatId { get; set; }

    /// <summary>
    /// Length string marking data disc line
    /// </summary>
    public short? LenMarkingDataDiscLine { get; set; }

    /// <summary>
    /// Length string marking data line 1
    /// </summary>
    public short? LenMarkingDataShellLine1 { get; set; }

    /// <summary>
    /// Length string marking data shell line 2
    /// </summary>
    public short? LenMarkingDataShellLine2 { get; set; }

    /// <summary>
    /// Marking data for shell line 1
    /// </summary>
    public short? MarkingDataShellLine1 { get; set; }

    /// <summary>
    /// Marking data for shell line 2
    /// </summary>
    public short? MarkingDataShellLine2 { get; set; }

    /// <summary>
    /// caster sequence Id
    /// </summary>
    public short? SeqId { get; set; }

    /// <summary>
    /// steelgrade customer
    /// </summary>
    public short? SteelCustomer { get; set; }

    /// <summary>
    /// width of coil customer
    /// </summary>
    public short? WidthExitCustomer { get; set; }

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
