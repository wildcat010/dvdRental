using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Edghrm
{
    public string MeCreator { get; set; }

    public int MeId { get; set; }

    public short MesId { get; set; }

    public string Source { get; set; }

    public string Description { get; set; }

    public double? Dw { get; set; }

    public int? EdgMode { get; set; }

    public int? EdgerActive { get; set; }

    public int? PlanNo { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual Me1 Me1 { get; set; }
}
