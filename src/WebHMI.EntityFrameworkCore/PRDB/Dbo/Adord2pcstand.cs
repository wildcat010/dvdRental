using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Adord2pcstand
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public string Source { get; set; }

    public short Standid { get; set; }

    public short Thickhead { get; set; }

    public double? Absprofile { get; set; }

    public double? Fb { get; set; }

    public double? Fr { get; set; }

    public double? Ms { get; set; }

    public double? Positionwrs { get; set; }

    public double? Rpower { get; set; }

    public double? Relprofile { get; set; }

    public double? Sd { get; set; }

    public double? Texit { get; set; }

    public double? Vcircum { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual Me1 Me1 { get; set; }
}
