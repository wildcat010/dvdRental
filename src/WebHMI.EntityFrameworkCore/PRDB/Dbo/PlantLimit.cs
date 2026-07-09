using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Plantlimit
{
    public string Limitname { get; set; }

    public string Planttype { get; set; }

    public string Ctype { get; set; }

    public string Description { get; set; }

    public double? Lowerlimit { get; set; }

    public string Moddescr { get; set; }

    public string Sortorder { get; set; }

    public string Unit { get; set; }

    public double? Upperlimit { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
