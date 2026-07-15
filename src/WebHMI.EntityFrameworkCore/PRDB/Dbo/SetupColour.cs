using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// defines different colours with name and colour (number)
/// </summary>
public partial class SetupColour
{
    /// <summary>
    /// name of colour
    /// </summary>
    public string Colour { get; set; }

    /// <summary>
    /// RGB value (number) of colour
    /// </summary>
    public int? RgbNumber { get; set; }

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
