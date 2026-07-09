using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class StatAdord2pcstand
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public string Source { get; set; }

    public short Standid { get; set; }

    public short Thickhead { get; set; }

    public short? Absprofile { get; set; }

    public short? Fb { get; set; }

    public short? Fr { get; set; }

    public short? Ms { get; set; }

    public short? Positionwrs { get; set; }

    public short? Rpower { get; set; }

    public short? Relprofile { get; set; }

    public short? Sd { get; set; }

    public short? Texit { get; set; }

    public short? Vcircum { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual Me1 Me1 { get; set; }
}
