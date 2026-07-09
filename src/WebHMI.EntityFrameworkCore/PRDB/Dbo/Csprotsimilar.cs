using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Csprotsimilar
{
    public int Meid { get; set; }

    public int Meidsim { get; set; }

    public int Seg { get; set; }

    public double? Dist { get; set; }

    public double? Weight { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
