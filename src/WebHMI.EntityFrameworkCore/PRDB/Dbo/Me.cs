using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Me
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Basid { get; set; }

    public short? Curmesid { get; set; }

    public short? Entmesid { get; set; }

    public string Extid { get; set; }

    public string Metyp { get; set; }

    public short? Outmesid { get; set; }

    public short? Status { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual ICollection<Me1> Me1MeNavigations { get; set; } = new List<Me1>();

    public virtual ICollection<Me1> Me1Mes { get; set; } = new List<Me1>();
}
