using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Stdaoppass
{
    public int Activeflag { get; set; }

    public int Passno { get; set; }

    public int Planno { get; set; }

    public int? Antioxstateentry { get; set; }

    public int? Antioxstateexit { get; set; }

    public double? Antioxidationentry { get; set; }

    public double? Antioxidationexit { get; set; }

    public double? Antipeeling { get; set; }

    public int? Antipeelingstate { get; set; }

    public string Description { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
