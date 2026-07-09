using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Caldss
{
    public int Dssnumber { get; set; }

    public string Planttype { get; set; }

    public int Standno { get; set; }

    public double? Dsframe { get; set; }

    public double? Dss { get; set; }

    public double? Fr { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
