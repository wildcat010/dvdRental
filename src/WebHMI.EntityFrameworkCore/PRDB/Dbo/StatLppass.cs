using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StatLppass
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public int Passno { get; set; }

    public string Source { get; set; }

    public short? Bendingforce { get; set; }

    public short? Cvcshifting { get; set; }

    public short? Circumspeedcorrection { get; set; }

    public short? Description { get; set; }

    public short? Loadingtype { get; set; }

    public short? Loadingvalue { get; set; }

    public short? Loadingvaluecorrection { get; set; }

    public short? Loadingvaluemaximumeps { get; set; }

    public short? Loadingvaluemaximumrollforce { get; set; }

    public short? Loadingvalueminimumeps { get; set; }

    public short? Loadingvalueminimumrollforce { get; set; }

    public short? Observedflat { get; set; }

    public short? Planno { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public short? Edgermode { get; set; }

    public short? Edgerforce { get; set; }

    public short? Widthreductionmax { get; set; }

    public short? Minwidthedgfactor { get; set; }

    public virtual Me1 Me1 { get; set; }
}
