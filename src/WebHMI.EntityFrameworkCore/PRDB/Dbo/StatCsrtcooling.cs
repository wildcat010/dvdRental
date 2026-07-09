using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StatCsrtcooling
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public string Source { get; set; }

    public short? Description { get; set; }

    public short? Manint { get; set; }

    public short? Planno { get; set; }

    public short? Rtccooldowntime { get; set; }

    public short? RtcstrategyInd00 { get; set; }

    public short? RtcstrategyInd01 { get; set; }

    public short? RtcstrategyInd02 { get; set; }

    public short? RtcstrategyInd03 { get; set; }

    public short? RtcstrategyInd04 { get; set; }

    public short? RtcstrategyInd05 { get; set; }

    public short? RtcstrategyInd06 { get; set; }

    public short? RtcstrategyInd07 { get; set; }

    public short? RtcstrategyInd08 { get; set; }

    public short? RtcstrategyInd09 { get; set; }

    public short? RtcstrategyInd10 { get; set; }

    public short? RtcstrategyInd11 { get; set; }

    public short? RtcstrategyInd12 { get; set; }

    public short? RtcstrategyInd13 { get; set; }

    public short? RtcstrategyInd14 { get; set; }

    public short? RtcstrategyInd15 { get; set; }

    public string Toextid { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual Me1 Me1 { get; set; }
}
