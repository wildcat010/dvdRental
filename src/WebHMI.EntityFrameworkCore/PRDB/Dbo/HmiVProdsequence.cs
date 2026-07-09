using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class HmiVProdsequence
{
    public decimal? Position { get; set; }

    public short? Pnext { get; set; }

    public int Majorno { get; set; }

    public int Minorno { get; set; }

    public string Enphextid { get; set; }

    public int Enphmeid { get; set; }

    public string Edphysrc { get; set; }

    public short? Enphstatus { get; set; }

    public int Enormeid { get; set; }

    public string Enorextid { get; set; }

    public string Edorsrc { get; set; }

    public string Enormetype { get; set; }

    public short? Enorstatus { get; set; }

    public string Enorcreator { get; set; }

    public short? Enormesid { get; set; }

    public int Enlomeid { get; set; }

    public string Enloextid { get; set; }

    public short? Enlostatus { get; set; }

    public string Alloycode { get; set; }

    public double? Hentry { get; set; }

    public double? Hexit { get; set; }

    public double? Wexit { get; set; }

    public double? Wentry { get; set; }

    public double? Weightentry { get; set; }

    public double? Lentry { get; set; }

    public double? Lexit { get; set; }

    public string Sequenceid { get; set; }

    public int? Pdistatus { get; set; }

    public short? Setpointspc2ok { get; set; }

    public int? Sbaz { get; set; }

    public DateTime? Lastcalc { get; set; }

    public string Apskey { get; set; }

    public int? Simmat { get; set; }

    public short? Setpointscsok { get; set; }

    public double? Tentryfm { get; set; }

    public double? Texitfm { get; set; }

    public double? Texitcaster { get; set; }

    public int? Coolstrategy { get; set; }

    public double? Coiltemp { get; set; }

    public string Heatid { get; set; }

    public string Flagbatchrolling { get; set; }

    public int? Plateproduction { get; set; }

    public double? Hexithrm { get; set; }

    public double? Profilehrm { get; set; }

    public string Orderno { get; set; }
}
