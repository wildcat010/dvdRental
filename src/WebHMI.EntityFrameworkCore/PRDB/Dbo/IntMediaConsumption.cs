using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class IntMediaConsumption
{
    /// <summary>
    /// ID
    /// </summary>
    public int Id { get; set; }

    public float? AirFlow { get; set; }

    public float? AirPressure { get; set; }

    public float? AirVolume { get; set; }

    public float? ArgFlow { get; set; }

    public float? ArgPressure { get; set; }

    public float? ArgVolume { get; set; }

    public float? BofFlow { get; set; }

    public float? BofPressure { get; set; }

    public float? BofVolume { get; set; }

    public float? NgFlow { get; set; }

    public float? NgPressure { get; set; }

    public float? NgVolume { get; set; }

    public float? NiFlow { get; set; }

    public float? NiPressure { get; set; }

    public float? NiVolume { get; set; }

    public float? OxyFlow { get; set; }

    public float? OxyPressure { get; set; }

    public float? OxyVolume { get; set; }

    public float? WtrFlow { get; set; }

    public float? WtrVolume { get; set; }

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
