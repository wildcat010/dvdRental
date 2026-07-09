using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StatCscoiltempoffset
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public string Source { get; set; }

    public short? Description { get; set; }

    public short? Manint { get; set; }

    public short? Planno { get; set; }

    public short? Splineid { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual Me1 Me1 { get; set; }
}
