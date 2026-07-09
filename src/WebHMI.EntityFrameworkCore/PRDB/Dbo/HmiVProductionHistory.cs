using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class HmiVProductionHistory
{
    public int Meid { get; set; }

    public string Coilid { get; set; }

    public string Slabid { get; set; }

    public string Sequenceid { get; set; }

    public string Heatid1 { get; set; }

    public int? Flagbatchrolling { get; set; }

    public string Alloycode { get; set; }

    public DateTime? Prodstart { get; set; }

    public DateTime? Prodend { get; set; }

    public double? Wexit { get; set; }

    public double? Wexitaver { get; set; }

    public double? Wexitmin { get; set; }

    public double? Wexitmax { get; set; }

    public double? Hexit { get; set; }

    public double? Hexitaver { get; set; }

    public double? Hexitmin { get; set; }

    public double? Hexitmax { get; set; }

    public double? Texitcs { get; set; }

    public double? Texitcsaver { get; set; }

    public double? Texitcsmin { get; set; }

    public double? Texitcsmax { get; set; }

    public double? Coillengthx { get; set; }
}
