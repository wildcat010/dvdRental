using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StatAdord2pc
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public string Source { get; set; }

    public short Thickhead { get; set; }

    public short? Hexit { get; set; }

    public short? Profile { get; set; }

    public short? Wexit { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual Me1 Me1 { get; set; }
}
