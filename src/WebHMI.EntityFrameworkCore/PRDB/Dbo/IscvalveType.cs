using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

/// <summary>
/// ISC Valve type related information
/// </summary>
public partial class IscvalveType
{
    /// <summary>
    /// valve type index
    /// </summary>
    public int ValveType { get; set; }

    /// <summary>
    /// Unit[m3/s] maximum flow, if -1, then individual headers have their flows specified and the valve flow should be the sum of those
    /// </summary>
    public double? MaxFlow { get; set; }

    /// <summary>
    /// order of spline (needed to properly initialize spline object)
    /// </summary>
    public int? SplineOrder { get; set; }

    /// <summary>
    /// 0 - switch, 1 - continuous flow control
    /// </summary>
    public int? SwitchOrContinuous { get; set; }

    /// <summary>
    /// order of taylor polynomial at the lower boarder of definition interval
    /// </summary>
    public int? TaylorOrderLower { get; set; }

    /// <summary>
    /// order of taylor polynomial at the upper boarder of definition interval
    /// </summary>
    public int? TaylorOrderUpper { get; set; }

    /// <summary>
    /// array of indexes of header types.  Index should be used to access table ISCValveHeadTypes
    /// </summary>
    public int? ValveHeadTypesInd0 { get; set; }

    /// <summary>
    /// array of indexes of header types.  Index should be used to access table ISCValveHeadTypes
    /// </summary>
    public int? ValveHeadTypesInd1 { get; set; }

    /// <summary>
    /// array of indexes of header types.  Index should be used to access table ISCValveHeadTypes
    /// </summary>
    public int? ValveHeadTypesInd2 { get; set; }

    /// <summary>
    /// array of indexes of header types.  Index should be used to access table ISCValveHeadTypes
    /// </summary>
    public int? ValveHeadTypesInd3 { get; set; }

    /// <summary>
    /// array of indexes of header types.  Index should be used to access table ISCValveHeadTypes
    /// </summary>
    public int? ValveHeadTypesInd4 { get; set; }

    /// <summary>
    /// array of indexes of header types.  Index should be used to access table ISCValveHeadTypes
    /// </summary>
    public int? ValveHeadTypesInd5 { get; set; }

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
