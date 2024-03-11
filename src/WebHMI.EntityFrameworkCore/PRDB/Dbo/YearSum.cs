using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class YearSum
{
    /// <summary>
    /// year
    /// </summary>
    public string Year { get; set; }

    /// <summary>
    /// Unit[m] sum of coil length
    /// </summary>
    public float? CoilLength { get; set; }

    /// <summary>
    /// Unit[kg] weight of coils produced
    /// </summary>
    public float? CoilWeight { get; set; }

    /// <summary>
    /// Unit[s] sum of down times
    /// </summary>
    public float? DownTime { get; set; }

    /// <summary>
    /// Unit[m] length out  of classification range due to flatness unsymmetric
    /// </summary>
    public float? LengthOutFlatAsym { get; set; }

    /// <summary>
    /// Unit[m] length out of classification range due to flatness symmetric
    /// </summary>
    public float? LengthOutFlatSym { get; set; }

    /// <summary>
    /// Unit[m] length out of classification range due to strip thickness
    /// </summary>
    public float? LengthOutH { get; set; }

    /// <summary>
    /// Unit[m] length out of classification range due to strip profile/crown
    /// </summary>
    public float? LengthOutPr { get; set; }

    /// <summary>
    /// Unit[m] length out of classification range due to coiling temperature
    /// </summary>
    public float? LengthOutTcs { get; set; }

    /// <summary>
    /// Unit[m] length out of classification range due to finished strip temperature
    /// </summary>
    public float? LengthOutTfm { get; set; }

    /// <summary>
    /// Unit[m] length out of classification range due to strip width
    /// </summary>
    public float? LengthOutW { get; set; }

    /// <summary>
    /// Unit[m] length out of classification range due to wedge
    /// </summary>
    public float? LengthOutWedge { get; set; }

    /// <summary>
    /// number of coils produced
    /// </summary>
    public int? NoCoilsProduced { get; set; }

    /// <summary>
    /// number of slabs discharged
    /// </summary>
    public int? NoSlabsDischarged { get; set; }

    /// <summary>
    /// Unit[s] sum of production time
    /// </summary>
    public float? ProdTime { get; set; }

    /// <summary>
    /// ratio for flatness unsymmetric ((coil length - length out of classification range) / coil length)
    /// </summary>
    public float? RatioFlatAsym { get; set; }

    /// <summary>
    /// ratio for flatness symmetric ((coil length - length out of classification range) / coil length)
    /// </summary>
    public float? RatioFlatSym { get; set; }

    /// <summary>
    /// ratio for strip thickness ((coil length - length out of classification range) / coil length)
    /// </summary>
    public float? RatioH { get; set; }

    /// <summary>
    /// ratio for strip profile((coil length - length out of classification range) / coil length)
    /// </summary>
    public float? RatioPr { get; set; }

    /// <summary>
    /// ratio for coiling temperature ((coil length - length out of classification range) / coil length)
    /// </summary>
    public float? RatioTcs { get; set; }

    /// <summary>
    /// ratio for finished strip temperature ((coil length - length out of classification range) / coil length)
    /// </summary>
    public float? RatioTfm { get; set; }

    /// <summary>
    /// ratio for strip width ((coil length - length out of classification range) / coil length)
    /// </summary>
    public float? RatioW { get; set; }

    /// <summary>
    /// ratio for strip wedge ((coil length - length out of classification range) / coil length)
    /// </summary>
    public float? RatioWedge { get; set; }

    /// <summary>
    /// Unit[kg] sum slab weight
    /// </summary>
    public float? SlabWeight { get; set; }

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
