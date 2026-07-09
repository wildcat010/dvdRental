using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Heat
{
    public string Heatid { get; set; }

    public int Heatstart { get; set; }

    public double? Aimlengthcaster { get; set; }

    public double? Aimlengthl3 { get; set; }

    public double? Endmixedarea { get; set; }

    public short? Heattreatmentno { get; set; }

    public double? Heatweight { get; set; }

    public double? Measlength { get; set; }

    public int? Nrofslabs { get; set; }

    public DateTime? Rectime { get; set; }

    public string Sequenceid { get; set; }

    public double? Speedcas { get; set; }

    public double? Startmixedarea { get; set; }

    public double? Startposheat { get; set; }

    public double? Status { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
