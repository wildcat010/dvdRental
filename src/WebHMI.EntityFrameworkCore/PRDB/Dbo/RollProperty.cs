using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Rollproperty
{
    public int Rollpropertyclass { get; set; }

    public double? Cwin { get; set; }

    public double? Cwout { get; set; }

    public double? Densityin { get; set; }

    public double? Densityout { get; set; }

    public string Description { get; set; }

    public double? Emodin { get; set; }

    public double? Emodout { get; set; }

    public double? Expansioncoefin { get; set; }

    public double? Expansioncoefout { get; set; }

    public double? Htenv { get; set; }

    public double? Htenv2 { get; set; }

    public double? Htneck { get; set; }

    public double? Lambdain { get; set; }

    public double? Lambdaout { get; set; }

    public double? Maxtemp { get; set; }

    public double? Mintemp { get; set; }

    public string Planttype { get; set; }

    public string Rolltype { get; set; }

    public double? Tinit { get; set; }

    public double? Tneck { get; set; }

    public double? Tneckmax { get; set; }

    public double? Weffbotroll { get; set; }

    public double? Wefftoproll { get; set; }

    public double? Wearfacmat { get; set; }

    public double? YieldpolynomcInd0 { get; set; }

    public double? YieldpolynomcInd1 { get; set; }

    public double? YieldpolynomcInd2 { get; set; }

    public double? YieldpolynomcInd3 { get; set; }

    public double? Yieldstress { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
