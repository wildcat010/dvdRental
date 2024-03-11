using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class CasL3sampleTaken
{
    public int Id { get; set; }

    public DateTime? DtTakenTime { get; set; }

    public string HeatId { get; set; }

    public string LineId { get; set; }

    public string SampleId { get; set; }

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
