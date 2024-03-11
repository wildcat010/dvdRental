using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Casl3heateventparam
{
    public int Id { get; set; }

    public string Parametername { get; set; }

    public DateTime? Parameterdate { get; set; }

    public float? Parametervaluenumber { get; set; }

    public string Parametervaluestring { get; set; }

    public string Unitofmeasurement { get; set; }

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
