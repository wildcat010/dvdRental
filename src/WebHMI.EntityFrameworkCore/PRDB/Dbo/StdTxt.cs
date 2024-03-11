using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StdTxt
{
    /// <summary>
    /// Language code. e.g. DE = German C = English   X = non-language-bound
    /// </summary>
    public string Lang { get; set; }

    /// <summary>
    /// It combines classes of standard texts.For example disturbances or material defects
    /// </summary>
    public string ParameterText { get; set; }

    /// <summary>
    /// Key of a text within a parameter Text
    /// </summary>
    public string StdTextKey { get; set; }

    /// <summary>
    /// Indication of modifications
    /// </summary>
    public string CreMark { get; set; }

    /// <summary>
    /// Identifier of the modifying one
    /// </summary>
    public string Moduser { get; set; }

    /// <summary>
    /// Identifier of plant group at TKS
    /// </summary>
    public int? PlantGroup { get; set; }

    /// <summary>
    /// Identifier of plant part (area) at TKS
    /// </summary>
    public int? PlantPart { get; set; }

    /// <summary>
    /// Sort key. It is used if a specific sorting of the standard texts should be carried out.
    /// </summary>
    public int? Sort { get; set; }

    /// <summary>
    /// Standard text
    /// </summary>
    public string StdText { get; set; }

    /// <summary>
    /// Here may can educated to one standard text class subgroups may be.
    /// </summary>
    public string StdTextGroup { get; set; }

    /// <summary>
    /// Numerical value to the standard text.
    /// </summary>
    public int? StdTextN { get; set; }

    /// <summary>
    /// End of validity
    /// </summary>
    public DateTime? ValidationEnd { get; set; }

    /// <summary>
    /// Validity beginning
    /// </summary>
    public DateTime? ValidationStart { get; set; }

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
