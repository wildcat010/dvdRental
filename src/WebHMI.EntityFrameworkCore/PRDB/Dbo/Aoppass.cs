using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Aoppass
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public int Passno { get; set; }

    public string Source { get; set; }

    public int? Antioxstateentry { get; set; }

    public int? Antioxstateexit { get; set; }

    public double? Antioxidationentry { get; set; }

    public double? Antioxidationexit { get; set; }

    public double? Antipeeling { get; set; }

    public int? Antipeelingstate { get; set; }

    public string Description { get; set; }

    public int? Planno { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual Me1 Me1 { get; set; }
}
