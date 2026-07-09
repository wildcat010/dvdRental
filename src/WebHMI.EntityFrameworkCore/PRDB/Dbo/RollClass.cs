using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Rollclass
{
    public int Rollclass1 { get; set; }

    public double? Caliberdiadiff { get; set; }

    public double? Caliberlength { get; set; }

    public double? Checkerheight { get; set; }

    public int? Checkerroll { get; set; }

    public double? Dneck { get; set; }

    public string Description { get; set; }

    public double? Lneck { get; set; }

    public double? Length { get; set; }

    public string Planttype { get; set; }

    public string Rolltype { get; set; }

    public string Standrange { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
