using System;
using System.Collections.Generic;

namespace WebHMI.PRDB;

public partial class VMatStructEntry
{
    public int Enormeid { get; set; }

    public string Enorextid { get; set; }

    public string Enormetype { get; set; }

    public short? Enormesid { get; set; }

    public short Enorbasid { get; set; }

    public int Enlomeid { get; set; }

    public string Enloextid { get; set; }

    public string Enlometype { get; set; }

    public short? Enlomesid { get; set; }

    public short Enlobasid { get; set; }

    public int Enphmeid { get; set; }

    public string Enphextid { get; set; }

    public short Enphbasid { get; set; }

    public string Enphmetype { get; set; }

    public short? Enphmesid { get; set; }

    public short? Enorstatus { get; set; }

    public string Enorcreator { get; set; }

    public short? Enlostatus { get; set; }

    public string Enlocreator { get; set; }

    public short? Enphstatus { get; set; }

    public string Enphcreator { get; set; }

    public DateTime? Lastupdate { get; set; }
}
