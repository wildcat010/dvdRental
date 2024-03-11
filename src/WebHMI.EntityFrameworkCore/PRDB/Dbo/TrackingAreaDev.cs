using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class TrackingAreaDev
{
    /// <summary>
    /// sequenceial id
    /// </summary>
    public short Sid { get; set; }

    /// <summary>
    /// area id
    /// </summary>
    public short AreaId { get; set; }

    /// <summary>
    /// device comment
    /// </summary>
    public string DeviceComment { get; set; }

    /// <summary>
    /// device id
    /// </summary>
    public short? DeviceId { get; set; }

    /// <summary>
    /// end position of the device
    /// </summary>
    public float? EndPos { get; set; }

    /// <summary>
    /// location id
    /// </summary>
    public short? LocationId { get; set; }

    /// <summary>
    /// start position of the device
    /// </summary>
    public float? StartPos { get; set; }

    /// <summary>
    /// y coordinate
    /// </summary>
    public int? YCoord { get; set; }

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
