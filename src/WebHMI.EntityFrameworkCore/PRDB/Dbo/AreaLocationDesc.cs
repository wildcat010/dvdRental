using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class AreaLocationDesc
{
    /// <summary>
    /// location id
    /// </summary>
    public short LocationId { get; set; }

    /// <summary>
    /// this location is member of this tracking area
    /// </summary>
    public short AreaId { get; set; }

    /// <summary>
    /// location begin
    /// </summary>
    public float? BeginLocation { get; set; }

    /// <summary>
    /// Unit[m] location end
    /// </summary>
    public float? EndLocation { get; set; }

    /// <summary>
    /// Unit[m] location description 1 = material place 2 = place with extension 3 = material area
    /// </summary>
    public short? LocationDesc { get; set; }

    /// <summary>
    /// location description text
    /// </summary>
    public string LocationDescText { get; set; }

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
