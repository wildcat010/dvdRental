using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Stdcscoiltempoffset
{
    public int Activeflag { get; set; }

    public int Planno { get; set; }

    public string Description { get; set; }

    public string Description2 { get; set; }

    public int? Splineid { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
