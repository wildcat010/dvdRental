using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Rollchamfer
{
    public int Rollchamferclass { get; set; }

    public double? Conedistds { get; set; }

    public double? Conedistos { get; set; }

    public double? Coneheightds { get; set; }

    public double? Coneheightos { get; set; }

    public double? Conelengthds { get; set; }

    public double? Conelengthos { get; set; }

    public double? Coneradiusds { get; set; }

    public double? Coneradiusos { get; set; }

    public int? Conetype { get; set; }

    public string Description { get; set; }

    public string Standrange { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
