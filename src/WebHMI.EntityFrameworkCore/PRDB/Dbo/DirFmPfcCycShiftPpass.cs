using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Dirfmpfccycshiftppass
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public int Passno { get; set; }

    public string Source { get; set; }

    public double? Csmaxlimit { get; set; }

    public double? Csminlimit { get; set; }

    public int? Csmode { get; set; }

    public int? Csshiftdir { get; set; }

    public double? Csshiftstep1 { get; set; }

    public double? Csshiftstep2 { get; set; }

    public double? Csshiftstep3 { get; set; }

    public double? Csstartpos { get; set; }

    public string Description { get; set; }

    public short? Manint { get; set; }

    public int? Planno { get; set; }

    public string Toextid { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public double? CsmaxlimitparabolicInd0 { get; set; }

    public double? CsmaxlimitparabolicInd1 { get; set; }

    public double? CsmaxlimitparabolicInd2 { get; set; }

    public double? CsminlimitparabolicInd0 { get; set; }

    public double? CsminlimitparabolicInd1 { get; set; }

    public double? CsminlimitparabolicInd2 { get; set; }

    public double? CsstepparabolicInd0 { get; set; }

    public double? CsstepparabolicInd1 { get; set; }

    public double? CsstepparabolicInd2 { get; set; }

    public double? CsstepsmartcrownInd0 { get; set; }

    public double? CsstepsmartcrownInd1 { get; set; }

    public double? CsstepsmartcrownInd2 { get; set; }

    public virtual Me1 Me1 { get; set; }
}
