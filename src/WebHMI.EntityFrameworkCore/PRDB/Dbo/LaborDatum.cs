using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class LaborDatum
{
    /// <summary>
    /// index for location, where the sample has been taken (used also as key for the description in STDTXT)
    /// </summary>
    public int SampleIndex { get; set; }

    /// <summary>
    /// date and time, when sample has been taken
    /// </summary>
    public DateTime? SampleDate { get; set; }

    /// <summary>
    /// manual entered value - without any unit
    /// </summary>
    public int? SampleValue { get; set; }

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
