using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Lppass
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public int Passno { get; set; }

    public string Source { get; set; }

    public double? Bendingforce { get; set; }

    public double? Cvcshifting { get; set; }

    public double? Circumspeedcorrection { get; set; }

    public string Description { get; set; }

    public int? Loadingtype { get; set; }

    public double? Loadingvalue { get; set; }

    public double? Loadingvaluecorrection { get; set; }

    public double? Loadingvaluemaximumeps { get; set; }

    public double? Loadingvaluemaximumrollforce { get; set; }

    public double? Loadingvalueminimumeps { get; set; }

    public double? Loadingvalueminimumrollforce { get; set; }

    public double? Observedflat { get; set; }

    public int? Planno { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public short? Edgermode { get; set; }

    public double? Edgerforce { get; set; }

    public double? Widthreductionmax { get; set; }

    public double? Minwidthedgfactor { get; set; }

    public virtual Me1 Me1 { get; set; }
}
