using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Rcppass
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public int Passno { get; set; }

    public string Source { get; set; }

    public double? Delaytime { get; set; }

    public string Description { get; set; }

    public double? FlowbridleInd0 { get; set; }

    public double? FlowbridleInd1 { get; set; }

    public double? FlowbridleInd2 { get; set; }

    public double? FlowbrloadedInd0 { get; set; }

    public double? FlowbrloadedInd1 { get; set; }

    public double? FlowbrloadedInd2 { get; set; }

    public double? FlowwridleInd0 { get; set; }

    public double? FlowwridleInd1 { get; set; }

    public double? FlowwridleInd2 { get; set; }

    public double? FlowwridleInd3 { get; set; }

    public double? FlowwridleInd4 { get; set; }

    public double? FlowwrloadedInd0 { get; set; }

    public double? FlowwrloadedInd1 { get; set; }

    public double? FlowwrloadedInd2 { get; set; }

    public double? FlowwrloadedInd3 { get; set; }

    public double? FlowwrloadedInd4 { get; set; }

    public int? Planno { get; set; }

    public int? Rollcoolcurve { get; set; }

    public int? Rollcoolstate { get; set; }

    public int? Wrcangle { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public double? Mzcflowrate { get; set; }

    public int? Mzcnozzelindex { get; set; }

    public int? Mzccascade { get; set; }

    public double? Mzcamplitude { get; set; }

    public double? Mzcflowrateedge { get; set; }

    public virtual Me1 Me1 { get; set; }
}
