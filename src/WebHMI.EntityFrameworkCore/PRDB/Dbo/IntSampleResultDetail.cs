using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class IntSampleResultDetail
{
    /// <summary>
    /// Element name as per  international standards (e.g.: C, SI, CR, FE2O3)
    /// </summary>
    public string Element { get; set; }

    /// <summary>
    /// ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Unit[%] Analysis value
    /// </summary>
    public float Value { get; set; }

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
