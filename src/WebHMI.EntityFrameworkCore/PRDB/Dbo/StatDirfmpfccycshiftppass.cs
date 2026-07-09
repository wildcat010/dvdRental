using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StatDirfmpfccycshiftppass
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public int Passno { get; set; }

    public string Source { get; set; }

    public short? Csmaxlimit { get; set; }

    public short? Csminlimit { get; set; }

    public short? Csmode { get; set; }

    public short? Csshiftdir { get; set; }

    public short? Csshiftstep1 { get; set; }

    public short? Csshiftstep2 { get; set; }

    public short? Csshiftstep3 { get; set; }

    public short? Csstartpos { get; set; }

    public short? Description { get; set; }

    public short? Manint { get; set; }

    public short? Planno { get; set; }

    public string Toextid { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public short? CsmaxlimitparabolicInd0 { get; set; }

    public short? CsmaxlimitparabolicInd1 { get; set; }

    public short? CsmaxlimitparabolicInd2 { get; set; }

    public short? CsminlimitparabolicInd0 { get; set; }

    public short? CsminlimitparabolicInd1 { get; set; }

    public short? CsminlimitparabolicInd2 { get; set; }

    public short? CsstepparabolicInd0 { get; set; }

    public short? CsstepparabolicInd1 { get; set; }

    public short? CsstepparabolicInd2 { get; set; }

    public short? CsstepsmartcrownInd0 { get; set; }

    public short? CsstepsmartcrownInd1 { get; set; }

    public short? CsstepsmartcrownInd2 { get; set; }

    public virtual Me1 Me1 { get; set; }
}
