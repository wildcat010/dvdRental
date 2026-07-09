using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Mosparam
{
    public string Paramname { get; set; }

    public string Planttype { get; set; }

    public string Ctype { get; set; }

    public string Curvalc { get; set; }

    public double? Curvaln { get; set; }

    public string Description { get; set; }

    public string Limitnamell { get; set; }

    public string Limitnameul { get; set; }

    public string Moddescr { get; set; }

    public string Sortorder { get; set; }

    public string Unit { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
