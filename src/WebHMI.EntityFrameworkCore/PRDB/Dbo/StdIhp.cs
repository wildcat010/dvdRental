using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Stdihp
{
    public int Activeflag { get; set; }

    public int Planno { get; set; }

    public string Description { get; set; }

    public double? Temperature { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
