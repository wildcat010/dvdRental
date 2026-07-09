using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Dphrm
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public string Source { get; set; }

    public double? Delaylength { get; set; }

    public string Description { get; set; }

    public int? Noramps { get; set; }

    public int? Planno { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual Me1 Me1 { get; set; }
}
