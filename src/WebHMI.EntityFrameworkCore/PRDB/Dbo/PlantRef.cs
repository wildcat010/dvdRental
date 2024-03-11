using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class PlantRef
{
    /// <summary>
    /// record id
    /// </summary>
    public int RecId { get; set; }

    /// <summary>
    /// name of the HMI server
    /// </summary>
    public string HmiServerName { get; set; }

    /// <summary>
    /// level1_name - parameter
    /// </summary>
    public string Level1Name { get; set; }

    /// <summary>
    /// level1_name - lower limit
    /// </summary>
    public string Level1NameLl { get; set; }

    /// <summary>
    /// level1_name - upper limit
    /// </summary>
    public string Level1NameUl { get; set; }

    /// <summary>
    /// name of the LFE, which uses this value
    /// </summary>
    public string LfeName { get; set; }

    /// <summary>
    /// name of the parameter or limit
    /// </summary>
    public string ParamName { get; set; }

    /// <summary>
    /// plant type:  HRM, HFM
    /// </summary>
    public string PlantType { get; set; }

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
