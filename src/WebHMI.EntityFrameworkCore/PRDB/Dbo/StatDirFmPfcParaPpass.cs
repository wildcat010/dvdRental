using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StatDirfmpfcparappass
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public int Passno { get; set; }

    public string Source { get; set; }

    public short? Description { get; set; }

    public short? Facdfbdfr { get; set; }

    public short? Facdfbdiu { get; set; }

    public short? Fbll { get; set; }

    public short? Fbul { get; set; }

    public short? Observedflat { get; set; }

    public short? Paircrossll { get; set; }

    public short? Paircrossul { get; set; }

    public short? Planno { get; set; }

    public short? Planttype { get; set; }

    public short? Srll { get; set; }

    public short? Srul { get; set; }

    public string Toextid { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual Me1 Me1 { get; set; }
}
