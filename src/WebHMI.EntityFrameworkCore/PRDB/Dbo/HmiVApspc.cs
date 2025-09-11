using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class HmiVApspc
{
    public int Planno { get; set; }

    public int Activeflag { get; set; }

    public int? Pcrampauto0 { get; set; }

    public int? Pcrampstate0 { get; set; }

    public int? Priopowerc0 { get; set; }

    public double? Pcrampvolume0 { get; set; }

    public int? Pcrampauto1 { get; set; }

    public int? Pcrampstate1 { get; set; }

    public int? Priopowerc1 { get; set; }

    public double? Pcrampvolume1 { get; set; }
}
