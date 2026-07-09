using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Csrtcooling
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public string Source { get; set; }

    public string Description { get; set; }

    public short? Manint { get; set; }

    public int? Planno { get; set; }

    public int? Rtccooldowntime { get; set; }

    public int? RtcstrategyInd00 { get; set; }

    public int? RtcstrategyInd01 { get; set; }

    public int? RtcstrategyInd02 { get; set; }

    public int? RtcstrategyInd03 { get; set; }

    public int? RtcstrategyInd04 { get; set; }

    public int? RtcstrategyInd05 { get; set; }

    public int? RtcstrategyInd06 { get; set; }

    public int? RtcstrategyInd07 { get; set; }

    public int? RtcstrategyInd08 { get; set; }

    public int? RtcstrategyInd09 { get; set; }

    public int? RtcstrategyInd10 { get; set; }

    public int? RtcstrategyInd11 { get; set; }

    public int? RtcstrategyInd12 { get; set; }

    public int? RtcstrategyInd13 { get; set; }

    public int? RtcstrategyInd14 { get; set; }

    public int? RtcstrategyInd15 { get; set; }

    public string Toextid { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual Me1 Me1 { get; set; }
}
