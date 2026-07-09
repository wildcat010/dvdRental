using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Tppass
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public int Passno { get; set; }

    public string Source { get; set; }

    public string Description { get; set; }

    public double? Looperangle { get; set; }

    public int? Loopermode { get; set; }

    public double? Looperstriplen { get; set; }

    public int? Planno { get; set; }

    public double? Speciffotension { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual Me1 Me1 { get; set; }
}
