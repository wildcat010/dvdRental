using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class ProdSchedule
{
    /// <summary>
    /// major number
    /// </summary>
    public int MajorNo { get; set; }

    /// <summary>
    /// minor number
    /// </summary>
    public int MinorNo { get; set; }

    /// <summary>
    /// owner
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// indication if this coil has got a new coil next the the order (if new =1, then the coil has to be recalculated by MOS)
    /// </summary>
    public short? CalcFlag { get; set; }

    /// <summary>
    /// flag for crane communication - requested Y/N
    /// </summary>
    public string Crane { get; set; }

    /// <summary>
    /// external material identification (customer code)
    /// </summary>
    public string ExtId { get; set; }

    /// <summary>
    /// identification of a maintenance order (roll change e.g.)
    /// </summary>
    public string Maintenance { get; set; }

    /// <summary>
    /// material creator
    /// </summary>
    public string MeCreator { get; set; }

    /// <summary>
    /// material identification
    /// </summary>
    public int? MeId { get; set; }

    /// <summary>
    /// Type of material
    /// </summary>
    public string MeTyp { get; set; }

    /// <summary>
    /// material working step
    /// </summary>
    public short? MesId { get; set; }

    /// <summary>
    /// flag for next material for production  next = 1
    /// </summary>
    public short? Next { get; set; }

    /// <summary>
    /// program code of the customer (related to the major number)
    /// </summary>
    public string PrCodeCus { get; set; }

    /// <summary>
    /// code for virtual program unit
    /// </summary>
    public int? VPrUnit { get; set; }

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
