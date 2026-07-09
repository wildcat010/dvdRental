using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Rollshapecoeff
{
    public int Shapecode { get; set; }

    public string Description { get; set; }

    public int? Shapecurvecode { get; set; }

    public int? Shapetype { get; set; }

    public double? Shapex1 { get; set; }

    public double? Shapex2 { get; set; }

    public double? Shapex3 { get; set; }

    public double? Shapex4 { get; set; }

    public double? Shapex5 { get; set; }

    public double? Shapex6 { get; set; }

    public double? Shapex7 { get; set; }

    public double? Shapex8 { get; set; }

    public double? Shapex9 { get; set; }

    public string Standrange { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
