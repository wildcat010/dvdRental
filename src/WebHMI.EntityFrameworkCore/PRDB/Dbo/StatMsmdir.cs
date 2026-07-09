using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StatMsmdir
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public string Source { get; set; }

    public short? A80 { get; set; }

    public short? Description { get; set; }

    public short? Manint { get; set; }

    public short? Msmmode { get; set; }

    public short? Msmswitch { get; set; }

    public short? Msmtemptolmax { get; set; }

    public short? Msmtemptolmin { get; set; }

    public short? Planno { get; set; }

    public short? Tgttensilestrengthmax { get; set; }

    public short? Tgttensilestrengthmin { get; set; }

    public short? Tgttensilestrengthtarget { get; set; }

    public short? Tgtyieldstrengthmax { get; set; }

    public short? Tgtyieldstrengthmin { get; set; }

    public short? Tgtyieldstrengthtarget { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual Me1 Me1 { get; set; }
}
