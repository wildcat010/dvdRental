using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CsReportCurf
{
    /// <summary>
    /// point of the point
    /// </summary>
    public short Segment { get; set; }

    /// <summary>
    /// Material identification
    /// </summary>
    public int MeId { get; set; }

    /// <summary>
    /// number of the strip: head, body
    /// </summary>
    public short PointNo { get; set; }

    /// <summary>
    /// chemical composition of phase transformation model
    /// </summary>
    public double? Austenite { get; set; }

    /// <summary>
    /// chemical composition of phase transformation model
    /// </summary>
    public double? Bainite { get; set; }

    /// <summary>
    /// chemical composition of phase transformation model
    /// </summary>
    public double? Cementite { get; set; }

    /// <summary>
    /// chemical composition of phase transformation model
    /// </summary>
    public double? Ferrite { get; set; }

    /// <summary>
    /// index of meter
    /// </summary>
    public double? Martensite { get; set; }

    /// <summary>
    /// chemical composition of phase transformation model
    /// </summary>
    public double? Pearlite { get; set; }

    /// <summary>
    /// Unit[m] pssition in the strip [m]
    /// </summary>
    public double? Possition { get; set; }

    /// <summary>
    /// temperature
    /// </summary>
    public double? Temperature { get; set; }

    /// <summary>
    /// Unit[s] time at the location [s]
    /// </summary>
    public double? Time { get; set; }

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
