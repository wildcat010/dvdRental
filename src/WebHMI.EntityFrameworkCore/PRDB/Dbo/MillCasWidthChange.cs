using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class MillCasWidthChange
{
    /// <summary>
    /// unique communication ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Unit[m] start pos of width change
    /// </summary>
    public float? NcastLength { get; set; }

    /// <summary>
    /// Unit[m] Aim width (cold slab width) after width change
    /// </summary>
    public float? AimWidth { get; set; }

    /// <summary>
    /// Unit[m] Cast Length when width change should start
    /// </summary>
    public float? CastLength { get; set; }

    /// <summary>
    /// Position of width chane: 0=Tail, 1=Head, 2=over slab length
    /// </summary>
    public int? ChangeAt { get; set; }

    /// <summary>
    /// Unit[m] Aim length of tapered slab. 0 = make width change as fast as possible. &gt;0 = try to make the width change over the specified length.
    /// </summary>
    public float? TaperLength { get; set; }

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
