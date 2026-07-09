using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StatSpordent
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public string Source { get; set; }

    public short Thickhead { get; set; }

    public short? Amountbindings { get; set; }

    public short? Amountbindingsr { get; set; }

    public short? Apskey { get; set; }

    public short? Dilatometercurve { get; set; }

    public short? Flagplateprod { get; set; }

    public short? Hexitcus { get; set; }

    public short? Hexitm { get; set; }

    public short? Hexitp { get; set; }

    public short? Hexitsetp { get; set; }

    public short? Idriga { get; set; }

    public short? Idseq { get; set; }

    public short? Inspectioncode { get; set; }

    public short? Lengthorder { get; set; }

    public short? Markingdatadiscline { get; set; }

    public short? Matid { get; set; }

    public short? Nodil { get; set; }

    public short? Setpointsedok { get; set; }

    public short? Steelcus { get; set; }

    public short? Tcoiler { get; set; }

    public short? Texitsetp { get; set; }

    public short? Wedgemax { get; set; }

    public short? Wedgemin { get; set; }

    public short? Widthexitcus { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual Me1 Me1 { get; set; }
}
