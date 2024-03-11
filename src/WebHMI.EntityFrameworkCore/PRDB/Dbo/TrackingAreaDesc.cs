using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class TrackingAreaDesc
{
    /// <summary>
    /// area identification number
    /// </summary>
    public short AreaId { get; set; }

    /// <summary>
    /// Begin of the area related to the whole plant 0-position
    /// </summary>
    public float? AreaBeginPos { get; set; }

    /// <summary>
    /// area description
    /// </summary>
    public string AreaDesc { get; set; }

    /// <summary>
    /// has this area a fixed length
    /// </summary>
    public bool? FixedAreaLength { get; set; }

    /// <summary>
    /// area length
    /// </summary>
    public float? Length { get; set; }

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
