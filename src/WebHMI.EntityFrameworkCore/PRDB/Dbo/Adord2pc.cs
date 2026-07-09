using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Adord2pc
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public string Source { get; set; }

    public short Thickhead { get; set; }

    public double? Hexit { get; set; }

    public double? Profile { get; set; }

    public double? Wexit { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual Me1 Me1 { get; set; }
}
