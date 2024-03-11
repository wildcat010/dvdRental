using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class PrPhyPro
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
    /// Owner
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// planned heat identification
    /// </summary>
    public string AimHeatId { get; set; }

    /// <summary>
    /// Planned thickness at entry of HRM
    /// </summary>
    public float? AimSlabThickness { get; set; }

    /// <summary>
    /// Planned weight
    /// </summary>
    public float? AimSlabWeight { get; set; }

    /// <summary>
    /// Planned width
    /// </summary>
    public float? AimSlabWidthHead { get; set; }

    /// <summary>
    /// Unit[m] FM coil inner diameter (meas Value)
    /// </summary>
    public float? CoilInDiaX { get; set; }

    /// <summary>
    /// Unit[m] strip length of the whole exit-coil
    /// </summary>
    public float? CoilLengthX { get; set; }

    /// <summary>
    /// number of used coiler
    /// </summary>
    public short? CoilNo { get; set; }

    /// <summary>
    /// Unit[m] FM coil outer diameter (meas Value)
    /// </summary>
    public float? CoilOutDiaX { get; set; }

    /// <summary>
    /// Unit[m] exit  thickness customer
    /// </summary>
    public float? HExitCustomer { get; set; }

    /// <summary>
    /// maximum slab weight (used as cutting limit for the strip, in case of same sequence ID)
    /// </summary>
    public float? MaxSlabWeight { get; set; }

    /// <summary>
    /// minimum slab weight (used as cutting limit for the strip, in case of same sequence ID)
    /// </summary>
    public float? MinSlabWeight { get; set; }

    /// <summary>
    /// production end time
    /// </summary>
    public DateTime? ProdEnd { get; set; }

    /// <summary>
    /// production start time
    /// </summary>
    public DateTime? ProdStart { get; set; }

    /// <summary>
    /// Coil production time
    /// </summary>
    public int? ProdTime { get; set; }

    /// <summary>
    /// shift identification
    /// </summary>
    public string Shift { get; set; }

    /// <summary>
    /// Status of transmision
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// steelgrade customer
    /// </summary>
    public string SteelCustomer { get; set; }

    /// <summary>
    /// type of product(0-coil  1- plate  2- passby RM plate)
    /// </summary>
    public int? Type { get; set; }

    /// <summary>
    /// Unit[m] wedge start position in strip
    /// </summary>
    public float? WedgeEndPos { get; set; }

    /// <summary>
    /// Unit[m] wedge end  position in strip
    /// </summary>
    public float? WedgeStartPos { get; set; }

    /// <summary>
    /// Unit[kg] product material weight (meas value)
    /// </summary>
    public float? Weight { get; set; }

    /// <summary>
    /// Planned width change
    /// </summary>
    public float? WidthChange { get; set; }

    /// <summary>
    /// 0=width change at the end of the coil, 1=width change cut as plate (scrap), 2=width change over entire coil
    /// </summary>
    public int? WidthChangeFlag { get; set; }

    /// <summary>
    /// Unit[m] exit  width customer
    /// </summary>
    public float? WidthExitCustomer { get; set; }

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
