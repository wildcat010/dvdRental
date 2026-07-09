using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class HmiVInlineMaterial
{
    public string Enphextid { get; set; }

    public int Enphmeid { get; set; }

    public string Edphysrc { get; set; }

    public short? Enphstatus { get; set; }

    public int Enormeid { get; set; }

    public string Enorextid { get; set; }

    public string Enormetype { get; set; }

    public short? Enormesid { get; set; }

    public string Enorcreator { get; set; }

    public string Edorsrc { get; set; }

    public int Enlomeid { get; set; }

    public string Edlosrc { get; set; }

    public string Alloycode { get; set; }

    public double? Hentry { get; set; }

    public double? Hexit { get; set; }

    public double? Wentry { get; set; }

    public double? Weightentry { get; set; }

    public double? Lentry { get; set; }

    public double? Wexit { get; set; }

    public string Sequenceid { get; set; }

    public short? Pdistatus { get; set; }

    public short? Setpointspc2ok { get; set; }

    public int? Sbaz { get; set; }

    public DateTime? Lastcalc { get; set; }

    public string Apskey { get; set; }

    public int? Simmat { get; set; }

    public short? Setpointscsok { get; set; }

    public double? Tentryfm { get; set; }

    public double? Texitfm { get; set; }

    public double? Texitcaster { get; set; }

    public double? Coiltemp { get; set; }

    public string Heatid { get; set; }

    public int? Flagbatchrolling { get; set; }

    public DateTime? Prodstarttime { get; set; }

    public int? Plateproduction { get; set; }
}
